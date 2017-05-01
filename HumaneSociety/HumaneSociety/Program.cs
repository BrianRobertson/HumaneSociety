using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Program
    {
        static void Main(string[] args)
        {
            Agency agency = new Agency();
            agency.Start();
            Console.ReadLine();
        }
    }
}
