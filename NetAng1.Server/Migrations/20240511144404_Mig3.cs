using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetAng1.Server.Migrations
{
    /// <inheritdoc />
    public partial class Mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Departments_HeadProfessorId",
                table: "Departments");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_HeadProfessorId",
                table: "Departments",
                column: "HeadProfessorId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Departments_HeadProfessorId",
                table: "Departments");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_HeadProfessorId",
                table: "Departments",
                column: "HeadProfessorId");
        }
    }
}
