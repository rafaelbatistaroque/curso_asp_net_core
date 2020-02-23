using Microsoft.EntityFrameworkCore;
using mod3_ativ1.BD.mapeamentos;
using mod3_ativ1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mod3_ativ1.BD
{
    public class EscolaDataContext : DbContext
    {

        public DbSet<Aluno> Alunos { get; set; }

        public EscolaDataContext(DbContextOptions<EscolaDataContext> options):base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new  AlunoMapeamento());
        }
    }
}
