using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DKSKOfficial.Migrations
{
    /// <inheritdoc />
    public partial class updateJDPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "priceBathroom",
                table: "JobDiscription");

            migrationBuilder.RenameColumn(
                name: "priceBedroom",
                table: "JobDiscription",
                newName: "price");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "price",
                table: "JobDiscription",
                newName: "priceBedroom");

            migrationBuilder.AddColumn<int>(
                name: "priceBathroom",
                table: "JobDiscription",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "JobDiscription",
                keyColumn: "Id",
                keyValue: 1,
                column: "priceBathroom",
                value: 100);

            migrationBuilder.UpdateData(
                table: "JobDiscription",
                keyColumn: "Id",
                keyValue: 2,
                column: "priceBathroom",
                value: 100);

            migrationBuilder.UpdateData(
                table: "JobDiscription",
                keyColumn: "Id",
                keyValue: 3,
                column: "priceBathroom",
                value: 100);

            migrationBuilder.UpdateData(
                table: "JobDiscription",
                keyColumn: "Id",
                keyValue: 4,
                column: "priceBathroom",
                value: 100);

            migrationBuilder.UpdateData(
                table: "JobDiscription",
                keyColumn: "Id",
                keyValue: 5,
                column: "priceBathroom",
                value: 100);

            migrationBuilder.UpdateData(
                table: "JobDiscription",
                keyColumn: "Id",
                keyValue: 6,
                column: "priceBathroom",
                value: 100);

            migrationBuilder.UpdateData(
                table: "JobDiscription",
                keyColumn: "Id",
                keyValue: 7,
                column: "priceBathroom",
                value: 100);

            migrationBuilder.UpdateData(
                table: "JobDiscription",
                keyColumn: "Id",
                keyValue: 8,
                column: "priceBathroom",
                value: 100);

            migrationBuilder.UpdateData(
                table: "JobDiscription",
                keyColumn: "Id",
                keyValue: 9,
                column: "priceBathroom",
                value: 100);

            migrationBuilder.UpdateData(
                table: "JobDiscription",
                keyColumn: "Id",
                keyValue: 10,
                column: "priceBathroom",
                value: 100);
        }
    }
}
