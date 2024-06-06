using Microsoft.EntityFrameworkCore;

namespace GreekShooping.ProductAPI.Model.Context
{
    public class PostgreSQLContext : DbContext
    {
        public PostgreSQLContext()
        {
            
        }

        public PostgreSQLContext(DbContextOptions<PostgreSQLContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Camisa",
                Price = new decimal(29.9),
                Description = "O Lorem Ipsum tem vindo a ser o texto padrão usado por estas indústrias desde o ano de 1500",
                ImageURL = "https://61971.cdn.lojaquevende.com.br/static/61971/sku/roupas-camisetas-femininas-produto-teste-camiseta-mulher-maravilha-vermelha-pode-excluir-1494093213682.jpg",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Camisa Batiman",
                Price = new decimal(39.9),
                Description = "O Lorem Ipsum tem vindo a ser o texto padrão usado por estas indústrias desde o ano de 1500",
                ImageURL = "https://61971.cdn.lojaquevende.com.br/static/61971/sku/roupas-camisetas-masculinas-produto-teste-camiseta-batman-preta-pode-excluir-1494097276451.jpg",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Camisa Doom",
                Price = new decimal(49.9),
                Description = "O Lorem Ipsum tem vindo a ser o texto padrão usado por estas indústrias desde o ano de 1500",
                ImageURL = "https://www.dhresource.com/0x0/f2/albu/g19/M01/96/0D/rBVap2D4WzqAKVR5AABxIIhKL0E891.jpg/men-s-t-shirts-summer-fashion-game-doom-t.jpg",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Camiseta",
                Price = new decimal(69.9),
                Description = "O Lorem Ipsum tem vindo a ser o texto padrão usado por estas indústrias desde o ano de 1500",
                ImageURL = "https://cf.shopee.com.br/file/c1637a3157672c360efaee48680ecca9",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Camisa",
                Price = new decimal(69.9),
                Description = "O Lorem Ipsum tem vindo a ser o texto padrão usado por estas indústrias desde o ano de 1500",
                ImageURL = "https://bawclothing.vtexassets.com/arquivos/ids/162432/BAW_1539.jpg?v=636662291912030000",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Camisa manga longa",
                Price = new decimal(69.9),
                Description = "O Lorem Ipsum tem vindo a ser o texto padrão usado por estas indústrias desde o ano de 1500",
                ImageURL = "https://m.media-amazon.com/images/I/51s4mGEZGlL._AC_SX385_.jpg",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Camisa nike",
                Price = new decimal(89.9),
                Description = "O Lorem Ipsum tem vindo a ser o texto padrão usado por estas indústrias desde o ano de 1500",
                ImageURL = "https://images.lojanike.com.br/1024x1024/produto/camisa-nike-franca-i-202021-torcedor-pro-masculina-CD0700-498-1.jpg",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "Camisa azul",
                Price = new decimal(99.9),
                Description = "O Lorem Ipsum tem vindo a ser o texto padrão usado por estas indústrias desde o ano de 1500",
                ImageURL = "https://static.netshoes.com.br/produtos/camisa-cruzeiro-i-2122-sn-torcedor-adidas-masculina/08/NQQ-7747-008/NQQ-7747-008_zoom1.jpg?ts=1615489262&ims=544x",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "Camisa Atletico MG",
                Price = new decimal(109.9),
                Description = "O Lorem Ipsum tem vindo a ser o texto padrão usado por estas indústrias desde o ano de 1500",
                ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRbugaKdtuKaiT57tnUbRydFQnV_t0rbu7inA&usqp=CAU",
                CategoryName = "T-shirt"
            });
        }

    }
}
