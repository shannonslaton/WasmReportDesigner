using Microsoft.EntityFrameworkCore.Migrations;

namespace WasmReportDesigner.Server.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Catalogs",
                columns: table => new
                {
                    RecId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CatalogName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalogs", x => x.RecId);
                });

            migrationBuilder.InsertData(
                table: "Catalogs",
                columns: new[] { "RecId", "CatalogName" },
                values: new object[] { 1, "Performance" });

            migrationBuilder.InsertData(
                table: "Catalogs",
                columns: new[] { "RecId", "CatalogName" },
                values: new object[] { 2, "Sound" });

            migrationBuilder.InsertData(
                table: "Catalogs",
                columns: new[] { "RecId", "CatalogName" },
                values: new object[] { 3, "Lights" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Catalogs");
        }
    }
}
