using System;

namespace ITSupport.Lib
{
    public class Usuario
    {
        public string Nome { get; set; } //displayName\\
        public string Username { get; set; } //sAMAccountName\\
        public string Departamento { get; set; } //description\\
        public string Email { get; set; } //mail\\
        public string Ramal { get; set; } //telephoneNumber
        public string Cargo { get; set; } //title
        public string Superior { get; set; } //manager
        public string ScriptLogon { get; set; } //scriptPath
        public string Matricula { get; set; } //pager
        public string Dominio { get; set; }

    }

    public class UsuarioAD
    {
        public DateTime AccountExpirationDate { get; set; } //Um DateTime que especifica a data e hora em que a conta expira ou null se a conta nunca expira. 
        public string DisplayName { get; set; } //A exibição de nome para esta entidade ou null se não houver nenhum nome de exibição.
        public string DistinguishedName { get; } //O DN para esta entidade ou null se não houver nenhum DN.
        public Nullable<bool> Enabled { get; set; } //true Se o objeto é ativado ou nulo se a conta não persistiu; Caso contrário, false.
        public Nullable<DateTime> LastLogon { get; } //Um Nullable DateTime que especifica a data e hora do último logon para esta conta. 
        public Nullable<DateTime> LastPasswordSet { get; } //Um Nullable DateTime que especifica a última data e hora em que a senha foi definida para esta conta.
        public string SamAccountName { get; set; } //A conta do SAM nome para esta entidade ou nulo se nenhum nome tiver sido definida. 
        public string ScriptPath { get; set; } //Um caminho do script para esta conta, ou null se não houver nenhum caminho de script. 
        public string Sid { get; } //O SecurityIdentifier para esta entidade ou null se não houver nenhuma SID. 
        public string UserPrincipalName { get; set; }  //O UPN associado a esta entidade ou null se não se o UPN não foi definido. 
        public string Description { get; set; }
        public string Mail { get; set; }
        public string telephoneNumber { get; set; }
        public string title { get; set; }


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
