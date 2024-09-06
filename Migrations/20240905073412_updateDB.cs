using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DKSKOfficial.Migrations
{
    /// <inheritdoc />
    public partial class updateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companny2Manager");

            migrationBuilder.DropTable(
                name: "Companny2Property");

            migrationBuilder.DropTable(
                name: "Companny2Supervisor");

            migrationBuilder.DropTable(
                name: "Manager2Property");

            migrationBuilder.DropTable(
                name: "Manager2Supervisor");

            migrationBuilder.DropTable(
                name: "Supervisor2Property");

            migrationBuilder.DropTable(
                name: "Manager");

            migrationBuilder.DropColumn(
                name: "CellPhone",
                table: "Supervisor");

            migrationBuilder.DropColumn(
                name: "CellPhone",
                table: "Companny");

            migrationBuilder.RenameColumn(
                name: "SpecialNote",
                table: "Supervisor",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "Ownner",
                table: "Companny",
                newName: "Phone");

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Supervisor",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ManagerEmail",
                table: "Properties",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ManagerName",
                table: "Properties",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ManagerPhone",
                table: "Properties",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SupervisorId",
                table: "Properties",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Companny",
                keyColumn: "Id",
                keyValue: 1,
                column: "Phone",
                value: "123-456-7890");

            migrationBuilder.UpdateData(
                table: "Companny",
                keyColumn: "Id",
                keyValue: 2,
                column: "Phone",
                value: "987-654-3210");

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ManagerEmail", "ManagerName", "ManagerPhone", "SupervisorId" },
                values: new object[] { "john@email.com", "John", "1234123", 1 });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ManagerEmail", "ManagerName", "ManagerPhone", "SupervisorId" },
                values: new object[] { "Doe@email.com", "Doe", "1234123", 1 });

            migrationBuilder.UpdateData(
                table: "Supervisor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CompanyId", "Phone" },
                values: new object[] { 1, "12345543" });

            migrationBuilder.UpdateData(
                table: "Supervisor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CompanyId", "Phone" },
                values: new object[] { 1, "12345543" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Supervisor");

            migrationBuilder.DropColumn(
                name: "ManagerEmail",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "ManagerName",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "ManagerPhone",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "SupervisorId",
                table: "Properties");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Supervisor",
                newName: "SpecialNote");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Companny",
                newName: "Ownner");

            migrationBuilder.AddColumn<string>(
                name: "CellPhone",
                table: "Supervisor",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CellPhone",
                table: "Companny",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Companny2Property",
                columns: table => new
                {
                    CompannyId = table.Column<int>(type: "INTEGER", nullable: false),
                    PropertiesId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companny2Property", x => new { x.CompannyId, x.PropertiesId });
                    table.ForeignKey(
                        name: "FK_Companny2Property_Companny_CompannyId",
                        column: x => x.CompannyId,
                        principalTable: "Companny",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Companny2Property_Properties_PropertiesId",
                        column: x => x.PropertiesId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Companny2Supervisor",
                columns: table => new
                {
                    CompannyId = table.Column<int>(type: "INTEGER", nullable: false),
                    SupervisorId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companny2Supervisor", x => new { x.CompannyId, x.SupervisorId });
                    table.ForeignKey(
                        name: "FK_Companny2Supervisor_Companny_CompannyId",
                        column: x => x.CompannyId,
                        principalTable: "Companny",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Companny2Supervisor_Supervisor_SupervisorId",
                        column: x => x.SupervisorId,
                        principalTable: "Supervisor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Manager",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CellPhone = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    SpecialNote = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manager", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Supervisor2Property",
                columns: table => new
                {
                    SupervisorId = table.Column<int>(type: "INTEGER", nullable: false),
                    PropertiesId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supervisor2Property", x => new { x.SupervisorId, x.PropertiesId });
                    table.ForeignKey(
                        name: "FK_Supervisor2Property_Properties_PropertiesId",
                        column: x => x.PropertiesId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Supervisor2Property_Supervisor_SupervisorId",
                        column: x => x.SupervisorId,
                        principalTable: "Supervisor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Companny2Manager",
                columns: table => new
                {
                    CompannyId = table.Column<int>(type: "INTEGER", nullable: false),
                    ManagerId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companny2Manager", x => new { x.CompannyId, x.ManagerId });
                    table.ForeignKey(
                        name: "FK_Companny2Manager_Companny_CompannyId",
                        column: x => x.CompannyId,
                        principalTable: "Companny",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Companny2Manager_Manager_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "Manager",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Manager2Property",
                columns: table => new
                {
                    ManagerId = table.Column<int>(type: "INTEGER", nullable: false),
                    PropertiesId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manager2Property", x => new { x.ManagerId, x.PropertiesId });
                    table.ForeignKey(
                        name: "FK_Manager2Property_Manager_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "Manager",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Manager2Property_Properties_PropertiesId",
                        column: x => x.PropertiesId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Manager2Supervisor",
                columns: table => new
                {
                    ManagerId = table.Column<int>(type: "INTEGER", nullable: false),
                    SupervisorId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manager2Supervisor", x => new { x.ManagerId, x.SupervisorId });
                    table.ForeignKey(
                        name: "FK_Manager2Supervisor_Manager_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "Manager",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Manager2Supervisor_Supervisor_SupervisorId",
                        column: x => x.SupervisorId,
                        principalTable: "Supervisor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Companny",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CellPhone", "Ownner" },
                values: new object[] { "123-456-7890", "Owner A" });

            migrationBuilder.UpdateData(
                table: "Companny",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CellPhone", "Ownner" },
                values: new object[] { "987-654-3210", "Owner B" });

            migrationBuilder.InsertData(
                table: "Companny2Property",
                columns: new[] { "CompannyId", "PropertiesId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Supervisor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CellPhone", "SpecialNote" },
                values: new object[] { "12345543", "" });

            migrationBuilder.UpdateData(
                table: "Supervisor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CellPhone", "SpecialNote" },
                values: new object[] { "12345543", "" });

            migrationBuilder.CreateIndex(
                name: "IX_Companny2Manager_ManagerId",
                table: "Companny2Manager",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Companny2Property_PropertiesId",
                table: "Companny2Property",
                column: "PropertiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Companny2Supervisor_SupervisorId",
                table: "Companny2Supervisor",
                column: "SupervisorId");

            migrationBuilder.CreateIndex(
                name: "IX_Manager2Property_PropertiesId",
                table: "Manager2Property",
                column: "PropertiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Manager2Supervisor_SupervisorId",
                table: "Manager2Supervisor",
                column: "SupervisorId");

            migrationBuilder.CreateIndex(
                name: "IX_Supervisor2Property_PropertiesId",
                table: "Supervisor2Property",
                column: "PropertiesId");
        }
    }
}
