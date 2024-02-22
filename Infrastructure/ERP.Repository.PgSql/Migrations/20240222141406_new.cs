using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_graduates",
                table: "graduates");

            migrationBuilder.DropColumn(
                name: "LabSpaceIsFree",
                table: "LabSpaces");

            migrationBuilder.DropColumn(
                name: "maximumCapaciity",
                table: "LabSpaces");

            migrationBuilder.DropColumn(
                name: "Address1",
                table: "graduates");

            migrationBuilder.DropColumn(
                name: "Address2",
                table: "graduates");

            migrationBuilder.DropColumn(
                name: "City",
                table: "graduates");

            migrationBuilder.DropColumn(
                name: "District",
                table: "graduates");

            migrationBuilder.DropColumn(
                name: "DoB",
                table: "graduates");

            migrationBuilder.RenameTable(
                name: "graduates",
                newName: "Graduates");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Graduates",
                newName: "GraduateName");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Graduates",
                newName: "GraduateDescription");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Graduates",
                newName: "GraduateContactNo");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Graduates",
                newName: "GraduateCompany");

            migrationBuilder.RenameColumn(
                name: "RegistrationNumber",
                table: "Graduates",
                newName: "GraduateID");

            migrationBuilder.AddColumn<int>(
                name: "LabSpaceId",
                table: "LabEquipments",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Graduates",
                table: "Graduates",
                column: "GraduateID");

            migrationBuilder.InsertData(
                table: "Graduates",
                columns: new[] { "GraduateID", "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[,]
                {
                    { 1001, "00033 Carissa Crossroad, South Jerrold, Cape Verde", "245-687-8262", "Direct", "Theodore" },
                    { 1002, "2427 Ziemann Fort, West Laverna, Sweden", "(210) 544-1078 x72553", "Lead", "Zaria" },
                    { 1003, "2141 VonRueden Coves, East Camron, Congo", "398.233.9499 x2942", "Internal", "Nels" }
                });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 1001,
                columns: new[] { "LabEquipmentName", "LabSpaceId", "condition" },
                values: new object[] { "Etha", 0, "bad" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 1002,
                columns: new[] { "LabEquipmentName", "LabSpaceId", "condition" },
                values: new object[] { "Laurence", 0, "bad" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 1003,
                columns: new[] { "LabEquipmentName", "LabSpaceId" },
                values: new object[] { "William", 0 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Arnold_Gleason@yahoo.com", "Arnold", "Gleason", "EG/2022/6997" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Willis_Weimann@hotmail.com", "Willis", "Weimann", "EG/2023/3603" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Johnny_Kihn85@hotmail.com", "Johnny", "Kihn", "EG/2020/4073" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Graduates",
                table: "Graduates");

            migrationBuilder.DeleteData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1003);

            migrationBuilder.DropColumn(
                name: "LabSpaceId",
                table: "LabEquipments");

            migrationBuilder.RenameTable(
                name: "Graduates",
                newName: "graduates");

            migrationBuilder.RenameColumn(
                name: "GraduateName",
                table: "graduates",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "GraduateDescription",
                table: "graduates",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "GraduateContactNo",
                table: "graduates",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "GraduateCompany",
                table: "graduates",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "GraduateID",
                table: "graduates",
                newName: "RegistrationNumber");

            migrationBuilder.AddColumn<bool>(
                name: "LabSpaceIsFree",
                table: "LabSpaces",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "maximumCapaciity",
                table: "LabSpaces",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Address1",
                table: "graduates",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address2",
                table: "graduates",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "graduates",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "District",
                table: "graduates",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateOnly>(
                name: "DoB",
                table: "graduates",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddPrimaryKey(
                name: "PK_graduates",
                table: "graduates",
                column: "RegistrationNumber");

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 1001,
                columns: new[] { "LabEquipmentName", "condition" },
                values: new object[] { "Amalia", "medium" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 1002,
                columns: new[] { "LabEquipmentName", "condition" },
                values: new object[] { "Alva", "medium" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 1003,
                column: "LabEquipmentName",
                value: "Lester");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Talia51@gmail.com", "Talia", "Heller", "EG/2020/5483" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Carroll73@yahoo.com", "Carroll", "Bailey", "EG/2021/1348" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Emile49@yahoo.com", "Emile", "Anderson", "EG/2020/8278" });
        }
    }
}
