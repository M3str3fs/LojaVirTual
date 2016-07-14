using System;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace LincolnME.LojaVirtual.Models
{
    public static class GeradorPaginacao
    {
        public static MvcHtmlString PageLinks(this HtmlHelper html, Paginacao paginacao, Func<int, string> paginaUrl)
        {
            StringBuilder resultado = new StringBuilder();

            for (int i = 1; i < paginacao.TotalPagina; i++)

            {
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href", paginaUrl(i));
                tag.InnerHtml = i.ToString();

                if (i == paginacao.PaginaAtual)
                {
                    tag.AddCssClass("selected");
                    tag.AddCssClass("btn-primary");
                }
                tag.AddCssClass("btn-default");
                resultado.Append(tag);
            }
            return MvcHtmlString.Create(resultado.ToString());
            
        }
    }
}