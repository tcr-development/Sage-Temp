using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Mvc;
using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Tcr.Sage.Dal.I;
using Tcr.Sage.Shared;

namespace Sage_Temp_UI.WebApi {
   [Produces("application/json")]
   [Route("api/[controller]")]
   [Authorize(Roles = UserRoles.SysAdminRoleName)]
   public class AdminApiController : Controller {

      private readonly ICompanyRepository _repo;

      public AdminApiController(ICompanyRepository repo)  {
         _repo = repo;
      }

      // GET: api/AdminApi
      [HttpGet]
      [Route("[action]")]
      public async Task<IActionResult> GetCompanies(CancellationToken cancellationToken) {
         try {
            var companies = await _repo.GetAdvisorCompanies(cancellationToken);
            return Ok(companies);
         }
         catch (Exception) {
            return new HttpStatusCodeResult((int)HttpStatusCode.InternalServerError);
         }
         
      }

      // GET: api/AdminApi/5
      [HttpGet]
      [Route("[action]/{id:int}")]
      public async Task<IActionResult> GetCompany([FromRoute] int id, CancellationToken cancellationToken) {
         if (!ModelState.IsValid) {
            return HttpBadRequest(ModelState);
         }

         var company = await _repo.GetCompany(id, cancellationToken);

         if (company == null) {
            return HttpNotFound();
         }

         return Ok(company);
      }

      //// PUT: api/AdminApi/5
      //[HttpPut("{id}")]
      //public async Task<IActionResult> PutCompany([FromRoute] int id, [FromBody] Company company) {
      //   if (!ModelState.IsValid) {
      //      return HttpBadRequest(ModelState);
      //   }

      //   if (id != company.Id) {
      //      return HttpBadRequest();
      //   }

      //   _ctx.Entry(company).State = EntityState.Modified;

      //   try {
      //      await _ctx.SaveChangesAsync();
      //   }
      //   catch (DbUpdateConcurrencyException) {
      //      if (!CompanyExists(id)) {
      //         return HttpNotFound();
      //      }
      //      else {
      //         throw;
      //      }
      //   }

      //   return new HttpStatusCodeResult(StatusCodes.Status204NoContent);
      //}

      //// POST: api/AdminApi
      //[HttpPost]
      //public async Task<IActionResult> PostCompany([FromBody] Company company) {
      //   if (!ModelState.IsValid) {
      //      return HttpBadRequest(ModelState);
      //   }

      //   _ctx.Companies.Add(company);
      //   try {
      //      await _ctx.SaveChangesAsync();
      //   }
      //   catch (DbUpdateException) {
      //      if (CompanyExists(company.Id)) {
      //         return new HttpStatusCodeResult(StatusCodes.Status409Conflict);
      //      }
      //      else {
      //         throw;
      //      }
      //   }

      //   return CreatedAtRoute("GetCompany", new { id = company.Id }, company);
      //}

      //// DELETE: api/AdminApi/5
      //[HttpDelete("{id}")]
      //public async Task<IActionResult> DeleteCompany([FromRoute] int id) {
      //   if (!ModelState.IsValid) {
      //      return HttpBadRequest(ModelState);
      //   }

      //   Company company = await _ctx.Companies.SingleAsync(m => m.Id == id);
      //   if (company == null) {
      //      return HttpNotFound();
      //   }

      //   _ctx.Companies.Remove(company);
      //   await _ctx.SaveChangesAsync();

      //   return Ok(company);
      //}

      //private bool CompanyExists(int id) {
      //   return _ctx.Companies.Count(e => e.Id == id) > 0;
      //}
   }
}