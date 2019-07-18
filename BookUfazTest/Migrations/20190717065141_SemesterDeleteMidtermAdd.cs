using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookUfazTest.Migrations
{
    public partial class SemesterDeleteMidtermAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Semesters_SemesterId",
                table: "Subjects");

            migrationBuilder.DropTable(
                name: "Semesters");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_SemesterId",
                table: "Subjects");

            migrationBuilder.RenameColumn(
                name: "SemesterId",
                table: "Subjects",
                newName: "Semester");

            migrationBuilder.AddColumn<int>(
                name: "Midterm",
                table: "Subjects",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Midterm",
                table: "Subjects");

            migrationBuilder.RenameColumn(
                name: "Semester",
                table: "Subjects",
                newName: "SemesterId");

            migrationBuilder.CreateTable(
                name: "Semesters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SemesterName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semesters", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_SemesterId",
                table: "Subjects",
                column: "SemesterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Semesters_SemesterId",
                table: "Subjects",
                column: "SemesterId",
                principalTable: "Semesters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
