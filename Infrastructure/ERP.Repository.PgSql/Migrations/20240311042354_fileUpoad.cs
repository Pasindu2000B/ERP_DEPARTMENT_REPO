using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class fileUpoad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { "6815 Abernathy Walk, New Bertram, Madagascar", "854-487-6220", "Regional", "Boris" });

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1002,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "894 Lera Park, Blazechester, Iran", "299-575-7856 x131", "Central", "Nikolas" });

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1003,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "47275 Hipolito Path, Smithammouth, Congo", "(951) 206-5833", "National", "Lisa" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "HowellOkunevaandKihn_Kertzmann@gmail.com", "Howell, Okuneva and Kihn", "cyber security engineer", "http://efrain.biz" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "CruickshankSchummandMcGlynn.Blick@hotmail.com", "Cruickshank, Schumm and McGlynn", "software engineer", "http://deja.name" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "UllrichLLC_Reilly@gmail.com", "Ullrich LLC", "computer networks engineer", "http://nat.org" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "VandervortandSons_Kirlin@yahoo.com", "Vandervort and Sons", "data engineer", "http://german.biz" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "DAmoreandSons_Reichel72@gmail.com", "D'Amore and Sons", "quality assurance Enginner", "https://jennyfer.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Block-Stracke.Goodwin@hotmail.com", "Block - Stracke", "computer networks engineer", "http://elfrieda.org" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "ChamplinGroup68@hotmail.com", "Champlin Group", "cyber security engineer", "http://annabel.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "BruenGleasonandUpton75@yahoo.com", "Bruen, Gleason and Upton", "http://gretchen.name" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Willms-Lesch14@gmail.com", "Willms - Lesch", "quality assurance Enginner", "http://stan.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "JerdeInc.Zieme23@gmail.com", "Jerde Inc", "quality assurance Enginner", "https://jakob.name" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "MacGyver-Maggio.Harvey44@yahoo.com", "MacGyver - Maggio", "cyber security engineer", "https://lavada.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "Gusikowski-Hickle_Torp68@yahoo.com", "Gusikowski - Hickle", "https://loyal.biz" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "RitchieSporerandSatterfield.Zieme@hotmail.com", "Ritchie, Sporer and Satterfield", "data engineer", "http://carmella.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "MooreRatkeandJerde.Kirlin@gmail.com", "Moore, Ratke and Jerde", "cyber security engineer", "http://fletcher.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "ProhaskaBinsandPurdy_Lang@hotmail.com", "Prohaska, Bins and Purdy", "cyber security engineer", "http://armando.com" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "Effertz-Konopelski.Borer85@yahoo.com", "Effertz - Konopelski", "http://bobbie.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "KrisMoenandReichert91@hotmail.com", "Kris, Moen and Reichert", "cyber security engineer", "https://emily.com" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Dickens-Konopelski91@gmail.com", "Dickens - Konopelski", "cyber security engineer", "https://magnolia.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "DeckowInc.Schaefer@gmail.com", "Deckow Inc", "software engineer", "http://jarred.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Borer-Lemke51@yahoo.com", "Borer - Lemke", "data engineer", "http://brenna.org" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Rippin-Hodkiewicz_Pacocha40@yahoo.com", "Rippin - Hodkiewicz", "computer networks engineer", "https://katlyn.com" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "AndersonandSons_McLaughlin15@hotmail.com", "Anderson and Sons", "computer networks engineer", "http://miles.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Becker-Cruickshank92@hotmail.com", "Becker - Cruickshank", "cyber security engineer", "http://drew.com" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Schimmel-Von.Breitenberg@yahoo.com", "Schimmel - Von", "quality assurance Enginner", "https://morris.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "SimonisGroup.Mertz45@gmail.com", "Simonis Group", "quality assurance Enginner", "https://emmalee.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Bechtelar-Romaguera_Friesen@yahoo.com", "Bechtelar - Romaguera", "cyber security engineer", "http://royce.name" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Prohaska-Douglas.Welch@yahoo.com", "Prohaska - Douglas", "computer networks engineer", "https://jordane.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "WindlerBinsandStracke.Dickens55@hotmail.com", "Windler, Bins and Stracke", "software engineer", "https://jarvis.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Abernathy-Reynolds.Feil44@gmail.com", "Abernathy - Reynolds", "data engineer", "http://hobart.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "WeberandSons8@hotmail.com", "Weber and Sons", "software engineer", "http://maximillian.org" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3001,
                column: "LabEquipmentName",
                value: "Rico");

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3002,
                columns: new[] { "LabEquipmentName", "condition" },
                values: new object[] { "Lester", "bad" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3003,
                columns: new[] { "LabEquipmentName", "condition" },
                values: new object[] { "Chandler", "bad" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Shea_Hoppe87@gmail.com", "Shea", "Hoppe", "EG/2020/6640" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Jess_Mante65@gmail.com", "Jess", "Mante", "EG/2021/3296" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Walter93@gmail.com", "Walter", "Ruecker", "EG/2021/2313" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Files");

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
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Herman-Shields_Reichert80@hotmail.com", "Herman - Shields", "computer networks engineer", "https://deborah.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "CummingsWehnerandPfeffer.Parisian27@gmail.com", "Cummings, Wehner and Pfeffer", "computer networks engineer", "http://anne.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "GoldnerRogahnandWaters_Feil32@gmail.com", "Goldner, Rogahn and Waters", "quality assurance Enginner", "https://elias.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Rogahn-Huels.Pollich18@hotmail.com", "Rogahn - Huels", "software engineer", "http://baby.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "McCulloughUllrichandFunk_Moen@hotmail.com", "McCullough, Ullrich and Funk", "data engineer", "http://robin.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "RitchieBeckerandWehner_Bins@gmail.com", "Ritchie, Becker and Wehner", "cyber security engineer", "https://kamryn.biz" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "DAmoreGroup.Bednar33@yahoo.com", "D'Amore Group", "data engineer", "https://amber.name" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "GutmannThielandWelch82@hotmail.com", "Gutmann, Thiel and Welch", "http://vivian.org" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "WisokyGroup76@yahoo.com", "Wisoky Group", "computer networks engineer", "http://libbie.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Langworth-Johnston.Weimann33@gmail.com", "Langworth - Johnston", "cyber security engineer", "https://hermann.org" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "AufderharandSons_Windler@yahoo.com", "Aufderhar and Sons", "quality assurance Enginner", "http://jessie.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "Shields-Trantow_Lesch@hotmail.com", "Shields - Trantow", "http://floyd.com" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "KossLLC_Thompson@hotmail.com", "Koss LLC", "quality assurance Enginner", "http://ismael.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Koss-Ondricka.Prosacco@hotmail.com", "Koss - Ondricka", "computer networks engineer", "https://allen.name" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "WhiteHagenesandSpinka74@hotmail.com", "White, Hagenes and Spinka", "computer networks engineer", "https://vidal.name" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "GreenholtHowellandHomenick77@hotmail.com", "Greenholt, Howell and Homenick", "https://ozella.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "WolffWelchandKulas_Zboncak71@gmail.com", "Wolff, Welch and Kulas", "computer networks engineer", "https://chandler.name" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "SchmidtKingandWuckert.Parisian80@hotmail.com", "Schmidt, King and Wuckert", "software engineer", "https://leonel.biz" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Tremblay-Kautzer86@hotmail.com", "Tremblay - Kautzer", "quality assurance Enginner", "https://tremayne.com" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Keeling-Hackett_Terry18@hotmail.com", "Keeling - Hackett", "computer networks engineer", "http://cruz.biz" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Wiegand-Barton.Kulas@gmail.com", "Wiegand - Barton", "software engineer", "http://brennon.biz" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "KrajcikandSons.Zboncak@gmail.com", "Krajcik and Sons", "quality assurance Enginner", "https://andy.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Braun-Prosacco.Murazik12@gmail.com", "Braun - Prosacco", "quality assurance Enginner", "http://gregorio.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "KlockoBlockandOKon.Kassulke@yahoo.com", "Klocko, Block and O'Kon", "data engineer", "http://jules.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Stracke-Adams_Herzog24@yahoo.com", "Stracke - Adams", "data engineer", "http://lucas.name" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "HaleyLefflerandCole.Wolff@gmail.com", "Haley, Leffler and Cole", "computer networks engineer", "https://darius.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "MullerJonesandGoldner.Veum42@gmail.com", "Muller, Jones and Goldner", "cyber security engineer", "http://drew.biz" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "BashirianRempelandBarrows.King@gmail.com", "Bashirian, Rempel and Barrows", "data engineer", "http://hulda.org" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "RiceHarberandSchuppe80@gmail.com", "Rice, Harber and Schuppe", "quality assurance Enginner", "https://darrick.name" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "BergeConnandPadberg_Jast74@gmail.com", "Berge, Conn and Padberg", "cyber security engineer", "https://brandyn.info" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3001,
                column: "LabEquipmentName",
                value: "Jovan");

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3002,
                columns: new[] { "LabEquipmentName", "condition" },
                values: new object[] { "Kiana", "medium" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3003,
                columns: new[] { "LabEquipmentName", "condition" },
                values: new object[] { "Vivien", "medium" });

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
