using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace ITSupport.Collector
{

    public class Contexto
    {
        //ComputerInformation Computer = new ComputerInformation();


        public bool ChecaConexao()
        {
            string connectionSTR = ConfigurationManager.ConnectionStrings["ConnectionSQL"].ConnectionString;
            SqlConnection myConn = new SqlConnection(connectionSTR);

            try
            {
                myConn.Open();
                return true;

            }
            catch
            {
                return false;
            }


        }

        public void AuthChange()
        {
            //Credenciais Domain ARS
            string DomainARS = ConfigurationManager.AppSettings["DomainARS"];
            string UserARS = ConfigurationManager.AppSettings["UserARS"];
            string PassARS = ConfigurationManager.AppSettings["PassARS"];

            //Credenciais Domain Affinity
            string DomainAffinity = ConfigurationManager.AppSettings["DomainAffinity"];
            string UserAffinity = ConfigurationManager.AppSettings["UserAffinity"];
            string PassAffinity = ConfigurationManager.AppSettings["PassAffinity"];

            //Credenciais Domain Latam
            string DomainLatam = ConfigurationManager.AppSettings["DomainLatam"];
            string UserLatam = ConfigurationManager.AppSettings["UserLatam"];
            string PassLatam = ConfigurationManager.AppSettings["PassLatam"];

        }

        public bool CheckOnline(string ipAddress)
        {
            try
            {
                Ping myPing = new Ping();
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(ipAddress, timeout, buffer, pingOptions);
                if (reply.Status == IPStatus.Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }


        }

        public ComputerInformation CheckAuth(string ipAddress)
        {
            //List<ComputerInformation> ComputerList = new List<ComputerInformation>();
            ComputerInformation Computer = new ComputerInformation();
            bool granted = false;
            int tries = 1;
            
            ConnectionOptions opt = new ConnectionOptions();

            do
            {
                switch (tries)
                {
                    case 1:
                        opt.Authority = "ntlmdomain:" + ConfigurationManager.AppSettings["DomainARS"];
                        opt.Username = ConfigurationManager.AppSettings["UserARS"];
                        opt.Password = ConfigurationManager.AppSettings["PassARS"];
                       

                        break;
                    case 2:
                        opt.Authority = "ntlmdomain:" + ConfigurationManager.AppSettings["DomainAffinity"];
                        opt.Username = ConfigurationManager.AppSettings["UserAffinity"];
                        opt.Password = ConfigurationManager.AppSettings["PassAffinity"];
                       
                        break;

                    case 3:
                        opt.Authority = "ntlmdomain:" + ConfigurationManager.AppSettings["DomainLatam"];
                        opt.Username = ConfigurationManager.AppSettings["UserLatam"];
                        opt.Password = ConfigurationManager.AppSettings["PassLatam"];
                        
                        break;
                }
                try
                {
                    string queryuser = "SELECT * FROM Win32_ComputerSystem";
                    WqlObjectQuery wqluser = new WqlObjectQuery(queryuser);
                    ManagementScope scope = new ManagementScope("\\\\" + ipAddress + "\\root\\cimv2", opt);
                    ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, wqluser);
                    ManagementObjectCollection queryResults = searcher.Get();
                    Computer.i_lastuser = (string)queryResults.Cast<ManagementBaseObject>().First()["UserName"];

                    granted = true;

                    Coletor Collection = new Coletor();
                    Computer = Collection.Collect(ipAddress, opt);
                    
                    
                    return Computer;
                    // ComputerList.Add(Computer);
                }
                catch (Exception ex)
                {
                    granted = false;
                    tries++;
                } 

            } while ((tries != 3) && (granted == false));

            return Computer;




        }



    }
}
