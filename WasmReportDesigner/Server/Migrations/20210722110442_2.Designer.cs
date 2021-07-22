﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WasmReportDesigner.Server.Data;

namespace WasmReportDesigner.Server.Migrations
{
    [DbContext(typeof(WasmReportContext))]
    [Migration("20210722110442_2")]
    partial class _2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WasmReportDesigner.Shared.Catalog", b =>
                {
                    b.Property<int>("RecId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CatalogName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RecId");

                    b.ToTable("Catalogs");

                    b.HasData(
                        new
                        {
                            RecId = 1,
                            CatalogName = "Performance"
                        },
                        new
                        {
                            RecId = 2,
                            CatalogName = "Sound"
                        },
                        new
                        {
                            RecId = 3,
                            CatalogName = "Lights"
                        });
                });

            modelBuilder.Entity("WasmReportDesigner.Shared.ReportTemplate", b =>
                {
                    b.Property<int>("RecId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<int?>("DisciplineId")
                        .HasColumnType("int");

                    b.Property<int>("EditIndex")
                        .HasColumnType("int");

                    b.Property<bool?>("GlobalLayout")
                        .HasColumnType("bit");

                    b.Property<bool>("Hidden")
                        .HasColumnType("bit");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastModifiedById")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastModifiedOnDt")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("Layout")
                        .HasColumnType("varbinary(max)");

                    b.Property<bool?>("Locked")
                        .HasColumnType("bit");

                    b.Property<int>("OwnerContactRecId")
                        .HasColumnType("int");

                    b.Property<string>("ReportTemplateName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReportType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Updated")
                        .HasColumnType("bit");

                    b.HasKey("RecId");

                    b.ToTable("ReportTemplates");
                });
#pragma warning restore 612, 618
        }
    }
}
