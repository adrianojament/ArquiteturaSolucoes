using BlogPessoal.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace BlogPessoal.Web.Data.Mapeamento
{
    public class AutorMap : EntityTypeConfiguration<Autor>
    {
        public AutorMap()
        {
            ToTable("autor", "dbo");

            HasKey(t => t.Id);

            Property(x => x.Nome).IsRequired().HasMaxLength(150).HasColumnName("nome");
            Property(x => x.eMail).IsRequired().HasMaxLength(150).HasColumnName("email");
            Property(x => x.Senha).IsRequired().HasMaxLength(50).HasColumnName("senha");
            Property(x => x.Adminstrador).IsRequired().HasColumnName("adminstrador");
            Property(x => x.DataCadastro).IsRequired().HasColumnName("data_cadastro");
        }
    }
}