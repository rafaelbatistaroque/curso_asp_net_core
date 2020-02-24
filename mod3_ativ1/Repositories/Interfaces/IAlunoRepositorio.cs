using mod3_ativ1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mod3_ativ1.Repositories.Interfaces
{
    public interface IAlunoRepositorio
    {
        Task<IEnumerable<Aluno>> ObterListaDeAlunosNoBD();
        Task<bool> DeletarAlunoNoBD(int id);
        Task AtualizarAlunoNoBD(Aluno alunoAtualizado);
        Task AdicionarAlunoNoBD(Aluno novoAluno);
        Task<Aluno> ObterAlunoPorId(int id);
    }
}
