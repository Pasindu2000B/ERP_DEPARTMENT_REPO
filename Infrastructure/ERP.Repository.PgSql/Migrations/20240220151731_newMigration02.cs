using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class newMigration02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LabSpaceIsFree",
                table: "LabSpaces");

            migrationBuilder.DropColumn(
                name: "maximumCapaciity",
                table: "LabSpaces");

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 1001,
                columns: new[] { "LabEquipmentName", "condition" },
                values: new object[] { "Daren", "bad" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 1002,
                columns: new[] { "LabEquipmentName", "condition" },
                values: new object[] { "Kiarra", "medium" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 1003,
                column: "LabEquipmentName",
                value: "Aisha");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Zula98@yahoo.com", "Zula", "Nitzsche", "EG/2021/8966" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Regan25@hotmail.com", "Regan", "Dickens", "EG/2022/3575" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Niko.DAmore@yahoo.com", "Niko", "D'Amore", "EG/2021/4775" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "LabSpaceIsFree",
                table: "LabSpaces",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "maximumCapaciity",
                table: "LabSpaces",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 1001,
                columns: new[] { "LabEquipmentName", "condition" },
                values: new object[] { "Alison", "medium" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 1002,
                columns: new[] { "LabEquipmentName", "condition" },
                values: new object[] { "Geovany", "bad" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 1003,
                column: "LabEquipmentName",
                value: "Dixie");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Alexzander_Dooley@hotmail.com", "Alexzander", "Dooley", "EG/2023/4048" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Alvera42@gmail.com", "Alvera", "Stroman", "EG/2023/8782" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Jarret15@gmail.com", "Jarret", "Stamm", "EG/2022/8242" });
        }
    }
}
