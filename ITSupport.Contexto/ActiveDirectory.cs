using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;


namespace ITSupport.Lib
{
    class ActiveDirectory
    {
        public DirectorySearcher dirSearch = null;

        Usuario usuario = new Usuario();
        
        public Usuario GetUserInformation(string username, string passowrd, string domain, string user)
        {
            SearchResult rs = null;
            rs = SearchUserByUserName(GetDirectorySearcher(username, passowrd, domain), user);
            ShowUserInformation(rs);
            return usuario;
        }

        public Usuario ShowUserInformation(SearchResult rs)
        {
            usuario.Nome = rs.GetDirectoryEntry().Properties["displayName"].Value.ToString();
            usuario.Username = rs.GetDirectoryEntry().Properties["samaccountname"].Value.ToString();
            usuario.Email = rs.GetDirectoryEntry().Properties["mail"].Value.ToString();

            usuario.Ramal = rs.GetDirectoryEntry().Properties["telephoneNumber"].Value.ToString();
            usuario.Cargo = rs.GetDirectoryEntry().Properties["title"].Value.ToString();
            usuario.Superior = rs.GetDirectoryEntry().Properties["manager"].Value.ToString().Substring(3).Split(',')[0];
            usuario.Departamento = rs.GetDirectoryEntry().Properties["Description"].Value.ToString();
            usuario.ScriptLogon = rs.GetDirectoryEntry().Properties["scriptPath"].Value.ToString();
            usuario.Matricula = rs.GetDirectoryEntry().Properties["pager"].Value.ToString();

            return usuario;

        }
        private DirectorySearcher GetDirectorySearcher(string username, string passowrd, string domain)
        {
            if (dirSearch == null)
            {
                try
                {
                    dirSearch = new DirectorySearcher(
                    new DirectoryEntry("LDAP://" + domain, username, passowrd));
                }
                catch (DirectoryServicesCOMException e)
                {
                    //MessageBox.Show("Connection Creditial is Wrong!!!, please Check.", "Erro Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // e.Message.ToString();
                }
                return dirSearch;
            }
            else
            {
                return dirSearch;
            }
        }

        private SearchResult SearchUserByUserName(DirectorySearcher ds, string username)
        {
            ds.Filter = "(&((&(objectCategory=Person)(objectClass=User)))(samaccountname=" + username + "))";

            ds.SearchScope = SearchScope.Subtree;
            ds.ServerTimeLimit = TimeSpan.FromSeconds(90);

            SearchResult userObject = ds.FindOne();

            if (userObject != null)
                return userObject;
            else
                return null;
        }
    }
}
