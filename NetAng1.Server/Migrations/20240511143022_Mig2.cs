using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetAng1.Server.Migrations
{
    /// <inheritdoc />
    public partial class Mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Professors_HeadProfessorId",
                table: "Departments");

            migrationBuilder.AlterColumn<int>(
                name: "HeadProfessorId",
                table: "Departments",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Professors_HeadProfessorId",
                table: "Departments",
                column: "HeadProfessorId",
                principalTable: "Professors",
                principalColumn: "ProfessorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Professors_HeadProfessorId",
                table: "Departments");

            migrationBuilder.AlterColumn<int>(
                name: "HeadProfessorId",
                table: "Departments",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Professors_HeadProfessorId",
                table: "Departments",
                column: "HeadProfessorId",
                principalTable: "Professors",
                principalColumn: "ProfessorId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
