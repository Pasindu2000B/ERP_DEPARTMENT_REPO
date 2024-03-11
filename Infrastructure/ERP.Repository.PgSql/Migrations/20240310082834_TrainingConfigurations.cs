using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class TrainingConfigurations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1001,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "4344 Louie Village, New Destiney, Iran", "753-953-5383", "Chief", "Verla" });

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1002,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "317 Colton Lake, Lake Isom, Zimbabwe", "722-519-0542", "Legacy", "Timmy" });

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1003,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "2513 Marilie Wells, West Brandt, Philippines", "1-617-276-6267 x31854", "Direct", "German" });

            migrationBuilder.InsertData(
                table: "JobPosts",
                columns: new[] { "Id", "Category", "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[,]
                {
                    { 101, "computer Engineering", "GreenholtRohanandStoltenberg.Rempel@gmail.com", "Greenholt, Rohan and Stoltenberg", "data engineer", "http://iliana.com" },
                    { 102, "computer Engineering", "PaucekSpencerandProsacco_Botsford37@gmail.com", "Paucek, Spencer and Prosacco", "quality assurance Enginner", "https://brant.info" },
                    { 103, "computer Engineering", "RomagueraEffertzandTorp_Hoeger20@gmail.com", "Romaguera, Effertz and Torp", "cyber security engineer", "http://lyric.info" }
                });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3001,
                columns: new[] { "LabEquipmentName", "condition" },
                values: new object[] { "Bernice", "medium" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3002,
                columns: new[] { "LabEquipmentName", "condition" },
                values: new object[] { "Joannie", "medium" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3003,
                column: "LabEquipmentName",
                value: "Hudson");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Jordy72@gmail.com", "Jordy", "Lesch", "EG/2023/1990" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Idella.Runolfsson42@hotmail.com", "Idella", "Runolfsson", "EG/2020/7605" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Ivah.Schinner62@gmail.com", "Ivah", "Schinner", "EG/2022/6853" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1001,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "293 Kathleen Neck, Idaburgh, Uruguay", "1-971-889-4340 x8969", "Dynamic", "Audreanne" });

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1002,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "2117 Minerva Flat, New Jarrettside, Finland", "(610) 337-4600", "District", "Dayne" });

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1003,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "07474 Jace Pass, Port Ludwigstad, Thailand", "263-437-1617 x2206", "Forward", "Brent" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3001,
                columns: new[] { "LabEquipmentName", "condition" },
                values: new object[] { "Ralph", "bad" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3002,
                columns: new[] { "LabEquipmentName", "condition" },
                values: new object[] { "Carlos", "bad" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3003,
                column: "LabEquipmentName",
                value: "Ursula");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Yoshiko.Weimann@gmail.com", "Yoshiko", "Weimann", "EG/2022/4649" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Ezekiel_Littel@gmail.com", "Ezekiel", "Littel", "EG/2023/1836" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Aimee_Stark41@gmail.com", "Aimee", "Stark", "EG/2020/1651" });
        }
    }
}
