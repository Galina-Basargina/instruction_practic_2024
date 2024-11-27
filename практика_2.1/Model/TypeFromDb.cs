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
    internal class TypeFromDb
    {
        public List<Classes.Type> LoadType()
        {
            List<Classes.Type> types = new List<Classes.Type>();

            NpgsqlConnection sqlConnection = new NpgsqlConnection(Connection.connectionStr);
            try
            {
                sqlConnection.Open();
                string sqlExp = $"select * FROM type_dish";
                NpgsqlCommand command = new NpgsqlCommand(sqlExp, sqlConnection);
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                        types.Add(new Classes.Type(Convert.ToInt32(reader[0]), reader[1].ToString()));
                }
                reader.Close();
                return types;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return types;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
