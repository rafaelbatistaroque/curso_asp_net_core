using Microsoft.EntityFrameworkCore;
using mod2_mvc.BD.mapeamentos;
using mod2_mvc.Models;

namespace mod2_mvc.BD
{
    public class Mod2DbContext: DbContext
    {
        public DbSet<Pais> Paises { get; set; }
        
        public Mod2DbContext(DbContextOptions<Mod2DbContext> options): base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PaisMapeamento());
            
        }
    }
}
