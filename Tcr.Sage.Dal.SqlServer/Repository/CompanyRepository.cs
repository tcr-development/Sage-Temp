using Microsoft.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Tcr.Sage.Dal.I;
using Tcr.Sage.Domain.Models;
using Tcr.Sage.Dtos;
using Tcr.Sage.Shared;

namespace Tcr.Sage.Dal.SqlServer.Repository {
   public class CompanyRepository : BaseRepository, ICompanyRepository {

      public CompanyRepository(SageContext ctx) : base(ctx) { }

      public async Task<ICollection<CompanyDto>> GetAllCompanies(CancellationToken cancellationToken) {
         var companies = await DbContext.Companies.Where(x => !x.IsDisabled).OrderBy(x => x.Name).ToListAsync(cancellationToken);
         return companies.Select(GetCompany).ToList();
      }

      public async Task<ICollection<CompanyDto>> GetAdvisorCompanies(CancellationToken cancellationToken) {
         var companies = await DbContext.Companies.Where(x => !x.IsDisabled && x.CompanyTypeCd == (byte)CompanyType.AdvisorCompany).OrderBy(x => x.Name).ToListAsync(cancellationToken);
         return companies.Select(GetCompany).ToList();
      }

      public async Task<ICollection<CompanyDto>> GetRecordKeeperCompanies(CancellationToken cancellationToken) {
         var companies = await DbContext.Companies.Where(x => !x.IsDisabled && x.CompanyTypeCd == (byte)CompanyType.RecordKeeper).OrderBy(x => x.Name).ToListAsync(cancellationToken);
         return companies.Select(GetCompany).ToList();
      }

      public async Task<CompanyDto> GetCompany(int companyId, CancellationToken cancellationToken) {
         var company = await DbContext.Companies.Include(x => x.CompanyLicense).SingleOrDefaultAsync(x => x.Id == companyId, cancellationToken);
         return company == null ? null : GetCompany(company);
      }

      public async Task<bool> UpdateCompany(CompanyDto company, CancellationToken cancellationToken) {
         var dbCompany = await DbContext.Companies.Include(x => x.CompanyLicense).SingleOrDefaultAsync(x => x.Id == company.Id, cancellationToken);
         if (dbCompany == null) {
            return false;
         }

         dbCompany.AddressLine1 = company.AddressLine1;
         dbCompany.AddressLine2 = company.AddressLine2;
         dbCompany.City = company.City;
         dbCompany.CompanyTypeCd = (byte)company.CompanyTypeCd;
         dbCompany.IsDisabled = company.IsDisabled;
         dbCompany.IsTestCompany = company.IsTestCompany;
         dbCompany.Name = company.Name;
         dbCompany.Notes = company.Notes;
         dbCompany.Phone = company.Phone;
         dbCompany.PrimaryContact = company.PrimaryContact;
         dbCompany.State = company.State;
         dbCompany.Zip = company.Zip;

         if (company.License != null) {
            dbCompany.CompanyLicense.Allow408b2 = company.License.Allow408b2;
            dbCompany.CompanyLicense.AllowFundList = company.License.AllowFundList;
            dbCompany.CompanyLicense.AllowModels = company.License.AllowModels;
            dbCompany.CompanyLicense.AllowPlanReview = company.License.AllowPlanReview;
            dbCompany.CompanyLicense.AllowProposal = company.License.AllowProposal;
            dbCompany.CompanyLicense.AllowSchwabCustody = company.License.AllowSchwabCustody;
            dbCompany.CompanyLicense.AllowSchwabTrust = company.License.AllowSchwabTrust;
            dbCompany.CompanyLicense.AllowSgnMidAtlantic = company.License.AllowSgnMidAtlantic;
            dbCompany.CompanyLicense.MaxPlans = company.License.MaxPlans;
            dbCompany.CompanyLicense.MaxPlatforms = company.License.MaxPlatforms;
            dbCompany.CompanyLicense.MaxUsers = company.License.MaxUsers;
         }

         return (await DbContext.SaveChangesAsync(cancellationToken) > 0);
      }

      #region Private helper methods

      private static CompanyDto GetCompany(Company company) {

         var retVal = new CompanyDto {
            AddressLine1 = company.AddressLine1,
            AddressLine2 = company.AddressLine2,
            City = company.City,
            CompanyTypeCd = (CompanyType)company.CompanyTypeCd,
            CreatedDateUtc = company.CreatedDateUtc,
            Id = company.Id,
            IsDisabled = company.IsDisabled,
            IsTestCompany = company.IsTestCompany,
            Name = company.Name,
            Notes = company.Notes,
            Phone = company.Phone,
            PrimaryContact = company.PrimaryContact,
            State = company.State,
            Zip = company.Zip
         };

         var license = company.CompanyLicense;
         if (license != null) {
            retVal.License = new CompanyLicenseDto {
               Allow408b2 = license.Allow408b2,
               AllowFundList = license.AllowFundList,
               AllowModels = license.AllowModels,
               AllowPlanReview = license.AllowPlanReview,
               AllowProposal = license.AllowProposal,
               AllowSchwabCustody = license.AllowSchwabCustody,
               AllowSchwabTrust = license.AllowSchwabTrust,
               AllowSgnMidAtlantic = license.AllowSgnMidAtlantic,
               MaxPlans = license.MaxPlans,
               MaxPlatforms = license.MaxPlatforms,
               MaxUsers = license.MaxUsers
            };
         }
         return retVal;
      }

      #endregion

      //public async Task<ICollection<CompanyDto>> GetCompanies(CancellationToken cancellationToken) {
      //   return await GetCompanies(null, null, default(Page), cancellationToken);
      //}

      //public async Task<ICollection<CompanyDto>> GetCompanies(OrderByCollection<CompanyDto> orderBy, CancellationToken cancellationToken) {
      //   return await GetCompanies(null, orderBy, default(Page), cancellationToken);
      //}

      //public async Task<ICollection<CompanyDto>> GetCompanies(Page page, CancellationToken cancellationToken) {
      //   return await GetCompanies(null, null, page, cancellationToken);
      //}

      //public async Task<ICollection<CompanyDto>> GetCompanies(Expression<Func<Company, bool>> filter, OrderByCollection<Company> orderBy, Page page, CancellationToken cancellationToken) {
      //   IQueryable<Company> dbQuery = DbContext.Companies;

      //   // handle filter
      //   if (filter != null) {
      //      dbQuery = dbQuery.Where(filter);
      //   }

      //   //handle order by
      //   if (orderBy != null) {
      //      dbQuery = orderBy.Clause(dbQuery);
      //      if (orderBy.Clauses != null) {
      //         dbQuery = orderBy.Clauses.Aggregate(dbQuery, (current, orderByClause) => orderByClause((IOrderedQueryable<Company>)current));
      //      }
      //   }

      //   // handle paging
      //   if (page != default(Page)) {
      //      dbQuery = dbQuery.Skip((page.PageNumber - 1) * page.PageSize);
      //      dbQuery = dbQuery.Take(page.PageSize);
      //   }

      //   return await dbQuery.AsNoTracking().ToListAsync(cancellationToken);
      //}

   }
}