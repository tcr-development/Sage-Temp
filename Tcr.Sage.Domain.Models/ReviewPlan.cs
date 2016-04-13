using System;
using System.Collections.Generic;

namespace Tcr.Sage.Domain.Models {
   public partial class ReviewPlan {
      public ReviewPlan() {
         ReviewFund = new HashSet<ReviewFund>();
         ReviewModel = new HashSet<ReviewModel>();
         ReviewPlanChange = new HashSet<ReviewPlanChange>();
         ReviewPlanNotification = new HashSet<ReviewPlanNotification>();
      }

      public int Id { get; set; }
      public string AddressLine1 { get; set; }
      public string AddressLine2 { get; set; }
      public DateTime? BalanceAsOfDate { get; set; }
      public string City { get; set; }
      public string CompanyName { get; set; }
      public string EmployerIdNumber { get; set; }
      public decimal? LoanBalanceAmount { get; set; }
      public string Name { get; set; }
      public int? ParticipantCount { get; set; }
      public string Phone { get; set; }
      public int PlanMasterId { get; set; }
      public string PrimaryContact { get; set; }
      public DateTime? RecEffDate { get; set; }
      public int ReviewId { get; set; }
      public string State { get; set; }
      public string TradingPlatform { get; set; }
      public string Trustees { get; set; }
      public string Zip { get; set; }

      public virtual ICollection<ReviewFund> ReviewFund { get; set; }
      public virtual ICollection<ReviewModel> ReviewModel { get; set; }
      public virtual ICollection<ReviewPlanChange> ReviewPlanChange { get; set; }
      public virtual ICollection<ReviewPlanNotification> ReviewPlanNotification { get; set; }
      public virtual PlanMaster PlanMaster { get; set; }
      public virtual Review Review { get; set; }
   }
}
