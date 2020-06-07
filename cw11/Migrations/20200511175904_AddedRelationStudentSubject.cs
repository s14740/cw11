using Microsoft.EntityFrameworkCore.Migrations;

namespace cw11.Migrations
{
    public partial class AddedRelationStudentSubject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdSubject",
                table: "Persons",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persons_IdSubject",
                table: "Persons",
                column: "IdSubject");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Subjects_IdSubject",
                table: "Persons",
                column: "IdSubject",
                principalTable: "Subjects",
                principalColumn: "IdSubject",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Subjects_IdSubject",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_IdSubject",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "IdSubject",
                table: "Persons");
        }
    }
}
