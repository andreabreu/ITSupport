using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITSupport.Lib;

namespace ITSupport.WebAdmin.Controllers
{
    public class CadastroController : Controller
    {
        private readonly CadastroComputador _computador = new CadastroComputador();
        private readonly Repositorio _repositorio = new Repositorio();
        private readonly CadastroFabricante _fabricante;
        private readonly CadastroModelo _modelo;

        // GET: Cadastro
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Computador()
        {
            List<string> modelos = _repositorio.ListaSelect("Modelo");
            List<string> fabricantes = _repositorio.ListaSelect("Fabricante");
            List<string> escritorios = _repositorio.ListaSelect("Escritorio");
            List<string> centroDeCusto = _repositorio.ListaSelect("CentroDeCusto");

            ViewBag.Modelos = modelos;
            ViewBag.Fabricantes = fabricantes;
            ViewBag.Escritorios = escritorios;
            ViewBag.CentroDeCusto = centroDeCusto;

            ViewBag.Controller = "Cadastro";
            return View(_computador);
        }

        [HttpPost]
        public ActionResult Computador(Computador computador)
        {
            List<string> modelos = _repositorio.ListaSelect("Modelo");
            List<string> fabricantes = _repositorio.ListaSelect("Fabricante");
            List<string> escritorios = _repositorio.ListaSelect("Escritorio");

            ViewBag.Modelos = modelos;
            ViewBag.Fabricantes = fabricantes;
            ViewBag.Escritorios = escritorios;


            if (ModelState.IsValid)
            {
                TempData["Success"] = computador.Fabricante + " - " + computador.Modelo + ": Cadastrado com sucesso!";
                _repositorio.InserirComputador(computador);
                return View();
            }
            else
            {
                TempData["Fail"] = "Falha ao processar o cadastrado, valide as informacoes preenchidas.";
                return View();
            }
        }

        

        public ActionResult Fabricante()
        {
            
            return View(_fabricante);
        }

        [HttpPost]
        public ActionResult Fabricante(CadastroFabricante _fabricante)
        {
            if (ModelState.IsValid)
            {
                TempData["Success"] = _fabricante.FabricanteNome + " - Cadastrado com sucesso!";
                _repositorio.InserirFabricante(_fabricante);
                ModelState.Clear();
                return View();
            }
            else
            {
                TempData["Fail"] = _fabricante.FabricanteNome + " - Problema ao cadastrar o Fabricante.";
                return View();
            }

            
        }


        public ActionResult Modelo()
        {
            List<string> fabricantes = _repositorio.ListaSelect("Fabricante");
            ViewBag.Fabricantes = fabricantes;

            return View(_modelo);
        }

        [HttpPost]
        public ActionResult Modelo(CadastroModelo _modelo)
        {
            List<string> fabricantes = _repositorio.ListaSelect("Fabricante");
            ViewBag.Fabricantes = fabricantes;

            if (ModelState.IsValid)
            {
                TempData["Success"] = _modelo.ModeloNome + " - Cadastrado com sucesso!";
                _repositorio.InserirModelo(_modelo);
                ModelState.Clear();
                return View();
            }
            else
            {
                TempData["Fail"] = _modelo.ModeloNome + " - Problema ao cadastrar o Fabricante.";
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