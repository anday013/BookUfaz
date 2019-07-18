using Microsoft.EntityFrameworkCore.Migrations;

namespace BookUfazTest.Migrations
{
    public partial class SubjectAndGradeUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Faculties_FacultyId",
                table: "Grades");

            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Semesters_SemesterId",
                table: "Grades");

            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Years_YearId",
                table: "Grades");

            migrationBuilder.DropIndex(
                name: "IX_Grades_FacultyId",
                table: "Grades");

            migrationBuilder.DropIndex(
                name: "IX_Grades_SemesterId",
                table: "Grades");

            migrationBuilder.DropIndex(
                name: "IX_Grades_YearId",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "FacultyId",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "SemesterId",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "YearId",
                table: "Grades");

            migrationBuilder.AddColumn<int>(
                name: "FacultyId",
                table: "Subjects",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SemesterId",
                table: "Subjects",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "YearId",
                table: "Subjects",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_FacultyId",
                table: "Subjects",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_SemesterId",
                table: "Subjects",
                column: "SemesterId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_YearId",
                table: "Subjects",
                column: "YearId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Faculties_FacultyId",
                table: "Subjects",
                column: "FacultyId",
                principalTable: "Faculties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Semesters_SemesterId",
                table: "Subjects",
                column: "SemesterId",
                principalTable: "Semesters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Years_YearId",
                table: "Subjects",
                column: "YearId",
                principalTable: "Years",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Faculties_FacultyId",
                table: "Subjects");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Semesters_SemesterId",
                table: "Subjects");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Years_YearId",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_FacultyId",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_SemesterId",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_YearId",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "FacultyId",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "SemesterId",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "YearId",
                table: "Subjects");

            migrationBuilder.AddColumn<int>(
                name: "FacultyId",
                table: "Grades",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SemesterId",
                table: "Grades",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "YearId",
                table: "Grades",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Grades_FacultyId",
                table: "Grades",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_SemesterId",
                table: "Grades",
                column: "SemesterId");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_YearId",
                table: "Grades",
                column: "YearId");

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Faculties_FacultyId",
                table: "Grades",
                column: "FacultyId",
                principalTable: "Faculties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Semesters_SemesterId",
                table: "Grades",
                column: "SemesterId",
                principalTable: "Semesters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Years_YearId",
                table: "Grades",
                column: "YearId",
                principalTable: "Years",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
