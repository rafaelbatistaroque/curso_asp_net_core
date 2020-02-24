using Microsoft.AspNetCore.Mvc;
using mod3_ativ1.Models;
using mod3_ativ1.Repositories;
using System;
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
        [Route("delete/")]
        [Route("delete/{id}")]
        public async Task<IActionResult> Delete(int? id)
        {   
            if (!id.HasValue) return NotFound("O id não pode ser nulo.");

            if (await _alunoRepositorio.DeletarAlunoNoBD(id.Value))
                return RedirectToAction(nameof(Alunos));
            else return NotFound("Aluno não existe");
        }
        [Route("pagina_adicionar")]
        public IActionResult Criar()
        {
            return View();
        }
        [Route("adicionar_aluno")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Adicionar(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                aluno.DataNascimento = DateTime.Now;
                await _alunoRepositorio.AdicionarAlunoNoBD(aluno);
                return RedirectToAction(nameof(Alunos));
            }
            return RedirectToAction(nameof(Criar));
        }
        [Route("pagina_atualizar")]
        [Route("pagina_atualizar/{id}")]
        public async Task<IActionResult> Atualizar(int? id)
        {
            if (!id.HasValue) return NotFound("O id não pode ser nulo.");
            var alunoParaAtualizar = await _alunoRepositorio.ObterAlunoPorId(id.Value);
            return View(nameof(Atualizar), alunoParaAtualizar);
        }
        [Route("atualizar_aluno")]
        public async Task<IActionResult> Modificar(Aluno aluno)
        {
            await _alunoRepositorio.AtualizarAlunoNoBD(aluno);
            return RedirectToAction(nameof(Alunos));
        }

    }
}