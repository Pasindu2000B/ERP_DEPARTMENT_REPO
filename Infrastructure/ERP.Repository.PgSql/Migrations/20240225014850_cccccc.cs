using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class cccccc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LabEquipments");

            migrationBuilder.DropTable(
                name: "LabSpaces");

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1001,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateName" },
                values: new object[] { "462 Abernathy Cliff, Delphinemouth, Nigeria", "813-451-5384 x88377", "Armand" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LabEquipments",
                columns: table => new
                {
                    LabEquipmentID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Avaialability = table.Column<bool>(type: "boolean", nullable: false),
                    LabEquipmentName = table.Column<string>(type: "text", nullable: false),
                    LabSpaceId = table.Column<int>(type: "integer", nullable: false),
                    condition = table.Column<string>(type: "text", nullable: false)
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
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateName" },
                values: new object[] { "939 Lois Passage, East Mariela, Tokelau", "(849) 428-9821 x8843", "Victor" });

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1002,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "511 Lempi Expressway, Port Royside, Saint Martin", "1-581-425-3051 x12576", "Corporate", "Sven" });

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1003,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "7983 Frederik Common, Fayside, Cook Islands", "353.437.8807 x53382", "Dynamic", "Albin" });

            migrationBuilder.InsertData(
                table: "LabEquipments",
                columns: new[] { "LabEquipmentID", "Avaialability", "LabEquipmentName", "LabSpaceId", "condition" },
                values: new object[,]
                {
                    { 1001, false, "Eleonore", 0, "medium" },
                    { 1002, false, "Emely", 0, "bad" },
                    { 1003, false, "Jett", 0, "medium" }
                });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Savannah.Torphy67@hotmail.com", "Savannah", "Torphy", "EG/2022/4739" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Willy.Herman5@yahoo.com", "Willy", "Herman", "EG/2020/7589" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Trever21@hotmail.com", "Trever", "Cremin", "EG/2022/2009" });
        }
    }
}
