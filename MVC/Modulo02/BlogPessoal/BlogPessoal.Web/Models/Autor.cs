using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogPessoal.Web.Models
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        [DataType(DataType.EmailAddress)]
        public string eMail { get; set; }

        [DataType(DataType.Password)]
        public string Senha { get; set; }
        public bool Adminstrador { get; set; }
        
        [Display(Name ="Data de Cadastro")]
        [DisplayFormat(ApplyFormatInEditMode =true, DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime DataCadastro { get; set; }
        public virtual ICollection<Artigo> Artigos { get; set; }

    }
}