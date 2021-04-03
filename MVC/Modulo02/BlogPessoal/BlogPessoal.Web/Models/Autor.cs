using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogPessoal.Web.Models
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string eMail { get; set; }
        public string Senha { get; set; }
        public bool Adminstrador { get; set; }
        public DateTime DataCadastro { get; set; }
        public virtual ICollection<Artigo> Artigos { get; set; }

    }
}