using System;

namespace Tcr.Sage.Dal.I.Helpers {
   public struct Page {
      public readonly int PageNumber;
      public readonly int PageSize;

      public Page(int pageNumber, int pageSize) {
         PageNumber = pageNumber;
         PageSize = pageSize;
      }

      public static bool operator ==(Page page, Page otherPage) {
         return page.PageNumber == otherPage.PageNumber && page.PageSize == otherPage.PageSize;
      }

      public static bool operator !=(Page page, Page otherPage) {
         return page.PageNumber != otherPage.PageNumber && page.PageSize != otherPage.PageSize;
      }

      public override bool Equals(object obj) {
         if (obj is Page) {
            return this == (Page)obj;
         }
         throw new ArgumentException("object not of proper type", nameof(obj));
      }

      public override int GetHashCode() {
         return (this.PageNumber + this.PageSize) ^ this.PageSize;
      }
   }
}