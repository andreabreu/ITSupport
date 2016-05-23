using ITSupport.Lib;
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
            ViewBag.Users = repo.Typeahead("logins", "tblLogins");

            return View();
        }

        [HttpPost]
        public ActionResult Reset(UserInformation usuario)
        {


            return View(usuario);


        }
    }
}