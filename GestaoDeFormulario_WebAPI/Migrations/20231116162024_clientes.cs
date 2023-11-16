using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GestaoDeFormulario_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class clientes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Leads",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nomeDaEmpresa = table.Column<string>(type: "TEXT", nullable: false),
                    cep = table.Column<string>(type: "TEXT", nullable: false),
                    logradouro = table.Column<string>(type: "TEXT", nullable: false),
                    numero = table.Column<string>(type: "TEXT", nullable: false),
                    bairro = table.Column<string>(type: "TEXT", nullable: false),
                    cidade = table.Column<string>(type: "TEXT", nullable: false),
                    estado = table.Column<string>(type: "TEXT", nullable: false),
                    email = table.Column<string>(type: "TEXT", nullable: false),
                    telefone = table.Column<string>(type: "TEXT", nullable: false),
                    contato = table.Column<string>(type: "TEXT", nullable: false),
                    detalhes = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leads", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Leads",
                columns: new[] { "id", "bairro", "cep", "cidade", "contato", "detalhes", "email", "estado", "logradouro", "nomeDaEmpresa", "numero", "telefone" },
                values: new object[,]
                {
                    { 1, "Bairro 1", "07122000", "Cidade 1", "Contato 1", "nada a declarar", "email1@mail.com", "SP", "Rua 0", "Empresa1", "1A", "1234-1234" },
                    { 2, "Bairro 1", "07122000", "Cidade 1", "Contato 1", "nada a declarar", "email1@mail.com", "SP", "Rua 0", "Empresa2", "1A", "1234-1234" },
                    { 3, "Bairro 1", "07122000", "Cidade 1", "Contato 1", "nada a declarar", "email1@mail.com", "SP", "Rua 0", "Empresa3", "1A", "1234-1234" },
                    { 4, "Bairro 1", "07122000", "Cidade 1", "Contato 1", "nada a declarar", "email1@mail.com", "SP", "Rua 0", "Empresa4", "1A", "1234-1234" },
                    { 5, "Bairro 1", "07122000", "Cidade 1", "Contato 1", "nada a declarar", "email1@mail.com", "SP", "Rua 0", "Empresa5", "1A", "1234-1234" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Leads");
        }
    }
}
