using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleDeVacina.Data.Migrations
{
    public partial class estruturainicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.CreateTable(
                name: "Vacina",
                columns: table => new
                {
                    Id_Vacina = table.Column<Guid>(nullable: false),
                    Doses_Necessarias = table.Column<int>(nullable: false),
                    Dt_Atualizacao = table.Column<DateTime>(nullable: false),
                    Dt_Criacao = table.Column<DateTime>(nullable: false),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacina", x => x.Id_Vacina);
                });

            migrationBuilder.CreateTable(
                name: "Usuario_Vacina",
                columns: table => new
                {
                    Id_Usuario_Vacina = table.Column<Guid>(nullable: false),
                    Id_Vacina = table.Column<Guid>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario_Vacina", x => x.Id_Usuario_Vacina);
                    table.ForeignKey(
                        name: "FK_Usuario_Vacina_Vacina_Id_Vacina",
                        column: x => x.Id_Vacina,
                        principalTable: "Vacina",
                        principalColumn: "Id_Vacina",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usuario_Vacina_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Agenda",
                columns: table => new
                {
                    Id_Agenda_Usuario = table.Column<Guid>(nullable: false),
                    Dt_Agendamento = table.Column<string>(nullable: true),
                    Id_Usuario_Vacina = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agenda", x => x.Id_Agenda_Usuario);
                    table.ForeignKey(
                        name: "FK_Agenda_Usuario_Vacina_Id_Usuario_Vacina",
                        column: x => x.Id_Usuario_Vacina,
                        principalTable: "Usuario_Vacina",
                        principalColumn: "Id_Usuario_Vacina",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Agenda_Id_Usuario_Vacina",
                table: "Agenda",
                column: "Id_Usuario_Vacina");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Vacina_Id_Vacina",
                table: "Usuario_Vacina",
                column: "Id_Vacina");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Vacina_UserId",
                table: "Usuario_Vacina",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agenda");

            migrationBuilder.DropTable(
                name: "Usuario_Vacina");

            migrationBuilder.DropTable(
                name: "Vacina");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName");
        }
    }
}
