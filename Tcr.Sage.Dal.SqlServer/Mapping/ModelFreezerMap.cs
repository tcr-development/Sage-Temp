using Microsoft.Data.Entity;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {
   public class ModelFreezerMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<ModelFreezer>(entity => {
            entity.Property(e => e.M0ReturnValue).HasColumnType("decimal");

            entity.Property(e => e.M120ReturnValue).HasColumnType("decimal");

            entity.Property(e => e.M120SharpeRatio).HasColumnType("decimal");

            entity.Property(e => e.M120StandardDeviation).HasColumnType("decimal");

            entity.Property(e => e.M12ReturnValue).HasColumnType("decimal");

            entity.Property(e => e.M36ReturnValue).HasColumnType("decimal");

            entity.Property(e => e.M36SharpeRatio).HasColumnType("decimal");

            entity.Property(e => e.M36StandardDeviation).HasColumnType("decimal");

            entity.Property(e => e.M3ReturnValue).HasColumnType("decimal");

            entity.Property(e => e.M60ReturnValue).HasColumnType("decimal");

            entity.Property(e => e.M60SharpeRatio).HasColumnType("decimal");

            entity.Property(e => e.M60StandardDeviation).HasColumnType("decimal");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnType("varchar");

            entity.Property(e => e.RkModelId)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar");

            entity.Property(e => e.RkModelUserId)
                .HasMaxLength(50)
                .HasColumnType("varchar");
         });
      }
   }
}