using System;

namespace ITSupport.Web
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
    }

    public class ComputerInformation
    {
        public string tipo { get; set; }
        public string fornecedor { get; set; }
        public string modelo { get; set; }
        public string servicetag { get; set; }
        public string processador { get; set; }
        public string harddrive { get; set; }
        public string memoria { get; set; }
        public string hostname { get; set; }

        public string localidade { get; set; }
        public string CCusto { get; set; }
        public string status { get; set; }
        public string ativo { get; set; }
        public string DataCadastro { get; set; }

    }
}
