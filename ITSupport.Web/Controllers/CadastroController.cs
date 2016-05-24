using ITSupport.Lib;
using System.Web.Mvc;

namespace ITSupport.Web.Controllers
{
    public class CadastroController : Controller
    {

        Repositorio Repo = new Repositorio();


        public ActionResult Index()
        {
            return RedirectToAction("Equipamento", "Cadastro");
        }


        public ActionResult Equipamento(string Computer)
        {
            var computador = new Computador();

            ViewBag.ListaCentroCusto = Repo.ListaColuna("CentroCusto", "tblCentroCusto");
            ViewBag.ListaModeloDell = Repo.ListaModelo("Dell Inc.");
            ViewBag.ListaModeloLenovo = Repo.ListaModelo("Lenovo");
            ViewBag.ListaModeloHP = Repo.ListaModelo("Hewlett Packard");
            ViewBag.Computador = Computer;


            return View(computador);

        }

        [HttpPost]
        public ActionResult Equipamento(Computador computador)
        {

            if (ModelState.IsValid)
            {
                Repo.Salvar(computador);
                return RedirectToAction("Equipamento", new { Computer = computador.Hostname });
            }
            else
            {
                //Fazer bagui de falha
                return RedirectToAction("Equipamento", new { Computer = "Falha" });
            }
            //Passa parametro de sucesso.




            }
        }
    }