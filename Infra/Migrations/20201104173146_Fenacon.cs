using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Migrations
{
    public partial class Fenacon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    NomeFuncionario = table.Column<string>(type: "varchar(40)", nullable: false),
                    CpfFuncionario = table.Column<string>(type: "varchar(11)", nullable: false),
                    EnderecoFuncionario = table.Column<string>(type: "varchar(60)", nullable: false),
                    CargoFuncionario = table.Column<int>(type: "int", nullable: false),
                    CargaHoraria = table.Column<int>(type: "int", nullable: false),
                    DataAdmissao = table.Column<DateTime>(type: "dateTime", nullable: false),
                    Situacao = table.Column<int>(type: "int", nullable: false),
                    SupervisorId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Funcionarios_Funcionarios_SupervisorId",
                        column: x => x.SupervisorId,
                        principalTable: "Funcionarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_SupervisorId",
                table: "Funcionarios",
                column: "SupervisorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Funcionarios");
        }
    }
}
