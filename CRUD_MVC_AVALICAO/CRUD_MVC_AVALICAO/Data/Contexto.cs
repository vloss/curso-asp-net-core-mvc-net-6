using System;
using Microsoft.EntityFrameworkCore;
using CRUD_MVC_AVALICAO.Models;

namespace CRUD_MVC_AVALICAO.Data
{
    public class Contexto : DbContext
    {

        public Contexto() { }

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        public DbSet<ProdutoModel> Produto { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            

            //optionsBuilder.UseMySql("server=localhost;database=library;user=user;password=password");
            optionsBuilder.UseMySql("Server=localhost;User Id=root;Password=root;Database=treinaweb");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { }
    }
}
