using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class Newest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LabSpaceId",
                table: "LabEquipments",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 1001,
                columns: new[] { "LabEquipmentName", "LabSpaceId", "condition" },
                values: new object[] { "Delpha", 0, "bad" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 1002,
                columns: new[] { "LabEquipmentName", "LabSpaceId" },
                values: new object[] { "Tate", 0 });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 1003,
                columns: new[] { "LabEquipmentName", "LabSpaceId" },
                values: new object[] { "Else", 0 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Henri_Schimmel25@gmail.com", "Henri", "Schimmel", "EG/2022/5924" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Isaias_Runte51@gmail.com", "Isaias", "Runte", "EG/2021/8177" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Vella_Paucek75@hotmail.com", "Vella", "Paucek", "EG/2023/1416" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LabEquipments_LabSpaces_LabSpaceId",
                table: "LabEquipments");

            migrationBuilder.DropIndex(
                name: "IX_LabEquipments_LabSpaceId",
                table: "LabEquipments");

            migrationBuilder.DropColumn(
                name: "LabSpaceId",
                table: "LabEquipments");

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 1001,
                columns: new[] { "LabEquipmentName", "condition" },
                values: new object[] { "Amalia", "medium" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 1002,
                column: "LabEquipmentName",
                value: "Alva");

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 1003,
                column: "LabEquipmentName",
                value: "Lester");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Talia51@gmail.com", "Talia", "Heller", "EG/2020/5483" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Carroll73@yahoo.com", "Carroll", "Bailey", "EG/2021/1348" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Emile49@yahoo.com", "Emile", "Anderson", "EG/2020/8278" });
        }
    }
}
