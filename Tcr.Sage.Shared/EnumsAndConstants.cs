namespace Tcr.Sage.Shared {

   public class Constants {
      public const int TcrAdminCompanyId = 0;
      public const int TcrRecordKeeperCompanyId = 1;
      public const int TcrUserId = 1;
      
   }

   public class UserRoles {
      public const string SysAdminRoleName = "SysAdmin";
      public const string SageUserRoleName = "SageUser";
      public const string PlanSponsorRoleName = "PlanSponsor";

      public const byte SysAdminRoleId = 1;
      public const byte SageUserRoleId = 2;
      public const byte PlanSponsorRoleId = 3;
   }

   public enum ItemType {
      PlanReview = 0,
      FundFilter = 1,
      FundList = 2,
      CustomPlan = 3,
      PassFailScoringTool = 4,
      PointBasedScoringTool = 5,
      User = 6,
      Proposal = 7,
      PlatformPlan = 8,
      File = 9,
      RptTemplate = 10,
      SecurityProfile = 11,
      FeeSchedule = 12,
      Platform = 13,
      CompanyFund = 14, // not a real item type as far as db is concerned but it is used for navigation to get to company funds view.
      PlanGroup = 15,
      GroupReview = 16,
      Benchmark = 17,
      Model = 18,
      PartMemo = 19,     // not a real item type as far as db is concerned but it is used for report template type
      PlanAdmin = 20, // not a real item type as far as db is concerned but it is used for navigation to get to plan/model admin view.
      FeeBenchmark = 21     // not a real item type as far as db is concerned but it is used for report template type
   }

   //public enum AspNetUserRole : byte {
   //   SysAdmin = 1,
   //   SageUser = 2,
   //   PlanSponsor = 3
   //}

   public enum AccessLevel : byte {
      NoAccess = 0,
      ReadOnly = 1,
      FullAccess = 2
   }

   public enum PlanNotificationLevel : byte {
      ReadOnly = 0,
      FullAccess = 1,
      PlanAdmin = 9
   }

   // we have company types 2,3,and 9 in old system.  will have types 1,2,9 in new system
   public enum CompanyType : byte {
      RecordKeeper = 1,
      AdvisorCompany = 2,
      TpaCompanyWithAdvisors = 3,
      System = 9
   }

   public enum RecordKeeperType : byte {
      FundSource = 0,
      ReliusAdmin = 1,
      Omni = 2,
      Srt = 3,
      Matc = 4,
      GenericLink = 5,
      Ssh = 6
   }
}