using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIFizyo.Migrations
{
    public partial class onbir : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kullanıcılar",
                columns: table => new
                {
                    KullanıcıID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Eposta = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Şifre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RolID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanıcılar", x => x.KullanıcıID);
                });

            migrationBuilder.CreateTable(
                name: "Roller",
                columns: table => new
                {
                    RolID = table.Column<int>(type: "int", nullable: false),
                    RolAdı = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roller", x => x.RolID);
                });

            migrationBuilder.InsertData(
                table: "Kullanıcılar",
                columns: new[] { "KullanıcıID", "Eposta", "RolID", "Şifre" },
                values: new object[,]
                {
                    { 1, "sinan@outlook.com", 1, "Qwe123" },
                    { 2, "ali@hotmail.com", 1, "Qwe123" },
                    { 3, "mahmut@hotmail.com", 3, "Qwe123" },
                    { 4, "mansurkürşad@icloud.com", 2, "Qwe123" },
                    { 5, "gamze@gmail.com", 4, "Qwe123" },
                    { 6, "miraç@hotmail.com", 3, "Qwe123" },
                    { 7, "yücel@outlook.com", 1, "Qwe123" },
                    { 8, "kubilay@gmail.com", 4, "Qwe123" },
                    { 9, "hayati@hotmail.com", 3, "Qwe123" },
                    { 10, "bedriyemüge@hotmail.com", 2, "Qwe123" },
                    { 11, "birsen@icloud.com", 1, "Qwe123" },
                    { 12, "serdal@gmail.com", 2, "Qwe123" },
                    { 13, "bünyamin@gmail.com", 3, "Qwe123" },
                    { 14, "özgür@gmail.com", 2, "Qwe123" },
                    { 15, "ferdi@gmail.com", 1, "Qwe123" },
                    { 16, "reyhan@outlook.com", 2, "Qwe123" },
                    { 17, "ilhan@gmail.com", 2, "Qwe123" },
                    { 18, "gülşah@icloud.com", 4, "Qwe123" },
                    { 19, "nalan@outlook.com", 3, "Qwe123" },
                    { 20, "semih@outlook.com", 2, "Qwe123" },
                    { 21, "ergün@outlook.com", 1, "Qwe123" },
                    { 22, "fatih@hotmail.com", 3, "Qwe123" },
                    { 23, "şenay@gmail.com", 4, "Qwe123" },
                    { 24, "serkan@outlook.com", 4, "Qwe123" },
                    { 25, "emre@icloud.com", 4, "Qwe123" },
                    { 26, "bahattin@gmail.com", 4, "Qwe123" },
                    { 27, "irazca@gmail.com", 1, "Qwe123" },
                    { 28, "hatice@icloud.com", 3, "Qwe123" },
                    { 29, "bariş@icloud.com", 3, "Qwe123" },
                    { 30, "rezan@hotmail.com", 3, "Qwe123" },
                    { 31, "fatih@gmail.com", 2, "Qwe123" },
                    { 32, "fuat@outlook.com", 1, "Qwe123" },
                    { 33, "gökhan@icloud.com", 1, "Qwe123" },
                    { 34, "orhan@outlook.com", 4, "Qwe123" },
                    { 35, "mehmet@hotmail.com", 3, "Qwe123" },
                    { 36, "evren@hotmail.com", 3, "Qwe123" },
                    { 37, "oktay@gmail.com", 1, "Qwe123" },
                    { 38, "harun@gmail.com", 1, "Qwe123" },
                    { 39, "yavuz@hotmail.com", 4, "Qwe123" },
                    { 40, "pinar@hotmail.com", 4, "Qwe123" },
                    { 41, "mehmet@icloud.com", 2, "Qwe123" },
                    { 42, "umut@outlook.com", 2, "Qwe123" }
                });

            migrationBuilder.InsertData(
                table: "Kullanıcılar",
                columns: new[] { "KullanıcıID", "Eposta", "RolID", "Şifre" },
                values: new object[,]
                {
                    { 43, "mesude@hotmail.com", 4, "Qwe123" },
                    { 44, "hüseyincahit@gmail.com", 4, "Qwe123" },
                    { 45, "haşimonur@gmail.com", 2, "Qwe123" },
                    { 46, "eyyupsabri@gmail.com", 3, "Qwe123" },
                    { 47, "mustafa@icloud.com", 2, "Qwe123" },
                    { 48, "mustafa@icloud.com", 2, "Qwe123" },
                    { 49, "ufuk@icloud.com", 1, "Qwe123" },
                    { 50, "ahmetali@hotmail.com", 2, "Qwe123" },
                    { 51, "mediha@icloud.com", 2, "Qwe123" },
                    { 52, "hasan@icloud.com", 3, "Qwe123" },
                    { 53, "kamil@icloud.com", 3, "Qwe123" },
                    { 54, "nebi@icloud.com", 1, "Qwe123" },
                    { 55, "özcan@gmail.com", 4, "Qwe123" },
                    { 56, "nagihan@gmail.com", 3, "Qwe123" },
                    { 57, "ceren@gmail.com", 2, "Qwe123" },
                    { 58, "serkan@hotmail.com", 3, "Qwe123" },
                    { 59, "hasan@icloud.com", 3, "Qwe123" },
                    { 60, "yusufkenan@gmail.com", 4, "Qwe123" },
                    { 61, "çetin@icloud.com", 1, "Qwe123" },
                    { 62, "tarkan@gmail.com", 2, "Qwe123" },
                    { 63, "meralleman@hotmail.com", 2, "Qwe123" },
                    { 64, "ergün@icloud.com", 4, "Qwe123" },
                    { 65, "kenanahmet@icloud.com", 4, "Qwe123" },
                    { 66, "ural@icloud.com", 4, "Qwe123" },
                    { 67, "yahya@icloud.com", 2, "Qwe123" },
                    { 68, "bengü@outlook.com", 2, "Qwe123" },
                    { 69, "fatihnazmi@hotmail.com", 2, "Qwe123" },
                    { 70, "dilek@outlook.com", 1, "Qwe123" },
                    { 71, "mehmet@icloud.com", 1, "Qwe123" },
                    { 72, "tufanakin@hotmail.com", 4, "Qwe123" },
                    { 73, "mehmet@hotmail.com", 1, "Qwe123" },
                    { 74, "turgayyilmaz@icloud.com", 4, "Qwe123" },
                    { 75, "güldehen@icloud.com", 4, "Qwe123" },
                    { 76, "gökmen@hotmail.com", 2, "Qwe123" },
                    { 77, "bülent@gmail.com", 2, "Qwe123" },
                    { 78, "erol@icloud.com", 2, "Qwe123" },
                    { 79, "bahri@icloud.com", 1, "Qwe123" },
                    { 80, "özenözlem@gmail.com", 2, "Qwe123" },
                    { 81, "selma@icloud.com", 3, "Qwe123" },
                    { 82, "tuğsem@hotmail.com", 1, "Qwe123" },
                    { 83, "teslimenazli@gmail.com", 4, "Qwe123" },
                    { 84, "gülçin@hotmail.com", 3, "Qwe123" }
                });

            migrationBuilder.InsertData(
                table: "Kullanıcılar",
                columns: new[] { "KullanıcıID", "Eposta", "RolID", "Şifre" },
                values: new object[,]
                {
                    { 85, "ismail@icloud.com", 3, "Qwe123" },
                    { 86, "murat@gmail.com", 4, "Qwe123" },
                    { 87, "ebru@icloud.com", 2, "Qwe123" },
                    { 88, "tümay@gmail.com", 2, "Qwe123" },
                    { 89, "ahmet@gmail.com", 4, "Qwe123" },
                    { 90, "ebru@icloud.com", 2, "Qwe123" },
                    { 91, "hüseyinyavuz@gmail.com", 3, "Qwe123" },
                    { 92, "başak@outlook.com", 1, "Qwe123" },
                    { 93, "ayşegül@hotmail.com", 1, "Qwe123" },
                    { 94, "evrim@icloud.com", 4, "Qwe123" },
                    { 95, "yaser@hotmail.com", 3, "Qwe123" },
                    { 96, "ülkü@icloud.com", 3, "Qwe123" },
                    { 97, "özhan@icloud.com", 1, "Qwe123" },
                    { 98, "ufuk@gmail.com", 4, "Qwe123" },
                    { 99, "aksel@hotmail.com", 3, "Qwe123" },
                    { 100, "fulya@icloud.com", 3, "Qwe123" },
                    { 101, "burcu@icloud.com", 3, "Qwe123" },
                    { 102, "taylan@hotmail.com", 4, "Qwe123" },
                    { 103, "yilmaz@icloud.com", 2, "Qwe123" },
                    { 104, "zeynep@gmail.com", 4, "Qwe123" },
                    { 105, "bayram@icloud.com", 3, "Qwe123" },
                    { 106, "gülay@hotmail.com", 3, "Qwe123" },
                    { 107, "rabia@outlook.com", 1, "Qwe123" },
                    { 108, "sevda@outlook.com", 2, "Qwe123" },
                    { 109, "serhat@hotmail.com", 2, "Qwe123" },
                    { 110, "engin@icloud.com", 3, "Qwe123" },
                    { 111, "asli@hotmail.com", 2, "Qwe123" },
                    { 112, "tuba@icloud.com", 2, "Qwe123" },
                    { 113, "bariş@hotmail.com", 4, "Qwe123" },
                    { 114, "sevgi@hotmail.com", 4, "Qwe123" },
                    { 115, "kalender@outlook.com", 3, "Qwe123" },
                    { 116, "halil@icloud.com", 4, "Qwe123" },
                    { 117, "bilge@icloud.com", 1, "Qwe123" },
                    { 118, "ferda@gmail.com", 4, "Qwe123" },
                    { 119, "ezgi@hotmail.com", 2, "Qwe123" },
                    { 120, "aysun@outlook.com", 4, "Qwe123" }
                });

            migrationBuilder.InsertData(
                table: "Roller",
                columns: new[] { "RolID", "RolAdı" },
                values: new object[,]
                {
                    { 1, "UserCandidate" },
                    { 2, "UserNormal" },
                    { 3, "Admin" },
                    { 4, "Supervisor" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kullanıcılar");

            migrationBuilder.DropTable(
                name: "Roller");
        }
    }
}
