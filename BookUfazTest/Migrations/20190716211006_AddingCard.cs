using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookUfazTest.Migrations
{
    public partial class AddingCard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Students_StudentId",
                table: "Grades");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Grades_StudentId",
                table: "Grades");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Grades",
                newName: "StudentUserId");

            migrationBuilder.AddColumn<string>(
                name: "StudentUserId1",
                table: "Grades",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FacultyId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StudentNameSurname",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UnistraCardId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "YearId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_StudentUserId1",
                table: "Grades",
                column: "StudentUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_FacultyId",
                table: "AspNetUsers",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_YearId",
                table: "AspNetUsers",
                column: "YearId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Faculties_FacultyId",
                table: "AspNetUsers",
                column: "FacultyId",
                principalTable: "Faculties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Years_YearId",
                table: "AspNetUsers",
                column: "YearId",
                principalTable: "Years",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_AspNetUsers_StudentUserId1",
                table: "Grades",
                column: "StudentUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Faculties_FacultyId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Years_YearId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Grades_AspNetUsers_StudentUserId1",
                table: "Grades");

            migrationBuilder.DropIndex(
                name: "IX_Grades_StudentUserId1",
                table: "Grades");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_FacultyId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_YearId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "StudentUserId1",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "FacultyId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "StudentNameSurname",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UnistraCardId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "YearId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "StudentUserId",
                table: "Grades",
                newName: "StudentId");

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FacultyId = table.Column<int>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    StudentCardId = table.Column<string>(nullable: true),
                    StudentNameSurname = table.Column<string>(nullable: true),
                    YearId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Faculties_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_Years_YearId",
                        column: x => x.YearId,
                        principalTable: "Years",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Grades_StudentId",
                table: "Grades",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_FacultyId",
                table: "Students",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_YearId",
                table: "Students",
                column: "YearId");

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Students_StudentId",
                table: "Grades",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
