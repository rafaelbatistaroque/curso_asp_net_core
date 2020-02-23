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
        Task DeletarAlunoNoBD(int? Id);
    }
}
