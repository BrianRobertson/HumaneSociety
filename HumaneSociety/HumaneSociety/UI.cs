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
        public static string GetString(string question)
        {
            string input;
            Console.Write(question);
            input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.Write($"Error: No input entered. {question}");
                GetString(question);
            }
            return input;
        }
        public static int GetInt(string question)
        {
            int input;
            Console.Write(question);
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.Write($"Error: Enter whole number. {question}");
            }
            return input;
        }
        public static double GetDouble(string question)
        {
            double input;
            Console.Write(question);
            while (!double.TryParse(Console.ReadLine(), out input))
            {
                Console.Write($"Error: enter whole number. {question}");
            }
            return input;
        }
        public static bool GetYesNoBool(string question)
        {
            string input;
            Console.Write(question + " enter (y or n): ");
            input = Console.ReadLine();
            switch (input.ToLower())
            {
                case "y":
                    return true;
                case "n":
                    return false;
                default:
                    Console.Write("Error, invalid input. ");
                    return GetYesNoBool(question);
            }
        }
    }
}
