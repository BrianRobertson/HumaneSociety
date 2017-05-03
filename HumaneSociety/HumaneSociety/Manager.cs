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
                + "\n4. Adjust an animal's daily food ration."
                + "\n5. Give an animal their shots."
                + "\n6. Process an animal's adoption."
                + "\n7. Exit the program.");
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
                    Animal roomAnimal = new Animal();
                    roomAnimal.ChangeRoomAssignment();
                    ManageMenu();
                    break;
                case "4":
                    Console.WriteLine("Update an animal's food rations.\n");
                    Animal foodAnimal = new Animal();
                    foodAnimal.AdjustFoodRation();
                    ManageMenu();
                    break;
                case "5":
                    Console.WriteLine("Give an animal shots.\n");
                    Animal shotsAnimal = new Animal();
                    shotsAnimal.GiveShots();
                    ManageMenu();
                    break;
                case "6":
                    Console.WriteLine("Process an animal's adoption.\n");
                    Animal adoptAnimal = new Animal();
                    adoptAnimal.ProcessAdoption();
                    ManageMenu();
                    break;
                case "7":
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
