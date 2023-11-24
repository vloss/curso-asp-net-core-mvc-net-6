using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace CRUD_MVC_AVALICAO.Models
{
    [Table("Produto")]
    public class ProdutoModel
	{
        [Display(Name = "Código")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Column("Nome")]
        public string Nome { get; set; }

        [Display(Name = "Descricao")]
        [Column("Descricao")]
        public string Descricao { get; set; }

        [Display(Name = "Valor")]
        [Column("Valor")]
        public double Valor { get; set; }

		public ProdutoModel()
		{

		}
	}
}

