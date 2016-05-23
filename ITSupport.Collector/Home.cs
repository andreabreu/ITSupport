using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace ITSupport.Collector
{
    public partial class Home : Form
    {
        public string host;
        Contextox Cont = new Contextox();
        public string admin, password, domain;

        public Home()
        {
            InitializeComponent();
        }


        private void btn_scan_Click(object sender, EventArgs e)
        {







            List<string> items = cl_local.CheckedItems.Cast<string>().ToList();


            Thread t = new Thread(() => loop(items));
            t.Start();





        }

        private void loop(List<string> items)
        {
            foreach (string value in items)
            {
                setlocal(value);
                for (int i = 100; i <= 115; i++)
                {
                    string ipAddress = "10.10." + host + "." + i;
                    if (Cont.CheckOnline(ipAddress) == true)
                    {
                        Coletor Collection = new Coletor();

                        //Retorna todos dados do Computador
                        ComputerInformation Computador = Cont.CheckAuth(ipAddress);

                        //Pega informações do usuário no AD
                        switch (Computador.i_domain)
                        {
                            case 1:
                                domain = ConfigurationManager.AppSettings["DomainARS"];
                                admin = ConfigurationManager.AppSettings["UserARS"];
                                password = ConfigurationManager.AppSettings["PassARS"];

                                break;
                            case 2:
                                domain = ConfigurationManager.AppSettings["DomainAffinity"];
                                admin = ConfigurationManager.AppSettings["UserAffinity"];
                                password = ConfigurationManager.AppSettings["PassAffinity"];
                                break;

                            case 3:
                                domain = ConfigurationManager.AppSettings["DomainLatam"];
                                admin = ConfigurationManager.AppSettings["UserLatam"];
                                password = ConfigurationManager.AppSettings["PassLatam"];

                                break;

                        }

                        UserInformation Username = new UserInformation();
                        //User Usuario = Username.GetUserInformation(admin, password, domain, Computador.i_lastuser);
                        User Usuario = Username.GetUserInformation(admin, password, domain, Computador.i_lastuser);






                        log.Text += ipAddress + " - [" + Computador.i_hostname + "] | " + Computador.i_lastuser + " | " + Usuario.ramal + " OK";
                    }
                    else
                    {
                        log.Text += ipAddress + "Offline \n";

                    }

                }


            } //Fim Foreach

        }

        private void setlocal(string value)
        {
            if (value.Contains("Belo Horizonte")) { host = "28"; }
            if (value.Contains("Campinas")) { host = "30"; }
            if (value.Contains("Curitiba")) { host = "26"; }
            if (value.Contains("Porto Alegre")) { host = "34"; }
            if (value.Contains("Ribeirão Preto")) { host = "42"; }
            if (value.Contains("Rio de Janeiro")) { host = "56"; }
            if (value.Contains("Salvador")) { host = "32"; }
            if (value.Contains("Vitória")) { host = "52"; }
            if (value.Contains("São Paulo - 1º Andar")) { host = "60"; }
            if (value.Contains("São Paulo - 2º Andar")) { host = "62"; }
            if (value.Contains("São Paulo - 3º Andar")) { host = "64"; }
            if (value.Contains("São Paulo - 4º Andar")) { host = "66"; }
            if (value.Contains("São Paulo - 5º Andar")) { host = "68"; }
            if (value.Contains("São Paulo - 6º Andar")) { host = "70"; }
            if (value.Contains("São Paulo - 7º Andar")) { host = "72"; }
            if (value.Contains("São Paulo - 8º Andar")) { host = "74"; }
            if (value.Contains("São Paulo - 9º Andar")) { host = "76"; }
            if (value.Contains("São Paulo - 10º Andar")) { host = "78"; }
            if (value.Contains("Wi-Fi")) { host = "93"; }

        }

        private void Home_Load(object sender, EventArgs e)
        {


            if (Cont.ChecaConexao() == false)
            {
                MessageBox.Show("Falha ao conectar com o banco de dados, favor verificar o arquivo de configuração.");
                this.Close();
            }

            Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}
