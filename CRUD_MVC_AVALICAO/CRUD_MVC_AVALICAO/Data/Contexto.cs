using System;
using Microsoft.EntityFrameworkCore;
using CRUD_MVC_AVALICAO.Models;

namespace CRUD_MVC_AVALICAO.Data
{
    public class Contexto : DbContext
    {

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        public DbSet<ProdutoModel> Produto { get; set; }
    }
}
