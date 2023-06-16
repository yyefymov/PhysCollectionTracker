using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFDataHandlerLibrary.Migrations
{
    /// <inheritdoc />
    public partial class NewInitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CDs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    YearOfProduction = table.Column<int>(type: "INTEGER", nullable: false),
                    Artist = table.Column<string>(type: "TEXT", nullable: true),
                    Label = table.Column<string>(type: "TEXT", nullable: true),
                    YearOfRecording = table.Column<int>(type: "INTEGER", nullable: false),
                    ManufacturerCountry = table.Column<string>(type: "TEXT", nullable: true),
                    Tracklist = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CDs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SwitchGames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Developer = table.Column<string>(type: "TEXT", nullable: true),
                    Publisher = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Genre = table.Column<string>(type: "TEXT", nullable: true),
                    ESRBRating = table.Column<string>(type: "TEXT", nullable: true),
                    NumberOfPlayers = table.Column<int>(type: "INTEGER", nullable: false),
                    ProControllerCompatible = table.Column<bool>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    YearOfProduction = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SwitchGames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vinyls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Speed = table.Column<string>(type: "TEXT", nullable: false),
                    NumberOfLPs = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    YearOfProduction = table.Column<int>(type: "INTEGER", nullable: false),
                    Artist = table.Column<string>(type: "TEXT", nullable: true),
                    Label = table.Column<string>(type: "TEXT", nullable: true),
                    YearOfRecording = table.Column<int>(type: "INTEGER", nullable: false),
                    ManufacturerCountry = table.Column<string>(type: "TEXT", nullable: true),
                    Tracklist = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vinyls", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CDs");

            migrationBuilder.DropTable(
                name: "SwitchGames");

            migrationBuilder.DropTable(
                name: "Vinyls");
        }
    }
}
