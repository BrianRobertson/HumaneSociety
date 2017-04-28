﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class DatabaseSaver
    {
        SqlConnection connection;
        public DatabaseSaver()
        {
            connection = new SqlConnection("Server=LAPTOP-297GRU9A;Database=HumaneSociety;Integrated Security=true");
        }
        public void Save(string tagId, string species, string name, string breed, string gender, bool neuteredSpayed, int dailyFoodRation, bool adopted, bool shots, double price)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"INSERT INTO Animal (tag_id, species, name, breed, gender, neutered_spayed, daily_food_ration, adopted, shots, price)VALUES('{tagId}', '{species}', '{name}', '{breed}','{gender}', '{neuteredSpayed}', '{dailyFoodRation}', '{adopted}', '{shots}', '{price}')", connection);
                command.ExecuteNonQuery();
                connection.Close();
                Console.WriteLine("Saved to database.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }
}