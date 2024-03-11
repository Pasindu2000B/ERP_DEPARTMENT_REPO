using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class BookingLabEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "HartmannandSons_Roob19@yahoo.com", "Hartmann and Sons", "computer networks engineer", "http://enola.net" });

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
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "McClure-Baumbach_Morar14@hotmail.com", "McClure - Baumbach", "http://adrien.com" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "Klein-Bergstrom.Weimann@yahoo.com", "Klein - Bergstrom", "https://alphonso.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Schumm-Gaylord.Gleichner@gmail.com", "Schumm - Gaylord", "software engineer", "https://ola.org" });

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
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "YundtPagacandKihn.Okuneva@hotmail.com", "Yundt, Pagac and Kihn", "https://anissa.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "VonRueden-Champlin.Jerde37@hotmail.com", "VonRueden - Champlin", "data engineer", "http://rhiannon.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "ShanahanWalterandDonnelly.Ward68@hotmail.com", "Shanahan, Walter and Donnelly", "data engineer", "https://marianna.org" });

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
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "CasperHegmannandDietrich14@yahoo.com", "Casper, Hegmann and Dietrich", "https://kaleigh.com" });

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
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "BodeGroup.Carroll@yahoo.com", "Bode Group", "https://norwood.biz" });

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
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "BinsInc76@hotmail.com", "Bins Inc", "http://maeve.biz" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3001,
                columns: new[] { "LabEquipmentName", "LabSpaceId" },
                values: new object[] { "Bettie", 21 });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3002,
                columns: new[] { "LabEquipmentName", "LabSpaceId" },
                values: new object[] { "Orie", 21 });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3003,
                columns: new[] { "LabEquipmentName", "LabSpaceId" },
                values: new object[] { "Jade", 21 });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1001,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "5858 Dorcas Neck, New Camronport, France", "1-932-227-9493 x210", "Future", "Nico" });

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1002,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "19142 Judd Highway, North Calista, Togo", "998-989-7711", "Dynamic", "Adele" });

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1003,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "5768 Nienow Burgs, Hildaburgh, Kyrgyz Republic", "(527) 745-6867", "District", "Edgardo" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "GloverInc_Ondricka59@gmail.com", "Glover Inc", "software engineer", "http://stewart.biz" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "BaumbachWindlerandBecker_Beer9@yahoo.com", "Baumbach, Windler and Becker", "software engineer", "https://opal.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "CollierRueckerandOKeefe_Grant@gmail.com", "Collier, Ruecker and O'Keefe", "quality assurance Enginner", "http://elijah.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "JohnstonGroup90@gmail.com", "Johnston Group", "cyber security engineer", "http://martina.name" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "DAmoreandSons_Torp@gmail.com", "D'Amore and Sons", "software engineer", "http://verlie.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "WilliamsonStrosinandMurray.Batz93@gmail.com", "Williamson, Strosin and Murray", "computer networks engineer", "https://aimee.org" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "WunschBeattyandTurcotte_Jaskolski12@hotmail.com", "Wunsch, Beatty and Turcotte", "data engineer", "http://ronaldo.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "ManteandSons.Goodwin@yahoo.com", "Mante and Sons", "http://bessie.com" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "ReichelLoweandBeahan_Goldner51@hotmail.com", "Reichel, Lowe and Beahan", "http://angelica.biz" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "BalistreriMuellerandRice.Lesch@gmail.com", "Balistreri, Mueller and Rice", "computer networks engineer", "https://fleta.biz" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "KemmerLangworthandWilderman.Kautzer41@hotmail.com", "Kemmer, Langworth and Wilderman", "quality assurance Enginner", "https://jerrold.com" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Kling-DAmore.Gibson@yahoo.com", "Kling - D'Amore", "software engineer", "http://verna.com" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Gulgowski-Ferry69@gmail.com", "Gulgowski - Ferry", "data engineer", "http://evangeline.com" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "KshlerinJacobsonandRaynor_Kutch79@gmail.com", "Kshlerin, Jacobson and Raynor", "https://tomas.org" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Buckridge-Moore.Legros@yahoo.com", "Buckridge - Moore", "cyber security engineer", "https://davin.com" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "McKenzieandSons52@gmail.com", "McKenzie and Sons", "computer networks engineer", "http://kelvin.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "ChamplinOberbrunnerandMonahan43@gmail.com", "Champlin, Oberbrunner and Monahan", "software engineer", "http://penelope.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Flatley-Gerlach_Roob59@yahoo.com", "Flatley - Gerlach", "cyber security engineer", "https://mack.org" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "ManteLindgrenandQuitzon_Ward51@gmail.com", "Mante, Lindgren and Quitzon", "computer networks engineer", "http://sydney.org" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "FlatleyJohnsonandShanahan_Lang84@hotmail.com", "Flatley, Johnson and Shanahan", "computer networks engineer", "http://abraham.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "KrajcikHaneandCartwright.Sauer@hotmail.com", "Krajcik, Hane and Cartwright", "cyber security engineer", "https://marcus.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "KshlerinLLC73@yahoo.com", "Kshlerin LLC", "http://jovanny.com" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "DenesikNikolausandHilpert_Goldner@hotmail.com", "Denesik, Nikolaus and Hilpert", "quality assurance Enginner", "http://brice.name" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "KuhlmanMedhurstandLindgren_Medhurst6@gmail.com", "Kuhlman, Medhurst and Lindgren", "software engineer", "https://edna.org" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Goldner-Glover_Spencer@gmail.com", "Goldner - Glover", "data engineer", "http://adrian.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "DAmoreandSons_Graham95@gmail.com", "D'Amore and Sons", "computer networks engineer", "https://lonie.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Murray-Dicki.Block@gmail.com", "Murray - Dicki", "data engineer", "http://dejon.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "Larkin-Adams66@yahoo.com", "Larkin - Adams", "https://eveline.com" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "KulasInc.Lubowitz@gmail.com", "Kulas Inc", "software engineer", "http://jacynthe.biz" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "FramiNienowandBalistreri48@gmail.com", "Frami, Nienow and Balistreri", "http://gail.com" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3001,
                columns: new[] { "LabEquipmentName", "LabSpaceId" },
                values: new object[] { "Bridie", 0 });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3002,
                columns: new[] { "LabEquipmentName", "LabSpaceId" },
                values: new object[] { "Mikayla", 0 });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3003,
                columns: new[] { "LabEquipmentName", "LabSpaceId" },
                values: new object[] { "Coty", 0 });

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
                values: new object[] { "Maryse.Reinger93@hotmail.com", "Maryse", "Reinger", "EG/2023/3328" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Keenan_Wolff79@gmail.com", "Keenan", "Wolff", "EG/2023/3525" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Kieran_Treutel@gmail.com", "Kieran", "Treutel", "EG/2023/8192" });
        }
    }
}
