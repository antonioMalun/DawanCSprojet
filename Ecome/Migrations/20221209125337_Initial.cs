using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecome.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Acteur",
                columns: table => new
                {
                    ActeurId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acteur", x => x.ActeurId);
                });

            migrationBuilder.CreateTable(
                name: "Auteur",
                columns: table => new
                {
                    AuteurId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auteur", x => x.AuteurId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    NomAutheurFilmeAuteurId = table.Column<int>(type: "int", nullable: true),
                    Titre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateSortie = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Films_Auteur_NomAutheurFilmeAuteurId",
                        column: x => x.NomAutheurFilmeAuteurId,
                        principalTable: "Auteur",
                        principalColumn: "AuteurId");
                });

            migrationBuilder.CreateTable(
                name: "Livres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuteurId = table.Column<int>(type: "int", nullable: true),
                    Titre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateSortie = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Livres_Auteur_AuteurId",
                        column: x => x.AuteurId,
                        principalTable: "Auteur",
                        principalColumn: "AuteurId");
                });

            migrationBuilder.CreateTable(
                name: "FilmActeurs",
                columns: table => new
                {
                    ActeurId = table.Column<int>(type: "int", nullable: false),
                    FilmId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmActeurs", x => new { x.ActeurId, x.FilmId });
                    table.ForeignKey(
                        name: "FK_FilmActeurs_Acteur_ActeurId",
                        column: x => x.ActeurId,
                        principalTable: "Acteur",
                        principalColumn: "ActeurId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmActeurs_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmUsers",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    FilmId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmUsers", x => new { x.UserId, x.FilmId });
                    table.ForeignKey(
                        name: "FK_FilmUsers_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LivreAuteurs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuteurId = table.Column<int>(type: "int", nullable: false),
                    LivreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LivreAuteurs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LivreAuteurs_Auteur_AuteurId",
                        column: x => x.AuteurId,
                        principalTable: "Auteur",
                        principalColumn: "AuteurId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LivreAuteurs_Livres_LivreId",
                        column: x => x.LivreId,
                        principalTable: "Livres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LivreUsers",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LivreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LivreUsers", x => new { x.UserId, x.LivreId });
                    table.ForeignKey(
                        name: "FK_LivreUsers_Livres_LivreId",
                        column: x => x.LivreId,
                        principalTable: "Livres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LivreUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FilmActeurs_FilmId",
                table: "FilmActeurs",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_Films_NomAutheurFilmeAuteurId",
                table: "Films",
                column: "NomAutheurFilmeAuteurId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmUsers_FilmId",
                table: "FilmUsers",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_LivreAuteurs_AuteurId",
                table: "LivreAuteurs",
                column: "AuteurId");

            migrationBuilder.CreateIndex(
                name: "IX_LivreAuteurs_LivreId",
                table: "LivreAuteurs",
                column: "LivreId");

            migrationBuilder.CreateIndex(
                name: "IX_Livres_AuteurId",
                table: "Livres",
                column: "AuteurId");

            migrationBuilder.CreateIndex(
                name: "IX_LivreUsers_LivreId",
                table: "LivreUsers",
                column: "LivreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmActeurs");

            migrationBuilder.DropTable(
                name: "FilmUsers");

            migrationBuilder.DropTable(
                name: "LivreAuteurs");

            migrationBuilder.DropTable(
                name: "LivreUsers");

            migrationBuilder.DropTable(
                name: "Acteur");

            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "Livres");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Auteur");
        }
    }
}
