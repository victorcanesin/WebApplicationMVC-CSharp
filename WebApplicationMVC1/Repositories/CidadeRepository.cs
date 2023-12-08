using Microsoft.EntityFrameworkCore;
using WebApplicationMVC1.Context;
using WebApplicationMVC1.Models;

namespace WebApplicationMVC1.Repositories
{
    public class CidadeRepository
    {
        private readonly InformixContext _informixContext;

        public CidadeRepository(InformixContext informixContext)
        {
            _informixContext = informixContext;
        }

        public IEnumerable<Cidade> obterCidades()
        {
            return _informixContext.Cidades
                                   .Include(x => x.estado)       
                                   .ThenInclude(y => y.pais)
                                   .ToList();
        }

        public void adicionar(Cidade cidade)
        {
            if (cidade.cidadeCodigo >= 0 && string.IsNullOrWhiteSpace(cidade.cidadeDescricao) == false)
            {
                _informixContext.Cidades.Add(cidade);
                _informixContext.SaveChanges();
            }
        }

    }
}