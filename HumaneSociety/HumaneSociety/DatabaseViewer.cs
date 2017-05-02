using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class DatabaseViewer
    {
        SqlConnection connection;
        public DatabaseViewer()
        {
            connection = new SqlConnection("Server=LAPTOP-297GRU9A;Database=HumaneSociety;Integrated Security=true");
        }
        public void ViewAllAnimals()
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT tag_id, species, name, breed, gender, neutered_spayed, room_assignment, daily_food_ration, adopted, shots, price FROM Animal", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("Tag Id: {0} \nSpecies: {1} \nName: {2} \nBreed: {3} \nGender: {4} \nNeutered/Spayed: {5} \nRoom Assignment: {6} \nDaily Food Ration: {7} \nAdopted: {8} \nShots: {9} \nPrice: {10}",
                        reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetBoolean(5), reader.GetInt32(6), reader.GetInt32(7), reader.GetBoolean(8), reader.GetBoolean(9), reader.GetDouble(10));
                    Console.WriteLine("*******************************");
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            //Console.ReadLine();
        }
    }
}
