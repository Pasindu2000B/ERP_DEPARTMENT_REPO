using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class labEquipment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EquipmentCondition",
                columns: table => new
                {
                    ConditionId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ConditionName = table.Column<string>(type: "text", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentCondition", x => x.ConditionId);
                });

            migrationBuilder.CreateTable(
                name: "LabBuilding",
                columns: table => new
                {
                    LabBuildingId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LabBuildingName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabBuilding", x => x.LabBuildingId);
                });

            migrationBuilder.CreateTable(
                name: "LabEquipments",
                columns: table => new
                {
                    LabEquipmentID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LabEquipmentName = table.Column<string>(type: "text", nullable: false),
                    LabBuildingId = table.Column<int>(type: "integer", nullable: false),
                    ConditionId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabEquipments", x => x.LabEquipmentID);
                    table.ForeignKey(
                        name: "FK_LabEquipments_EquipmentCondition_ConditionId",
                        column: x => x.ConditionId,
                        principalTable: "EquipmentCondition",
                        principalColumn: "ConditionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LabEquipments_LabBuilding_LabBuildingId",
                        column: x => x.LabBuildingId,
                        principalTable: "LabBuilding",
                        principalColumn: "LabBuildingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Daphnee.Ledner@yahoo.com", "Daphnee", "Ledner", "EG/2023/2890" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Chloe.Cummerata@gmail.com", "Chloe", "Cummerata", "EG/2023/5289" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Vella.Monahan31@hotmail.com", "Vella", "Monahan", "EG/2020/2330" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1004,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Glen84@yahoo.com", "Glen", "Schroeder", "EG/2020/4305" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1005,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Brant96@gmail.com", "Brant", "Dickinson", "EG/2023/8663" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1006,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Mallie_Macejkovic@hotmail.com", "Mallie", "Macejkovic", "EG/2023/4813" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1007,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Narciso85@gmail.com", "Narciso", "Torphy", "EG/2022/8919" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1008,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Waino_Turner80@hotmail.com", "Waino", "Turner", "EG/2022/6984" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1009,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Susanna.Balistreri28@gmail.com", "Susanna", "Balistreri", "EG/2022/3352" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1010,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Lenora31@yahoo.com", "Lenora", "Ward", "EG/2022/8365" });

            migrationBuilder.CreateIndex(
                name: "IX_LabEquipments_ConditionId",
                table: "LabEquipments",
                column: "ConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_LabEquipments_LabBuildingId",
                table: "LabEquipments",
                column: "LabBuildingId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LabEquipments");

            migrationBuilder.DropTable(
                name: "EquipmentCondition");

            migrationBuilder.DropTable(
                name: "LabBuilding");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Jacynthe_Conn44@gmail.com", "Jacynthe", "Conn", "EG/2022/7443" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Garry86@gmail.com", "Garry", "McGlynn", "EG/2022/3197" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Patience.Gutmann@yahoo.com", "Patience", "Gutmann", "EG/2023/4256" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1004,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Una_Schoen@gmail.com", "Una", "Schoen", "EG/2021/2453" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1005,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Darryl77@yahoo.com", "Darryl", "Hudson", "EG/2023/7986" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1006,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Kristin74@gmail.com", "Kristin", "Labadie", "EG/2021/9773" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1007,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Ben_Wiza@gmail.com", "Ben", "Wiza", "EG/2022/5975" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1008,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Joesph.Christiansen73@gmail.com", "Joesph", "Christiansen", "EG/2021/8228" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1009,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Aleen88@yahoo.com", "Aleen", "West", "EG/2020/5301" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1010,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Kade_Marks@hotmail.com", "Kade", "Marks", "EG/2022/9395" });
        }
    }
}
