using System;
using System.Collections.Generic;

namespace Tcr.Sage.Domain.Models {
   public partial class DataFeed {
      public DataFeed() {
         CategoryDetail = new HashSet<CategoryDetail>();
         FundDetail = new HashSet<FundDetail>();
         FundList = new HashSet<FundList>();
         IndexDetail = new HashSet<IndexDetail>();
         Proposal = new HashSet<Proposal>();
      }

      public int Id { get; set; }
      public DateTime FeedDate { get; set; }

      public virtual ICollection<CategoryDetail> CategoryDetail { get; set; }
      public virtual ICollection<FundDetail> FundDetail { get; set; }
      public virtual ICollection<FundList> FundList { get; set; }
      public virtual ICollection<IndexDetail> IndexDetail { get; set; }
      public virtual ICollection<Proposal> Proposal { get; set; }
   }
}
