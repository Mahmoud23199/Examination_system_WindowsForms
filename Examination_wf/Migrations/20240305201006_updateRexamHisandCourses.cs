using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examinationwf.Migrations
{
    /// <inheritdoc />
    public partial class updateRexamHisandCourses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ExamHistorys_CourseId",
                table: "ExamHistorys");

            migrationBuilder.CreateIndex(
                name: "IX_ExamHistorys_CourseId",
                table: "ExamHistorys",
                column: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ExamHistorys_CourseId",
                table: "ExamHistorys");

            migrationBuilder.CreateIndex(
                name: "IX_ExamHistorys_CourseId",
                table: "ExamHistorys",
                column: "CourseId",
                unique: true);
        }
    }
}
