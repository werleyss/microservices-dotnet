using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreekShooping.ProductAPI.Migrations
{
    public partial class SeedProductDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 10L);
        }
    }
}
