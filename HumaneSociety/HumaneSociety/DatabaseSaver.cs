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
        public void Save(string tagId, string species, string name, string breed, string gender, bool neuteredSpayed, int roomAssignment, int dailyFoodRation, bool adopted, bool shots, double price)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"INSERT INTO Animal (tag_id, species, name, breed, gender, neutered_spayed, room_assignment, daily_food_ration, adopted, shots, price)VALUES('{tagId}', '{species}', '{name}', '{breed}','{gender}', '{neuteredSpayed}', '{roomAssignment}', '{dailyFoodRation}', '{adopted}', '{shots}', '{price}')", connection);
                command.ExecuteNonQuery();
                connection.Close();
                Console.WriteLine("Saved to database.\n");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            //Console.ReadLine();
        }
        public void UpdateRoom(string tagId, int roomAssignment)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"UPDATE Animal SET room_assignment = ('{roomAssignment}') WHERE tag_id = '{tagId}'", connection);
                command.ExecuteNonQuery();
                connection.Close();
                Console.WriteLine("Database is updated.\n");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            //Console.ReadLine();
        }
        public void UpdateFood(string tagId, int dailyFoodRation)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"UPDATE Animal SET daily_food_ration = ('{dailyFoodRation}') WHERE tag_id = '{tagId}'", connection);
                command.ExecuteNonQuery();
                connection.Close();
                Console.WriteLine("Database is updated.\n");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void UpdateShots(string tagId, bool shots)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"UPDATE Animal SET shots = ('{shots}') WHERE tag_id = '{tagId}'", connection);
                command.ExecuteNonQuery();
                connection.Close();
                Console.WriteLine("Database is updated.\n");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void AdoptAnimal(string tagId, bool adopted)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"UPDATE Animal SET adopted = ('{adopted}') WHERE tag_id = '{tagId}'", connection);
                command.ExecuteNonQuery();
                connection.Close();
                Console.WriteLine("Database is updated.\n");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
