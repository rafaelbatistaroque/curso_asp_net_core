using Microsoft.EntityFrameworkCore;
using mod2_mvc.BD.mapeamentos;
using mod2_mvc.Models;

namespace mod2_mvc.BD
{
    public class DataContext: DbContext
    {
        public DbSet<Pais> Paises { get; set; }
        
        public DataContext(DbContextOptions<DataContext> options): base(options) {}

        protected override void OnModelCreating(ModelBuilder _)
        {
            _.ApplyConfiguration(new PaisMapeamento());
            
        }
    }
}
