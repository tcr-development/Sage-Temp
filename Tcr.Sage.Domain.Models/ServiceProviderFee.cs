using System.Collections.Generic;

namespace Tcr.Sage.Domain.Models {
   public partial class ServiceProviderFee {
      public ServiceProviderFee() {
         FeeStepRate = new HashSet<FeeStepRate>();
      }

      public int Id { get; set; }
      public decimal? Amount { get; set; }
      public string Description { get; set; }
      public byte FeeInvestExclusionCd { get; set; }
      public byte FeeMethodCd { get; set; }
      public byte FeePaidByCd { get; set; }
      public bool FeeReducesPayment { get; set; }
      public byte FeeTypeCd { get; set; }
      public bool IncludeLoanBalance { get; set; }
      public int? NumUnits { get; set; }
      public int? PaidByServiceProviderId { get; set; }
      public byte? Percentage { get; set; }
      public string SelectedInvestments { get; set; }
      public int ServiceProviderId { get; set; }
      public byte? StepRateMethodCd { get; set; }
      public byte? StepRateTypeCd { get; set; }

      public virtual ICollection<FeeStepRate> FeeStepRate { get; set; }
      public virtual ServiceProvider PaidByServiceProvider { get; set; }
      public virtual ServiceProvider ServiceProvider { get; set; }
   }
}
