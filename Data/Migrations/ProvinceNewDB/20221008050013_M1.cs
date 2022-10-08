using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace codeFirst.Data.Migrations.ProvinceNewDB
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Province",
                columns: table => new
                {
                    ProvinceCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProvinceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Province", x => x.ProvinceCode);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Population = table.Column<int>(type: "int", nullable: false),
                    ProvinceCode = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_City_Province_ProvinceCode",
                        column: x => x.ProvinceCode,
                        principalTable: "Province",
                        principalColumn: "ProvinceCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Province",
                columns: new[] { "ProvinceCode", "ProvinceName" },
                values: new object[,]
                {
                    { "AB", "Alberta" },
                    { "BC", "British Columbia" },
                    { "MB", "Manitoba" },
                    { "NB", "New Brunswick" },
                    { "NL", "Newfoundland and Labrador" },
                    { "NS", "Nova Scotia" },
                    { "NT", "Northwest Territories" },
                    { "NU", "Nunavut" },
                    { "ON", "Ontario" },
                    { "PE", "Prince Edward Island" },
                    { "QC", "Quebec" },
                    { "SK", "Saskatchewan" },
                    { "YT", "Yukon" }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityId", "CityName", "Population", "ProvinceCode" },
                values: new object[,]
                {
                    { 1, "Calgary", 1239220, "AB" },
                    { 2, "Edmonton", 979587, "AB" },
                    { 3, "Red Deer", 100418, "AB" },
                    { 4, "Vancouver", 631486, "BC" },
                    { 5, "Victoria", 367770, "BC" },
                    { 6, "Kelowna", 141767, "BC" },
                    { 7, "Winnipeg", 778489, "MB" },
                    { 8, "Brandon", 45935, "MB" },
                    { 9, "Steinbach", 13245, "MB" },
                    { 10, "Fredericton", 56250, "NB" },
                    { 11, "Moncton", 71227, "NB" },
                    { 12, "Saint John", 67074, "NB" },
                    { 13, "St. John's", 108792, "NL" },
                    { 14, "Corner Brook", 21420, "NL" },
                    { 15, "Grand Falls-Windsor", 11266, "NL" },
                    { 16, "Halifax", 403131, "NS" },
                    { 17, "Dartmouth", 103733, "NS" },
                    { 18, "Sydney", 35986, "NS" },
                    { 19, "Yellowknife", 19769, "NT" },
                    { 20, "Iqaluit", 6830, "NU" },
                    { 21, "Toronto", 2731571, "ON" },
                    { 22, "Ottawa", 934243, "ON" },
                    { 23, "Hamilton", 721053, "ON" },
                    { 24, "Charlottetown", 34579, "PE" },
                    { 25, "Quebec City", 531902, "QC" },
                    { 26, "Montreal", 1704694, "QC" },
                    { 27, "Regina", 236481, "SK" },
                    { 28, "Saskatoon", 255251, "SK" },
                    { 29, "Prince Albert", 35146, "SK" },
                    { 30, "Whitehorse", 24505, "YT" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_City_ProvinceCode",
                table: "City",
                column: "ProvinceCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Province");
        }
    }
}
