using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCCodeFirstInCore.Migrations
{
    /// <inheritdoc />
    public partial class AddedValidations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TotalPercentage",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalPercentage",
                table: "Students");
        }
    }
}
