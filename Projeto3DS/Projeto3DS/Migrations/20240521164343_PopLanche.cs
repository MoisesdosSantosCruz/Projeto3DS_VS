using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projeto3DS.Migrations
{
    /// <inheritdoc />
    public partial class PopLanche : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql("insert into Lanche(Descrisaocurta, Descrisaodetalhada, Emestoque, Nome, Preco, ImagemULR, Lanchepreferido, ImagemIminiatura, Categoriaid)");

            //values ('pão,hamburguer', 'Delicioso pão de harmburguer com maionese', 1, 'Hamburguese', 12.50, 'https://assets.unileversolutions.com/recipes-v2/111033.jpg', 'Preferido', 'https://www.saboresajinomoto.com.br/uploads/images/recipes/hamburguer.jpg', 1);
            //values ('Sorvete, chocolate, baunilha', 'Sorvete de refrescar a careca de sua avó', 1, 'Chocoverte', 25.00, 'https://encrypted-tbn0.gstatic.com/shopping?q=tbn:ANd9GcSyLFqC637cfgUj7JhXel27IaeXW6qpkD_yVKvdd1MdFGGARQWk4PheBR-XHdnOGAy__1THD7nb-zf4elUBT7vXJwimVCB2dv940_szlAtzGAxcYulsLFs_7Q&usqp=CAE', 'Preferido', 'https://www.dielo.com.br/images/uploads/produtos/_banner-retina/1305x1188px-TRADICIONAIS-CHOCOLATE.png', 2);

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
// values (1, 'pão,hamburguer', 'Delicioso pão de harmburguer com maionese', 1, 'https://assets.unileversolutions.com/recipes-v2/111033.jpg', 'https://www.saboresajinomoto.com.br/uploads/images/recipes/hamburguer.jpg', '0', 'Hamburguese', 12.50)
