﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCCodeFirstInCore.Migrations
{
    /// <inheritdoc />
    public partial class firtdbcreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Studentname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marks = table.Column<int>(type: "int", nullable: false),
                    ClassTeacher = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
