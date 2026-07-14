using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DocumentSchool.InfraEstructure.Migrations
{
    /// <inheritdoc />
    public partial class Addingpropertyamountintheclass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "Registers",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Registers");
        }
    }
}
