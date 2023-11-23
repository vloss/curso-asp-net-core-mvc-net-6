using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace WebMvcMysql.Models
{

	[Table("Usuario")]
	public class Usuario
	{

		[Display(Name = "Código")]
		[Column("Id")]
		public int Id { get; set; }

        [Display(Name = "Nome")]
		[Column("Nome")]
        public string Nome { get; set; }

		public Usuario()
		{
		}
	}
}

