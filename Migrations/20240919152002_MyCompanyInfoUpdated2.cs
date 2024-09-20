using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DKSKOfficial.Migrations
{
    /// <inheritdoc />
    public partial class MyCompanyInfoUpdated2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MyCompanyInfo",
                columns: new[] { "Id", "Address", "Email", "LicenseNumber", "Name", "Phone" },
                values: new object[] { 1, "123 A St.", "ownerA@example.com", "123123", "DKSK Company", "123-456-7890" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MyCompanyInfo",
                keyColumn: "Id",
                keyValue: 1);

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
    }
}
