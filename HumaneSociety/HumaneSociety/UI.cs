using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public static class UI
    {
        public static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to Humane Society.");
        }
        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
        public static string GetUserInput()
        {
            return Console.ReadLine();
        }
    }
}
