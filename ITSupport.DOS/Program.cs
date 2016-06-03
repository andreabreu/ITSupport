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
        readonly Usuario _usuario = new Usuario();

        static void Main(string[] args)
        {
           

        }

        public void RefreshUsersAD()
        {
            PrincipalContext AD = new PrincipalContext(ContextType.Domain, "br.aon.bz");
            UserPrincipal u = new UserPrincipal(AD);
            PrincipalSearcher search = new PrincipalSearcher(u);


            foreach (UserPrincipal result in search.FindAll())
            {
                if (result.DisplayName != null)
                {
                    if (result.DisplayName.Contains("'"))
                    {
                        string user = result.DisplayName;
                        StringBuilder builder = new StringBuilder();
                        builder.Append(user).Replace(user, user.Replace("'", ""));
                        _usuario.Nome = builder.ToString();

                    }
                    else
                    {
                        _usuario.Nome = result.DisplayName;
                    }
                }


                _usuario.Username = result.SamAccountName;
                _usuario.Departamento = result.Description;
                _usuario.Email = result.EmailAddress;
                _usuario.Ramal = result.VoiceTelephoneNumber;
                _usuario.ScriptPath = result.ScriptPath;


                if (result.AccountExpirationDate != null)
                {
                    var sqlFormattedDate = (DateTime)result.AccountExpirationDate;
                    _usuario.AccountExpirationDate = sqlFormattedDate.Date.ToString("yyyy-MM-dd HH:mm:ss");
                }

                //Remove Quotes
                string DName = result.DistinguishedName;
                StringBuilder builders = new StringBuilder();
                builders.Append(DName).Replace(DName, DName.Replace("'", ""));
                _usuario.DistinguishedName = builders.ToString();




                _usuario.Enabled = (string)result.Enabled.ToString();

                if (result.LastLogon != null)
                {
                    var sqlFormattedDate = (DateTime)result.LastLogon;
                    _usuario.LastLogon = sqlFormattedDate.Date.ToString("yyyy-MM-dd HH:mm:ss");
                }



                if (result.LastPasswordSet != null)
                {
                    var sqlFormattedDate = (DateTime)result.LastPasswordSet;
                    _usuario.LastPasswordSet = sqlFormattedDate.Date.ToString("yyyy-MM-dd HH:mm:ss");
                }


                if (result.GetUnderlyingObjectType() == typeof(DirectoryEntry))
                {
                    // Transition to directory entry to get other properties
                    using (var entry = (DirectoryEntry)result.GetUnderlyingObject())
                    {
                        if (entry.Properties["manager"].Value != null)
                        {
                            _usuario.Superior = entry.Properties["manager"].Value.ToString();
                        }


                        if (entry.Properties["pager"].Value != null)
                        {
                            _usuario.Matricula = entry.Properties["pager"].Value.ToString();
                        }


                        if (entry.Properties["whenCreated"].Value != null)
                        {
                            var sqlFormattedDate = (DateTime)entry.Properties["whenCreated"].Value;
                            _usuario.Created = sqlFormattedDate.Date.ToString("yyyy-MM-dd HH:mm:ss");
                        }
                    }

                }


                _repositorio.InserirUsuario(_usuario);
            }
        }
    }
}
