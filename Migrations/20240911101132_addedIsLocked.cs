using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DKSKOfficial.Migrations
{
    /// <inheritdoc />
    public partial class addedIsLocked : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsLocked",
                table: "Properties",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsLocked",
                table: "Contractor",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsLocked",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsLocked",
                value: null);

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsLocked",
                value: null);

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsLocked",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsLocked",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "IsLocked",
                table: "Contractor");
        }
    }
}
