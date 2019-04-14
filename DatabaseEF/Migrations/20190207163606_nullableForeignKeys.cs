using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseEF.Migrations
{
    public partial class nullableForeignKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                "IX_Persons_TodoItemID",
                "Persons");

            migrationBuilder.AlterColumn<int>(
                "PersonOnItID",
                "TodoItems",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                "TodoItemID",
                "Persons",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                "IX_Persons_TodoItemID",
                "Persons",
                "TodoItemID",
                unique: true,
                filter: "[TodoItemID] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                "IX_Persons_TodoItemID",
                "Persons");

            migrationBuilder.AlterColumn<int>(
                "PersonOnItID",
                "TodoItems",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                "TodoItemID",
                "Persons",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                "IX_Persons_TodoItemID",
                "Persons",
                "TodoItemID",
                unique: true);
        }
    }
}