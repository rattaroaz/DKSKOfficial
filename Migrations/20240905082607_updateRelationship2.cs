using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DKSKOfficial.Migrations
{
    /// <inheritdoc />
    public partial class updateRelationship2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Supervisor_Companny_CompannyId",
                table: "Supervisor");

            migrationBuilder.DropIndex(
                name: "IX_Supervisor_CompannyId",
                table: "Supervisor");

            migrationBuilder.DropColumn(
                name: "CompannyId",
                table: "Supervisor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompannyId",
                table: "Supervisor",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Supervisor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CompannyId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Supervisor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CompannyId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Supervisor_CompannyId",
                table: "Supervisor",
                column: "CompannyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Supervisor_Companny_CompannyId",
                table: "Supervisor",
                column: "CompannyId",
                principalTable: "Companny",
                principalColumn: "Id");
        }
    }
}
