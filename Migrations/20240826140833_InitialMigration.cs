using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DKSKOfficial.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companny",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Ownner = table.Column<string>(type: "TEXT", nullable: false),
                    CellPhone = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    Zip = table.Column<string>(type: "TEXT", nullable: false),
                    SpecialNote = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companny", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contractor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    LicenseNumber = table.Column<string>(type: "TEXT", nullable: false),
                    SocailSecurityNumber = table.Column<string>(type: "TEXT", nullable: false),
                    ContractorID = table.Column<string>(type: "TEXT", nullable: false),
                    PayrollPercent = table.Column<string>(type: "TEXT", nullable: false),
                    CellPhone = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    Zip = table.Column<string>(type: "TEXT", nullable: false),
                    SpecialNote = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contractor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Invoice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TodaysDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AnticipatedEndDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CompanyName = table.Column<string>(type: "TEXT", nullable: false),
                    PropertyAddress = table.Column<string>(type: "TEXT", nullable: false),
                    Unit = table.Column<string>(type: "TEXT", nullable: false),
                    GateCode = table.Column<string>(type: "TEXT", nullable: false),
                    LockBox = table.Column<string>(type: "TEXT", nullable: false),
                    Size = table.Column<string>(type: "TEXT", nullable: false),
                    WorkOrder = table.Column<string>(type: "TEXT", nullable: false),
                    JobDescriptionChoice = table.Column<string>(type: "TEXT", nullable: false),
                    ContractorName = table.Column<string>(type: "TEXT", nullable: false),
                    AmountCost = table.Column<string>(type: "TEXT", nullable: false),
                    Paid = table.Column<string>(type: "TEXT", nullable: false),
                    AmountPaid = table.Column<string>(type: "TEXT", nullable: false),
                    CheckNumber = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobDiscription",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    description = table.Column<string>(type: "TEXT", nullable: false),
                    price = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobDiscription", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manager",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    CellPhone = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    SpecialNote = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manager", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MyCompanyInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    CellPhone = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    Zip = table.Column<string>(type: "TEXT", nullable: false),
                    State = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyCompanyInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    Zip = table.Column<string>(type: "TEXT", nullable: false),
                    GateCode = table.Column<string>(type: "TEXT", nullable: false),
                    LockBox = table.Column<string>(type: "TEXT", nullable: false),
                    SpecialNote = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Supervisor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    CellPhone = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    SpecialNote = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supervisor", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "Companny",
                columns: new[] { "Id", "Address", "CellPhone", "City", "Email", "Name", "Ownner", "SpecialNote", "Zip" },
                values: new object[,]
                {
                    { 1, "123 A St.", "123-456-7890", "CityA", "ownerA@example.com", "Company A", "Owner A", "Note A", "11111" },
                    { 2, "456 B St.", "987-654-3210", "CityB", "ownerB@example.com", "Company B", "Owner B", "Note B", "22222" }
                });

            migrationBuilder.InsertData(
                table: "JobDiscription",
                columns: new[] { "Id", "description", "price" },
                values: new object[,]
                {
                    { 1, "interior walls, closet inside, ceiling", 100 },
                    { 2, "walls, closet inside", 100 },
                    { 3, "base boards", 100 },
                    { 4, "kitchen cabinet - inside and outside", 100 },
                    { 5, "all enamel surfaces including doors, door frames, kitchen, bathrooms", 100 },
                    { 6, "2 tone colors: navaho white, swiss coffee", 100 },
                    { 7, "2 tone colors: BM1520(Hushed Hue), swiss coffee", 100 },
                    { 8, "Balcony floor", 100 },
                    { 9, "Cover flooring and plastic", 100 },
                    { 10, "Ceiling", 100 }
                });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "Id", "Address", "City", "GateCode", "LockBox", "Name", "SpecialNote", "Zip" },
                values: new object[,]
                {
                    { 1, "789 C St.", "CityC", "GATE123", "LOCK123", "Property 1", "Property Note 1", "33333" },
                    { 2, "123 D St.", "CityD", "GATE456", "LOCK456", "Property 2", "Property Note 2", "44444" }
                });

            migrationBuilder.InsertData(
                table: "Companny2Property",
                columns: new[] { "CompannyId", "PropertiesId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Companny2Property_PropertiesId",
                table: "Companny2Property",
                column: "PropertiesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companny2Property");

            migrationBuilder.DropTable(
                name: "Contractor");

            migrationBuilder.DropTable(
                name: "Invoice");

            migrationBuilder.DropTable(
                name: "JobDiscription");

            migrationBuilder.DropTable(
                name: "Manager");

            migrationBuilder.DropTable(
                name: "MyCompanyInfo");

            migrationBuilder.DropTable(
                name: "Supervisor");

            migrationBuilder.DropTable(
                name: "Companny");

            migrationBuilder.DropTable(
                name: "Properties");
        }
    }
}
