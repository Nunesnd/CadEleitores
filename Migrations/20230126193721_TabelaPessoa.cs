using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadEleitores.Migrations
{
    public partial class TabelaPessoa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    PessoaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PessoaNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PessoaPsudonimo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PessoaCpf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PessoaNasc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PessoaFilhos = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.PessoaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pessoa");
        }
    }
}
