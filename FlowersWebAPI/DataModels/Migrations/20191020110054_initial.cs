using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataModels.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Flowers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    LatinName = table.Column<string>(nullable: true),
                    TitleImage = table.Column<string>(nullable: true),
                    BloomTime = table.Column<string>(nullable: true),
                    Humidity = table.Column<string>(nullable: true),
                    Light = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flowers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    CreditCardNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Flowers",
                columns: new[] { "Id", "BloomTime", "Description", "Humidity", "LatinName", "Light", "Name", "Price", "TitleImage", "Type" },
                values: new object[] { 1, "summer", "A plant that lasts many years and is characterised by its big and beautiful flowers that can be in many vivid colours.", "low", "Gerbera Daisy", "sunlight", "Daisy", 120, "https://github.com/kristina-s/Frontend-project-resourses/blob/master/images/branch/title-imgs/daisy-title.jpg?raw=true", "Branch" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flowers");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
