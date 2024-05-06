using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace Projeto3DS.Migrations
{
    /// <inheritdoc />
    public partial class McLanches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Categoriaid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CategoriaNome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Descrisao = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Categoriaid);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Lanche",
                columns: table => new
                {
                    Lancheid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Descrisaocurta = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Descrisaodetalhada = table.Column<string>(type: "longtext", nullable: false),
                    Emestoque = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    ImagemULR = table.Column<string>(type: "longtext", nullable: false),
                    Lanchepreferido = table.Column<string>(type: "longtext", nullable: false),
                    Imagemiminiauta = table.Column<string>(type: "longtext", nullable: false),
                    Categoriaid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lanche", x => x.Lancheid);
                    table.ForeignKey(
                        name: "FK_Lanche_Categoria_Categoriaid",
                        column: x => x.Categoriaid,
                        principalTable: "Categoria",
                        principalColumn: "Categoriaid",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Lanche_Categoriaid",
                table: "Lanche",
                column: "Categoriaid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lanche");

            migrationBuilder.DropTable(
                name: "Categoria");
        }
    }
}
