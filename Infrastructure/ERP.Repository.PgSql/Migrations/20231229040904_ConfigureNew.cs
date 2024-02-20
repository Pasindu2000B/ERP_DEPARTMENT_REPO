using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class ConfigureNew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LabEquipments_EquipmentCondition_ConditionId",
                table: "LabEquipments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EquipmentCondition",
                table: "EquipmentCondition");

            migrationBuilder.RenameTable(
                name: "EquipmentCondition",
                newName: "EquipmentConditions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EquipmentConditions",
                table: "EquipmentConditions",
                column: "ConditionId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_LabEquipments_EquipmentConditions_ConditionId",
                table: "LabEquipments",
                column: "ConditionId",
                principalTable: "EquipmentConditions",
                principalColumn: "ConditionId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LabEquipments_EquipmentConditions_ConditionId",
                table: "LabEquipments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EquipmentConditions",
                table: "EquipmentConditions");

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

            migrationBuilder.RenameTable(
                name: "EquipmentConditions",
                newName: "EquipmentCondition");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EquipmentCondition",
                table: "EquipmentCondition",
                column: "ConditionId");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Isaac.Wolff59@gmail.com", "Isaac", "Wolff", "EG/2022/8249" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Orie_Pagac97@hotmail.com", "Orie", "Pagac", "EG/2021/5045" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Roxane62@hotmail.com", "Roxane", "Howell", "EG/2023/9814" });

            migrationBuilder.AddForeignKey(
                name: "FK_LabEquipments_EquipmentCondition_ConditionId",
                table: "LabEquipments",
                column: "ConditionId",
                principalTable: "EquipmentCondition",
                principalColumn: "ConditionId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
