using Microsoft.EntityFrameworkCore.Migrations;

namespace Tool_Warehouse_Management_System.DataAccess.Migrations
{
    public partial class AfterSomeMods : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tools_ToolCategories_ToolCategoryId",
                table: "Tools");

            migrationBuilder.DropIndex(
                name: "IX_Tools_ToolCategoryId",
                table: "Tools");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Tools_ToolCategoryId",
                table: "Tools",
                column: "ToolCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tools_ToolCategories_ToolCategoryId",
                table: "Tools",
                column: "ToolCategoryId",
                principalTable: "ToolCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
