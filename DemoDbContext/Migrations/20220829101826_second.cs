using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoDbContext.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdresseId",
                table: "Personnes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Adresse",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresse", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personnes_AdresseId",
                table: "Personnes",
                column: "AdresseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personnes_Adresse_AdresseId",
                table: "Personnes",
                column: "AdresseId",
                principalTable: "Adresse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personnes_Adresse_AdresseId",
                table: "Personnes");

            migrationBuilder.DropTable(
                name: "Adresse");

            migrationBuilder.DropIndex(
                name: "IX_Personnes_AdresseId",
                table: "Personnes");

            migrationBuilder.DropColumn(
                name: "AdresseId",
                table: "Personnes");
        }
    }
}
