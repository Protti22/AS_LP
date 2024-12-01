using Microsoft.EntityFrameworkCore;
using ProjetoRaiz.Models;

namespace ProjetoRaiz.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
    }
}
