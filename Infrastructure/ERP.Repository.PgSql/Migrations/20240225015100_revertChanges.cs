using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class revertChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LabEquipments",
                columns: table => new
                {
                    LabEquipmentID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LabEquipmentName = table.Column<string>(type: "text", nullable: false),
                    condition = table.Column<string>(type: "text", nullable: false),
                    Avaialability = table.Column<bool>(type: "boolean", nullable: false),
                    LabSpaceId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabEquipments", x => x.LabEquipmentID);
                });

            migrationBuilder.CreateTable(
                name: "LabSpaces",
                columns: table => new
                {
                    LabSpaceId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LabSpaceName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabSpaces", x => x.LabSpaceId);
                });

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1001,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "0477 Lorenz Springs, South Daphne, Wallis and Futuna", "(649) 564-2938 x8136", "Internal", "Lilla" });

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1002,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "889 Green Rest, Satterfieldchester, Tokelau", "1-722-202-2162 x797", "Global", "Jessyca" });

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1003,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "92823 Iliana Ramp, New Brianville, Niue", "486.276.8037", "Future", "Ericka" });

            migrationBuilder.InsertData(
                table: "LabEquipments",
                columns: new[] { "LabEquipmentID", "Avaialability", "LabEquipmentName", "LabSpaceId", "condition" },
                values: new object[,]
                {
                    { 3001, false, "Santino", 0, "medium" },
                    { 3002, false, "Marion", 0, "medium" },
                    { 3003, false, "Alexandre", 0, "medium" }
                });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Randi8@hotmail.com", "Randi", "Metz", "EG/2023/4022" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Tyshawn_Hyatt50@gmail.com", "Tyshawn", "Hyatt", "EG/2021/5767" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Astrid_Langosh@yahoo.com", "Astrid", "Langosh", "EG/2023/5684" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LabEquipments");

            migrationBuilder.DropTable(
                name: "LabSpaces");

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1001,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "462 Abernathy Cliff, Delphinemouth, Nigeria", "813-451-5384 x88377", "International", "Armand" });

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1002,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "8879 Cletus Branch, Botsfordton, Georgia", "821-886-2348", "Forward", "Florian" });

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1003,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "016 O'Connell Port, West Ben, Timor-Leste", "1-643-726-2811 x67552", "District", "Ron" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Beverly39@gmail.com", "Beverly", "White", "EG/2020/2485" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Aida_Hickle55@gmail.com", "Aida", "Hickle", "EG/2022/1685" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Ashly18@gmail.com", "Ashly", "Jacobi", "EG/2021/6090" });
        }
    }
}
