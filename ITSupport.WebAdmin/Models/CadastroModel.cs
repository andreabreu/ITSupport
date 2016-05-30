using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITSupport.WebAdmin.Models
{
    public class CadastroModel
    {
        public int Id { get; set; }

        //Location
        public string Hostname { get; set; }
        public string Localidade { get; set; }
        public string CentroCusto { get; set; }
        public string Status { get; set; } //Em Uso, em Reparo, bla bla
        public string Ativo { get; set; }
        public string LastUser { get; set; }
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
        [Remote("DoesServiceTagExist", "Cadastro", HttpMethod = "POST", ErrorMessage = "User name already exists. Please enter a different user name.")]
        public string ServiceTag { get; set; } //Win32_BIOS - SerialNumber

        public string BiosVersion { get; set; } //Win32_BIOS - SMBIOSBIOSVersion
        public string DateBios { get; set; } //Win32_BIOS - Description
        public string FirstMonitor { get; set; } //Informações do Primeiro Monitor
        public string SecondMonitor { get; set; } //Informações do Segundo Monitor


        //McAfee Information
        public string AgentMcAfee { get; set; }
        public string EpoMcAfee { get; set; }
        public string EngineMcAfee { get; set; }
        public string DatMcAfee { get; set; }
    }
}