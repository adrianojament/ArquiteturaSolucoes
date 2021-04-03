using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogPessoal.Web.Models
{
    public class Artigo
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public string DataPublicacao { get; set; }
        public bool Removido { get; set; }
        public int CategoriaDeArtigo_Id { get; set; }
        public virtual CategoriaDeArtigo CategoriaDeArtigo { get; set; }
        public int Autor_Id { get; set; }
        public virtual Autor Autor { get; set; }

    }
}