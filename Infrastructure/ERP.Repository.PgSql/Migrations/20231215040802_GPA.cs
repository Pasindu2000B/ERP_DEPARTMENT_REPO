using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class GPA : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "GPA",
                table: "Students",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "GPA", "LastName", "RegistrationNum" },
                values: new object[] { "Jacynthe_Conn44@gmail.com", "Jacynthe", 0.0, "Conn", "EG/2022/7443" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "GPA", "LastName", "RegistrationNum" },
                values: new object[] { "Garry86@gmail.com", "Garry", 0.0, "McGlynn", "EG/2022/3197" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "GPA", "LastName", "RegistrationNum" },
                values: new object[] { "Patience.Gutmann@yahoo.com", "Patience", 0.0, "Gutmann", "EG/2023/4256" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1004,
                columns: new[] { "Email", "FirstName", "GPA", "LastName", "RegistrationNum" },
                values: new object[] { "Una_Schoen@gmail.com", "Una", 0.0, "Schoen", "EG/2021/2453" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1005,
                columns: new[] { "Email", "FirstName", "GPA", "LastName", "RegistrationNum" },
                values: new object[] { "Darryl77@yahoo.com", "Darryl", 0.0, "Hudson", "EG/2023/7986" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1006,
                columns: new[] { "Email", "FirstName", "GPA", "LastName", "RegistrationNum" },
                values: new object[] { "Kristin74@gmail.com", "Kristin", 0.0, "Labadie", "EG/2021/9773" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1007,
                columns: new[] { "Email", "FirstName", "GPA", "LastName", "RegistrationNum" },
                values: new object[] { "Ben_Wiza@gmail.com", "Ben", 0.0, "Wiza", "EG/2022/5975" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1008,
                columns: new[] { "Email", "FirstName", "GPA", "LastName", "RegistrationNum" },
                values: new object[] { "Joesph.Christiansen73@gmail.com", "Joesph", 0.0, "Christiansen", "EG/2021/8228" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1009,
                columns: new[] { "Email", "FirstName", "GPA", "LastName", "RegistrationNum" },
                values: new object[] { "Aleen88@yahoo.com", "Aleen", 0.0, "West", "EG/2020/5301" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1010,
                columns: new[] { "Email", "FirstName", "GPA", "LastName", "RegistrationNum" },
                values: new object[] { "Kade_Marks@hotmail.com", "Kade", 0.0, "Marks", "EG/2022/9395" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GPA",
                table: "Students");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Gail_Auer7@hotmail.com", "Gail", "Auer", "EG/2021/6447" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Jefferey.Kshlerin47@gmail.com", "Jefferey", "Kshlerin", "EG/2023/6712" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Stevie35@hotmail.com", "Stevie", "Bosco", "EG/2022/7796" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1004,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Christy_Moore76@gmail.com", "Christy", "Moore", "EG/2022/5728" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1005,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Glenda_Marks@yahoo.com", "Glenda", "Marks", "EG/2023/7424" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1006,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Mellie.Deckow83@gmail.com", "Mellie", "Deckow", "EG/2023/9723" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1007,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Noah_Mosciski74@yahoo.com", "Noah", "Mosciski", "EG/2020/7537" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1008,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Darrel29@yahoo.com", "Darrel", "Goyette", "EG/2020/1430" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1009,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Cary64@hotmail.com", "Cary", "Senger", "EG/2023/2956" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1010,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Coby66@hotmail.com", "Coby", "O'Reilly", "EG/2023/3277" });
        }
    }
}
