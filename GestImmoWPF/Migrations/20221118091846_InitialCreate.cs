﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GestImmoWPF.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Biens",
                columns: table => new
                {
                    BiensId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nom = table.Column<string>(type: "text", nullable: false),
                    Adresse = table.Column<string>(type: "text", nullable: false),
                    Valeur = table.Column<int>(type: "integer", nullable: false),
                    Surface = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Biens", x => x.BiensId);
                });

            migrationBuilder.CreateTable(
                name: "Contrat",
                columns: table => new
                {
                    ContratId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Loyer = table.Column<int>(type: "integer", nullable: false),
                    DateDebut = table.Column<string>(type: "text", nullable: false),
                    DateFin = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contrat", x => x.ContratId);
                });

            migrationBuilder.CreateTable(
                name: "Locataires",
                columns: table => new
                {
                    LocataireId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nom = table.Column<string>(type: "text", nullable: false),
                    Prenom = table.Column<string>(type: "text", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    Profession = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locataires", x => x.LocataireId);
                });

            migrationBuilder.CreateTable(
                name: "Prestataires",
                columns: table => new
                {
                    PrestataireId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RaisonSociale = table.Column<string>(type: "text", nullable: false),
                    Nom = table.Column<string>(type: "text", nullable: false),
                    Prenom = table.Column<string>(type: "text", nullable: false),
                    Telephone = table.Column<string>(type: "text", nullable: false),
                    Adresse = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestataires", x => x.PrestataireId);
                });

            migrationBuilder.CreateTable(
                name: "Prets",
                columns: table => new
                {
                    PretId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Apport = table.Column<int>(type: "integer", nullable: false),
                    Mensualite = table.Column<int>(type: "integer", nullable: false),
                    Duree = table.Column<int>(type: "integer", nullable: false),
                    DateDebut = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prets", x => x.PretId);
                });

            migrationBuilder.CreateTable(
                name: "Box",
                columns: table => new
                {
                    BiensId = table.Column<int>(type: "integer", nullable: false),
                    BoxId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Box", x => x.BiensId);
                    table.ForeignKey(
                        name: "FK_Box_Biens_BiensId",
                        column: x => x.BiensId,
                        principalTable: "Biens",
                        principalColumn: "BiensId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Habitable",
                columns: table => new
                {
                    BiensId = table.Column<int>(type: "integer", nullable: false),
                    HabitationsId = table.Column<int>(type: "integer", nullable: false),
                    NbPiece = table.Column<int>(type: "integer", nullable: false),
                    NbChambre = table.Column<int>(type: "integer", nullable: false),
                    Cave = table.Column<int>(type: "integer", nullable: false),
                    Parking = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habitable", x => x.BiensId);
                    table.ForeignKey(
                        name: "FK_Habitable_Biens_BiensId",
                        column: x => x.BiensId,
                        principalTable: "Biens",
                        principalColumn: "BiensId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Interventions",
                columns: table => new
                {
                    InterventionId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DateIntervention = table.Column<string>(type: "text", nullable: false),
                    MontantTTC = table.Column<int>(type: "integer", nullable: false),
                    Information = table.Column<string>(type: "text", nullable: false),
                    PrestataireId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interventions", x => x.InterventionId);
                    table.ForeignKey(
                        name: "FK_Interventions_Prestataires_PrestataireId",
                        column: x => x.PrestataireId,
                        principalTable: "Prestataires",
                        principalColumn: "PrestataireId");
                });

            migrationBuilder.CreateTable(
                name: "Apparetement",
                columns: table => new
                {
                    BiensId = table.Column<int>(type: "integer", nullable: false),
                    AppartmentId = table.Column<int>(type: "integer", nullable: false),
                    Etage = table.Column<int>(type: "integer", nullable: false),
                    Ascenseur = table.Column<bool>(type: "boolean", nullable: false),
                    Chauffage = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apparetement", x => x.BiensId);
                    table.ForeignKey(
                        name: "FK_Apparetement_Habitable_BiensId",
                        column: x => x.BiensId,
                        principalTable: "Habitable",
                        principalColumn: "BiensId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Maison",
                columns: table => new
                {
                    BiensId = table.Column<int>(type: "integer", nullable: false),
                    MaisonId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maison", x => x.BiensId);
                    table.ForeignKey(
                        name: "FK_Maison_Habitable_BiensId",
                        column: x => x.BiensId,
                        principalTable: "Habitable",
                        principalColumn: "BiensId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Interventions_PrestataireId",
                table: "Interventions",
                column: "PrestataireId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Apparetement");

            migrationBuilder.DropTable(
                name: "Box");

            migrationBuilder.DropTable(
                name: "Contrat");

            migrationBuilder.DropTable(
                name: "Interventions");

            migrationBuilder.DropTable(
                name: "Locataires");

            migrationBuilder.DropTable(
                name: "Maison");

            migrationBuilder.DropTable(
                name: "Prets");

            migrationBuilder.DropTable(
                name: "Prestataires");

            migrationBuilder.DropTable(
                name: "Habitable");

            migrationBuilder.DropTable(
                name: "Biens");
        }
    }
}
