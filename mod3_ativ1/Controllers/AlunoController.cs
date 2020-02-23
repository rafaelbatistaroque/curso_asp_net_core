using Microsoft.AspNetCore.Mvc;
using mod3_ativ1.Models;
using mod3_ativ1.Repositories;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mod3_ativ1.Controllers
{
    [Route("escola")]
    public class AlunoController : Controller
    {
        private readonly AlunoRepositorio _alunoRepositorio;
        private IEnumerable<Aluno> _listaAlunos;

        public AlunoController(AlunoRepositorio alunoRepositorio) => _alunoRepositorio = alunoRepositorio;
        
        [Route("alunos")]
        public async Task<IActionResult> Alunos()
        {
            _listaAlunos = await _alunoRepositorio.ObterListaDeAlunosNoBD();
            return View(_listaAlunos);
        }
        [Route("delete/{id}")]
        public async Task<IActionResult> Delete(int? Id)
        {
            await _alunoRepositorio.DeletarAlunoNoBD(Id);
            return RedirectToAction(nameof(Alunos));
        }

    }
}