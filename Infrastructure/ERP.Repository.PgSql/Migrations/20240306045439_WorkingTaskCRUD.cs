using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class WorkingTaskCRUD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkingTask_Teachers_TeacherId",
                table: "WorkingTask");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkingTask",
                table: "WorkingTask");

            migrationBuilder.RenameTable(
                name: "WorkingTask",
                newName: "WorkingTasks");

            migrationBuilder.RenameIndex(
                name: "IX_WorkingTask_TeacherId",
                table: "WorkingTasks",
                newName: "IX_WorkingTasks_TeacherId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkingTasks",
                table: "WorkingTasks",
                column: "WorkingTaskId");

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1001,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "0643 Gleichner Light, Cynthialand, Singapore", "1-495-221-0874 x03075", "Customer", "Georgiana" });

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1002,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "307 Ryder Terrace, Towneland, Tuvalu", "(270) 442-7806", "Dynamic", "Shanelle" });

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1003,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "000 Kihn Orchard, East Othaport, Anguilla", "544.352.0044", "Corporate", "Imani" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3001,
                column: "LabEquipmentName",
                value: "Nikolas");

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3002,
                columns: new[] { "LabEquipmentName", "condition" },
                values: new object[] { "Else", "bad" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3003,
                column: "LabEquipmentName",
                value: "Curt");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Amy.Cole8@hotmail.com", "Amy", "Cole", "EG/2020/7328" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Preston_Gaylord@yahoo.com", "Preston", "Gaylord", "EG/2020/1508" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Julia_Robel@yahoo.com", "Julia", "Robel", "EG/2021/3654" });

            migrationBuilder.AddForeignKey(
                name: "FK_WorkingTasks_Teachers_TeacherId",
                table: "WorkingTasks",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkingTasks_Teachers_TeacherId",
                table: "WorkingTasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkingTasks",
                table: "WorkingTasks");

            migrationBuilder.RenameTable(
                name: "WorkingTasks",
                newName: "WorkingTask");

            migrationBuilder.RenameIndex(
                name: "IX_WorkingTasks_TeacherId",
                table: "WorkingTask",
                newName: "IX_WorkingTask_TeacherId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkingTask",
                table: "WorkingTask",
                column: "WorkingTaskId");

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
                column: "LabEquipmentName",
                value: "Valentine");

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3002,
                columns: new[] { "LabEquipmentName", "condition" },
                values: new object[] { "Aniya", "medium" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3003,
                column: "LabEquipmentName",
                value: "Kadin");

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

            migrationBuilder.AddForeignKey(
                name: "FK_WorkingTask_Teachers_TeacherId",
                table: "WorkingTask",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
