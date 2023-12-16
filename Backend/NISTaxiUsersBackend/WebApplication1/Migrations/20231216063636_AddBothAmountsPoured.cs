using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class AddBothAmountsPoured : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AmountPoured",
                table: "Drivers",
                newName: "AmountPouredSecond");

            migrationBuilder.AddColumn<double>(
                name: "AmountPouredFirst",
                table: "Drivers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmountPouredFirst",
                table: "Drivers");

            migrationBuilder.RenameColumn(
                name: "AmountPouredSecond",
                table: "Drivers",
                newName: "AmountPoured");
        }
    }
}
