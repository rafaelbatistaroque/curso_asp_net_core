using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using mod3_ativ1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mod3_ativ1.BD.mapeamentos
{
    public class AlunoMapeamento : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("Alunos");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasMaxLength(50).HasColumnName("nome_aluno");
            builder.Property(x => x.Sexo).HasMaxLength(20).HasColumnName("sexo_aluno");
            builder.Property(x => x.Email).HasMaxLength(50).HasColumnName("email_aluno");
            builder.Property(x => x.DataNascimento).HasColumnName("data_nascimento_aluno");
        }
    }
}
