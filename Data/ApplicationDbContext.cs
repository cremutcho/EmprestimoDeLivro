using EmprestimoLivro.Models;
using Microsoft.EntityFrameworkCore;

namespace EmprestimoLivro.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<EmprestimoModel> Emprestimos { get; set; } // Use um nome no plural para a DbSet
    }
}

