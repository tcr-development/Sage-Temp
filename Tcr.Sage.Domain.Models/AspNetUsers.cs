using System;
using System.Collections.Generic;

namespace Tcr.Sage.Domain.Models {
   public partial class AspNetUsers {
      public AspNetUsers() {
         AspNetUserClaims = new HashSet<AspNetUserClaims>();
         AspNetUserLogins = new HashSet<AspNetUserLogins>();
         AspNetUserRoles = new HashSet<AspNetUserRoles>();
         PlanNotification = new HashSet<PlanNotification>();
         ReviewPlanNotification = new HashSet<ReviewPlanNotification>();
      }

      public int Id { get; set; }
      public int AccessFailedCount { get; set; }
      public string Email { get; set; }
      public bool EmailConfirmed { get; set; }
      public bool IsActive { get; set; }
      public bool LockedOut { get; set; }
      public bool LockoutEnabled { get; set; }
      public DateTime? LockoutEndDateUtc { get; set; }
      public string PasswordHash { get; set; }
      public string PhoneNumber { get; set; }
      public bool PhoneNumberConfirmed { get; set; }
      public string SecurityStamp { get; set; }
      public bool TwoFactorEnabled { get; set; }
      public string UserName { get; set; }

      public virtual ICollection<AspNetUserClaims> AspNetUserClaims { get; set; }
      public virtual ICollection<AspNetUserLogins> AspNetUserLogins { get; set; }
      public virtual ICollection<AspNetUserRoles> AspNetUserRoles { get; set; }
      public virtual ICollection<PlanNotification> PlanNotification { get; set; }
      public virtual ICollection<ReviewPlanNotification> ReviewPlanNotification { get; set; }
      public virtual User User { get; set; }
   }
}
