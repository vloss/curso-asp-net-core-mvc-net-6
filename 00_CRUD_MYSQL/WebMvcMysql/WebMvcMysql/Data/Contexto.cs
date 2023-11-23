using System;
using Microsoft.EntityFrameworkCore;

namespace WebMvcMysql.Data
{
	public class Contexto : DbContext
	{
		public Contexto(DbContextOptions<Contexto> options) : base(options)
		{

		}

		public DbSet<Models.Usuario> Usuario { get; set; }
	}
}

