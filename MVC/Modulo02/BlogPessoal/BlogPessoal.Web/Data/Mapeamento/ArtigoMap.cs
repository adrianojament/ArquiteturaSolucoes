using BlogPessoal.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace BlogPessoal.Web.Data.Mapeamento
{
    public class ArtigoMap : EntityTypeConfiguration<Artigo>
    {
        public ArtigoMap()
        {
            ToTable("artigo", "dbo");

            HasKey(t => t.Id);

            HasRequired(x => x.Autor)
                .WithMany(t => t.Artigos)
                .HasForeignKey(x => x.Autor_Id)
                .WillCascadeOnDelete(false);

            HasRequired(x => x.CategoriaDeArtigo)
                .WithMany(t => t.Artigos)
                .HasForeignKey(x => x.CategoriaDeArtigo_Id)
                .WillCascadeOnDelete(false);
            
            Property(x => x.Titulo).IsRequired().HasMaxLength(150).HasColumnName("Titulo");
            Property(x => x.Conteudo).IsRequired().HasColumnName("conteudo");
            Property(x => x.DataPublicacao).IsRequired().HasColumnName("data_publicacao");
            Property(x => x.Removido).IsRequired().HasColumnName("removido");
            Property(x => x.CategoriaDeArtigo_Id).IsRequired().HasColumnName("categoria_artigo_id");            
            Property(x => x.Autor_Id).IsRequired().HasColumnName("autor_id");
        }
    }
}