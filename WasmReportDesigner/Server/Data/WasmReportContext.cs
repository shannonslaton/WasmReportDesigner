using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WasmReportDesigner.Shared;

namespace WasmReportDesigner.Server.Data
{
    public partial class WasmReportContext : DbContext
    {
        public WasmReportContext(DbContextOptions<WasmReportContext> options) : base(options)
        {
        }

        public virtual DbSet<Catalog> Catalogs { get; set; }
        public virtual DbSet<ReportTemplate> ReportTemplates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Catalog>(entity =>
            {
                entity.HasKey(e => e.RecId);
            });

            modelBuilder.Entity<Catalog>().HasData(
                new Catalog() { RecId = 1, CatalogName = "Performance"},
                new Catalog() { RecId = 2, CatalogName = "Sound" },
                new Catalog() { RecId = 3, CatalogName = "Lights" }
            );

            modelBuilder.Entity<ReportTemplate>(entity =>
            {
                entity.HasKey(e => e.RecId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
