using System;
using _02_LachesMac.Models;
using Microsoft.EntityFrameworkCore;

namespace _02_LachesMac.Context
{
	public class AppDbContext : DbContext
	{
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){
        }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Lanche> Lanches { get; set; }
    }
}

