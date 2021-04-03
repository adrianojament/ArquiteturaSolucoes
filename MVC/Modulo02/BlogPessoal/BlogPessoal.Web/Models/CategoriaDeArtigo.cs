using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogPessoal.Web.Models
{
    public class CategoriaDeArtigo
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Campo Requerido")]
        [MaxLength(150, ErrorMessage ="Campo no maximo 150")]
        [Display(Name ="Nome da Categoria")]
        public string Nome { get; set; }

        [MaxLength(300, ErrorMessage = "Campo no maximo 300")]
        [Display(Name = "Descrição")]
        [DataType(DataType.MultilineText)]
        public string Descricao { get; set; }

        public virtual ICollection<Artigo> Artigos { get; set; }
    }
}