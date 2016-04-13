using System.Collections.Generic;

namespace Tcr.Sage.Domain.Models {
   public partial class ServiceProvider {
      public ServiceProvider() {
         FeeScheduleServiceProvider = new HashSet<FeeScheduleServiceProvider>();
         ServiceProviderFee = new HashSet<ServiceProviderFee>();
         ServiceProviderFeeNavigation = new HashSet<ServiceProviderFee>();
      }

      public int Id { get; set; }
      public string AddressLine1 { get; set; }
      public string AddressLine2 { get; set; }
      public string City { get; set; }
      public string EmployerIdNumber { get; set; }
      public string Name { get; set; }
      public string Phone { get; set; }
      public string State { get; set; }
      public string Zip { get; set; }

      public virtual ICollection<FeeScheduleServiceProvider> FeeScheduleServiceProvider { get; set; }
      public virtual ICollection<ServiceProviderFee> ServiceProviderFee { get; set; }
      public virtual ICollection<ServiceProviderFee> ServiceProviderFeeNavigation { get; set; }
   }
}
