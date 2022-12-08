using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecome.Migrations
{
    /// <inheritdoc />
    public partial class Users : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Livres",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Films",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Livres_UserId",
                table: "Livres",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Films_UserId",
                table: "Films",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Films_Users_UserId",
                table: "Films",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Livres_Users_UserId",
                table: "Livres",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Films_Users_UserId",
                table: "Films");

            migrationBuilder.DropForeignKey(
                name: "FK_Livres_Users_UserId",
                table: "Livres");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Livres_UserId",
                table: "Livres");

            migrationBuilder.DropIndex(
                name: "IX_Films_UserId",
                table: "Films");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Livres");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Films");
        }
    }
}
