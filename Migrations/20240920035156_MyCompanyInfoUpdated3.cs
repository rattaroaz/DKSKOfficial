using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DKSKOfficial.Migrations
{
    /// <inheritdoc />
    public partial class MyCompanyInfoUpdated3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Zip",
                table: "MyCompanyInfo",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "MyCompanyInfo",
                keyColumn: "Id",
                keyValue: 1,
                column: "Zip",
                value: "1234");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$5rwYyZi/RX54Dum6z4dEq.IGHaROYg9ejAPwegWK49ABN7MDg5GFS");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$iu1FAZQnx5rqTgBIXklEwONPaA1AhhHcH9rqH3WHHhh.jtOdwGHC6");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Zip",
                table: "MyCompanyInfo");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$BWbaOYefw/LNK0fP6.RmbO0McPXO1b/b4e3oMh2AAxjmerJj3j2hK");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$it7wjo91RpVRi.R8WlBmK.J/XceTDX6yYchfKmRPRBP.kjC/E/GZa");
        }
    }
}
