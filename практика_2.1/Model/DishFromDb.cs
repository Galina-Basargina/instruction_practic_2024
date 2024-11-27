using практика_2._1.Classes;
using System;
using System.Collections.Generic;
//using System.Data.NpgsqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace практика_2._1.Model
{
    internal class DishFromDb
    {
        public List<Dish> LoadDishes()
        {
            List<Dish> dishes = new List<Dish>();

            NpgsqlConnection sqlConnection = new NpgsqlConnection(Connection.connectionStr);
            try
            {
                sqlConnection.Open();
                string sqlExp = $"select d.id, d.dish, t.type, b.name, weight from "
                    + $"dishes d join type_dish t on d.type = t.id "
                    + $"join basics b on d.base = b.id;";
                NpgsqlCommand command = new NpgsqlCommand(sqlExp, sqlConnection);
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                        dishes.Add(new Dish(Convert.ToInt32(reader[0]), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), Convert.ToInt32(reader[4])));
                }
                reader.Close();
                return dishes;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Load Dish");
                return dishes;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}