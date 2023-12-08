using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplicationMVC1.Models;
using WebApplicationMVC1.Repositories;

namespace WebApplicationMVC1.Conttrolers
{
    public class EstadoController : Controller
    {
        private readonly EstadoRepository _estadoRepository;
        private readonly PaisRepository _paisRepository;

        public EstadoController(EstadoRepository estadoRepository, PaisRepository paisRepository)
        {
            _estadoRepository = estadoRepository;
            _paisRepository = paisRepository;
        }

        public IActionResult Index()
        {
            var estados = _estadoRepository.obterEstados();
            return View(estados);
        }

        public IActionResult adicionar()
        {
            var paises = _paisRepository.obterPaises();
            ViewBag.Paises = paises.Select(p => new SelectListItem { Value = p.paisCodigo.ToString(), Text = p.paisDescricao});
            return View();
        }

        [HttpPost]
        public IActionResult adicionar(Estado estado)
        {            
            _estadoRepository.adicionar(estado);
            return RedirectToAction("Index");
        }

       

    }
}
