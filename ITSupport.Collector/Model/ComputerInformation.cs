using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSupport.Collector
{
    public class ComputerInformation
    {
        /* Legenda:
            V_ = Captura Versão de algum Software
            I_ = Armazena informação aleatoria
            S_ = Captura Status de algum serviço
            H_ = Captura Informações de Hardware
        */
        public string i_lastuser { get; set; }  //Win32_ComputerSystem - UserName OK
        public string i_hostname { get; set; } //Win32_ComputerSystem - Caption OK
        public string i_lastip { get; set; }
        public int i_domain { get; set; } //Retorna do OPT

        public string v_sccm { get; set; } //OK
        public string v_ie { get; set; } //OK
        public string s_tanium { get; set; } //OK

        //Hardware
        public string h_manufacturer { get; set; } //Win32_ComputerSystem - Manufacturer
        public string h_model { get; set; } //Win32_ComputerSystem - Model
        public string h_memory { get; set; } //Win32_ComputerSystem - TotalPhysicalMemory

        public string h_processor { get; set; } //Win32_Processor - Name
        public string h_servicetag { get; set; } //Win32_BIOS - SerialNumber
        public string h_biosversion { get; set; } //Win32_BIOS - SMBIOSBIOSVersion
        public string h_datebios { get; set; } //Win32_BIOS - Description
        public string h_fmonitor { get; set; } //Informações do Primeiro Monitor
        public string h_smonitor { get; set; } //Informações do Segundo Monitor

        //McAfee Information
        public string v_agentmcafee { get; set; }
        public string i_epomcafee { get; set; }
        public string v_enginemcafee { get; set; }
        public string i_datmcafee { get; set; }


    }
}
