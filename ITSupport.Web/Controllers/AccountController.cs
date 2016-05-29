using ITSupport.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace ITSupport.Web.Controllers
{
    public class AccountController : Controller
    {

        // GET: Account
        public ActionResult Index()
        {
            return RedirectToAction("Reset", "Account");
        }

        [HttpGet]
        public ActionResult Reset()
        {
            Repositorio repo = new Repositorio();
            ViewBag.Users = repo.Typeahead("Username", "tblUsuario");

            return View();
        }

        [HttpPost]
        public ActionResult Reset(Usuario usuario)
        {


            return View(usuario);


        }

        public ActionResult Cadastro()
        {
            return View();
        }
    }
}
