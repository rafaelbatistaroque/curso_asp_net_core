using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mod3_ativ1.BD;
using mod3_ativ1.Models;
using mod3_ativ1.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace mod3_ativ1.Repositories
{
    public class AlunoRepositorio : IAlunoRepositorio
    {
        private readonly EscolaDataContext _dbEscola;
        public AlunoRepositorio(EscolaDataContext _escola) => _dbEscola = _escola;

        [HttpPost]
        public async Task DeletarAlunoNoBD(int? Id)
        {
            var alunoParaDeletar = await _dbEscola.Alunos.FindAsync(Id);
            _dbEscola.Alunos.Remove(alunoParaDeletar);
            await _dbEscola.SaveChangesAsync();
        }

        public async Task<IEnumerable<Aluno>> ObterListaDeAlunosNoBD()
        {
            return await _dbEscola.Alunos.ToListAsync();
        }
    }
}
