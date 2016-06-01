using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITSupport.Lib;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;

namespace ITSupport.DOS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Network Net = new Network();

            //List<string> lista = Net.teste();

            //foreach (var item in lista)
            //{
            //    Console.WriteLine(item);
            //}

            //string a = Console.ReadLine();

            Repositorio repo = new Repositorio();

            Usuario usuario = new Usuario();

            PrincipalContext AD = new PrincipalContext(ContextType.Domain, "br.aon.bz");
            UserPrincipal u = new UserPrincipal(AD);
            PrincipalSearcher search = new PrincipalSearcher(u);


            foreach (UserPrincipal result in search.FindAll())
            {
                try
                {
                    if (result.DisplayName.Contains("'"))
                    {
                        string user = result.DisplayName;
                        usuario.Nome = user.Replace("'", "''");
                    }
                } catch { }
              
                
               
                usuario.Username = result.SamAccountName;
                usuario.Departamento = result.Description;
                usuario.Email = result.EmailAddress;
                usuario.Ramal = result.VoiceTelephoneNumber;
                usuario.ScriptPath = result.ScriptPath;
                try { usuario.AccountExpirationDate = (DateTime)result.AccountExpirationDate; } catch { }
                usuario.DistinguishedName = result.DistinguishedName;
                usuario.Enabled = (string)result.Enabled.ToString();
                try { usuario.LastLogon = (DateTime)result.LastLogon; } catch { }
                try { usuario.LastPasswordSet = (DateTime)result.LastPasswordSet; } catch { }



                if (result.GetUnderlyingObjectType() == typeof(DirectoryEntry))
                {
                    // Transition to directory entry to get other properties
                    using (var entry = (DirectoryEntry)result.GetUnderlyingObject())
                    {
                        try { usuario.Superior = entry.Properties["manager"].Value.ToString(); } catch { }
                        try { usuario.Matricula = entry.Properties["pager"].Value.ToString(); } catch { }
                        try { usuario.Created = (DateTime)entry.Properties["Created"].Value; } catch { }
                    }
                }

                repo.InserirUsuario(usuario);


            }

        }
    }
}
