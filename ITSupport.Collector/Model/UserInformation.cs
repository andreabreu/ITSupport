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
        public DirectorySearcher dirSearch = null;
        User usuario = new User();

        public User GetUserInformation(string username, string passowrd, string domain, string user)
        {
            SearchResult rs = null;
            rs = SearchUserByUserName(GetDirectorySearcher(username, passowrd, domain), user);
            ShowUserInformation(rs);
            return usuario;
        }

        public User ShowUserInformation(SearchResult rs)
        {
                usuario.nome = rs.GetDirectoryEntry().Properties["Name"].Value.ToString();
                usuario.username = rs.GetDirectoryEntry().Properties["samaccountname"].Value.ToString();
                usuario.email = rs.GetDirectoryEntry().Properties["mail"].Value.ToString();
               
                usuario.ramal = rs.GetDirectoryEntry().Properties["telephoneNumber"].Value.ToString();
                usuario.cargo = rs.GetDirectoryEntry().Properties["title"].Value.ToString();
                usuario.gerente = rs.GetDirectoryEntry().Properties["manager"].Value.ToString().Substring(3).Split(',')[0];

                usuario.departamento = rs.GetDirectoryEntry().Properties["Description"].Value.ToString();

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
