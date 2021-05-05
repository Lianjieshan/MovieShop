using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class CreatingMovieTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Genres",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Overview = table.Column<string>(type: "nvarchar(max)", maxLength: 4096, nullable: true),
                    Tagline = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Budget = table.Column<decimal>(type: "decimal(18,4)", nullable: true, defaultValue: 9.9m),
                    Revenue = table.Column<decimal>(type: "decimal(18,4)", nullable: true, defaultValue: 9.9m),
                    ImdbUrl = table.Column<string>(type: "nvarchar(2084)", maxLength: 2084, nullable: true),
                    TmdbUrl = table.Column<string>(type: "nvarchar(2084)", maxLength: 2084, nullable: true),
                    PosterUrl = table.Column<string>(type: "nvarchar(2084)", maxLength: 2084, nullable: true),
                    BackdropUrl = table.Column<string>(type: "nvarchar(2084)", maxLength: 2084, nullable: true),
                    OriginalLanguage = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RunTime = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(5,2)", nullable: true, defaultValue: 9.9m),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "getdate()"),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Genres_MovieId",
                table: "Genres",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Genres_Movie_MovieId",
                table: "Genres",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Genres_Movie_MovieId",
                table: "Genres");

            migrationBuilder.DropTable(
                name: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Genres_MovieId",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Genres");
        }
    }
}
