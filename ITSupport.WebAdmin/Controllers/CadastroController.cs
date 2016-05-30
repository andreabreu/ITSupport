using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITSupport.Lib;
using ITSupport.WebAdmin.Models;

namespace ITSupport.WebAdmin.Controllers
{
    public class CadastroController : Controller
    {
        private readonly Computador _computador = new Computador();

        // GET: Cadastro
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Computador()
        {
            ViewBag.Controller = "Cadastro";
            return View(_computador);
        }

        [HttpPost]
        public ActionResult Computador(Computador computador)
        {
            return View();
        }


        [HttpPost]
        public JsonResult DoesServiceTagExist(string ServiceTag)
        {
            var tag = ServiceTag;

            return Json(tag == null);
        }
    }
}