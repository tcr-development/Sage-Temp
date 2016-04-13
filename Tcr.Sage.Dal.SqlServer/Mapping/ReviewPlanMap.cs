using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class ReviewPlanMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<ReviewPlan>(entity => {
            entity.HasIndex(e => e.PlanMasterId).HasName("Idx_ReviewPlan_PlanMasterId");

            entity.HasIndex(e => e.ReviewId).HasName("Idx_ReviewPlan_ReviewId");

            entity.Property(e => e.AddressLine1)
                .HasMaxLength(50)
                .HasColumnType("varchar");

            entity.Property(e => e.AddressLine2)
                .HasMaxLength(50)
                .HasColumnType("varchar");

            entity.Property(e => e.BalanceAsOfDate).HasColumnType("date");

            entity.Property(e => e.City)
                .HasMaxLength(30)
                .HasColumnType("varchar");

            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .HasColumnType("varchar");

            entity.Property(e => e.EmployerIdNumber)
                .HasMaxLength(30)
                .HasColumnType("varchar");

            entity.Property(e => e.LoanBalanceAmount).HasColumnType("decimal");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnType("varchar");

            entity.Property(e => e.Phone)
                .HasMaxLength(30)
                .HasColumnType("varchar");

            entity.Property(e => e.PrimaryContact)
                .HasMaxLength(500)
                .HasColumnType("varchar");

            entity.Property(e => e.RecEffDate).HasColumnType("date");

            entity.Property(e => e.State)
                .HasMaxLength(2)
                .HasColumnType("varchar");

            entity.Property(e => e.TradingPlatform)
                .HasMaxLength(150)
                .HasColumnType("varchar");

            entity.Property(e => e.Trustees)
                .HasMaxLength(500)
                .HasColumnType("varchar");

            entity.Property(e => e.Zip)
                .HasMaxLength(10)
                .HasColumnType("varchar");

            entity.HasOne(d => d.PlanMaster).WithMany(p => p.ReviewPlan).HasForeignKey(d => d.PlanMasterId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Review).WithMany(p => p.ReviewPlan).HasForeignKey(d => d.ReviewId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}