using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseEF.Migrations
{
    public partial class fromIsCompleteToStateColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsComplete",
                table: "TodoItems");

            migrationBuilder.AddColumn<int>(
                name: "State",
                table: "TodoItems",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "State",
                table: "TodoItems");

            migrationBuilder.AddColumn<bool>(
                name: "IsComplete",
                table: "TodoItems",
                nullable: false,
                defaultValue: false);
        }
    }
}
