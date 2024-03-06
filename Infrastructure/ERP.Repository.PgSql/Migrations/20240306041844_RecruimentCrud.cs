using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class RecruimentCrud : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecruimentApplication_RecruimentJobPost_RecruimentJobPostId",
                table: "RecruimentApplication");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RecruimentJobPost",
                table: "RecruimentJobPost");

            migrationBuilder.RenameTable(
                name: "RecruimentJobPost",
                newName: "RecruimentJobs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RecruimentJobs",
                table: "RecruimentJobs",
                column: "JobId");

            migrationBuilder.CreateTable(
                name: "WorkingTask",
                columns: table => new
                {
                    WorkingTaskId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TeacherId = table.Column<int>(type: "integer", nullable: false),
                    Decription = table.Column<string>(type: "text", nullable: true),
                    Assign = table.Column<bool>(type: "boolean", nullable: false),
                    TimeAllocated = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkingTask", x => x.WorkingTaskId);
                    table.ForeignKey(
                        name: "FK_WorkingTask_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1001,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "0705 Milton Groves, Blockstad, Kiribati", "878.426.6092", "International", "Malachi" });

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1002,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "891 Watsica Glens, East Jermey, Paraguay", "(496) 271-0884 x763", "Senior", "Candice" });

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1003,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "8396 O'Hara Mews, Ansleyfurt, Belgium", "(237) 649-0905 x60013", "Investor", "Ricky" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3001,
                columns: new[] { "LabEquipmentName", "condition" },
                values: new object[] { "Valentine", "medium" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3002,
                column: "LabEquipmentName",
                value: "Aniya");

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3003,
                columns: new[] { "LabEquipmentName", "condition" },
                values: new object[] { "Kadin", "bad" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Judge_Blick31@hotmail.com", "Judge", "Blick", "EG/2020/3667" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Tad5@gmail.com", "Tad", "Wiegand", "EG/2022/2621" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Ashlynn7@hotmail.com", "Ashlynn", "MacGyver", "EG/2023/9312" });

            migrationBuilder.CreateIndex(
                name: "IX_WorkingTask_TeacherId",
                table: "WorkingTask",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_RecruimentApplication_RecruimentJobs_RecruimentJobPostId",
                table: "RecruimentApplication",
                column: "RecruimentJobPostId",
                principalTable: "RecruimentJobs",
                principalColumn: "JobId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecruimentApplication_RecruimentJobs_RecruimentJobPostId",
                table: "RecruimentApplication");

            migrationBuilder.DropTable(
                name: "WorkingTask");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RecruimentJobs",
                table: "RecruimentJobs");

            migrationBuilder.RenameTable(
                name: "RecruimentJobs",
                newName: "RecruimentJobPost");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RecruimentJobPost",
                table: "RecruimentJobPost",
                column: "JobId");

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1001,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "384 Ryley Run, O'Keefeland, Turkmenistan", "(331) 404-8857", "District", "Reva" });

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1002,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "5915 Nona Gardens, Port Earnestinestad, Lao People's Democratic Republic", "567-519-2792 x4094", "Product", "Jana" });

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1003,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "11007 Oberbrunner Keys, New Tanyafurt, Brazil", "616-769-4138 x60764", "Central", "Wilber" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3001,
                columns: new[] { "LabEquipmentName", "condition" },
                values: new object[] { "Morris", "bad" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3002,
                column: "LabEquipmentName",
                value: "Armand");

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3003,
                columns: new[] { "LabEquipmentName", "condition" },
                values: new object[] { "Aliya", "medium" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Ignatius34@gmail.com", "Ignatius", "Vandervort", "EG/2020/7338" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Mackenzie_Brakus27@gmail.com", "Mackenzie", "Brakus", "EG/2021/8417" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Vallie64@gmail.com", "Vallie", "Sauer", "EG/2021/9682" });

            migrationBuilder.AddForeignKey(
                name: "FK_RecruimentApplication_RecruimentJobPost_RecruimentJobPostId",
                table: "RecruimentApplication",
                column: "RecruimentJobPostId",
                principalTable: "RecruimentJobPost",
                principalColumn: "JobId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
