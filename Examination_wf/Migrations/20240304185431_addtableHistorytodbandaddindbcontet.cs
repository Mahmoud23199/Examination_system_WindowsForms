using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examinationwf.Migrations
{
    /// <inheritdoc />
    public partial class addtableHistorytodbandaddindbcontet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExamHistory_Courses_CourseId",
                table: "ExamHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_ExamHistory_Students_StudentId",
                table: "ExamHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExamHistory",
                table: "ExamHistory");

            migrationBuilder.RenameTable(
                name: "ExamHistory",
                newName: "ExamHistorys");

            migrationBuilder.RenameIndex(
                name: "IX_ExamHistory_StudentId",
                table: "ExamHistorys",
                newName: "IX_ExamHistorys_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_ExamHistory_CourseId",
                table: "ExamHistorys",
                newName: "IX_ExamHistorys_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExamHistorys",
                table: "ExamHistorys",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExamHistorys_Courses_CourseId",
                table: "ExamHistorys",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Crs_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExamHistorys_Students_StudentId",
                table: "ExamHistorys",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Student_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExamHistorys_Courses_CourseId",
                table: "ExamHistorys");

            migrationBuilder.DropForeignKey(
                name: "FK_ExamHistorys_Students_StudentId",
                table: "ExamHistorys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExamHistorys",
                table: "ExamHistorys");

            migrationBuilder.RenameTable(
                name: "ExamHistorys",
                newName: "ExamHistory");

            migrationBuilder.RenameIndex(
                name: "IX_ExamHistorys_StudentId",
                table: "ExamHistory",
                newName: "IX_ExamHistory_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_ExamHistorys_CourseId",
                table: "ExamHistory",
                newName: "IX_ExamHistory_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExamHistory",
                table: "ExamHistory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExamHistory_Courses_CourseId",
                table: "ExamHistory",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Crs_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExamHistory_Students_StudentId",
                table: "ExamHistory",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Student_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
