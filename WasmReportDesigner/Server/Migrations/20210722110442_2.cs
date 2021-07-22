using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WasmReportDesigner.Server.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReportTemplates",
                columns: table => new
                {
                    RecId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerContactRecId = table.Column<int>(type: "int", nullable: false),
                    LastModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedOnDt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<bool>(type: "bit", nullable: false),
                    Hidden = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EditIndex = table.Column<int>(type: "int", nullable: false),
                    ReportTemplateName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Layout = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Locked = table.Column<bool>(type: "bit", nullable: true),
                    ReportType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GlobalLayout = table.Column<bool>(type: "bit", nullable: true),
                    DisciplineId = table.Column<int>(type: "int", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportTemplates", x => x.RecId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReportTemplates");
        }
    }
}
