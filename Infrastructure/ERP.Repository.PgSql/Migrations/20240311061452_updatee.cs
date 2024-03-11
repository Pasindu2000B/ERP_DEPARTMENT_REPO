using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class updatee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3001);

            migrationBuilder.DeleteData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3002);

            migrationBuilder.DeleteData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3003);

            migrationBuilder.RenameColumn(
                name: "LabEquipmentName",
                table: "JobPosts",
                newName: "Category");

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FileName = table.Column<string>(type: "text", nullable: false),
                    Data = table.Column<byte[]>(type: "bytea", nullable: false),
                    ContentType = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1001,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "966 Rosenbaum Via, West Waldo, Western Sahara", "831-733-6815", "Dynamic", "Herman" });

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1002,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "98030 Purdy Track, Karleechester, Bhutan", "436-960-9239 x618", "Forward", "Javon" });

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1003,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "277 Dickens Hollow, Port Dejahview, Tajikistan", "(919) 441-8306 x2652", "International", "Magdalena" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Category", "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "computer Engineering", "Sanford-Sporer.Berge62@yahoo.com", "Sanford - Sporer", "quality assurance Enginner", "https://gussie.biz" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Category", "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "computer Engineering", "Hansen-Gibson57@hotmail.com", "Hansen - Gibson", "data engineer", "https://shannon.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Category", "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "computer Engineering", "RennerInc43@hotmail.com", "Renner Inc", "data engineer", "http://drake.org" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Category", "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "computer Engineering", "BlockWaelchiandLangworth31@yahoo.com", "Block, Waelchi and Langworth", "data engineer", "http://isabel.org" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Category", "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "computer Engineering", "JohnstonBlockandPadberg_Beatty70@hotmail.com", "Johnston, Block and Padberg", "computer networks engineer", "http://gregory.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Category", "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "computer Engineering", "GulgowskiWillmsandJenkins_Pouros37@yahoo.com", "Gulgowski, Willms and Jenkins", "software engineer", "https://tressie.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Category", "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "computer Engineering", "MurrayInc72@hotmail.com", "Murray Inc", "software engineer", "https://juliana.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Category", "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "computer Engineering", "Ebert-Wisoky_Gleason71@gmail.com", "Ebert - Wisoky", "computer networks engineer", "http://hermann.name" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Category", "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "computer Engineering", "ProhaskaInc27@gmail.com", "Prohaska Inc", "data engineer", "https://alivia.com" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Category", "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "computer Engineering", "ChristiansenandSons_Hansen85@hotmail.com", "Christiansen and Sons", "http://alexandro.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Category", "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "computer Engineering", "EmardHilpertandMorissette42@yahoo.com", "Emard, Hilpert and Morissette", "https://mckenna.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Category", "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "computer Engineering", "Osinski-Deckow.Haag46@yahoo.com", "Osinski - Deckow", "software engineer", "https://jaqueline.name" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Category", "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "computer Engineering", "Mante-Durgan.Johnson58@yahoo.com", "Mante - Durgan", "https://gideon.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Category", "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "computer Engineering", "WeberSpencerandReynolds.Ondricka84@gmail.com", "Weber, Spencer and Reynolds", "data engineer", "https://jocelyn.biz" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Category", "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "computer Engineering", "HowellOrnandGreenholt95@yahoo.com", "Howell, Orn and Greenholt", "cyber security engineer", "https://rosie.org" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Category", "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "computer Engineering", "VeumLLC39@yahoo.com", "Veum LLC", "software engineer", "http://junius.biz" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Category", "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "computer Engineering", "KiehnPagacandMills38@hotmail.com", "Kiehn, Pagac and Mills", "http://gail.name" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Category", "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "computer Engineering", "Weimann-Okuneva.Pollich@hotmail.com", "Weimann - Okuneva", "computer networks engineer", "https://juana.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Category", "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "computer Engineering", "GrimesKulasandHoppe61@gmail.com", "Grimes, Kulas and Hoppe", "computer networks engineer", "https://alfonso.name" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Category", "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "computer Engineering", "Pollich-Jacobs47@hotmail.com", "Pollich - Jacobs", "data engineer", "https://tad.org" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Category", "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "computer Engineering", "Murray-Smith8@yahoo.com", "Murray - Smith", "cyber security engineer", "https://lois.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Category", "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "computer Engineering", "GreenLLC.Frami35@gmail.com", "Green LLC", "http://jayda.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Category", "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "computer Engineering", "KohlerGroup_Haley@yahoo.com", "Kohler Group", "computer networks engineer", "http://kennith.name" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Category", "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "computer Engineering", "StrosinWunschandLabadie77@yahoo.com", "Strosin, Wunsch and Labadie", "software engineer", "http://doug.com" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Category", "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "computer Engineering", "Jaskolski-Wiza54@hotmail.com", "Jaskolski - Wiza", "quality assurance Enginner", "http://mariela.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Category", "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "computer Engineering", "AbernathyLLC.Rice@gmail.com", "Abernathy LLC", "data engineer", "https://domenica.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Category", "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "computer Engineering", "Kovacek-Kohler_Dickinson@hotmail.com", "Kovacek - Kohler", "software engineer", "https://amanda.biz" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Category", "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "computer Engineering", "Bernhard-Jaskolski20@gmail.com", "Bernhard - Jaskolski", "cyber security engineer", "https://hosea.org" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Category", "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "computer Engineering", "PourosandSons_Mante@hotmail.com", "Pouros and Sons", "http://deshawn.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Category", "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "computer Engineering", "BechtelarCarrollandStanton.Lowe@hotmail.com", "Bechtelar, Carroll and Stanton", "quality assurance Enginner", "https://kyleigh.name" });

            migrationBuilder.InsertData(
                table: "LabSpaces",
                columns: new[] { "LabSpaceId", "LabSpaceName" },
                values: new object[,]
                {
                    { 21, "Adriana" },
                    { 22, "Jensen" },
                    { 23, "Brook" }
                });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Joel_Fisher@yahoo.com", "Joel", "Fisher", "EG/2020/7468" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Louie_Bruen65@hotmail.com", "Louie", "Bruen", "EG/2022/3748" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Fletcher38@hotmail.com", "Fletcher", "Harvey", "EG/2020/2036" });

            migrationBuilder.CreateIndex(
                name: "IX_LabEquipments_LabSpaceId",
                table: "LabEquipments",
                column: "LabSpaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_LabEquipments_LabSpaces_LabSpaceId",
                table: "LabEquipments",
                column: "LabSpaceId",
                principalTable: "LabSpaces",
                principalColumn: "LabSpaceId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LabEquipments_LabSpaces_LabSpaceId",
                table: "LabEquipments");

            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropIndex(
                name: "IX_LabEquipments_LabSpaceId",
                table: "LabEquipments");

            migrationBuilder.DeleteData(
                table: "LabSpaces",
                keyColumn: "LabSpaceId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "LabSpaces",
                keyColumn: "LabSpaceId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "LabSpaces",
                keyColumn: "LabSpaceId",
                keyValue: 23);

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "JobPosts",
                newName: "LabEquipmentName");

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1001,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "5993 Hills Burg, East Josianefort, Argentina", "450-228-5802", "Internal", "Reymundo" });

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1002,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "971 Grady Springs, Veumfort, Grenada", "272-897-9194 x479", "Dynamic", "Baby" });

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1003,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "442 Arno Way, Coltonstad, Guyana", "(966) 220-2767", "Product", "Zula" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink", "LabEquipmentName" },
                values: new object[] { "Herman-Shields_Reichert80@hotmail.com", "Herman - Shields", "computer networks engineer", "https://deborah.net", null });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink", "LabEquipmentName" },
                values: new object[] { "CummingsWehnerandPfeffer.Parisian27@gmail.com", "Cummings, Wehner and Pfeffer", "computer networks engineer", "http://anne.net", null });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink", "LabEquipmentName" },
                values: new object[] { "GoldnerRogahnandWaters_Feil32@gmail.com", "Goldner, Rogahn and Waters", "quality assurance Enginner", "https://elias.net", null });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink", "LabEquipmentName" },
                values: new object[] { "Rogahn-Huels.Pollich18@hotmail.com", "Rogahn - Huels", "software engineer", "http://baby.net", null });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink", "LabEquipmentName" },
                values: new object[] { "McCulloughUllrichandFunk_Moen@hotmail.com", "McCullough, Ullrich and Funk", "data engineer", "http://robin.info", null });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink", "LabEquipmentName" },
                values: new object[] { "RitchieBeckerandWehner_Bins@gmail.com", "Ritchie, Becker and Wehner", "cyber security engineer", "https://kamryn.biz", null });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink", "LabEquipmentName" },
                values: new object[] { "DAmoreGroup.Bednar33@yahoo.com", "D'Amore Group", "data engineer", "https://amber.name", null });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink", "LabEquipmentName" },
                values: new object[] { "GutmannThielandWelch82@hotmail.com", "Gutmann, Thiel and Welch", "quality assurance Enginner", "http://vivian.org", null });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink", "LabEquipmentName" },
                values: new object[] { "WisokyGroup76@yahoo.com", "Wisoky Group", "computer networks engineer", "http://libbie.net", null });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink", "LabEquipmentName" },
                values: new object[] { "Langworth-Johnston.Weimann33@gmail.com", "Langworth - Johnston", "https://hermann.org", null });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink", "LabEquipmentName" },
                values: new object[] { "AufderharandSons_Windler@yahoo.com", "Aufderhar and Sons", "http://jessie.info", null });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink", "LabEquipmentName" },
                values: new object[] { "Shields-Trantow_Lesch@hotmail.com", "Shields - Trantow", "quality assurance Enginner", "http://floyd.com", null });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink", "LabEquipmentName" },
                values: new object[] { "KossLLC_Thompson@hotmail.com", "Koss LLC", "http://ismael.net", null });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink", "LabEquipmentName" },
                values: new object[] { "Koss-Ondricka.Prosacco@hotmail.com", "Koss - Ondricka", "computer networks engineer", "https://allen.name", null });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink", "LabEquipmentName" },
                values: new object[] { "WhiteHagenesandSpinka74@hotmail.com", "White, Hagenes and Spinka", "computer networks engineer", "https://vidal.name", null });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink", "LabEquipmentName" },
                values: new object[] { "GreenholtHowellandHomenick77@hotmail.com", "Greenholt, Howell and Homenick", "cyber security engineer", "https://ozella.net", null });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink", "LabEquipmentName" },
                values: new object[] { "WolffWelchandKulas_Zboncak71@gmail.com", "Wolff, Welch and Kulas", "https://chandler.name", null });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink", "LabEquipmentName" },
                values: new object[] { "SchmidtKingandWuckert.Parisian80@hotmail.com", "Schmidt, King and Wuckert", "software engineer", "https://leonel.biz", null });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink", "LabEquipmentName" },
                values: new object[] { "Tremblay-Kautzer86@hotmail.com", "Tremblay - Kautzer", "quality assurance Enginner", "https://tremayne.com", null });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink", "LabEquipmentName" },
                values: new object[] { "Keeling-Hackett_Terry18@hotmail.com", "Keeling - Hackett", "computer networks engineer", "http://cruz.biz", null });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink", "LabEquipmentName" },
                values: new object[] { "Wiegand-Barton.Kulas@gmail.com", "Wiegand - Barton", "software engineer", "http://brennon.biz", null });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink", "LabEquipmentName" },
                values: new object[] { "KrajcikandSons.Zboncak@gmail.com", "Krajcik and Sons", "https://andy.net", null });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink", "LabEquipmentName" },
                values: new object[] { "Braun-Prosacco.Murazik12@gmail.com", "Braun - Prosacco", "quality assurance Enginner", "http://gregorio.info", null });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink", "LabEquipmentName" },
                values: new object[] { "KlockoBlockandOKon.Kassulke@yahoo.com", "Klocko, Block and O'Kon", "data engineer", "http://jules.info", null });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink", "LabEquipmentName" },
                values: new object[] { "Stracke-Adams_Herzog24@yahoo.com", "Stracke - Adams", "data engineer", "http://lucas.name", null });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink", "LabEquipmentName" },
                values: new object[] { "HaleyLefflerandCole.Wolff@gmail.com", "Haley, Leffler and Cole", "computer networks engineer", "https://darius.net", null });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink", "LabEquipmentName" },
                values: new object[] { "MullerJonesandGoldner.Veum42@gmail.com", "Muller, Jones and Goldner", "cyber security engineer", "http://drew.biz", null });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink", "LabEquipmentName" },
                values: new object[] { "BashirianRempelandBarrows.King@gmail.com", "Bashirian, Rempel and Barrows", "data engineer", "http://hulda.org", null });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink", "LabEquipmentName" },
                values: new object[] { "RiceHarberandSchuppe80@gmail.com", "Rice, Harber and Schuppe", "https://darrick.name", null });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink", "LabEquipmentName" },
                values: new object[] { "BergeConnandPadberg_Jast74@gmail.com", "Berge, Conn and Padberg", "cyber security engineer", "https://brandyn.info", null });

            migrationBuilder.InsertData(
                table: "LabEquipments",
                columns: new[] { "LabEquipmentID", "Avaialability", "LabEquipmentName", "LabSpaceId", "condition" },
                values: new object[,]
                {
                    { 3001, false, "Jovan", 0, "medium" },
                    { 3002, false, "Kiana", 0, "medium" },
                    { 3003, false, "Vivien", 0, "medium" }
                });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Eryn97@gmail.com", "Eryn", "Dicki", "EG/2022/6407" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Dawson_Hudson70@hotmail.com", "Dawson", "Hudson", "EG/2023/2426" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Brielle.Labadie@hotmail.com", "Brielle", "Labadie", "EG/2020/3144" });
        }
    }
}
