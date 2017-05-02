using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Agency
    {
        Manager manager;
        public Agency()
        {
            this.manager = new Manager();
        }
        public void Start()
        {
            UI.DisplayWelcome();
            SetUserMode();
        }
        public void SetUserMode()
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
                    manager.ManageMenu();
                    break;
                case "3":
                    Console.WriteLine("Start new session.\n");
                    Start();
                    break;
                case "4":
                    Console.WriteLine("Exit program by pressing Enter button.\n");
                    break;
                default:
                    Console.WriteLine("Not a valid choice.\n");
                    SetUserMode();
                    break;
            }
        }
    }
}
