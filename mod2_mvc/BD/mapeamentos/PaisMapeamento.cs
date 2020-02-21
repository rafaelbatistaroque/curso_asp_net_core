using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using mod2_mvc.Models;

namespace mod2_mvc.BD.mapeamentos
{
    public class PaisMapeamento: IEntityTypeConfiguration<Pais>
    {

        public void Configure(EntityTypeBuilder<Pais> builder)
        {
            builder.ToTable("Paises");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasMaxLength(25);
            builder.Property(x => x.Codigo).HasMaxLength(25);

            builder.HasData(
                new { Id = 1, Nome = "Brasil", Codigo = "55" },
                new { Id = 2, Nome = "Argentina", Codigo = "54" },
                new { Id = 3, Nome = "Bolívia", Codigo = "591" },
                new { Id = 4, Nome = "Paraguai", Codigo = "não" },
                new { Id = 5, Nome = "Uruguai", Codigo = "598" }
                );
        }
    }
}
