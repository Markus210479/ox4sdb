using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ox4sDatabase.Server.Migrations
{
    /// <inheritdoc />
    public partial class article : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Hersteller = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lieferant_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lieferant_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lieferant_3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lieferant_4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lieferant_5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lieferant_6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lieferant_7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PositionsName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KurzName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LangName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kategorie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HerstellerArtikelNummer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LieferantenArtikelNummer_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LieferantenArtikelNummer_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EinheitsPreis_1_Netto = table.Column<double>(type: "float", nullable: true),
                    EinheitsPreis_2_Netto = table.Column<double>(type: "float", nullable: true),
                    PE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VPE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Einheit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rabatt = table.Column<double>(type: "float", nullable: true),
                    RabattierterNettoPreis = table.Column<double>(type: "float", nullable: true),
                    AlternativArtikelNummer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VK_10 = table.Column<double>(type: "float", nullable: true),
                    VK_15 = table.Column<double>(type: "float", nullable: true),
                    VK_20 = table.Column<double>(type: "float", nullable: true),
                    Bemerkungen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InternerLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExternerLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hoehe = table.Column<double>(type: "float", nullable: true),
                    Breite = table.Column<double>(type: "float", nullable: true),
                    Tiefe = table.Column<double>(type: "float", nullable: true),
                    UmgebungstemperaturBetrieb = table.Column<double>(type: "float", nullable: true),
                    LieferZeit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LagerPlatz = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");
        }
    }
}
