using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class day5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1001,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "70091 Janie Crescent, Myastad, Austria", "1-272-848-0895 x2501", "International", "Lois" });

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1002,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "65419 Dietrich Cove, Lake Kristastad, Canada", "290-889-4403", "Product", "Earnest" });

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1003,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "93047 Heathcote Pine, Lake Johanshire, Russian Federation", "(275) 612-3803 x74727", "Chief", "Velma" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "MillsInc87@gmail.com", "Mills Inc", "quality assurance Enginner", "https://mary.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "NaderLLC_Streich77@yahoo.com", "Nader LLC", "cyber security engineer", "http://alvina.biz" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "SchinnerandSons56@gmail.com", "Schinner and Sons", "computer networks engineer", "http://mark.com" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "GorczanyKlingandGottlieb31@hotmail.com", "Gorczany, Kling and Gottlieb", "software engineer", "http://marlon.com" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "TreutelLLC47@gmail.com", "Treutel LLC", "cyber security engineer", "http://molly.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Predovic-OReilly.Beahan@yahoo.com", "Predovic - O'Reilly", "quality assurance Enginner", "https://reta.name" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "LemkeLLC_Davis@yahoo.com", "Lemke LLC", "computer networks engineer", "http://darrin.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "GutmannLLC.Rogahn@gmail.com", "Gutmann LLC", "software engineer", "http://lesley.org" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "CormierLLC73@hotmail.com", "Cormier LLC", "quality assurance Enginner", "http://pansy.org" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "KoelpinMurphyandReichel.Stark10@gmail.com", "Koelpin, Murphy and Reichel", "quality assurance Enginner", "http://boyd.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "HermistonInc.Padberg57@yahoo.com", "Hermiston Inc", "cyber security engineer", "https://jewell.biz" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "SimonisWisokyandOReilly12@yahoo.com", "Simonis, Wisoky and O'Reilly", "http://oleta.name" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "SengerGroup97@yahoo.com", "Senger Group", "https://tiara.com" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "CarterLLC28@hotmail.com", "Carter LLC", "computer networks engineer", "http://leda.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Streich-Kerluke.DAmore6@gmail.com", "Streich - Kerluke", "software engineer", "http://mabel.com" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Yost-Stoltenberg84@hotmail.com", "Yost - Stoltenberg", "quality assurance Enginner", "http://chance.name" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "LednerStoltenbergandOsinski64@yahoo.com", "Ledner, Stoltenberg and Osinski", "quality assurance Enginner", "http://kieran.com" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "LittelInc21@hotmail.com", "Littel Inc", "computer networks engineer", "http://leonel.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "RunolfssonHeaneyandSchuster.McClure@yahoo.com", "Runolfsson, Heaney and Schuster", "quality assurance Enginner", "http://gay.org" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "Mayer-Boehm_Medhurst13@gmail.com", "Mayer - Boehm", "http://elody.com" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "BoyerSchneiderandWalker29@yahoo.com", "Boyer, Schneider and Walker", "https://scarlett.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "HayesDanielandSawayn12@hotmail.com", "Hayes, Daniel and Sawayn", "computer networks engineer", "http://eldora.name" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "Predovic-Corkery.Hilpert@gmail.com", "Predovic - Corkery", "https://garrison.org" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "RoweGroup81@gmail.com", "Rowe Group", "data engineer", "https://everett.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "Hand-Aufderhar_Marquardt64@yahoo.com", "Hand - Aufderhar", "https://ali.org" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "DareInc_Keeling@yahoo.com", "Dare Inc", "cyber security engineer", "http://liza.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "PaucekInc38@gmail.com", "Paucek Inc", "http://sedrick.com" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "FeilKutchandBeatty_Hahn39@hotmail.com", "Feil, Kutch and Beatty", "quality assurance Enginner", "http://kayla.name" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "LueilwitzWunschandSchinner95@gmail.com", "Lueilwitz, Wunsch and Schinner", "cyber security engineer", "http://rickie.org" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "HagenesLLC11@hotmail.com", "Hagenes LLC", "cyber security engineer", "http://isac.org" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3001,
                columns: new[] { "LabEquipmentName", "condition" },
                values: new object[] { "Patrick", "bad" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3002,
                columns: new[] { "LabEquipmentName", "condition" },
                values: new object[] { "Laney", "bad" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3003,
                columns: new[] { "LabEquipmentName", "condition" },
                values: new object[] { "Adela", "medium" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Gino.Bradtke@hotmail.com", "Gino", "Bradtke", "EG/2020/3688" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Mitchel.Windler98@gmail.com", "Mitchel", "Windler", "EG/2021/5263" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Harmony_Hayes8@gmail.com", "Harmony", "Hayes", "EG/2023/2774" });
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
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "ManteandSons.Goodwin@yahoo.com", "Mante and Sons", "cyber security engineer", "http://bessie.com" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "ReichelLoweandBeahan_Goldner51@hotmail.com", "Reichel, Lowe and Beahan", "data engineer", "http://angelica.biz" });

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
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "Kling-DAmore.Gibson@yahoo.com", "Kling - D'Amore", "http://verna.com" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "Gulgowski-Ferry69@gmail.com", "Gulgowski - Ferry", "http://evangeline.com" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "KshlerinJacobsonandRaynor_Kutch79@gmail.com", "Kshlerin, Jacobson and Raynor", "quality assurance Enginner", "https://tomas.org" });

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
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "FlatleyJohnsonandShanahan_Lang84@hotmail.com", "Flatley, Johnson and Shanahan", "http://abraham.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "KrajcikHaneandCartwright.Sauer@hotmail.com", "Krajcik, Hane and Cartwright", "https://marcus.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "KshlerinLLC73@yahoo.com", "Kshlerin LLC", "software engineer", "http://jovanny.com" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "DenesikNikolausandHilpert_Goldner@hotmail.com", "Denesik, Nikolaus and Hilpert", "http://brice.name" });

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
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "Goldner-Glover_Spencer@gmail.com", "Goldner - Glover", "http://adrian.info" });

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
                columns: new[] { "CompanyEmail", "CompanyName", "JobDescriptionLink" },
                values: new object[] { "Murray-Dicki.Block@gmail.com", "Murray - Dicki", "http://dejon.net" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "Larkin-Adams66@yahoo.com", "Larkin - Adams", "computer networks engineer", "https://eveline.com" });

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
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "FramiNienowandBalistreri48@gmail.com", "Frami, Nienow and Balistreri", "computer networks engineer", "http://gail.com" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3001,
                columns: new[] { "LabEquipmentName", "condition" },
                values: new object[] { "Bridie", "medium" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3002,
                columns: new[] { "LabEquipmentName", "condition" },
                values: new object[] { "Mikayla", "medium" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3003,
                columns: new[] { "LabEquipmentName", "condition" },
                values: new object[] { "Coty", "bad" });

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
