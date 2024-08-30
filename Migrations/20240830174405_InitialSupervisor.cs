using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DKSKOfficial.Migrations
{
    /// <inheritdoc />
    public partial class InitialSupervisor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Supervisor",
                columns: new[] { "Id", "CellPhone", "Email", "Name", "SpecialNote" },
                values: new object[,]
                {
                    { 1, "12345543", "johndoe@gmail.com", "John Doe", "" },
                    { 2, "12345543", "david@gmail.com", "David", "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Supervisor",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Supervisor",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
