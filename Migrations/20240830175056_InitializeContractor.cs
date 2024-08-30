using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DKSKOfficial.Migrations
{
    /// <inheritdoc />
    public partial class InitializeContractor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Contractor",
                columns: new[] { "Id", "Address", "CellPhone", "City", "ContractorID", "Email", "LicenseNumber", "Name", "PayrollPercent", "SocailSecurityNumber", "SpecialNote", "Zip" },
                values: new object[,]
                {
                    { 1, "", "", "", "", "", "", "John Doe", "", "", "", "" },
                    { 2, "", "", "", "", "", "", "David", "", "", "", "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contractor",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
