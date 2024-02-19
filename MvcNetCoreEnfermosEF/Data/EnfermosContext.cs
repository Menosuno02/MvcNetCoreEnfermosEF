using Microsoft.EntityFrameworkCore;
using MvcNetCoreEnfermosEF.Models;

namespace MvcNetCoreEnfermosEF.Data
{
    public class EnfermosContext : DbContext
    {
        public EnfermosContext(DbContextOptions<EnfermosContext> options)
            : base(options) { }

        public DbSet<Enfermo> Enfermos { get; set; }
    }
}
