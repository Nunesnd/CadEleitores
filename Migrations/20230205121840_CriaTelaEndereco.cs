using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadEleitores.Migrations
{
    public partial class CriaTelaEndereco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    EnderecoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnderecoLogradouro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnderecoNumero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnderecoComplemento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnderecoBairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnderecoCidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnderecoUF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnderecoCEP = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.EnderecoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Endereco");
        }
    }
}
