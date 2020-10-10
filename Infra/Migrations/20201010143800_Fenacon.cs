using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Migrations
{
    public partial class Fenacon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Supervisor",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(nullable: true),
                    Endereco = table.Column<string>(nullable: true),
                    Cargo = table.Column<int>(nullable: false),
                    CargaHoraria = table.Column<TimeSpan>(nullable: false),
                    DataAdmissao = table.Column<DateTime>(nullable: false),
                    Situacao = table.Column<int>(nullable: false),
                    IdFuncionario = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supervisor", x => x.Id);
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
                    IdSupervisor = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Funcionarios_Supervisor_IdSupervisor",
                        column: x => x.IdSupervisor,
                        principalTable: "Supervisor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "Supervisor");
        }
    }
}
