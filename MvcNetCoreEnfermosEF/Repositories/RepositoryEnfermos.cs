using MvcNetCoreEnfermosEF.Data;
using MvcNetCoreEnfermosEF.Models;

namespace MvcNetCoreEnfermosEF.Repositories
{
    public class RepositoryEnfermos
    {
        private EnfermosContext context;

        public RepositoryEnfermos(EnfermosContext context)
        {
            this.context = context;
        }

        public List<Enfermo> GetEnfermos()
        {
            var consulta = from datos in this.context.Enfermos
                           select datos;
            return consulta.ToList();
        }
    }
}
