using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class nnn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LabEquipments_LabSpaces_LabSpaceId",
                table: "LabEquipments");

            migrationBuilder.DropIndex(
                name: "IX_LabEquipments_LabSpaceId",
                table: "LabEquipments");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 1001,
                columns: new[] { "LabEquipmentName", "condition" },
                values: new object[] { "Mylene", "bad" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 1002,
                columns: new[] { "LabEquipmentName", "condition" },
                values: new object[] { "Roderick", "medium" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 1003,
                column: "LabEquipmentName",
                value: "Lorena");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Scot39@gmail.com", "Scot", "Ruecker", "EG/2022/8808" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Kylee43@yahoo.com", "Kylee", "Hoppe", "EG/2021/1374" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Pansy.Heaney1@yahoo.com", "Pansy", "Heaney", "EG/2020/7085" });

            migrationBuilder.CreateIndex(
                name: "IX_LabEquipments_LabSpaceId",
                table: "LabEquipments",
                column: "LabSpaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_LabEquipments_LabSpaces_LabSpaceId",
                table: "LabEquipments",
                column: "LabSpaceId",
                principalTable: "LabSpaces",
                principalColumn: "LabSpaceId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
