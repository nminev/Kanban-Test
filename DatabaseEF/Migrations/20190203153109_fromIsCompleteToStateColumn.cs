using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseEF.Migrations
{
    public partial class fromIsCompleteToStateColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                "IsComplete",
                "TodoItems");

            migrationBuilder.AddColumn<int>(
                "State",
                "TodoItems",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                "State",
                "TodoItems");

            migrationBuilder.AddColumn<bool>(
                "IsComplete",
                "TodoItems",
                nullable: false,
                defaultValue: false);
        }
    }
}