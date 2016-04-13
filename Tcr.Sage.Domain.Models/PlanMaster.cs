using System;
using System.Collections.Generic;

namespace Tcr.Sage.Domain.Models {
   public partial class PlanMaster {
      public PlanMaster() {
         PlanAccess = new HashSet<PlanAccess>();
         PlanContact = new HashSet<PlanContact>();
         PlanFeeSchedule = new HashSet<PlanFeeSchedule>();
         PlanFile = new HashSet<PlanFile>();
         PlanGroupDetail = new HashSet<PlanGroupDetail>();
         PlanInvestment = new HashSet<PlanInvestment>();
         PlanNotification = new HashSet<PlanNotification>();
         PlanReport = new HashSet<PlanReport>();
         ReportRequest = new HashSet<ReportRequest>();
         ReviewPlan = new HashSet<ReviewPlan>();
      }

      public int Id { get; set; }
      public string AddressLine1 { get; set; }
      public string AddressLine2 { get; set; }
      public DateTime? BalanceAsOfDate { get; set; }
      public string City { get; set; }
      public string ClientPlanId { get; set; }
      public int CompanyId { get; set; }
      public string CompanyName { get; set; }
      public DateTime? DataAsOfDate { get; set; }
      public string EmployerIdNumber { get; set; }
      public decimal? LoanBalance { get; set; }
      public string Name { get; set; }
      public string Phone { get; set; }
      public string PlanId { get; set; }
      public byte RecordKeeperTypeCd { get; set; }
      public string State { get; set; }
      public string Zip { get; set; }

      public virtual ICollection<PlanAccess> PlanAccess { get; set; }
      public virtual ICollection<PlanContact> PlanContact { get; set; }
      public virtual PlanDetail PlanDetail { get; set; }
      public virtual ICollection<PlanFeeSchedule> PlanFeeSchedule { get; set; }
      public virtual ICollection<PlanFile> PlanFile { get; set; }
      public virtual ICollection<PlanGroupDetail> PlanGroupDetail { get; set; }
      public virtual ICollection<PlanInvestment> PlanInvestment { get; set; }
      public virtual ICollection<PlanNotification> PlanNotification { get; set; }
      public virtual ICollection<PlanReport> PlanReport { get; set; }
      public virtual ICollection<ReportRequest> ReportRequest { get; set; }
      public virtual ICollection<ReviewPlan> ReviewPlan { get; set; }
      public virtual Company Company { get; set; }
   }
}
