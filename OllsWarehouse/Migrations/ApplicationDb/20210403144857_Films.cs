using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OllsWarehouse.Migrations.ApplicationDb
{
    public partial class Films : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    movieID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    movieTitle = table.Column<string>(type: "varchar(100)", nullable: false),
                    movieCertificate = table.Column<string>(type: "varchar(5)", nullable: true),
                    movieDescription = table.Column<string>(type: "text", nullable: true),
                    movieImage = table.Column<string>(type: "varchar(100)", nullable: true),
                    moviePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stars = table.Column<int>(type: "int", nullable: false),
                    movieReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    movieTrailer = table.Column<string>(type: "varchar(100)", nullable: true),
                    movieGenre = table.Column<string>(type: "varchar(100)", nullable: true),
                    movieBackgroundImage = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.movieID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Films");
        }
    }
}
