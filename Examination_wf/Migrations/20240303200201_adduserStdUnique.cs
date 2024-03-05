using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examinationwf.Migrations
{
    /// <inheritdoc />
    public partial class adduserStdUnique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Students_userName",
                table: "Students",
                column: "userName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Students_userName",
                table: "Students");
        }
    }
}
