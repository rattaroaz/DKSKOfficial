using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DKSKOfficial.Migrations
{
    /// <inheritdoc />
    public partial class jogdescriptionChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Size",
                table: "Invoice");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "JobDiscription",
                newName: "sizeBedroom");

            migrationBuilder.AddColumn<int>(
                name: "priceBathroom",
                table: "JobDiscription",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "priceBedroom",
                table: "JobDiscription",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "sizeBathroom",
                table: "JobDiscription",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Paid",
                table: "Invoice",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "AmountPaid",
                table: "Invoice",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "AmountCost",
                table: "Invoice",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<int>(
                name: "SizeBathroom",
                table: "Invoice",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SizeBedroom",
                table: "Invoice",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "JobDiscription",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "priceBathroom", "priceBedroom", "sizeBathroom", "sizeBedroom" },
                values: new object[] { 100, 100, 1, 1 });

            migrationBuilder.UpdateData(
                table: "JobDiscription",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "priceBathroom", "priceBedroom", "sizeBathroom", "sizeBedroom" },
                values: new object[] { 100, 100, 1, 1 });

            migrationBuilder.UpdateData(
                table: "JobDiscription",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "priceBathroom", "priceBedroom", "sizeBathroom", "sizeBedroom" },
                values: new object[] { 100, 100, 1, 1 });

            migrationBuilder.UpdateData(
                table: "JobDiscription",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "priceBathroom", "priceBedroom", "sizeBathroom", "sizeBedroom" },
                values: new object[] { 100, 100, 1, 1 });

            migrationBuilder.UpdateData(
                table: "JobDiscription",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "priceBathroom", "priceBedroom", "sizeBathroom", "sizeBedroom" },
                values: new object[] { 100, 100, 1, 1 });

            migrationBuilder.UpdateData(
                table: "JobDiscription",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "priceBathroom", "priceBedroom", "sizeBathroom", "sizeBedroom" },
                values: new object[] { 100, 100, 1, 1 });

            migrationBuilder.UpdateData(
                table: "JobDiscription",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "priceBathroom", "priceBedroom", "sizeBathroom", "sizeBedroom" },
                values: new object[] { 100, 100, 1, 1 });

            migrationBuilder.UpdateData(
                table: "JobDiscription",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "priceBathroom", "priceBedroom", "sizeBathroom", "sizeBedroom" },
                values: new object[] { 100, 100, 1, 1 });

            migrationBuilder.UpdateData(
                table: "JobDiscription",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "priceBathroom", "priceBedroom", "sizeBathroom", "sizeBedroom" },
                values: new object[] { 100, 100, 1, 1 });

            migrationBuilder.UpdateData(
                table: "JobDiscription",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "priceBathroom", "priceBedroom", "sizeBathroom", "sizeBedroom" },
                values: new object[] { 100, 100, 1, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "priceBathroom",
                table: "JobDiscription");

            migrationBuilder.DropColumn(
                name: "priceBedroom",
                table: "JobDiscription");

            migrationBuilder.DropColumn(
                name: "sizeBathroom",
                table: "JobDiscription");

            migrationBuilder.DropColumn(
                name: "SizeBathroom",
                table: "Invoice");

            migrationBuilder.DropColumn(
                name: "SizeBedroom",
                table: "Invoice");

            migrationBuilder.RenameColumn(
                name: "sizeBedroom",
                table: "JobDiscription",
                newName: "price");

            migrationBuilder.AlterColumn<string>(
                name: "Paid",
                table: "Invoice",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "AmountPaid",
                table: "Invoice",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "AmountCost",
                table: "Invoice",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "Invoice",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "JobDiscription",
                keyColumn: "Id",
                keyValue: 1,
                column: "price",
                value: 100);

            migrationBuilder.UpdateData(
                table: "JobDiscription",
                keyColumn: "Id",
                keyValue: 2,
                column: "price",
                value: 100);

            migrationBuilder.UpdateData(
                table: "JobDiscription",
                keyColumn: "Id",
                keyValue: 3,
                column: "price",
                value: 100);

            migrationBuilder.UpdateData(
                table: "JobDiscription",
                keyColumn: "Id",
                keyValue: 4,
                column: "price",
                value: 100);

            migrationBuilder.UpdateData(
                table: "JobDiscription",
                keyColumn: "Id",
                keyValue: 5,
                column: "price",
                value: 100);

            migrationBuilder.UpdateData(
                table: "JobDiscription",
                keyColumn: "Id",
                keyValue: 6,
                column: "price",
                value: 100);

            migrationBuilder.UpdateData(
                table: "JobDiscription",
                keyColumn: "Id",
                keyValue: 7,
                column: "price",
                value: 100);

            migrationBuilder.UpdateData(
                table: "JobDiscription",
                keyColumn: "Id",
                keyValue: 8,
                column: "price",
                value: 100);

            migrationBuilder.UpdateData(
                table: "JobDiscription",
                keyColumn: "Id",
                keyValue: 9,
                column: "price",
                value: 100);

            migrationBuilder.UpdateData(
                table: "JobDiscription",
                keyColumn: "Id",
                keyValue: 10,
                column: "price",
                value: 100);
        }
    }
}
