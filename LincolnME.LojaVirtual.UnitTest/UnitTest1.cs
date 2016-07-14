using System;
using System.Web.Mvc;
using LincolnME.LojaVirtual.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LincolnME.LojaVirtual.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

        }
        [TestMethod]
        public void TestandoRetornoGeradorPaginacao()
        {
            //Arrange
            HtmlHelper html = null; 
            Paginacao  paginacao = new Paginacao();
            {
                paginacao.PaginaAtual = 2;
                paginacao.ItensPorPagina = 10;
                paginacao.ItensTotal = 28;
                
            }

            //Act
            Func<int, string> paginaUrl = i => "pagina" + i;

            //A

            MvcHtmlString resultado = html.PageLinks(paginacao, paginaUrl);
            //assert

            Assert.AreEqual( 
               @"<a class=""btn btn-default""href=""Pagina1"">1<a/>",resultado.ToString()



                );


        }
    }
}
