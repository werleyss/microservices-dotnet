using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GreekShooping.ProductAPI.Migrations.PostgreSQL
{
    public partial class InicialPostgreSQL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "product",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    price = table.Column<decimal>(type: "numeric", nullable: false),
                    description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    category_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    image_url = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 2L, "T-shirt", "O Lorem Ipsum tem vindo a ser o texto padrão usado por estas indústrias desde o ano de 1500", "https://61971.cdn.lojaquevende.com.br/static/61971/sku/roupas-camisetas-femininas-produto-teste-camiseta-mulher-maravilha-vermelha-pode-excluir-1494093213682.jpg", "Camisa", 29.9m },
                    { 3L, "T-shirt", "O Lorem Ipsum tem vindo a ser o texto padrão usado por estas indústrias desde o ano de 1500", "https://61971.cdn.lojaquevende.com.br/static/61971/sku/roupas-camisetas-masculinas-produto-teste-camiseta-batman-preta-pode-excluir-1494097276451.jpg", "Camisa Batiman", 39.9m },
                    { 4L, "T-shirt", "O Lorem Ipsum tem vindo a ser o texto padrão usado por estas indústrias desde o ano de 1500", "https://www.dhresource.com/0x0/f2/albu/g19/M01/96/0D/rBVap2D4WzqAKVR5AABxIIhKL0E891.jpg/men-s-t-shirts-summer-fashion-game-doom-t.jpg", "Camisa Doom", 49.9m },
                    { 5L, "T-shirt", "O Lorem Ipsum tem vindo a ser o texto padrão usado por estas indústrias desde o ano de 1500", "https://cf.shopee.com.br/file/c1637a3157672c360efaee48680ecca9", "Camiseta", 69.9m },
                    { 6L, "T-shirt", "O Lorem Ipsum tem vindo a ser o texto padrão usado por estas indústrias desde o ano de 1500", "https://bawclothing.vtexassets.com/arquivos/ids/162432/BAW_1539.jpg?v=636662291912030000", "Camisa", 69.9m },
                    { 7L, "T-shirt", "O Lorem Ipsum tem vindo a ser o texto padrão usado por estas indústrias desde o ano de 1500", "https://m.media-amazon.com/images/I/51s4mGEZGlL._AC_SX385_.jpg", "Camisa manga longa", 69.9m },
                    { 8L, "T-shirt", "O Lorem Ipsum tem vindo a ser o texto padrão usado por estas indústrias desde o ano de 1500", "https://images.lojanike.com.br/1024x1024/produto/camisa-nike-franca-i-202021-torcedor-pro-masculina-CD0700-498-1.jpg", "Camisa nike", 89.9m },
                    { 9L, "T-shirt", "O Lorem Ipsum tem vindo a ser o texto padrão usado por estas indústrias desde o ano de 1500", "https://static.netshoes.com.br/produtos/camisa-cruzeiro-i-2122-sn-torcedor-adidas-masculina/08/NQQ-7747-008/NQQ-7747-008_zoom1.jpg?ts=1615489262&ims=544x", "Camisa azul", 99.9m },
                    { 10L, "T-shirt", "O Lorem Ipsum tem vindo a ser o texto padrão usado por estas indústrias desde o ano de 1500", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRbugaKdtuKaiT57tnUbRydFQnV_t0rbu7inA&usqp=CAU", "Camisa Atletico MG", 109.9m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "product");
        }
    }
}
