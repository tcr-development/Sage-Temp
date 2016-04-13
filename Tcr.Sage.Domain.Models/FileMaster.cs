using System;
using System.Collections.Generic;

namespace Tcr.Sage.Domain.Models {
   public partial class FileMaster {
      public FileMaster() {
         InvestmentProductReport = new HashSet<InvestmentProductReport>();
         PlanFile = new HashSet<PlanFile>();
         PlanReport = new HashSet<PlanReport>();
         ProposalReport = new HashSet<ProposalReport>();
         ReportPiece = new HashSet<ReportPiece>();
      }

      public int Id { get; set; }
      public int CompanyId { get; set; }
      public DateTime CreatedDate { get; set; }
      public string Name { get; set; }
      public int SizeInBytes { get; set; }

      public virtual ICollection<InvestmentProductReport> InvestmentProductReport { get; set; }
      public virtual ICollection<PlanFile> PlanFile { get; set; }
      public virtual ICollection<PlanReport> PlanReport { get; set; }
      public virtual ICollection<ProposalReport> ProposalReport { get; set; }
      public virtual ICollection<ReportPiece> ReportPiece { get; set; }
      public virtual Company Company { get; set; }
   }
}
