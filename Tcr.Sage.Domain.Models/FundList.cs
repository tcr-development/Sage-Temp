using System;
using System.Collections.Generic;

namespace Tcr.Sage.Domain.Models {
   public partial class FundList {
      public FundList() {
         FundListAccess = new HashSet<FundListAccess>();
         FundListFund = new HashSet<FundListFund>();
      }

      public int Id { get; set; }
      public bool Archived { get; set; }
      public int CompanyId { get; set; }
      public DateTime CreatedDate { get; set; }
      public int DataFeedId { get; set; }
      public DateTime LastModifyDate { get; set; }
      public bool Locked { get; set; }
      public string Name { get; set; }
      public string Notes { get; set; }
      public int? TradingPlatformId { get; set; }

      public virtual ICollection<FundListAccess> FundListAccess { get; set; }
      public virtual ICollection<FundListFund> FundListFund { get; set; }
      public virtual Company Company { get; set; }
      public virtual DataFeed DataFeed { get; set; }
      public virtual TradingPlatform TradingPlatform { get; set; }
   }
}
