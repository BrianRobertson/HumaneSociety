using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class MainMenu
    {
        public void Start()
        {
            UI.DisplayWelcome();
            SetMode();
            //UI.DisplayMessage("Hello, write something");
            //string input = UI.GetUserInput();
            //UI.DisplayMessage("This is what you wrote. " + input);
        }
        public void SetMode()
        {
            UI.DisplayMessage("Main menu. What do you want to do?"
                + "\n1. Enter as Guest/Potential Adopter"
                + "\n2. Enter as Manager/Employee"
                + "\n3. Start a new session."
                + "\n4. Exit the program.");
            string input = Console.ReadLine().ToLower().Trim();
            switch (input)
            {
                case "1":
                    Console.WriteLine("Guest/Potential Adopter\n");
                    break;
                case "2":
                    Console.WriteLine("Manager/Employee\n");
                    break;
                case "3":
                    Console.WriteLine("Start new session.\n");
                    Start();
                    break;
                case "4":
                    Console.WriteLine("Exit program.\n");
                    break;
                default:
                    Console.WriteLine("Not a valid choice.\n");
                    SetMode();
                    break;
            }
        }
    }
}
