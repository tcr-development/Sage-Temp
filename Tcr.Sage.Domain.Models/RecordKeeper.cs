namespace Tcr.Sage.Domain.Models {
   public partial class RecordKeeper {
      public int CompanyId { get; set; }
      public string DataUrl { get; set; }
      public byte RecordKeeperTypeCd { get; set; }
      public string Version { get; set; }

      public virtual Company Company { get; set; }
   }
}
