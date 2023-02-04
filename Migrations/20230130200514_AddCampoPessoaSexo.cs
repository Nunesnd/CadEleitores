using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadEleitores.Migrations
{
    public partial class AddCampoPessoaSexo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "PessoaSexo",
                table: "Pessoa",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PessoaSexo",
                table: "Pessoa");
        }
    }
}
