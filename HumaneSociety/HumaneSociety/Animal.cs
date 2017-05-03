using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Animal
    {
        public string tagId;
        public string species;
        public string name;
        public string breed;
        public string gender;
        public bool neuteredSpayed;
        public int roomAssignment;
        public int dailyFoodRation;
        public bool adopted;
        public bool shots;
        public double price;

        public Animal()
        {
            //constructor.
        }
        public void IntakeAnimal()
        {
            tagId = UI.GetString("Number on animal tag issued: ");
            species = UI.GetString("Type of animal: ");
            name = UI.GetString("Name: ");
            breed = UI.GetString("Breed: ");
            gender = UI.GetString("Gender, enter m for male or f for female: ");
            neuteredSpayed = UI.GetYesNoBool("Neutered or spayed? ");
            roomAssignment = UI.GetInt("Room assignment: ");
            dailyFoodRation = UI.GetInt("Daily food ration, enter number of scoops: ");
            adopted = UI.GetYesNoBool("Adopted? ");
            shots = UI.GetYesNoBool("Shots? ");
            price = UI.GetDouble("Amount of donation request, enter dollar value: ");
        }
        public void AddToDatabase()
        {
            DatabaseSaver databaseSaver = new DatabaseSaver();
            databaseSaver.Save(tagId, species, name, breed, gender, neuteredSpayed, roomAssignment, dailyFoodRation, adopted, shots, price);
        }
        public void ChangeRoomAssignment()
        {
            tagId = UI.GetString("Enter the tag of the animal you wish to reassign a room: ");
            roomAssignment = UI.GetInt("New room assignment: ");
            DatabaseSaver databaseSaver = new DatabaseSaver();
            databaseSaver.UpdateRoom(tagId, roomAssignment);
        }
        public void AdjustFoodRation()
        {
            tagId = UI.GetString("Enter the tag of the animal you wish to adjust food ration: ");
            dailyFoodRation = UI.GetInt("New number of rations: ");
            DatabaseSaver databaseSaver = new DatabaseSaver();
            databaseSaver.UpdateFood(tagId, dailyFoodRation);
        }
        public void GiveShots()
        {
            tagId = UI.GetString("Enter the tag of the animal you are giving shots: ");
            shots = UI.GetYesNoBool("Shots received? ");
            DatabaseSaver databaseSaver = new DatabaseSaver();
            databaseSaver.UpdateShots(tagId, shots);
        }
        public void ProcessAdoption()
        {
            tagId = UI.GetString("Enter the tag of the animal you wish to process the adoption: ");
            adopted = UI.GetYesNoBool("Adoption process complete? ");
            DatabaseSaver databaseSaver = new DatabaseSaver();
            databaseSaver.AdoptAnimal(tagId, adopted);
        }
    }
}
