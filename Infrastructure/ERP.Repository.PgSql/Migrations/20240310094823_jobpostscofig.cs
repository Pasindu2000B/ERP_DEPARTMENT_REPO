using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class jobpostscofig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateName" },
                values: new object[] { "971 Grady Springs, Veumfort, Grenada", "272-897-9194 x479", "Baby" });

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

            migrationBuilder.InsertData(
                table: "JobPosts",
                columns: new[] { "Id", "Category", "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[,]
                {
                    { 104, "computer Engineering", "Rogahn-Huels.Pollich18@hotmail.com", "Rogahn - Huels", "software engineer", "http://baby.net" },
                    { 105, "computer Engineering", "McCulloughUllrichandFunk_Moen@hotmail.com", "McCullough, Ullrich and Funk", "data engineer", "http://robin.info" },
                    { 106, "computer Engineering", "RitchieBeckerandWehner_Bins@gmail.com", "Ritchie, Becker and Wehner", "cyber security engineer", "https://kamryn.biz" },
                    { 107, "computer Engineering", "DAmoreGroup.Bednar33@yahoo.com", "D'Amore Group", "data engineer", "https://amber.name" },
                    { 108, "computer Engineering", "GutmannThielandWelch82@hotmail.com", "Gutmann, Thiel and Welch", "quality assurance Enginner", "http://vivian.org" },
                    { 109, "computer Engineering", "WisokyGroup76@yahoo.com", "Wisoky Group", "computer networks engineer", "http://libbie.net" },
                    { 110, "computer Engineering", "Langworth-Johnston.Weimann33@gmail.com", "Langworth - Johnston", "cyber security engineer", "https://hermann.org" },
                    { 111, "computer Engineering", "AufderharandSons_Windler@yahoo.com", "Aufderhar and Sons", "quality assurance Enginner", "http://jessie.info" },
                    { 112, "computer Engineering", "Shields-Trantow_Lesch@hotmail.com", "Shields - Trantow", "quality assurance Enginner", "http://floyd.com" },
                    { 113, "computer Engineering", "KossLLC_Thompson@hotmail.com", "Koss LLC", "quality assurance Enginner", "http://ismael.net" },
                    { 114, "computer Engineering", "Koss-Ondricka.Prosacco@hotmail.com", "Koss - Ondricka", "computer networks engineer", "https://allen.name" },
                    { 115, "computer Engineering", "WhiteHagenesandSpinka74@hotmail.com", "White, Hagenes and Spinka", "computer networks engineer", "https://vidal.name" },
                    { 116, "computer Engineering", "GreenholtHowellandHomenick77@hotmail.com", "Greenholt, Howell and Homenick", "cyber security engineer", "https://ozella.net" },
                    { 117, "computer Engineering", "WolffWelchandKulas_Zboncak71@gmail.com", "Wolff, Welch and Kulas", "computer networks engineer", "https://chandler.name" },
                    { 118, "computer Engineering", "SchmidtKingandWuckert.Parisian80@hotmail.com", "Schmidt, King and Wuckert", "software engineer", "https://leonel.biz" },
                    { 119, "computer Engineering", "Tremblay-Kautzer86@hotmail.com", "Tremblay - Kautzer", "quality assurance Enginner", "https://tremayne.com" },
                    { 120, "computer Engineering", "Keeling-Hackett_Terry18@hotmail.com", "Keeling - Hackett", "computer networks engineer", "http://cruz.biz" },
                    { 121, "computer Engineering", "Wiegand-Barton.Kulas@gmail.com", "Wiegand - Barton", "software engineer", "http://brennon.biz" },
                    { 122, "computer Engineering", "KrajcikandSons.Zboncak@gmail.com", "Krajcik and Sons", "quality assurance Enginner", "https://andy.net" },
                    { 123, "computer Engineering", "Braun-Prosacco.Murazik12@gmail.com", "Braun - Prosacco", "quality assurance Enginner", "http://gregorio.info" },
                    { 124, "computer Engineering", "KlockoBlockandOKon.Kassulke@yahoo.com", "Klocko, Block and O'Kon", "data engineer", "http://jules.info" },
                    { 125, "computer Engineering", "Stracke-Adams_Herzog24@yahoo.com", "Stracke - Adams", "data engineer", "http://lucas.name" },
                    { 126, "computer Engineering", "HaleyLefflerandCole.Wolff@gmail.com", "Haley, Leffler and Cole", "computer networks engineer", "https://darius.net" },
                    { 127, "computer Engineering", "MullerJonesandGoldner.Veum42@gmail.com", "Muller, Jones and Goldner", "cyber security engineer", "http://drew.biz" },
                    { 128, "computer Engineering", "BashirianRempelandBarrows.King@gmail.com", "Bashirian, Rempel and Barrows", "data engineer", "http://hulda.org" },
                    { 129, "computer Engineering", "RiceHarberandSchuppe80@gmail.com", "Rice, Harber and Schuppe", "quality assurance Enginner", "https://darrick.name" },
                    { 130, "computer Engineering", "BergeConnandPadberg_Jast74@gmail.com", "Berge, Conn and Padberg", "cyber security engineer", "https://brandyn.info" }
                });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3001,
                columns: new[] { "LabEquipmentName", "condition" },
                values: new object[] { "Jovan", "medium" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3002,
                column: "LabEquipmentName",
                value: "Kiana");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 130);

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
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateName" },
                values: new object[] { "307 Ryder Terrace, Towneland, Tuvalu", "(270) 442-7806", "Shanelle" });

            migrationBuilder.UpdateData(
                table: "Graduates",
                keyColumn: "GraduateID",
                keyValue: 1003,
                columns: new[] { "GraduateCompany", "GraduateContactNo", "GraduateDescription", "GraduateName" },
                values: new object[] { "000 Kihn Orchard, East Othaport, Anguilla", "544.352.0044", "Corporate", "Imani" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "GreenholtRohanandStoltenberg.Rempel@gmail.com", "Greenholt, Rohan and Stoltenberg", "data engineer", "http://iliana.com" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "PaucekSpencerandProsacco_Botsford37@gmail.com", "Paucek, Spencer and Prosacco", "quality assurance Enginner", "https://brant.info" });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CompanyEmail", "CompanyName", "InternPosition", "JobDescriptionLink" },
                values: new object[] { "RomagueraEffertzandTorp_Hoeger20@gmail.com", "Romaguera, Effertz and Torp", "cyber security engineer", "http://lyric.info" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3001,
                columns: new[] { "LabEquipmentName", "condition" },
                values: new object[] { "Nikolas", "bad" });

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3002,
                column: "LabEquipmentName",
                value: "Else");

            migrationBuilder.UpdateData(
                table: "LabEquipments",
                keyColumn: "LabEquipmentID",
                keyValue: 3003,
                columns: new[] { "LabEquipmentName", "condition" },
                values: new object[] { "Curt", "bad" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Amy.Cole8@hotmail.com", "Amy", "Weimann", "EG/2020/7328" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Preston_Gaylord@yahoo.com", "Preston", "Littel", "EG/2020/1508" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Julia_Robel@yahoo.com", "Julia", "Stark", "EG/2021/3654" });
        }
    }
}
