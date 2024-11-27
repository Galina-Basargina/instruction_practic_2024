using практика_2._1.Classes;
using практика_2._1.Forms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using практика_2._1.Class;

namespace практика_2._1.Model
{

    public class UserFromDb
    {
        public User GetUser(string login, string password)
        {
            User user = null;

            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection(Connection.connectionStr))
                {
                    connect.Open();
                    string sqlQuery = $"Select * from Users where Login = @login";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlQuery, connect);
                    cmd.Parameters.AddWithValue("login", login);
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();

                        if (password != "")
                        {
                            if (Verification.VerifySHA512Hash(password, reader[6].ToString()))
                            {
                                DateTime birthday = DateTime.Now;
                                if (!(reader[4] is DBNull))
                                    birthday = Convert.ToDateTime(reader[4]);

                                //Console.WriteLine(Convert.ToInt32(reader[0]));
                                //Console.WriteLine(reader[1].ToString());
                                //Console.WriteLine(reader[2].ToString());
                                //Console.WriteLine(reader[3].ToString());
                                //Console.WriteLine(birthday);
                                //Console.WriteLine(reader[5].ToString());
                                //Console.WriteLine(reader[6].ToString());
                                //Console.WriteLine(reader[8].ToString());
                                Convert.ToInt32(reader[9]);
                                //Console.WriteLine(reader[7].ToString());
                                //int userId,                 string firstName,     string lastName,      string patronymic,    DateTime, string login,         string password,      string adress,        int roleId,                 string phone
                                user = new User(Convert.ToInt32(reader[0]), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), birthday, reader[5].ToString(), reader[6].ToString(), reader[8].ToString(), Convert.ToInt32(reader[9]), reader[7].ToString());
                            }
                            else
                                MessageBox.Show("НЕВЕРНЫЙ ПАРОЛЬ");
                        }
                    }
                    else
                        MessageBox.Show("NET TAKOVO POLZOVATELY");
                    return user;
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                return user;
            }
        }
    }
}



