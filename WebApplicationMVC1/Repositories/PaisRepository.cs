using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplicationMVC1.Context;
using WebApplicationMVC1.Models;

namespace WebApplicationMVC1.Repositories
{
    public class PaisRepository
    {
        private readonly InformixContext _informixContext;

        public PaisRepository(InformixContext informixContext)
        {
            _informixContext = informixContext;
        }

        public IEnumerable<Pais> obterPaises()
        {
            return _informixContext.Paises.ToList();
        }

        public void adicionar(Pais pais)
        {
            if(pais.paisCodigo >= 0 && string.IsNullOrWhiteSpace(pais.paisDescricao) == false)
            {
                _informixContext.Paises.Add(pais);
                _informixContext.SaveChanges();
            }
        }
    }
}