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
        public async Task AdicionarAlunoNoBD(Aluno novoAluno)
        {
            _dbEscola.Add(novoAluno);
            await _dbEscola.SaveChangesAsync();
        }

        [HttpPut]
        public async Task AtualizarAlunoNoBD(Aluno alunoAtualizado)
        {
            _dbEscola.Entry(alunoAtualizado).State = EntityState.Modified;
            await _dbEscola.SaveChangesAsync();
        }

        [HttpDelete]
        public async Task<bool> DeletarAlunoNoBD(int id)
        {
            var alunoProcurado = await _dbEscola.Alunos.FindAsync(id);
            if (alunoProcurado == null) return false;
            else
            {
                _dbEscola.Entry(alunoProcurado).State = EntityState.Deleted;
                await _dbEscola.SaveChangesAsync();
            }
            return true;
        }
        [HttpGet]
        public async Task<Aluno> ObterAlunoPorId(int id)
        {
            return await _dbEscola.Alunos.SingleOrDefaultAsync(x => x.Id.Equals(id));
        }

        [HttpGet]
        public async Task<IEnumerable<Aluno>> ObterListaDeAlunosNoBD()
        {
            return await _dbEscola.Alunos.ToListAsync();
        }

    }
}
