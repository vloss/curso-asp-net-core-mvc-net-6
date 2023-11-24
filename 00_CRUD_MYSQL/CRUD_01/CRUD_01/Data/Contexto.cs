using CRUD_01.Models;
using Microsoft.EntityFrameworkCore;

namespace WebMvcMysql.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        { }

        public DbSet<Usuario> Usuario { get; set; }

    }
}

