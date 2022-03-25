using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() {}

        public MySQLContext( DbContextOptions<MySQLContext> options) : base(options){}

        public DbSet<Product> Products { get; set; }

        //Para migrations:
        //botão diretiro em cima do nome do projeto/open in terminal
        //1. Executar(Instalação do ef): dotnet tool install --global dotnet-ef
        //2. Executar:dotnet ef migrations add AddProductDataTableOnDB
        //2.1 Executar(Se quiser Remover): dotnet ef migrations remove
        //3. Para compilar no banco basta: dotnet ef database update


    }
}
