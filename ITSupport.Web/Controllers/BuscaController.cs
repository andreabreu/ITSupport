using ITSupport.Lib;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ITSupport.Web.Controllers
{
    public class BuscaController : Controller
    {
        // GET: Busca
        public ActionResult Index(string q)
        {
            Search Busca = new Search();

            List<SearchInformation> Resultado = Busca.Searching(q);

            
            
            return View(Resultado);
        }
    }
}