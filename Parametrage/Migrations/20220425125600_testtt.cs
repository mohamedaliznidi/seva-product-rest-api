using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parametrage.Migrations
{
    public partial class testtt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActeFamilles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActeFamilleId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActeFamilles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActeFamilles_ActeFamilles_ActeFamilleId",
                        column: x => x.ActeFamilleId,
                        principalTable: "ActeFamilles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Commissionnements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commissionnements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InfoComp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfoComp", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Intervenants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Intervenants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Risques",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Risques", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeColleges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeColleges", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Zones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Actes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActeFamilleId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Actes_ActeFamilles_ActeFamilleId",
                        column: x => x.ActeFamilleId,
                        principalTable: "ActeFamilles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ValeurInfoComp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valeur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InfoCompId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValeurInfoComp", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ValeurInfoComp_InfoComp_InfoCompId",
                        column: x => x.InfoCompId,
                        principalTable: "InfoComp",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Devise",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdPays = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devise", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Devise_Pays_IdPays",
                        column: x => x.IdPays,
                        principalTable: "Pays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Colleges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeCollegeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colleges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Colleges_TypeColleges_TypeCollegeId",
                        column: x => x.TypeCollegeId,
                        principalTable: "TypeColleges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "PaysZone",
                columns: table => new
                {
                    PaysId = table.Column<int>(type: "int", nullable: false),
                    ZonesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaysZone", x => new { x.PaysId, x.ZonesId });
                    table.ForeignKey(
                        name: "FK_PaysZone_Pays_PaysId",
                        column: x => x.PaysId,
                        principalTable: "Pays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PaysZone_Zones_ZonesId",
                        column: x => x.ZonesId,
                        principalTable: "Zones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "RegleCalculs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    ZoneId = table.Column<int>(type: "int", nullable: false),
                    TypeCotisant = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegleCalculs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegleCalculs_Zones_ZoneId",
                        column: x => x.ZoneId,
                        principalTable: "Zones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Produits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LibelleCommercial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateEffet = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Enseigne = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GestionPrestation = table.Column<bool>(type: "bit", nullable: false),
                    GestionCotisation = table.Column<bool>(type: "bit", nullable: false),
                    IdDevise = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produits_Devise_IdDevise",
                        column: x => x.IdDevise,
                        principalTable: "Devise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "RegleInfoComp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InfoCompId = table.Column<int>(type: "int", nullable: false),
                    Valeur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegleCalculId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegleInfoComp", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegleInfoComp_InfoComp_InfoCompId",
                        column: x => x.InfoCompId,
                        principalTable: "InfoComp",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_RegleInfoComp_RegleCalculs_RegleCalculId",
                        column: x => x.RegleCalculId,
                        principalTable: "RegleCalculs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProduitRisque",
                columns: table => new
                {
                    ProduitsId = table.Column<int>(type: "int", nullable: false),
                    RisquesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProduitRisque", x => new { x.ProduitsId, x.RisquesId });
                    table.ForeignKey(
                        name: "FK_ProduitRisque_Produits_ProduitsId",
                        column: x => x.ProduitsId,
                        principalTable: "Produits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProduitRisque_Risques_RisquesId",
                        column: x => x.RisquesId,
                        principalTable: "Risques",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ProduitZone",
                columns: table => new
                {
                    ProduitsId = table.Column<int>(type: "int", nullable: false),
                    ZonesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProduitZone", x => new { x.ProduitsId, x.ZonesId });
                    table.ForeignKey(
                        name: "FK_ProduitZone_Produits_ProduitsId",
                        column: x => x.ProduitsId,
                        principalTable: "Produits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProduitZone_Zones_ZonesId",
                        column: x => x.ZonesId,
                        principalTable: "Zones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "SousProduits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LibelleCommercial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateEffet = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Enseigne = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GestionPrestation = table.Column<bool>(type: "bit", nullable: false),
                    GestionCotisation = table.Column<bool>(type: "bit", nullable: false),
                    IdDevise = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProduitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SousProduits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SousProduits_Devise_IdDevise",
                        column: x => x.IdDevise,
                        principalTable: "Devise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SousProduits_Produits_ProduitId",
                        column: x => x.ProduitId,
                        principalTable: "Produits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Garanties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LibelleCommercial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateEffet = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Enseigne = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GestionPrestation = table.Column<bool>(type: "bit", nullable: false),
                    GestionCotisation = table.Column<bool>(type: "bit", nullable: false),
                    IdDevise = table.Column<int>(type: "int", nullable: false),
                    SousProduitId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Garanties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Garanties_Devise_IdDevise",
                        column: x => x.IdDevise,
                        principalTable: "Devise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Garanties_SousProduits_SousProduitId",
                        column: x => x.SousProduitId,
                        principalTable: "SousProduits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "RisqueSousProduit",
                columns: table => new
                {
                    RisquesId = table.Column<int>(type: "int", nullable: false),
                    SousProduitsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RisqueSousProduit", x => new { x.RisquesId, x.SousProduitsId });
                    table.ForeignKey(
                        name: "FK_RisqueSousProduit_Risques_RisquesId",
                        column: x => x.RisquesId,
                        principalTable: "Risques",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_RisqueSousProduit_SousProduits_SousProduitsId",
                        column: x => x.SousProduitsId,
                        principalTable: "SousProduits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "SousProduitZone",
                columns: table => new
                {
                    SousProduitsId = table.Column<int>(type: "int", nullable: false),
                    ZonesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SousProduitZone", x => new { x.SousProduitsId, x.ZonesId });
                    table.ForeignKey(
                        name: "FK_SousProduitZone_SousProduits_SousProduitsId",
                        column: x => x.SousProduitsId,
                        principalTable: "SousProduits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SousProduitZone_Zones_ZonesId",
                        column: x => x.ZonesId,
                        principalTable: "Zones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "GarantieRisque",
                columns: table => new
                {
                    GarantiesId = table.Column<int>(type: "int", nullable: false),
                    RisquesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GarantieRisque", x => new { x.GarantiesId, x.RisquesId });
                    table.ForeignKey(
                        name: "FK_GarantieRisque_Garanties_GarantiesId",
                        column: x => x.GarantiesId,
                        principalTable: "Garanties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_GarantieRisque_Risques_RisquesId",
                        column: x => x.RisquesId,
                        principalTable: "Risques",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "GarantieZone",
                columns: table => new
                {
                    GarantiesId = table.Column<int>(type: "int", nullable: false),
                    ZonesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GarantieZone", x => new { x.GarantiesId, x.ZonesId });
                    table.ForeignKey(
                        name: "FK_GarantieZone_Garanties_GarantiesId",
                        column: x => x.GarantiesId,
                        principalTable: "Garanties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_GarantieZone_Zones_ZonesId",
                        column: x => x.ZonesId,
                        principalTable: "Zones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActeFamilles_ActeFamilleId",
                table: "ActeFamilles",
                column: "ActeFamilleId");

            migrationBuilder.CreateIndex(
                name: "IX_Actes_ActeFamilleId",
                table: "Actes",
                column: "ActeFamilleId");

            migrationBuilder.CreateIndex(
                name: "IX_Colleges_TypeCollegeId",
                table: "Colleges",
                column: "TypeCollegeId");

            migrationBuilder.CreateIndex(
                name: "IX_Devise_IdPays",
                table: "Devise",
                column: "IdPays",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GarantieRisque_RisquesId",
                table: "GarantieRisque",
                column: "RisquesId");

            migrationBuilder.CreateIndex(
                name: "IX_Garanties_IdDevise",
                table: "Garanties",
                column: "IdDevise");

            migrationBuilder.CreateIndex(
                name: "IX_Garanties_SousProduitId",
                table: "Garanties",
                column: "SousProduitId");

            migrationBuilder.CreateIndex(
                name: "IX_GarantieZone_ZonesId",
                table: "GarantieZone",
                column: "ZonesId");

            migrationBuilder.CreateIndex(
                name: "IX_PaysZone_ZonesId",
                table: "PaysZone",
                column: "ZonesId");

            migrationBuilder.CreateIndex(
                name: "IX_ProduitRisque_RisquesId",
                table: "ProduitRisque",
                column: "RisquesId");

            migrationBuilder.CreateIndex(
                name: "IX_Produits_IdDevise",
                table: "Produits",
                column: "IdDevise");

            migrationBuilder.CreateIndex(
                name: "IX_ProduitZone_ZonesId",
                table: "ProduitZone",
                column: "ZonesId");

            migrationBuilder.CreateIndex(
                name: "IX_RegleCalculs_ZoneId",
                table: "RegleCalculs",
                column: "ZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_RegleInfoComp_InfoCompId",
                table: "RegleInfoComp",
                column: "InfoCompId");

            migrationBuilder.CreateIndex(
                name: "IX_RegleInfoComp_RegleCalculId",
                table: "RegleInfoComp",
                column: "RegleCalculId");

            migrationBuilder.CreateIndex(
                name: "IX_RisqueSousProduit_SousProduitsId",
                table: "RisqueSousProduit",
                column: "SousProduitsId");

            migrationBuilder.CreateIndex(
                name: "IX_SousProduits_IdDevise",
                table: "SousProduits",
                column: "IdDevise");

            migrationBuilder.CreateIndex(
                name: "IX_SousProduits_ProduitId",
                table: "SousProduits",
                column: "ProduitId");

            migrationBuilder.CreateIndex(
                name: "IX_SousProduitZone_ZonesId",
                table: "SousProduitZone",
                column: "ZonesId");

            migrationBuilder.CreateIndex(
                name: "IX_ValeurInfoComp_InfoCompId",
                table: "ValeurInfoComp",
                column: "InfoCompId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Actes");

            migrationBuilder.DropTable(
                name: "Colleges");

            migrationBuilder.DropTable(
                name: "Commissionnements");

            migrationBuilder.DropTable(
                name: "GarantieRisque");

            migrationBuilder.DropTable(
                name: "GarantieZone");

            migrationBuilder.DropTable(
                name: "Intervenants");

            migrationBuilder.DropTable(
                name: "PaysZone");

            migrationBuilder.DropTable(
                name: "ProduitRisque");

            migrationBuilder.DropTable(
                name: "ProduitZone");

            migrationBuilder.DropTable(
                name: "RegleInfoComp");

            migrationBuilder.DropTable(
                name: "RisqueSousProduit");

            migrationBuilder.DropTable(
                name: "SousProduitZone");

            migrationBuilder.DropTable(
                name: "ValeurInfoComp");

            migrationBuilder.DropTable(
                name: "ActeFamilles");

            migrationBuilder.DropTable(
                name: "TypeColleges");

            migrationBuilder.DropTable(
                name: "Garanties");

            migrationBuilder.DropTable(
                name: "RegleCalculs");

            migrationBuilder.DropTable(
                name: "Risques");

            migrationBuilder.DropTable(
                name: "InfoComp");

            migrationBuilder.DropTable(
                name: "SousProduits");

            migrationBuilder.DropTable(
                name: "Zones");

            migrationBuilder.DropTable(
                name: "Produits");

            migrationBuilder.DropTable(
                name: "Devise");

            migrationBuilder.DropTable(
                name: "Pays");
        }
    }
}
