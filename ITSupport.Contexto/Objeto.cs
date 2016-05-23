namespace ITSupport.Lib
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
        public string dominio { get; set; }
    }

    public class ComputerInformation
    {
        
        public int id { get; set; } //
        public string tipo { get; set; } //
        public string fornecedor { get; set; } //
        public string modelo { get; set; }//

        
        public string servicetag { get; set; } //

        public string processador { get; set; } //
        public string harddrive { get; set; } //
        public string memoria { get; set; } //

        
        public string hostname { get; set; } //
        public string localidade { get; set; }
        public string CCusto { get; set; } //
        public string status { get; set; }//
        public string ativo { get; set; } //

        public string lastuser { get; set; } //

    }

    public class Computador
    {
        public int ID { get; set; }

        //Location
        public string Hostname { get; set; }
        public string Localidade { get; set; }
        public string CentroCusto { get; set; }
        public string Status { get; set; } //Em Uso, em Reparo, bla bla
        public string Ativo { get; set; }
        public string LastUser { get; set; }
        public string Dominio { get; set; }

        //Hardware
        public string Tipo { get; set; } 
        public string Fornecedor { get; set; } //Win32_ComputerSystem - Manufacturer
        public string Modelo { get; set; } //Win32_ComputerSystem - Model

        public string Memoria { get; set; } //Win32_ComputerSystem - TotalPhysicalMemory
        public string Processador { get; set; } //Win32_Processor - Name
        public string HardDrive { get; set; }
        public string ServiceTag { get; set; } //Win32_BIOS - SerialNumber

        public string BiosVersion { get; set; } //Win32_BIOS - SMBIOSBIOSVersion
        public string DateBios { get; set; } //Win32_BIOS - Description
        public string FirstMonitor { get; set; } //Informações do Primeiro Monitor
        public string SecondMonitor { get; set; } //Informações do Segundo Monitor


        //McAfee Information
        public string AgentMcAfee { get; set; }
        public string EpoMcAfee { get; set; }
        public string EngineMcAfee { get; set; }
        public string DatMcAfee { get; set; }
    }

    public class SearchInformation
    {
        public string tipo { get; set; }
        public string descricao { get; set; }
    }
}
