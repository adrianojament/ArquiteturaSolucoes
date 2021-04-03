using System.Linq;
using BlogPessoal.Web.Data.Contexto;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlogPessoal.Web.Tests
{
    [TestClass]
    public class CategoriaDeArtigoTeste
    {
        [TestMethod]
        public void ConectarBanco_com_Sucesso()
        {
            bool conectou = false;
            try
            {
                var ctx = new BlogPessoalContexto();
                var obj = ctx.CategoriasDeArtigo.FirstOrDefault();
                conectou = true;
            }
            catch{}

            Assert.IsTrue(conectou);
        }
    }
}
