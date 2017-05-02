using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Manager
    {
        public Manager()
        {
            //constructor.
        }
        public void ManageMenu()
        {
            UI.DisplayMessage("Manager Menu. What do you want to do?"
                + "\n1. Add a new animal."
                + "\n2. View all animals."
                + "\n3. Update an animal's room assignment."
                + "\n4. Exit the program.");
            string input = Console.ReadLine().ToLower().Trim();
            switch (input)
            {
                case "1":
                    Console.WriteLine("Add animal.\n");
                    Animal animal = new Animal();
                    animal.IntakeAnimal();
                    animal.AddToDatabase();
                    ManageMenu();
                    break;
                case "2":
                    Console.WriteLine("View all animals.\n");
                    DatabaseViewer databaseViewer = new DatabaseViewer();
                    databaseViewer.ViewAllAnimals();
                    ManageMenu();
                    break;
                case "3":
                    Console.WriteLine("Update an animal's room assignment.\n");
                    Animal updateAnimal = new Animal();
                    updateAnimal.ChangeRoomAssignment();
                    ManageMenu();
                    break;
                case "4":
                    Console.WriteLine("Exit program by pressing Enter button.\n");
                    break;
                default:
                    Console.WriteLine("Not a valid choice.\n");
                    ManageMenu();
                    break;
            }
        }
    }
}
