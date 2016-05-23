using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace ITSupport.Collector
{
    public class Coletor
    {
        ComputerInformation Computer = new ComputerInformation();

        public ComputerInformation Collect(string ipAddress, ConnectionOptions opt)
        {
            _win32_BIOS(ipAddress, opt);
            _sms_Client(ipAddress, opt);
            _win32_ComputerSystem(ipAddress, opt);
            _Win32_Processor(ipAddress, opt);
            _InternetExplorer(ipAddress, opt);
            _TaniumClient(ipAddress, opt);

            _epoMcAfee(ipAddress, opt);
            _agentMcAfee(ipAddress, opt);
            _engineMcAfee(ipAddress, opt);
            _datMcAfee(ipAddress, opt);


            Computer.i_lastip = ipAddress;


            //Seta o Dominio
            if (opt.Authority.Contains("br.aon.bz")) { Computer.i_domain = 1; }
            if (opt.Authority.Contains("aonbrasgsao01")) { Computer.i_domain = 2; }
            if (opt.Authority.Contains("aonnet.aon.net")) { Computer.i_domain = 3; }

          

            return Computer;

        }

        private void _win32_BIOS(string ipAddress, ConnectionOptions opt)
        {
            string querys = "SELECT * FROM Win32_BIOS";
            WqlObjectQuery wql = new WqlObjectQuery(querys);

            ManagementScope inventoryAgentScope = new ManagementScope(@"\\" + ipAddress + @"\root\cimv2", opt);
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(inventoryAgentScope, wql);
            ManagementObjectCollection queryResults = searcher.Get();
            Computer.h_servicetag = (string)queryResults.Cast<ManagementBaseObject>().First()["SerialNumber"];
            Computer.h_biosversion = (string)queryResults.Cast<ManagementBaseObject>().First()["SMBIOSBIOSVersion"];
            string bios_date = (string)queryResults.Cast<ManagementBaseObject>().First()["Description"]; //Description = BIOS Date: 01 / 08 / 15 20:14:41 Ver: A03.00
            string[] bios_dates = bios_date.Split(' ');
            Computer.h_datebios = bios_dates[2];

        }

        private void _sms_Client(string ipAddress, ConnectionOptions opt)
        {
            string query = "SELECT * FROM sms_Client";
            ObjectQuery wql = new ObjectQuery(query);
            ManagementScope inventoryAgentScope = new ManagementScope("\\\\" + ipAddress + "\\root\\ccm", opt);

            ManagementObjectSearcher searcher = new ManagementObjectSearcher(inventoryAgentScope, wql);
            ManagementObjectCollection queryResults = searcher.Get();
            Computer.v_sccm = (string)queryResults.Cast<ManagementBaseObject>().First()["ClientVersion"];

        }

        private void _win32_ComputerSystem(string ipAddress, ConnectionOptions opt)
        {
            string querys = "SELECT * FROM Win32_ComputerSystem";
            WqlObjectQuery wql = new WqlObjectQuery(querys);
            ManagementScope scope = new ManagementScope(@"\\" + ipAddress + @"\root\cimv2", opt);
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, wql);
            ManagementObjectCollection queryResults = searcher.Get();

            Computer.i_lastuser = (string)queryResults.Cast<ManagementBaseObject>().First()["UserName"].ToString().Split('\\')[1];
            Computer.h_manufacturer = (string)queryResults.Cast<ManagementBaseObject>().First()["Manufacturer"];
            Computer.h_model = (string)queryResults.Cast<ManagementBaseObject>().First()["Model"];
            Computer.i_hostname = (string)queryResults.Cast<ManagementBaseObject>().First()["DNSHostName"];
            //Captura informações da Memoria
            double memory = (UInt64)queryResults.Cast<ManagementBaseObject>().First()["TotalPhysicalMemory"];
            double SizeinGB = memory / (1073741824);
            memory = Math.Round(SizeinGB);
            Computer.h_memory = memory + " GB";

        }

        private void _Win32_Processor(string ipAddress, ConnectionOptions opt)
        {
            string querys = "SELECT * FROM Win32_Processor";
            WqlObjectQuery wql = new WqlObjectQuery(querys);
            ManagementScope scope = new ManagementScope(@"\\" + ipAddress + @"\root\cimv2", opt);
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, wql);
            ManagementObjectCollection queryResults = searcher.Get();

            Computer.h_processor = (string)queryResults.Cast<ManagementBaseObject>().First()["Name"];

        }

        private void _InternetExplorer(string ipAddress, ConnectionOptions opt)
        {
            ManagementScope scope = new ManagementScope(@"\\" + ipAddress + @"\root\cimv2", opt);
            scope.Connect();

            ManagementClass registry = new ManagementClass(scope, new ManagementPath("StdRegProv"), null);
            ManagementBaseObject inParams = registry.GetMethodParameters("GetStringValue");
            inParams["sValueName"] = "Version";
            inParams["hDefKey"] = 0x80000002;// HKEY_LOCAL_MACHINE;
            inParams["sSubKeyName"] = "Software\\Microsoft\\Internet Explorer";

            ManagementBaseObject outParams = registry.InvokeMethod("GetStringValue", inParams, null);
            try
            {
                string v_ie = outParams.Properties["sValue"].Value.ToString();

                if ((v_ie.Contains("9.10")) || (v_ie.Contains("9.11")))
                {
                    Computer.v_ie = v_ie.Substring(2);
                }
            } catch
            {
                Computer.v_ie = "";
            }
           
        }

        private void _TaniumClient(string ipAddress, ConnectionOptions opt)
        {
            string querys = "SELECT * FROM Win32_Service WHERE Name='Tanium Client'";
            WqlObjectQuery wql = new WqlObjectQuery(querys);
            ManagementScope scope = new ManagementScope(@"\\" + ipAddress + @"\root\cimv2", opt);
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, wql);
            ManagementObjectCollection queryResults = searcher.Get();

            try
            {
                Computer.s_tanium = (string)queryResults.Cast<ManagementBaseObject>().First()["State"];
            } catch
            {
                Computer.s_tanium = "";
            }
            
        }
        
        private void _epoMcAfee(string ipAddress, ConnectionOptions opt)
        {
            System.Management.ManagementScope scope = new System.Management.ManagementScope(@"\\" + ipAddress + @"\root\cimv2", opt);
            scope.Connect();

            ManagementClass registry = new ManagementClass(scope, new ManagementPath("StdRegProv"), null);
            ManagementBaseObject inParams = registry.GetMethodParameters("GetStringValue");
            inParams["sValueName"] = "ePOServerList";
            inParams["hDefKey"] = 0x80000002;// HKEY_LOCAL_MACHINE;
            inParams["sSubKeyName"] = "Software\\Wow6432Node\\Network Associates\\ePolicy Orchestrator\\Agent";

            ManagementBaseObject outParams = registry.InvokeMethod("GetStringValue", inParams, null);
           try
            {
                Computer.i_epomcafee = outParams.Properties["sValue"].Value.ToString();
            }
            catch
            {
                Computer.i_epomcafee = "";
            }
           

        }

        private void _agentMcAfee(string ipAddress, ConnectionOptions opt)
        {
            System.Management.ManagementScope scope = new System.Management.ManagementScope(@"\\" + ipAddress + @"\root\cimv2", opt);
            scope.Connect();

            ManagementClass registry = new ManagementClass(scope, new ManagementPath("StdRegProv"), null);
            ManagementBaseObject inParams = registry.GetMethodParameters("GetStringValue");
            inParams["sValueName"] = "DisplayVersion";
            inParams["hDefKey"] = 0x80000002;// HKEY_LOCAL_MACHINE;
            inParams["sSubKeyName"] = "SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\{76473CBB-FE8D-4E3A-9591-CD6EFB621063}";
            ManagementBaseObject outParams = registry.InvokeMethod("GetStringValue", inParams, null);
            try
            {
                Computer.v_agentmcafee = outParams.Properties["sValue"].Value.ToString();
            } catch
            {
                Computer.v_agentmcafee = "";
            }
            

        }

        private void _engineMcAfee(string ipAddress, ConnectionOptions opt)
        {
            
            System.Management.ManagementScope scope = new System.Management.ManagementScope(@"\\" + ipAddress + @"\root\cimv2", opt);
            scope.Connect();

            ManagementClass registry = new ManagementClass(scope, new ManagementPath("StdRegProv"), null);
            ManagementBaseObject inParams = registry.GetMethodParameters("GetStringValue");
            inParams["sValueName"] = "EngineVersion";
            inParams["hDefKey"] = 0x80000002;// HKEY_LOCAL_MACHINE;
            inParams["sSubKeyName"] = "SOFTWARE\\Wow6432Node\\Network Associates\\ePolicy Orchestrator\\Application Plugins\\VIRUSCAN8800";
            ManagementBaseObject outParams = registry.InvokeMethod("GetStringValue", inParams, null);
            
            try
            {
                Computer.v_enginemcafee = outParams.Properties["sValue"].Value.ToString();
            } catch
            {
                Computer.v_enginemcafee = "";
            }
            
        }

        private void _datMcAfee(string ipAddress, ConnectionOptions opt)
        {
            System.Management.ManagementScope scope = new System.Management.ManagementScope(@"\\" + ipAddress + @"\root\cimv2", opt);
            scope.Connect();
            ManagementClass registry = new ManagementClass(scope, new ManagementPath("StdRegProv"), null);
            ManagementBaseObject inParams = registry.GetMethodParameters("GetStringValue");
            inParams["sValueName"] = "AVDatDate";
            inParams["hDefKey"] = 0x80000002;// HKEY_LOCAL_MACHINE;
            inParams["sSubKeyName"] = "Software\\Wow6432Node\\McAfee\\AvEngine";

            ManagementBaseObject outParams = registry.InvokeMethod("GetStringValue", inParams, null);

            try
            {
                Computer.i_datmcafee = outParams.Properties["sValue"].Value.ToString();
            } catch
            {
                Computer.i_datmcafee = "";
            }
            
        }

    }
}
