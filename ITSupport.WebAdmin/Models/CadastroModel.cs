using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITSupport.WebAdmin.Models
{
    public class CadastroComputador
    {
        public int Id { get; set; }

        //Location
        public string Hostname { get; set; }
        public string Localidade { get; set; }
        public string CentroCusto { get; set; }
        public string Status { get; set; } //Em Uso, em Reparo, bla bla
        [Required]
        [Remote("DoesAtivoExist", "Cadastro", HttpMethod = "POST", ErrorMessage = "Este ativo ja esta cadastrado no Sistema, favor validar o Inventario.")]
        public string Ativo { get; set; }
        public string Dominio { get; set; }

        //Hardware
        public string Tipo { get; set; }
        public string Fabricante { get; set; } //Win32_ComputerSystem - Manufacturer
        public string Modelo { get; set; } //Win32_ComputerSystem - Model

        public string Memoria { get; set; } //Win32_ComputerSystem - TotalPhysicalMemory
        public string Processador { get; set; } //Win32_Processor - Name
        public string HardDrive { get; set; }
        [Required]
        [Display(Name = "Service TAG")]
        [Remote("DoesServiceTagExist", "Cadastro", HttpMethod = "POST", ErrorMessage = "Esta Service Tag ja esta cadastrado no sistema, favor validar o Inventario.")]
        public string ServiceTag { get; set; } //Win32_BIOS - SerialNumber

    }

    public class CadastroFabricante
    {
        [Required]
        public string FabricanteNome { get; set; }
        [Required]
        public string CNPJ { get; set; }
        public string WebSite { get; set; }

    }
   

   


}