using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITSupport.Lib;

namespace ITSupport.UserUpdate
{
    class Program
    {
        static void Main(string[] args)
        {
            ActiveDirectory AD = new ActiveDirectory();
            Usuario Usuario = new Usuario();

            //Usuario = AD.GetUserInformation("andre_abreu_trp", "Suporte01", "br.aon.bz", "andre_abreu_trp");

            List<Usuario> Lista = AD.ListaUsuarios();

            foreach (var item in Lista)
            {
                Console.WriteLine(item.Nome);
            }
        }

      
    }
}
