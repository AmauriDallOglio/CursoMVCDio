using Microsoft.EntityFrameworkCore;

namespace CursoMVCDio.Models
{
    public class Context : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString:@"Server=DESKTOP-Q37347P;Database=CURSO;Trusted_Connection=True;Encrypt=False");
        }
    }
}
