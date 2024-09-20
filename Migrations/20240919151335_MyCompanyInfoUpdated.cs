using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DKSKOfficial.Migrations
{
    /// <inheritdoc />
    public partial class MyCompanyInfoUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CellPhone",
                table: "MyCompanyInfo");

            migrationBuilder.DropColumn(
                name: "City",
                table: "MyCompanyInfo");

            migrationBuilder.RenameColumn(
                name: "Zip",
                table: "MyCompanyInfo",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "MyCompanyInfo",
                newName: "LicenseNumber");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$KdIRHxhBcBocjAyWVdAPPep8S/Y5ObD4wFMMZ4Yk2cwxFSe0mSmHe");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$XnQ/gmjCB5fMHJMso2P2y.g.9tFOJveDuNDeZirzWwlyzN593m9nG");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "MyCompanyInfo",
                newName: "Zip");

            migrationBuilder.RenameColumn(
                name: "LicenseNumber",
                table: "MyCompanyInfo",
                newName: "State");

            migrationBuilder.AddColumn<string>(
                name: "CellPhone",
                table: "MyCompanyInfo",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "MyCompanyInfo",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$ABEpvKHOu9YiQWXlRiSQPekQOnLfIYj81n236vo.QuJW3rmFYc0hG");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$Izi0kNLcXRXCgc5GwfsbYu2i85twv7fML9VbMPr5Flvzw0HqupMpa");
        }
    }
}
