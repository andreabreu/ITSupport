using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITSupport.Lib;

namespace ITSupport.WebAdmin.Controllers
{
    public class RecursosHumanosController : Controller
    {
        private readonly Admissao usuario = new Admissao();
        private Repositorio _repositorio = new Repositorio();

        // GET: RecursosHumanos
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Admissao()
        {
            List<string> escritorios = _repositorio.ListaSelect("Escritorio");
            List<string> CentroCusto = _repositorio.ListaSelect("CentroDeCusto");

            ViewBag.Escritorios = escritorios;
            ViewBag.CentroDeCusto = CentroCusto;

            return View(usuario);
        }
    }
}