
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ITSupport.Lib
{
    public class Network
    {
        public List<string> teste()
        {
            List<string> Lista = new List<string>();
            
            IPNetwork ipn = IPNetwork.Parse("10.10.1.0/23");
            IPAddressCollection ips = IPNetwork.ListIPAddress(ipn);

            foreach (IPAddress ip in ips)
            {
                Lista.Add(ip.ToString());
            }
            return Lista;
        }


    }

}

