using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSupport.UI.DOS
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection Connect = new SqlConnection(@"Data Source=.\SQLSERVER;Initial Catalog=dbITSupport;Integrated Security=SSPI;");

            Connect.Open();
        }
    }
}
