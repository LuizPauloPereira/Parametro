using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace parametro.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Buscar(int prd)
        {
            string link = string.Empty;
            string retorno = string.Empty;
            switch (prd)
            {
                case 1:
                    retorno = "SAMSUNG GALAXY NOTE 3";
                    link = "https://www.tudocelular.com/Samsung/fichas-tecnicas/n2503/Samsung-Galaxy-Note-3.html";
                    break;
                case 5:
                    retorno = "IPHONE 8";
                    link = "https://www.tudocelular.com/Apple/fichas-tecnicas/n3501/Apple-iPhone-8.html"; 
                    break;
                case 10:
                    retorno = "NOKIA 1208";
                    link = "https://www.tudocelular.com/Nokia/fichas-tecnicas/n1235/Nokia-1208.html";
                    break;
            }

            ViewBag.Produto = retorno;
            ViewBag.Link = link;
            return View();
        }
    }
}