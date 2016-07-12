using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LincolnME.LojaVirtual.Dominio.Repositorio;

namespace LincolnME.LojaVirtual.Controllers
{
    public class VitrineController : Controller
    {
        private ModelContext _repositorio;
        public int ProdutosPorPagina = 5;
        // GET: Vitrine
        public ActionResult ListarProdutos(int pagina = 1)
        {
            _repositorio = new ModelContext();
            var produtos = _repositorio.Produtos.OrderBy(x => x.Nome).Skip((pagina - 1) * ProdutosPorPagina).Take(ProdutosPorPagina);

            return View(produtos);



        }
    }
}