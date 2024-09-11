using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DKSKOfficial.Migrations
{
    /// <inheritdoc />
    public partial class addedIsActive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsLocked",
                table: "Properties",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "IsLocked",
                table: "Contractor",
                newName: "IsActive");

            migrationBuilder.UpdateData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsActive",
                value: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Properties",
                newName: "IsLocked");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Contractor",
                newName: "IsLocked");

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
    }
}
