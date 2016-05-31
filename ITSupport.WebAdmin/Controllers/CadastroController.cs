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
        private readonly CadastroComputador _computador = new CadastroComputador();
        private readonly Repositorio _repositorio = new Repositorio();

        

        // GET: Cadastro
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Computador()
        {
            List<string> modelos = _repositorio.ListaSelect("Modelo");
            List<string> fabricantes = _repositorio.ListaSelect("Fabricante");



            ViewBag.Modelos = modelos;
            ViewBag.Fabricantes = fabricantes;


            ViewBag.Controller = "Cadastro";
            return View(_computador);
        }


        [HttpPost]
        public ActionResult Computador(Computador computador)
        {
            List<string> modelos = _repositorio.ListaSelect("Modelo");
            List<string> fabricantes = _repositorio.ListaSelect("Fabricante");

            ViewBag.Modelos = modelos;
            ViewBag.Fabricantes = fabricantes;

            if (ModelState.IsValid)
            {
                TempData["Success"] = computador.Fabricante + " - " + computador.Modelo + ": Cadastrado com sucesso!";
                _repositorio.Inserir(computador);
                return View();
            }
            else
            {
                TempData["Fail"] = "Falha ao processar o cadastrado, valide as informacoes preenchidas.";
                return View();
            }
           
           
           
        }




        //ABAIXO SOMENTE VALIDACAO EM REAL TIME
        [HttpPost]
        public JsonResult DoesServiceTagExist(string ServiceTag)
        {

            if (_repositorio.CheckExist("tblComputador", "ServiceTag", ServiceTag))
            {
                return Json(false);
            }
            else
            {
                return Json(true);
            }

          
        }

        [HttpPost]
        public JsonResult DoesAtivoExist(string Ativo)
        {
            if (_repositorio.CheckExist("tblComputador", "Ativo", Ativo))
            {
                return Json(false);
            }
            else
            {
                return Json(true);
            }
        }
    }
}