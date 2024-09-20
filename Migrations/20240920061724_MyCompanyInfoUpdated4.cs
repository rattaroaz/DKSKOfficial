using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DKSKOfficial.Migrations
{
    /// <inheritdoc />
    public partial class MyCompanyInfoUpdated4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Invoice",
                newName: "WorkDate");

            migrationBuilder.RenameColumn(
                name: "PaymentHistory",
                table: "Invoice",
                newName: "CheckNumber2");

            migrationBuilder.RenameColumn(
                name: "Paid",
                table: "Invoice",
                newName: "AmountPaid2");

            migrationBuilder.RenameColumn(
                name: "DatePaid",
                table: "Invoice",
                newName: "DatePaid2");

            migrationBuilder.RenameColumn(
                name: "CheckNumber",
                table: "Invoice",
                newName: "CheckNumber1");

            migrationBuilder.RenameColumn(
                name: "AnticipatedEndDate",
                table: "Invoice",
                newName: "DatePaid1");

            migrationBuilder.RenameColumn(
                name: "AmountPaid",
                table: "Invoice",
                newName: "AmountPaid1");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$SAoMS6DY5MpD8QCem3f56.VWoSggoOKAUbaE/ln62Ay3ufAyiszga");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$Vr40mLhUsu8XrU0H/W2kWOkNLMHmHGAuap0UmY0v4Enn35kTngy3q");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WorkDate",
                table: "Invoice",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "DatePaid2",
                table: "Invoice",
                newName: "DatePaid");

            migrationBuilder.RenameColumn(
                name: "DatePaid1",
                table: "Invoice",
                newName: "AnticipatedEndDate");

            migrationBuilder.RenameColumn(
                name: "CheckNumber2",
                table: "Invoice",
                newName: "PaymentHistory");

            migrationBuilder.RenameColumn(
                name: "CheckNumber1",
                table: "Invoice",
                newName: "CheckNumber");

            migrationBuilder.RenameColumn(
                name: "AmountPaid2",
                table: "Invoice",
                newName: "Paid");

            migrationBuilder.RenameColumn(
                name: "AmountPaid1",
                table: "Invoice",
                newName: "AmountPaid");

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
    }
}
