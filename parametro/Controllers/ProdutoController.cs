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

            string retorno = string.Empty;
            switch (prd)
            {
                case 1:
                    retorno = "SAMSUNG GALAXY NOTE 3";
                    break;
                case 5:
                    retorno = "IPHONE 8";
                    break;
                case 10:
                    retorno = "NOKIA 1208";
                    break;
            }

            ViewBag.Produto = retorno;
            return View();
        }
    }
}