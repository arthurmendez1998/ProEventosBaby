using Microsoft.EntityFrameworkCore;
using ProEventosBaby.Models;

namespace ProEventosBaby.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) // o base (options) está passando o options que é um dbcontextOption(vulgo connection string) para o DbContext
        {

        }
        public DbSet<EventoModel> Eventos { get; set; }
    }
}
