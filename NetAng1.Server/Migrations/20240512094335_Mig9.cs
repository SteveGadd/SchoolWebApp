﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetAng1.Server.Migrations
{
    /// <inheritdoc />
    public partial class Mig9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Departments_Name",
                table: "Departments",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Departments_Name",
                table: "Departments");
        }
    }
}
