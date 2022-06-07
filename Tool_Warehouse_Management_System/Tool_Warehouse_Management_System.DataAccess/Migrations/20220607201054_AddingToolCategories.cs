using Microsoft.EntityFrameworkCore.Migrations;

namespace Tool_Warehouse_Management_System.DataAccess.Migrations
{
    public partial class AddingToolCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tools_ToolCategory_ToolCategoryId",
                table: "Tools");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ToolCategory",
                table: "ToolCategory");

            migrationBuilder.RenameTable(
                name: "ToolCategory",
                newName: "ToolCategories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ToolCategories",
                table: "ToolCategories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tools_ToolCategories_ToolCategoryId",
                table: "Tools",
                column: "ToolCategoryId",
                principalTable: "ToolCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tools_ToolCategories_ToolCategoryId",
                table: "Tools");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ToolCategories",
                table: "ToolCategories");

            migrationBuilder.RenameTable(
                name: "ToolCategories",
                newName: "ToolCategory");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ToolCategory",
                table: "ToolCategory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tools_ToolCategory_ToolCategoryId",
                table: "Tools",
                column: "ToolCategoryId",
                principalTable: "ToolCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
