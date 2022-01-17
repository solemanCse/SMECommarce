using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreExamples.Migrations
{
    public partial class Add_Code_Column_On_Item_Tabl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Items");
        }
    }
}
