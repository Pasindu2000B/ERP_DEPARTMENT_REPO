using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class labsche : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Booking_Labs",
                columns: table => new
                {
                    BookingID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LabSpaceId = table.Column<int>(type: "integer", nullable: false),
                    Module_CoordinatorTeacherId = table.Column<int>(type: "integer", nullable: false),
                    Module_Coordinator_Id = table.Column<int>(type: "integer", nullable: false),
                    Start_Time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    End_Time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Date_Of_Booking = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking_Labs", x => x.BookingID);
                    table.ForeignKey(
                        name: "FK_Booking_Labs_LabSpaces_LabSpaceId",
                        column: x => x.LabSpaceId,
                        principalTable: "LabSpaces",
                        principalColumn: "LabSpaceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Booking_Labs_Teachers_Module_CoordinatorTeacherId",
                        column: x => x.Module_CoordinatorTeacherId,
                        principalTable: "Teachers",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1001,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "52774 Barrows Island, Port Domenicaside, Holy See (Vatican City State)", "(639) 260-0673", "National", "Verla" });

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1002,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "633 Von Passage, West Maggie, Mayotte", "1-795-566-4190 x24836", "Product", "Bret" });

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1003,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "36612 Marcus Terrace, New Antonio, Saint Pierre and Miquelon", "(834) 868-9445", "Regional", "Brody" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Kautzer-Kemmer_Hand93@hotmail.com", "Kautzer - Kemmer", "cyber security engineer", "http://stewart.org" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "JacobiGroup.Wiza30@hotmail.com", "Jacobi Group", "quality assurance Enginner", "http://amie.name" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Hartmann-Wilderman52@hotmail.com", "Hartmann - Wilderman", "computer networks engineer", "https://myrtice.name" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "OReillyandSons.Konopelski@gmail.com", "O'Reilly and Sons", "computer networks engineer", "http://georgiana.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "KirlinRoobandBeahan.Larkin84@gmail.com", "Kirlin, Roob and Beahan", "http://heaven.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "CollierLLC.Greenfelder@yahoo.com", "Collier LLC", "quality assurance Enginner", "https://nat.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "StromanGroup_Wiegand75@gmail.com", "Stroman Group", "quality assurance Enginner", "http://jettie.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "BaileyInc49@yahoo.com", "Bailey Inc", "software engineer", "https://albina.name" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "JaskolskiKossandGreenfelder.Quitzon@hotmail.com", "Jaskolski, Koss and Greenfelder", "quality assurance Enginner", "http://melvina.org" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "Welch-Moen.Schamberger60@gmail.com", "Welch - Moen", "http://cassandre.name" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "HahnLLC14@yahoo.com", "Hahn LLC", "software engineer", "https://missouri.org" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "ErnserConroyandKautzer_Schinner@hotmail.com", "Ernser, Conroy and Kautzer", "software engineer", "https://raquel.biz" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Pfeffer-Hilpert40@hotmail.com", "Pfeffer - Hilpert", "data engineer", "http://lorenz.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Wisoky-Osinski43@yahoo.com", "Wisoky - Osinski", "software engineer", "http://damien.com" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "CarrollandSons.White@gmail.com", "Carroll and Sons", "http://tavares.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "Haag-Rowe_Rosenbaum@yahoo.com", "Haag - Rowe", "https://pierce.org" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Mitchell-Carroll.Bartoletti20@hotmail.com", "Mitchell - Carroll", "computer networks engineer", "https://magdalen.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Blick-Towne.Olson@hotmail.com", "Blick - Towne", "quality assurance Enginner", "http://maxwell.name" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "WolfReichelandBeahan_Goldner49@hotmail.com", "Wolf, Reichel and Beahan", "computer networks engineer", "https://urban.name" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "KilbackHillsandLeannon_Luettgen14@gmail.com", "Kilback, Hills and Leannon", "software engineer", "http://stefanie.biz" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Auer-Bernier42@gmail.com", "Auer - Bernier", "software engineer", "http://helen.biz" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "ParkerGroup_Stokes@yahoo.com", "Parker Group", "cyber security engineer", "http://heidi.biz" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "WhiteAbernathyandCarroll_MacGyver42@hotmail.com", "White, Abernathy and Carroll", "computer networks engineer", "http://hailee.org" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "GulgowskiGroup.Prosacco@yahoo.com", "Gulgowski Group", "cyber security engineer", "https://parker.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "JastInc.Okuneva@hotmail.com", "Jast Inc", "data engineer", "https://christ.biz" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "JakubowskiLLC69@hotmail.com", "Jakubowski LLC", "cyber security engineer", "https://concepcion.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Cole-Rau.Leuschke95@hotmail.com", "Cole - Rau", "data engineer", "http://armand.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Ratke-Kiehn.Rohan34@yahoo.com", "Ratke - Kiehn", "software engineer", "http://bud.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "CreminHilllandKoch.Harris@gmail.com", "Cremin, Hilll and Koch", "software engineer", "https://lizeth.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "HaneandSons_Beahan91@gmail.com", "Hane and Sons", "data engineer", "http://kasandra.net" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3001,
                column: "LabEquipmentName",
                value: "Matteo");

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3002,
                columns: new[] { "LabEquipmentName", "condition" },
                values: new object[] { "Josianne", "bad" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3003,
                column: "LabEquipmentName",
                value: "Jeff");

            migrationBuilder.UpdateData(
                table: "LabSpaces",
                keyColumn: "LabSpaceId",
                keyValue: 21,
                column: "LabSpaceName",
                value: "Belle");

            migrationBuilder.UpdateData(
                table: "LabSpaces",
                keyColumn: "LabSpaceId",
                keyValue: 22,
                column: "LabSpaceName",
                value: "Kamille");

            migrationBuilder.UpdateData(
                table: "LabSpaces",
                keyColumn: "LabSpaceId",
                keyValue: 23,
                column: "LabSpaceName",
                value: "Cordie");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Felicia_Fisher@gmail.com", "Felicia", "Fisher", "EG/2020/7936" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Ben.Skiles@yahoo.com", "Ben", "Skiles", "EG/2020/5449" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Emmie_Swift@gmail.com", "Emmie", "Swift", "EG/2023/5875" });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_Labs_LabSpaceId",
                table: "Booking_Labs",
                column: "LabSpaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_Labs_Module_CoordinatorTeacherId",
                table: "Booking_Labs",
                column: "Module_CoordinatorTeacherId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Booking_Labs");

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1001,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "252 Henri Circle, Wymanland, Norfolk Island", "789.882.6939 x463", "Internal", "Reilly" });

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1002,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "12886 Kilback Orchard, Port Leeside, Belgium", "619-387-5797 x7219", "National", "Adam" });

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1003,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "01961 Ola Centers, Rathshire, Uzbekistan", "728.879.8037 x7160", "Human", "Deven" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Lubowitz-Schiller91@yahoo.com", "Lubowitz - Schiller", "computer networks engineer", "https://leann.org" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "RutherfordTreutelandBartoletti16@hotmail.com", "Rutherford, Treutel and Bartoletti", "cyber security engineer", "https://jamal.org" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "BoehmKuhicandHand_Kihn24@yahoo.com", "Boehm, Kuhic and Hand", "data engineer", "https://nyah.name" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Hamill-Lind.Reichert45@hotmail.com", "Hamill - Lind", "data engineer", "https://samantha.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "HartmannandSons_Roob19@yahoo.com", "Hartmann and Sons", "http://enola.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "LynchLLC_Crist32@yahoo.com", "Lynch LLC", "cyber security engineer", "https://deborah.name" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Kunze-Mertz59@gmail.com", "Kunze - Mertz", "cyber security engineer", "https://opal.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "McClure-Baumbach_Morar14@hotmail.com", "McClure - Baumbach", "cyber security engineer", "http://adrien.com" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Klein-Bergstrom.Weimann@yahoo.com", "Klein - Bergstrom", "data engineer", "https://alphonso.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "Schumm-Gaylord.Gleichner@gmail.com", "Schumm - Gaylord", "https://ola.org" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "ZiemannInc.Rempel@gmail.com", "Ziemann Inc", "computer networks engineer", "https://oran.com" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "ZiemeLLC.Stiedemann@hotmail.com", "Zieme LLC", "cyber security engineer", "http://reina.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "MacGyverMetzandBernier36@yahoo.com", "MacGyver, Metz and Bernier", "quality assurance Enginner", "https://riley.org" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "YundtPagacandKihn.Okuneva@hotmail.com", "Yundt, Pagac and Kihn", "quality assurance Enginner", "https://anissa.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "VonRueden-Champlin.Jerde37@hotmail.com", "VonRueden - Champlin", "http://rhiannon.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "ShanahanWalterandDonnelly.Ward68@hotmail.com", "Shanahan, Walter and Donnelly", "https://marianna.org" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Gerlach-Williamson60@yahoo.com", "Gerlach - Williamson", "cyber security engineer", "https://douglas.name" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "FritschInc.Hermann86@gmail.com", "Fritsch Inc", "computer networks engineer", "https://cyril.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Herzog-Orn.Pollich@yahoo.com", "Herzog - Orn", "quality assurance Enginner", "https://roberto.com" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "BeattyLLC.Nader@hotmail.com", "Beatty LLC", "data engineer", "http://catalina.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "SawaynInc_Welch@yahoo.com", "Sawayn Inc", "quality assurance Enginner", "https://emmett.org" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "CasperHegmannandDietrich14@yahoo.com", "Casper, Hegmann and Dietrich", "software engineer", "https://kaleigh.com" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "West-Mertz_Larkin72@gmail.com", "West - Mertz", "cyber security engineer", "http://tevin.biz" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Green-Mills.McCullough68@gmail.com", "Green - Mills", "data engineer", "https://berry.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "BednarKilbackandGrant_Klein@hotmail.com", "Bednar, Kilback and Grant", "quality assurance Enginner", "http://amya.org" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "WymanBoehmandGusikowski.Gaylord23@hotmail.com", "Wyman, Boehm and Gusikowski", "data engineer", "https://estefania.name" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Gerhold-Gutmann60@yahoo.com", "Gerhold - Gutmann", "quality assurance Enginner", "https://carolanne.com" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "BodeGroup.Carroll@yahoo.com", "Bode Group", "computer networks engineer", "https://norwood.biz" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "BogisichLLC.Jones57@gmail.com", "Bogisich LLC", "data engineer", "http://rosendo.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "BinsInc76@hotmail.com", "Bins Inc", "computer networks engineer", "http://maeve.biz" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3001,
                column: "LabEquipmentName",
                value: "Bettie");

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3002,
                columns: new[] { "LabEquipmentName", "condition" },
                values: new object[] { "Orie", "medium" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3003,
                column: "LabEquipmentName",
                value: "Jade");

            migrationBuilder.UpdateData(
                table: "LabSpaces",
                keyColumn: "LabSpaceId",
                keyValue: 21,
                column: "LabSpaceName",
                value: "Kaelyn");

            migrationBuilder.UpdateData(
                table: "LabSpaces",
                keyColumn: "LabSpaceId",
                keyValue: 22,
                column: "LabSpaceName",
                value: "Brandyn");

            migrationBuilder.UpdateData(
                table: "LabSpaces",
                keyColumn: "LabSpaceId",
                keyValue: 23,
                column: "LabSpaceName",
                value: "Cierra");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Santiago11@hotmail.com", "Santiago", "Balistreri", "EG/2021/9409" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Alexane_Bechtelar4@hotmail.com", "Alexane", "Bechtelar", "EG/2020/9032" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Lexi.Welch10@gmail.com", "Lexi", "Welch", "EG/2022/7548" });
        }
    }
}
