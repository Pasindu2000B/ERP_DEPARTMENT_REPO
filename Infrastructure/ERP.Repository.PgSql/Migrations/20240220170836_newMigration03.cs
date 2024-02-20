using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class newMigration03 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_graduates",
                table: "graduates");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_Graduates",
                table: "Graduates",
                column: "GraduateID");

            migrationBuilder.InsertData(
                table: "Graduates",
                columns: new[] { "GraduateID", "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[,]
                {
                    { 1001, "535 Wiza Branch, New Kira, Guyana", "932.375.1156", "Forward", "Elliott" },
                    { 1002, "43901 Stiedemann Port, Landenbury, Tokelau", "425.875.9174", "Forward", "Vita" },
                    { 1003, "438 Kertzmann Ramp, Collinsview, Cocos (Keeling) Islands", "788.440.3672 x2348", "Lead", "Shanie" }
                });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 1001,
                column: "LabEquipmentName",
                value: "Bernie");

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 1002,
                columns: new[] { "LabEquipmentName", "condition" },
                values: new object[] { "Lacy", "bad" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 1003,
                column: "LabEquipmentName",
                value: "Johnny");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Jeremie_Waters82@gmail.com", "Jeremie", "Waters", "EG/2020/4985" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Owen.Prosacco@hotmail.com", "Owen", "Prosacco", "EG/2023/9845" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Sincere_Anderson9@gmail.com", "Sincere", "Anderson", "EG/2023/2129" });
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
                column: "LabEquipmentName",
                value: "Daren");

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 1002,
                columns: new[] { "LabEquipmentName", "condition" },
                values: new object[] { "Kiarra", "medium" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 1003,
                column: "LabEquipmentName",
                value: "Aisha");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Zula98@yahoo.com", "Zula", "Nitzsche", "EG/2021/8966" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Regan25@hotmail.com", "Regan", "Dickens", "EG/2022/3575" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Niko.DAmore@yahoo.com", "Niko", "D'Amore", "EG/2021/4775" });
        }
    }
}
