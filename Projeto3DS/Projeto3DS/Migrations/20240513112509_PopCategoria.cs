using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projeto3DS.Migrations
{
    /// <inheritdoc />
    public partial class PopCategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Categoria(CategoriaNome, Descrisao) " +
                "values('Normal','Lanches feito com ingredientes normais')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Categoria");
        }
    }
}
