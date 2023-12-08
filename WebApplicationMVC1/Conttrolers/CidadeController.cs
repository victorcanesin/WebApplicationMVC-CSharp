using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplicationMVC1.Models;
using WebApplicationMVC1.Repositories;

namespace WebApplicationMVC1.Conttrolers
{
    public class CidadeController : Controller
    {
        private readonly CidadeRepository  _cidadeRepository;
        private readonly EstadoRepository  _estadoRepository;

        public CidadeController(CidadeRepository cidadeRepository, EstadoRepository estadoRepository)
        {
            _cidadeRepository = cidadeRepository;
            _estadoRepository = estadoRepository;
        }

        public IActionResult Index()
        {
            var cidades = _cidadeRepository.obterCidades();
            return View(cidades);
        }

        public IActionResult adicionar()
        {
            var est = _estadoRepository.obterEstados();
            ViewBag.Estados = est.Select(e => new SelectListItem { Value = e.estadoCodigo.ToString(), Text = e.estadoDescricao });
            return View();
        }

        [HttpPost]
        public IActionResult adicionar(Cidade cidade)
        {
            _cidadeRepository.adicionar(cidade);
            return RedirectToAction("Index");  
        }
    }
}
