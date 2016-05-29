using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITSupport.Lib;

namespace ITSupport.DOS
{
    class Program
    {
        static void Main(string[] args)
        {
            Network Net = new Network();

            List<string> lista = Net.teste();

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            string a = Console.ReadLine();

        }
    }
}
