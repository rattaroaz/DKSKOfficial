using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DKSKOfficial.Migrations
{
    /// <inheritdoc />
    public partial class junktiontableAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateIndex(
                name: "IX_Companny2Manager_ManagerId",
                table: "Companny2Manager",
                column: "ManagerId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companny2Manager");

            migrationBuilder.DropTable(
                name: "Companny2Supervisor");

            migrationBuilder.DropTable(
                name: "Manager2Property");

            migrationBuilder.DropTable(
                name: "Manager2Supervisor");

            migrationBuilder.DropTable(
                name: "Supervisor2Property");
        }
    }
}
