namespace Tcr.Sage.Domain.Models {
   public partial class TestDataTypeOption {
      public int Id { get; set; }
      public string DataValue { get; set; }
      public string DisplayText { get; set; }
      public byte OrderNum { get; set; }
      public byte TestDataTypeId { get; set; }

      public virtual TestDataType TestDataType { get; set; }
   }
}
