using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Migrations
{
    public partial class Fenacon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ferias",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataInicio = table.Column<DateTime>(type: "dateTime", nullable: false),
                    DataFim = table.Column<DateTime>(type: "dateTime", nullable: false),
                    PeriodoAquisitivo = table.Column<DateTime>(type: "dateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ferias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Supervisores",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(type: "varchar(40)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supervisores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    NomeUsuario = table.Column<string>(type: "varchar(40)", nullable: false),
                    Email = table.Column<string>(type: "varchar(40)", nullable: false),
                    Senha = table.Column<string>(type: "varchar(40)", nullable: false),
                    ConfirmaSenha = table.Column<string>(type: "varchar(40)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    NomeFuncionario = table.Column<string>(type: "varchar(40)", nullable: false),
                    CpfFuncionario = table.Column<string>(type: "varchar(11)", nullable: false),
                    EnderecoFuncionario = table.Column<string>(type: "varchar(60)", nullable: false),
                    CargoFuncionario = table.Column<int>(type: "int", nullable: false),
                    CargaHoraria = table.Column<TimeSpan>(type: "time", nullable: false),
                    DataAdmissao = table.Column<DateTime>(type: "dateTime", nullable: false),
                    Situacao = table.Column<int>(type: "int", nullable: false),
                    IdSupervisor = table.Column<Guid>(nullable: false),
                    IdFerias = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Funcionarios_Ferias_IdFerias",
                        column: x => x.IdFerias,
                        principalTable: "Ferias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Funcionarios_Supervisores_IdSupervisor",
                        column: x => x.IdSupervisor,
                        principalTable: "Supervisores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_IdFerias",
                table: "Funcionarios",
                column: "IdFerias");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_IdSupervisor",
                table: "Funcionarios",
                column: "IdSupervisor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Funcionarios");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Ferias");

            migrationBuilder.DropTable(
                name: "Supervisores");
        }
    }
}
