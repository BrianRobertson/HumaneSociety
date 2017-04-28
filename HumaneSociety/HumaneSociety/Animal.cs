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
            tagId = "d101";
            species = "dog";
            name = "Fido";
            breed = "mixed";
            gender = "M";
            neuteredSpayed = true;
            dailyFoodRation = 1;
            adopted = false;
            shots = true;
            price = 75;
        }
        public void AddToDatabase()
        {
            DatabaseSaver databaseSaver = new DatabaseSaver();
            databaseSaver.Save(tagId, species, name, breed, gender, neuteredSpayed, dailyFoodRation, adopted, shots, price);
        }
    }
}
