using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseEF.Migrations
{
    public partial class nullableForeignKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Persons_TodoItemID",
                table: "Persons");

            migrationBuilder.AlterColumn<int>(
                name: "PersonOnItID",
                table: "TodoItems",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "TodoItemID",
                table: "Persons",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Persons_TodoItemID",
                table: "Persons",
                column: "TodoItemID",
                unique: true,
                filter: "[TodoItemID] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Persons_TodoItemID",
                table: "Persons");

            migrationBuilder.AlterColumn<int>(
                name: "PersonOnItID",
                table: "TodoItems",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TodoItemID",
                table: "Persons",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persons_TodoItemID",
                table: "Persons",
                column: "TodoItemID",
                unique: true);
        }
    }
}
