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
        public int dailyFoodRation;
        public bool adopted;
        public bool shots;
        public double price;

        public Animal()
        {
            //constructor. time stamp perhaps.
        }
        public void IntakeAnimal()
        {
            tagId = UI.GetString("Number on animal tag issued: ");
            species = UI.GetString("Type of animal: ");
            name = UI.GetString("Name: ");
            breed = UI.GetString("Breed: ");
            gender = UI.GetString("Gender, enter m for male or f for female: ");
            neuteredSpayed = UI.GetYesNoBool("Neutered or spayed? ");
            dailyFoodRation = UI.GetInt("Daily food ration, enter number of scoops: ");
            adopted = UI.GetYesNoBool("Adopted? ");
            shots = UI.GetYesNoBool("Shots? ");
            price = UI.GetDouble("Amount of donation request, enter dollar value: ");
        }
        public void AddToDatabase()
        {
            DatabaseSaver databaseSaver = new DatabaseSaver();
            databaseSaver.Save(tagId, species, name, breed, gender, neuteredSpayed, dailyFoodRation, adopted, shots, price);
        }
    }
}
