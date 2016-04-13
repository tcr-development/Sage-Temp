using Microsoft.Data.Entity;
using Tcr.Sage.Dal.SqlServer.Mapping;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer {
   public partial class SageContext : DbContext {
      protected override void OnConfiguring(DbContextOptionsBuilder options) {
         if (!options.IsConfigured) {
            options.UseSqlServer(@"Server=DK-XPS85;Database=Tcr.Sage;user id=sage;password=pop_goes_the_weasel_15");
         }
      }

      protected override void OnModelCreating(ModelBuilder modelBuilder) {

         AspNetRolesMap.AddMap(modelBuilder);

         AspNetUserClaimsMap.AddMap(modelBuilder);
         AspNetUserLoginsMap.AddMap(modelBuilder);
         AspNetUserRolesMap.AddMap(modelBuilder);
         AspNetUsersMap.AddMap(modelBuilder);
         BenchmarkMap.AddMap(modelBuilder);
         BenchmarkAccessMap.AddMap(modelBuilder);
         BenchmarkDetailMap.AddMap(modelBuilder);
         CategoryDetailMap.AddMap(modelBuilder);
         CompanyMap.AddMap(modelBuilder);
         CompanyLicenseMap.AddMap(modelBuilder);
         DataFeedMap.AddMap(modelBuilder);
         FeeScheduleMap.AddMap(modelBuilder);
         FeeScheduleAccessMap.AddMap(modelBuilder);
         FeeScheduleServiceProviderMap.AddMap(modelBuilder);
         FeeStepRateMap.AddMap(modelBuilder);
         FileMasterMap.AddMap(modelBuilder);
         FundDetailMap.AddMap(modelBuilder);
         FundListMap.AddMap(modelBuilder);
         FundListAccessMap.AddMap(modelBuilder);
         FundListFundMap.AddMap(modelBuilder);
         IndexDetailMap.AddMap(modelBuilder);
         InvestmentProductMap.AddMap(modelBuilder);
         InvestmentProductFundMap.AddMap(modelBuilder);
         InvestmentProductReportMap.AddMap(modelBuilder);
         ModelFreezerMap.AddMap(modelBuilder);
         ModelFreezerDetailMap.AddMap(modelBuilder);
         PlanAccessMap.AddMap(modelBuilder);
         PlanContactMap.AddMap(modelBuilder);
         PlanDetailMap.AddMap(modelBuilder);
         PlanFeeScheduleMap.AddMap(modelBuilder);
         PlanFileMap.AddMap(modelBuilder);
         PlanGroupMap.AddMap(modelBuilder);
         PlanGroupAccessMap.AddMap(modelBuilder);
         PlanGroupDetailMap.AddMap(modelBuilder);
         PlanInvestmentMap.AddMap(modelBuilder);
         PlanMasterMap.AddMap(modelBuilder);
         PlanNotificationMap.AddMap(modelBuilder);
         PlanReportMap.AddMap(modelBuilder);
         ProposalMap.AddMap(modelBuilder);
         ProposalAccessMap.AddMap(modelBuilder);
         ProposalBalanceMapMap.AddMap(modelBuilder);
         ProposalInvestmentMap.AddMap(modelBuilder);
         ProposalPlanContactMap.AddMap(modelBuilder);
         ProposalReportMap.AddMap(modelBuilder);
         RecordKeeperMap.AddMap(modelBuilder);
         ReportPieceMap.AddMap(modelBuilder);
         ReportRequestMap.AddMap(modelBuilder);
         ReportTemplateMap.AddMap(modelBuilder);
         ReportTemplateAccessMap.AddMap(modelBuilder);
         ReportTemplateDetailMap.AddMap(modelBuilder);
         ReviewMap.AddMap(modelBuilder);
         ReviewFundMap.AddMap(modelBuilder);
         ReviewModelMap.AddMap(modelBuilder);
         ReviewModelDetailMap.AddMap(modelBuilder);
         ReviewPlanMap.AddMap(modelBuilder);
         ReviewPlanChangeMap.AddMap(modelBuilder);
         ReviewPlanChangeDetailMap.AddMap(modelBuilder);
         ReviewPlanNotificationMap.AddMap(modelBuilder);
         SageItemTypeMap.AddMap(modelBuilder);
         ScoreWarehouseMap.AddMap(modelBuilder);
         ScoreWarehouseInvestmentScoreMap.AddMap(modelBuilder);
         ScoreWarehouseToolDetailMap.AddMap(modelBuilder);
         ScoringToolMap.AddMap(modelBuilder);
         ScoringToolAccessMap.AddMap(modelBuilder);
         ScoringToolDetailMap.AddMap(modelBuilder);
         ServiceProviderMap.AddMap(modelBuilder);
         ServiceProviderFeeMap.AddMap(modelBuilder);
         TestColumnMap.AddMap(modelBuilder);
         TestCompareAgainstMap.AddMap(modelBuilder);
         TestCompareAgainstListMap.AddMap(modelBuilder);
         TestCompareAgainstListDetailMap.AddMap(modelBuilder);
         TestCompareOperatorMap.AddMap(modelBuilder);
         TestCompareOperatorListMap.AddMap(modelBuilder);
         TestCompareOperatorListDetailMap.AddMap(modelBuilder);
         TestDataTypeMap.AddMap(modelBuilder);
         TestDataTypeOptionMap.AddMap(modelBuilder);
         TestGroupMap.AddMap(modelBuilder);
         TestSectionMap.AddMap(modelBuilder);
         TradingPlatformMap.AddMap(modelBuilder);
         TradingPlatformAccessMap.AddMap(modelBuilder);
         TradingPlatformFundMap.AddMap(modelBuilder);
         UserMap.AddMap(modelBuilder);
      }

      public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
      public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
      public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
      public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
      public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
      public virtual DbSet<Benchmark> Benchmarks { get; set; }
      public virtual DbSet<BenchmarkAccess> BenchmarkAccesses { get; set; }
      public virtual DbSet<BenchmarkDetail> BenchmarkDetails { get; set; }
      public virtual DbSet<CategoryDetail> CategoryDetails { get; set; }
      public virtual DbSet<Company> Companies { get; set; }
      public virtual DbSet<CompanyLicense> CompanyLicenses { get; set; }
      public virtual DbSet<DataFeed> DataFeeds { get; set; }
      public virtual DbSet<FeeSchedule> FeeSchedules { get; set; }
      public virtual DbSet<FeeScheduleAccess> FeeScheduleAccesses { get; set; }
      public virtual DbSet<FeeScheduleServiceProvider> FeeScheduleServiceProviders { get; set; }
      public virtual DbSet<FeeStepRate> FeeStepRates { get; set; }
      public virtual DbSet<FileMaster> FileMasters { get; set; }
      public virtual DbSet<FundDetail> FundDetails { get; set; }
      public virtual DbSet<FundList> FundLists { get; set; }
      public virtual DbSet<FundListAccess> FundListAccesses { get; set; }
      public virtual DbSet<FundListFund> FundListFunds { get; set; }
      public virtual DbSet<IndexDetail> IndexDetails { get; set; }
      public virtual DbSet<InvestmentProduct> InvestmentProducts { get; set; }
      public virtual DbSet<InvestmentProductFund> InvestmentProductFunds { get; set; }
      public virtual DbSet<InvestmentProductReport> InvestmentProductReports { get; set; }
      public virtual DbSet<ModelFreezer> ModelFreezers { get; set; }
      public virtual DbSet<ModelFreezerDetail> ModelFreezerDetails { get; set; }
      public virtual DbSet<PlanAccess> PlanAccesses { get; set; }
      public virtual DbSet<PlanContact> PlanContacts { get; set; }
      public virtual DbSet<PlanDetail> PlanDetails { get; set; }
      public virtual DbSet<PlanFeeSchedule> PlanFeeSchedules { get; set; }
      public virtual DbSet<PlanFile> PlanFiles { get; set; }
      public virtual DbSet<PlanGroup> PlanGroups { get; set; }
      public virtual DbSet<PlanGroupAccess> PlanGroupAccesses { get; set; }
      public virtual DbSet<PlanGroupDetail> PlanGroupDetails { get; set; }
      public virtual DbSet<PlanInvestment> PlanInvestments { get; set; }
      public virtual DbSet<PlanMaster> PlanMasters { get; set; }
      public virtual DbSet<PlanNotification> PlanNotifications { get; set; }
      public virtual DbSet<PlanReport> PlanReports { get; set; }
      public virtual DbSet<Proposal> Proposals { get; set; }
      public virtual DbSet<ProposalAccess> ProposalAccesses { get; set; }
      public virtual DbSet<ProposalBalanceMap> ProposalBalanceMaps { get; set; }
      public virtual DbSet<ProposalInvestment> ProposalInvestments { get; set; }
      public virtual DbSet<ProposalPlanContact> ProposalPlanContacts { get; set; }
      public virtual DbSet<ProposalReport> ProposalReports { get; set; }
      public virtual DbSet<RecordKeeper> RecordKeepers { get; set; }
      public virtual DbSet<ReportPiece> ReportPieces { get; set; }
      public virtual DbSet<ReportRequest> ReportRequests { get; set; }
      public virtual DbSet<ReportTemplate> ReportTemplates { get; set; }
      public virtual DbSet<ReportTemplateAccess> ReportTemplateAccesses { get; set; }
      public virtual DbSet<ReportTemplateDetail> ReportTemplateDetails { get; set; }
      public virtual DbSet<Review> Reviews { get; set; }
      public virtual DbSet<ReviewFund> ReviewFunds { get; set; }
      public virtual DbSet<ReviewModel> ReviewModels { get; set; }
      public virtual DbSet<ReviewModelDetail> ReviewModelDetails { get; set; }
      public virtual DbSet<ReviewPlan> ReviewPlans { get; set; }
      public virtual DbSet<ReviewPlanChange> ReviewPlanChanges { get; set; }
      public virtual DbSet<ReviewPlanChangeDetail> ReviewPlanChangeDetails { get; set; }
      public virtual DbSet<ReviewPlanNotification> ReviewPlanNotifications { get; set; }
      public virtual DbSet<SageItemType> SageItemTypes { get; set; }
      public virtual DbSet<ScoreWarehouse> ScoreWarehouses { get; set; }
      public virtual DbSet<ScoreWarehouseInvestmentScore> ScoreWarehouseInvestmentScores { get; set; }
      public virtual DbSet<ScoreWarehouseToolDetail> ScoreWarehouseToolDetails { get; set; }
      public virtual DbSet<ScoringTool> ScoringTools { get; set; }
      public virtual DbSet<ScoringToolAccess> ScoringToolAccesses { get; set; }
      public virtual DbSet<ScoringToolDetail> ScoringToolDetails { get; set; }
      public virtual DbSet<ServiceProvider> ServiceProviders { get; set; }
      public virtual DbSet<ServiceProviderFee> ServiceProviderFees { get; set; }
      public virtual DbSet<TestColumn> TestColumns { get; set; }
      public virtual DbSet<TestCompareAgainst> TestCompareAgainsts { get; set; }
      public virtual DbSet<TestCompareAgainstList> TestCompareAgainstLists { get; set; }
      public virtual DbSet<TestCompareAgainstListDetail> TestCompareAgainstListDetails { get; set; }
      public virtual DbSet<TestCompareOperator> TestCompareOperators { get; set; }
      public virtual DbSet<TestCompareOperatorList> TestCompareOperatorLists { get; set; }
      public virtual DbSet<TestCompareOperatorListDetail> TestCompareOperatorListDetails { get; set; }
      public virtual DbSet<TestDataType> TestDataTypes { get; set; }
      public virtual DbSet<TestDataTypeOption> TestDataTypeOptions { get; set; }
      public virtual DbSet<TestGroup> TestGroups { get; set; }
      public virtual DbSet<TestSection> TestSections { get; set; }
      public virtual DbSet<TradingPlatform> TradingPlatforms { get; set; }
      public virtual DbSet<TradingPlatformAccess> TradingPlatformAccesses { get; set; }
      public virtual DbSet<TradingPlatformFund> TradingPlatformFunds { get; set; }
      public virtual DbSet<User> Users { get; set; }
   }
}