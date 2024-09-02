using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DKSKOfficial.Migrations
{
    /// <inheritdoc />
    public partial class PropertyInvoiceUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GarageRemoteCode",
                table: "Properties",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GarageRemoteCode",
                table: "Invoice",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1,
                column: "GarageRemoteCode",
                value: "1234");

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2,
                column: "GarageRemoteCode",
                value: "223a");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GarageRemoteCode",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "GarageRemoteCode",
                table: "Invoice");
        }
    }
}
