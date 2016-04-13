using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Tcr.Sage.Dtos;

namespace Tcr.Sage.Dal.I {
   public interface ICompanyRepository {
      Task<ICollection<CompanyDto>> GetAllCompanies(CancellationToken cancellationToken);
      Task<ICollection<CompanyDto>> GetAdvisorCompanies(CancellationToken cancellationToken);
      Task<ICollection<CompanyDto>> GetRecordKeeperCompanies(CancellationToken cancellationToken);
      Task<CompanyDto> GetCompany(int companyId, CancellationToken cancellationToken);
      Task<bool> UpdateCompany(CompanyDto company, CancellationToken cancellationToken);
   }
}