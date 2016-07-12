using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LincolnME.LojaVirtual.Dominio.Repositorio;

namespace LincolnME.LojaVirtual.Controllers
{
    public class ProdutoController : Controller
    {
        private ModelContext _repositorio;
        // GET: Produto
        public ActionResult Index()
        {

            _repositorio = new ModelContext();
            var produtos = _repositorio.Produtos.Take(10);
            return View(produtos);
        }
    }
}