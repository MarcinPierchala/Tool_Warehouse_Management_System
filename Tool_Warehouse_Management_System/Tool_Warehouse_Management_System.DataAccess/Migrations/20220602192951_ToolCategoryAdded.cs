using Microsoft.EntityFrameworkCore.Migrations;

namespace Tool_Warehouse_Management_System.DataAccess.Migrations
{
    public partial class ToolCategoryAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Tools");

            migrationBuilder.AddColumn<int>(
                name: "ToolCategoryId",
                table: "Tools",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ToolCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToolCategory", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tools_ToolCategoryId",
                table: "Tools",
                column: "ToolCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tools_ToolCategory_ToolCategoryId",
                table: "Tools",
                column: "ToolCategoryId",
                principalTable: "ToolCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tools_ToolCategory_ToolCategoryId",
                table: "Tools");

            migrationBuilder.DropTable(
                name: "ToolCategory");

            migrationBuilder.DropIndex(
                name: "IX_Tools_ToolCategoryId",
                table: "Tools");

            migrationBuilder.DropColumn(
                name: "ToolCategoryId",
                table: "Tools");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Tools",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }
    }
}
