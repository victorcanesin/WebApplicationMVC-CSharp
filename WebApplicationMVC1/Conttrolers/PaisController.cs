using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplicationMVC1.Models;
using WebApplicationMVC1.Repositories;

namespace WebApplicationMVC1.Conttrolers
{
    public class PaisController : Controller
    {
        private readonly PaisRepository _paisRepository;

        public PaisController(PaisRepository paisRepository)
        {
            _paisRepository = paisRepository;
        }

        public IActionResult Index()
        {           
            var paisesx = _paisRepository.obterPaises();          
            return View(paisesx);
        }

        public IActionResult adicionar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult adicionar(Pais pais)
        {            
            _paisRepository.adicionar(pais);
            return RedirectToAction("Index");
        }
    }
}
