using AulaPratica.Entities;
using Microsoft.EntityFrameworkCore;

namespace AulaPratica.Context
{
    public class AgendaContext : DbContext
    {
        public DbSet<Contato> Contatos { get; set; }

        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        } 
    }
}
