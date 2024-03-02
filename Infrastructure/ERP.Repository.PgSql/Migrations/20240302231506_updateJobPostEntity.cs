using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class updateJobPostEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "JobPosts",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1001,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "8659 Little Brook, Arleneville, South Africa", "1-830-331-9684", "Investor", "Kamryn" });

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1002,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "9492 Hansen Ways, Pfefferborough, Bermuda", "921.736.8971", "Senior", "Lily" });

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1003,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "699 Hand Estate, South Cleve, Argentina", "904-804-9850", "Forward", "Dimitri" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3001,
                column: "LabEquipmentName",
                value: "Aracely");

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3002,
                column: "LabEquipmentName",
                value: "Mike");

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3003,
                column: "LabEquipmentName",
                value: "Roxanne");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Emmanuelle45@hotmail.com", "Emmanuelle", "Hartmann", "EG/2020/9961" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Mohamed.Torp@hotmail.com", "Mohamed", "Torp", "EG/2021/8767" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Denis.Cormier0@yahoo.com", "Denis", "Cormier", "EG/2020/2090" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "JobPosts");

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1001,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "5960 Dawson Harbors, Leschbury, Australia", "(365) 739-7523 x05460", "Product", "Rebeca" });

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1002,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "4648 Karlee Shoal, Quigleyville, Portugal", "1-281-886-6494 x243", "Human", "Elisabeth" });

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1003,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "584 Goyette Ville, Alvertabury, Ireland", "463.283.4286 x337", "Senior", "Aisha" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3001,
                column: "LabEquipmentName",
                value: "Jimmy");

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3002,
                column: "LabEquipmentName",
                value: "Donnie");

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3003,
                column: "LabEquipmentName",
                value: "Shanie");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Marguerite_Rogahn@hotmail.com", "Marguerite", "Rogahn", "EG/2020/2066" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Everardo_Grady@yahoo.com", "Everardo", "Grady", "EG/2021/1518" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Mike_Hilpert34@hotmail.com", "Mike", "Hilpert", "EG/2023/8649" });
        }
    }
}
