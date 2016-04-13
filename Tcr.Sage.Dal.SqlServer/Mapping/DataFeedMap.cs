using Microsoft.Data.Entity;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {
   public class DataFeedMap {
      public static void AddMap(ModelBuilder modelBuilder) {
         modelBuilder.Entity<DataFeed>(entity => {
            entity.Property(e => e.FeedDate).HasColumnType("date");
         });
      }
   }
}