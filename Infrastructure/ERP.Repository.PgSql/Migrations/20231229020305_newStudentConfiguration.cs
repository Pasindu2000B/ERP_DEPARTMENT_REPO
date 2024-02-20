using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class newStudentConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1010);

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Camila.Lesch@gmail.com", "Camila", "Lesch", "EG/2020/5939" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Linnie_Volkman@gmail.com", "Linnie", "Volkman", "EG/2022/3448" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Louisa_Daniel@gmail.com", "Louisa", "Daniel", "EG/2023/5891" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Address1", "Address2", "City", "DegreeId", "District", "DoB", "Email", "FirstName", "GPA", "LastName", "NationalID", "Phone", "PhoneNumber", "RegistrationNum" },
                values: new object[,]
                {
                    { 1004, "", "", "", null, "", new DateOnly(1, 1, 1), "Charlene_Trantow21@yahoo.com", "Charlene", 0.0, "Trantow", "", "", "", "EG/2020/2288" },
                    { 1005, "", "", "", null, "", new DateOnly(1, 1, 1), "Destinee24@gmail.com", "Destinee", 0.0, "Yost", "", "", "", "EG/2020/9552" },
                    { 1006, "", "", "", null, "", new DateOnly(1, 1, 1), "Janice.Balistreri59@yahoo.com", "Janice", 0.0, "Balistreri", "", "", "", "EG/2023/1794" },
                    { 1007, "", "", "", null, "", new DateOnly(1, 1, 1), "Burley26@hotmail.com", "Burley", 0.0, "Zieme", "", "", "", "EG/2023/9524" },
                    { 1008, "", "", "", null, "", new DateOnly(1, 1, 1), "Jannie54@yahoo.com", "Jannie", 0.0, "Hilpert", "", "", "", "EG/2021/3265" },
                    { 1009, "", "", "", null, "", new DateOnly(1, 1, 1), "Francesca35@gmail.com", "Francesca", 0.0, "Gleichner", "", "", "", "EG/2021/2028" },
                    { 1010, "", "", "", null, "", new DateOnly(1, 1, 1), "Marlee_Flatley@gmail.com", "Marlee", 0.0, "Flatley", "", "", "", "EG/2023/9800" }
                });
        }
    }
}
