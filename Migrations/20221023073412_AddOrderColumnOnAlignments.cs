using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaldursGateAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddOrderColumnOnAlignments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Alignments",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Order",
                table: "Alignments");
        }
    }
}
