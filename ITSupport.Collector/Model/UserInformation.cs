using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;

namespace ITSupport.Collector
{
    public class User
    {
        public string username { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string gerente { get; set; }
        public string ramal { get; set; }
        public string cargo { get; set; }
        public string departamento { get; set; }
        public string scriptlogon { get; set; }
        public int matricula { get; set; }


    }

    class UserInformation
    {
       
    }
}
