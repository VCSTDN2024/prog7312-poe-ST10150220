using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiceDeliveryPOE.Migrations
{
    /// <inheritdoc />
    public partial class ReportStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Reports",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StatusDetails",
                table: "Reports",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "StatusDetails",
                table: "Reports");
        }
    }
}
