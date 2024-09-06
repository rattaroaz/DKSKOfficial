using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DKSKOfficial.Migrations
{
    /// <inheritdoc />
    public partial class updateRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateIndex(
                name: "IX_Supervisor_CompanyId",
                table: "Supervisor",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_SupervisorId",
                table: "Properties",
                column: "SupervisorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Supervisor_SupervisorId",
                table: "Properties",
                column: "SupervisorId",
                principalTable: "Supervisor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Supervisor_Companny_CompannyId",
                table: "Supervisor",
                column: "CompannyId",
                principalTable: "Companny",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Supervisor_Companny_CompanyId",
                table: "Supervisor",
                column: "CompanyId",
                principalTable: "Companny",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Supervisor_SupervisorId",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_Supervisor_Companny_CompannyId",
                table: "Supervisor");

            migrationBuilder.DropForeignKey(
                name: "FK_Supervisor_Companny_CompanyId",
                table: "Supervisor");

            migrationBuilder.DropIndex(
                name: "IX_Supervisor_CompannyId",
                table: "Supervisor");

            migrationBuilder.DropIndex(
                name: "IX_Supervisor_CompanyId",
                table: "Supervisor");

            migrationBuilder.DropIndex(
                name: "IX_Properties_SupervisorId",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "CompannyId",
                table: "Supervisor");
        }
    }
}
