using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class ForeignKeyProblem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1001,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "737 Schinner Islands, Angelport, Thailand", "301-365-7145 x974", "Direct", "Dustin" });

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1002,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "10893 Osborne Fort, Tremblaymouth, Lao People's Democratic Republic", "(475) 210-2510", "Principal", "Pearl" });

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1003,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateName" },
                values: new object[] { "81390 Kailey Ports, Port Joshuahmouth, Tunisia", "1-229-693-9221", "Buster" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "FritschandSons.Kilback@yahoo.com", "Fritsch and Sons", "software engineer", "http://eldridge.name" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "LabadieWeissnatandPadberg71@yahoo.com", "Labadie, Weissnat and Padberg", "quality assurance Enginner", "https://brendan.org" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "AnkundingWardandBuckridge.Cummerata@yahoo.com", "Ankunding, Ward and Buckridge", "https://ole.name" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "SmithamVeumandHoeger90@yahoo.com", "Smitham, Veum and Hoeger", "computer networks engineer", "http://virgie.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "ConnellyParkerandFay.Thompson22@gmail.com", "Connelly, Parker and Fay", "software engineer", "https://erling.biz" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "LynchGroup_Kiehn37@yahoo.com", "Lynch Group", "cyber security engineer", "https://tony.biz" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "LangGroup_Altenwerth@yahoo.com", "Lang Group", "cyber security engineer", "http://khalid.name" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Howe-Rempel95@gmail.com", "Howe - Rempel", "quality assurance Enginner", "https://nicklaus.com" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "Herzog-Keeling.Collins@yahoo.com", "Herzog - Keeling", "https://victor.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "SpencerGreenholtandTurcotte14@yahoo.com", "Spencer, Greenholt and Turcotte", "computer networks engineer", "http://pearlie.org" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "BlickHaleyandBeer_Upton3@gmail.com", "Blick, Haley and Beer", "software engineer", "http://jazmyne.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "Schamberger-Collins75@yahoo.com", "Schamberger - Collins", "https://akeem.org" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Bode-Prosacco_Rempel@gmail.com", "Bode - Prosacco", "data engineer", "https://freeman.org" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Runte-Schultz94@yahoo.com", "Runte - Schultz", "computer networks engineer", "https://luis.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Kilback-Parker4@yahoo.com", "Kilback - Parker", "computer networks engineer", "https://brielle.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "HettingerCollinsandProsacco_Sauer8@gmail.com", "Hettinger, Collins and Prosacco", "http://verlie.name" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Hammes-Cummings78@yahoo.com", "Hammes - Cummings", "data engineer", "https://noemie.name" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "BoyleKautzerandDoyle_Lind@hotmail.com", "Boyle, Kautzer and Doyle", "data engineer", "https://malcolm.name" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "BergstromDeckowandJaskolski94@gmail.com", "Bergstrom, Deckow and Jaskolski", "data engineer", "https://sibyl.biz" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "ProhaskaSchusterandOrn_Tillman@hotmail.com", "Prohaska, Schuster and Orn", "quality assurance Enginner", "https://tremaine.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Bernhard-Wunsch.Nolan@hotmail.com", "Bernhard - Wunsch", "software engineer", "https://camryn.name" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "HoppeSchmidtandMurphy_Osinski@yahoo.com", "Hoppe, Schmidt and Murphy", "computer networks engineer", "http://jamie.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Denesik-Kling11@yahoo.com", "Denesik - Kling", "software engineer", "http://mitchell.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "AbernathyGroup.Baumbach@gmail.com", "Abernathy Group", "http://estel.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "BartolettiInc.Champlin@gmail.com", "Bartoletti Inc", "software engineer", "http://jadon.org" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "BraunKautzerandMaggio_Gerhold@hotmail.com", "Braun, Kautzer and Maggio", "http://rylee.biz" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "RempelRippinandRosenbaum.Kuhic@yahoo.com", "Rempel, Rippin and Rosenbaum", "cyber security engineer", "http://torrance.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Bednar-Trantow_Quitzon@gmail.com", "Bednar - Trantow", "computer networks engineer", "http://janessa.com" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "RauLLC.Swaniawski@yahoo.com", "Rau LLC", "software engineer", "https://bryce.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "WolffInc28@gmail.com", "Wolff Inc", "cyber security engineer", "https://verner.info" });

            migrationBuilder.InsertData(
                table: "LabEquipments",
                columns: new[] { "LabEquipmentID", "Avaialability", "LabEquipmentName", "LabSpaceId", "condition" },
                values: new object[,]
                {
                    { 3001, false, "Xander", 21, "bad" },
                    { 3002, false, "Guido", 21, "medium" },
                    { 3003, false, "Carole", 21, "medium" }
                });

            migrationBuilder.UpdateData(
                table: "LabSpaces",
                keyColumn: "LabSpaceId",
                keyValue: 21,
                column: "LabSpaceName",
                value: "Douglas");

            migrationBuilder.UpdateData(
                table: "LabSpaces",
                keyColumn: "LabSpaceId",
                keyValue: 22,
                column: "LabSpaceName",
                value: "Gage");

            migrationBuilder.UpdateData(
                table: "LabSpaces",
                keyColumn: "LabSpaceId",
                keyValue: 23,
                column: "LabSpaceName",
                value: "Rodolfo");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Isabella_Hammes@hotmail.com", "Isabella", "Hammes", "EG/2023/7779" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Janiya98@gmail.com", "Janiya", "Auer", "EG/2021/4303" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Keaton.Barton@gmail.com", "Keaton", "Barton", "EG/2021/5228" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateName" },
                values: new object[] { "277 Dickens Hollow, Port Dejahview, Tajikistan", "(919) 441-8306 x2652", "Magdalena" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Sanford-Sporer.Berge62@yahoo.com", "Sanford - Sporer", "quality assurance Enginner", "https://gussie.biz" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Hansen-Gibson57@hotmail.com", "Hansen - Gibson", "data engineer", "https://shannon.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "RennerInc43@hotmail.com", "Renner Inc", "http://drake.org" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "BlockWaelchiandLangworth31@yahoo.com", "Block, Waelchi and Langworth", "data engineer", "http://isabel.org" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "JohnstonBlockandPadberg_Beatty70@hotmail.com", "Johnston, Block and Padberg", "computer networks engineer", "http://gregory.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "GulgowskiWillmsandJenkins_Pouros37@yahoo.com", "Gulgowski, Willms and Jenkins", "software engineer", "https://tressie.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "MurrayInc72@hotmail.com", "Murray Inc", "software engineer", "https://juliana.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Ebert-Wisoky_Gleason71@gmail.com", "Ebert - Wisoky", "computer networks engineer", "http://hermann.name" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "ProhaskaInc27@gmail.com", "Prohaska Inc", "https://alivia.com" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "ChristiansenandSons_Hansen85@hotmail.com", "Christiansen and Sons", "cyber security engineer", "http://alexandro.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "EmardHilpertandMorissette42@yahoo.com", "Emard, Hilpert and Morissette", "quality assurance Enginner", "https://mckenna.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "Osinski-Deckow.Haag46@yahoo.com", "Osinski - Deckow", "https://jaqueline.name" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Mante-Durgan.Johnson58@yahoo.com", "Mante - Durgan", "quality assurance Enginner", "https://gideon.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "WeberSpencerandReynolds.Ondricka84@gmail.com", "Weber, Spencer and Reynolds", "data engineer", "https://jocelyn.biz" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "HowellOrnandGreenholt95@yahoo.com", "Howell, Orn and Greenholt", "cyber security engineer", "https://rosie.org" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "VeumLLC39@yahoo.com", "Veum LLC", "http://junius.biz" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "KiehnPagacandMills38@hotmail.com", "Kiehn, Pagac and Mills", "computer networks engineer", "http://gail.name" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Weimann-Okuneva.Pollich@hotmail.com", "Weimann - Okuneva", "computer networks engineer", "https://juana.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "GrimesKulasandHoppe61@gmail.com", "Grimes, Kulas and Hoppe", "computer networks engineer", "https://alfonso.name" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Pollich-Jacobs47@hotmail.com", "Pollich - Jacobs", "data engineer", "https://tad.org" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Murray-Smith8@yahoo.com", "Murray - Smith", "cyber security engineer", "https://lois.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "GreenLLC.Frami35@gmail.com", "Green LLC", "quality assurance Enginner", "http://jayda.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "KohlerGroup_Haley@yahoo.com", "Kohler Group", "computer networks engineer", "http://kennith.name" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "StrosinWunschandLabadie77@yahoo.com", "Strosin, Wunsch and Labadie", "http://doug.com" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Jaskolski-Wiza54@hotmail.com", "Jaskolski - Wiza", "quality assurance Enginner", "http://mariela.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "AbernathyLLC.Rice@gmail.com", "Abernathy LLC", "https://domenica.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Kovacek-Kohler_Dickinson@hotmail.com", "Kovacek - Kohler", "software engineer", "https://amanda.biz" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Bernhard-Jaskolski20@gmail.com", "Bernhard - Jaskolski", "cyber security engineer", "https://hosea.org" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "PourosandSons_Mante@hotmail.com", "Pouros and Sons", "quality assurance Enginner", "http://deshawn.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "BechtelarCarrollandStanton.Lowe@hotmail.com", "Bechtelar, Carroll and Stanton", "quality assurance Enginner", "https://kyleigh.name" });

            migrationBuilder.UpdateData(
                table: "LabSpaces",
                keyColumn: "LabSpaceId",
                keyValue: 21,
                column: "LabSpaceName",
                value: "Adriana");

            migrationBuilder.UpdateData(
                table: "LabSpaces",
                keyColumn: "LabSpaceId",
                keyValue: 22,
                column: "LabSpaceName",
                value: "Jensen");

            migrationBuilder.UpdateData(
                table: "LabSpaces",
                keyColumn: "LabSpaceId",
                keyValue: 23,
                column: "LabSpaceName",
                value: "Brook");

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
        }
    }
}
