using System;
using System.ComponentModel.DataAnnotations;

namespace ITSupport.Web.Models
{
    public class UserInformation
    {
        public string nome { get; set; } //displayName
        public string username { get; set; } //sAMAccountName
        public string departamento { get; set; } //description
        public string email { get; set; } //mail
        public string ramal { get; set; } //telephoneNumber
        public string cargo { get; set; } //title
        public string superior { get; set; } //manager
        public string scriptlogon { get; set; } //scriptPath
        public string matricula { get; set; } //pager
        public string dominio { get; set; }
    }

    public class ComputerInformation
    {
        public int id { get; set; }

        [Display(Name = "Tipo")]
        public string tipo { get; set; }
        public string fornecedor { get; set; }
        public string modelo { get; set; }

        [Required(ErrorMessage = "Preencha o Service TAG")]
        [Display(Name = "Service TAG")]
        public string servicetag { get; set; }

        public string processador { get; set; }
        public string harddrive { get; set; }
        public string memoria { get; set; }

        [Required(ErrorMessage = "Preencha o hostname")]
        [StringLength(50, MinimumLength = 6)]
        [Display(Name = "Hostname")]
        public string hostname { get; set; }

        public string localidade { get; set; }

        [Required(ErrorMessage = "Preencha o Centro de Custo")]
        public string CCusto { get; set; }

        public string status { get; set; }

        [Required(ErrorMessage = "Preencha o número de patrimônio do equipamento!")]
        [Display(Name = "Patrimônio")]
        public string ativo { get; set; }

        public string lastuser { get; set; }
        public bool aAD { get; set; }
        public bool aControladoria { get; set; }

    }

    public class SearchInformation
    {
        public string tipo { get; set; }
        public string descricao { get; set; }
    }
}
