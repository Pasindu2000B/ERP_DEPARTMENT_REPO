using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class latestI : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LabEquipments_EquipmentConditions_ConditionId",
                table: "LabEquipments");

            migrationBuilder.DropForeignKey(
                name: "FK_LabEquipments_LabBuilding_LabBuildingId",
                table: "LabEquipments");

            migrationBuilder.DropIndex(
                name: "IX_LabEquipments_ConditionId",
                table: "LabEquipments");

            migrationBuilder.DropIndex(
                name: "IX_LabEquipments_LabBuildingId",
                table: "LabEquipments");

            migrationBuilder.DeleteData(
                table: "EquipmentConditions",
                keyColumn: "ConditionId",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "EquipmentConditions",
                keyColumn: "ConditionId",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "EquipmentConditions",
                keyColumn: "ConditionId",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "LabBuilding",
                keyColumn: "LabBuildingId",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "LabBuilding",
                keyColumn: "LabBuildingId",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "LabBuilding",
                keyColumn: "LabBuildingId",
                keyValue: 1002);

            migrationBuilder.DropColumn(
                name: "ConditionId",
                table: "LabEquipments");

            migrationBuilder.DropColumn(
                name: "LabBuildingId",
                table: "LabEquipments");

            migrationBuilder.AddColumn<string>(
                name: "condition",
                table: "LabEquipments",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "LabEquipments",
                columns: new[] { "LabEquipmentID", "LabEquipmentName", "condition" },
                values: new object[,]
                {
                    { 1001, "Vella", "Abbott" },
                    { 1002, "Stefanie", "Mitchell" },
                    { 1003, "Deshawn", "Little" }
                });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Willow_Jakubowski28@yahoo.com", "Willow", "Jakubowski", "EG/2023/7498" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Hilbert.Jacobson60@hotmail.com", "Hilbert", "Jacobson", "EG/2021/5493" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Raquel91@gmail.com", "Raquel", "Marks", "EG/2020/5860" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 1003);

            migrationBuilder.DropColumn(
                name: "condition",
                table: "LabEquipments");

            migrationBuilder.AddColumn<int>(
                name: "ConditionId",
                table: "LabEquipments",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LabBuildingId",
                table: "LabEquipments",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "EquipmentConditions",
                columns: new[] { "ConditionId", "Comment", "ConditionName" },
                values: new object[,]
                {
                    { 1001, "Blanditiis explicabo similique nostrum qui et.", "Refurbished" },
                    { 1002, "Odio animi voluptas corporis commodi neque.", "Good Condition" },
                    { 1003, "Tempore quo atque pariatur id non commodi consectetur omnis.", "Refurbished" }
                });

            migrationBuilder.InsertData(
                table: "LabBuilding",
                columns: new[] { "LabBuildingId", "LabBuildingName" },
                values: new object[,]
                {
                    { 1000, "Electronic Lab" },
                    { 1001, "High Voltage Lab" },
                    { 1002, "Signal and Measurement Lab" }
                });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Carley_Mann63@hotmail.com", "Carley", "Mann", "EG/2020/9942" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Rebeka_Huels61@hotmail.com", "Rebeka", "Huels", "EG/2021/2381" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Lia26@yahoo.com", "Lia", "Homenick", "EG/2023/6052" });

            migrationBuilder.CreateIndex(
                name: "IX_LabEquipments_ConditionId",
                table: "LabEquipments",
                column: "ConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_LabEquipments_LabBuildingId",
                table: "LabEquipments",
                column: "LabBuildingId");

            migrationBuilder.AddForeignKey(
                name: "FK_LabEquipments_EquipmentConditions_ConditionId",
                table: "LabEquipments",
                column: "ConditionId",
                principalTable: "EquipmentConditions",
                principalColumn: "ConditionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LabEquipments_LabBuilding_LabBuildingId",
                table: "LabEquipments",
                column: "LabBuildingId",
                principalTable: "LabBuilding",
                principalColumn: "LabBuildingId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
