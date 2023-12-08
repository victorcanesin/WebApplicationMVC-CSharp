using Microsoft.EntityFrameworkCore;
using WebApplicationMVC1.Context;
using WebApplicationMVC1.Models;

namespace WebApplicationMVC1.Repositories
{
    public class EstadoRepository
    {
        private readonly InformixContext _informixContext;

        public EstadoRepository (InformixContext informixContext)
        {
            _informixContext = informixContext;
        }

        public IEnumerable<Estado> obterEstados()
        {
            return _informixContext.Estados.
                                    Include(x => x.pais)
                                    .ToList();
        }

        public void adicionar(Estado estado)
        {
            if(estado.estadoCodigo >= 0 && string.IsNullOrWhiteSpace(estado.estadoDescricao) == false)
            {
                _informixContext.Estados.Add(estado);
                _informixContext.SaveChanges();
            }
        }
    }
}
