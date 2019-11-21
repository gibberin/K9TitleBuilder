using Microsoft.EntityFrameworkCore.Migrations;

namespace K9TitleBuilder.Data.Migrations
{
    public partial class Factored_Out_Name_Prop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Dog",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Dog");
        }
    }
}
