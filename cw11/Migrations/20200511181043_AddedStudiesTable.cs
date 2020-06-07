using Microsoft.EntityFrameworkCore.Migrations;

namespace cw11.Migrations
{
    public partial class AddedStudiesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Studies",
                columns: table => new
                {
                    IdStudies = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studies", x => x.IdStudies);
                });

            migrationBuilder.InsertData(
                table: "Studies",
                columns: new[] { "IdStudies", "Description", "Name" },
                values: new object[] { 1, "AAA", "IT" });

            migrationBuilder.InsertData(
                table: "Studies",
                columns: new[] { "IdStudies", "Description", "Name" },
                values: new object[] { 2, "BBB", "Graphic design" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Studies");
        }
    }
}
