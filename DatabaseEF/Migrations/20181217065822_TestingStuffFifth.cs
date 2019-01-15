using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseEF.Migrations
{
    public partial class TestingStuffFifth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_Tasks_TaskID",
                table: "Person");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Tasks_TaskID",
                table: "Person",
                column: "TaskID",
                principalTable: "Tasks",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_Tasks_TaskID",
                table: "Person");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Tasks_TaskID",
                table: "Person",
                column: "TaskID",
                principalTable: "Tasks",
                principalColumn: "ID",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
