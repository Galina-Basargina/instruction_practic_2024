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

                                Console.WriteLine(Convert.ToInt32(reader[0]));
                                Console.WriteLine(reader[1].ToString());
                                Console.WriteLine(reader[2].ToString());
                                Console.WriteLine(reader[3].ToString());
                                Console.WriteLine(birthday);
                                Console.WriteLine(reader[5].ToString());
                                Console.WriteLine(reader[6].ToString());
                                Console.WriteLine(reader[8].ToString());
                                Convert.ToInt32(reader[9]);
                                Console.WriteLine(reader[7].ToString());
                                user = new User(Convert.ToInt32(reader[0]), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), birthday, reader[5].ToString(), reader[6].ToString(), reader[8].ToString(), Convert.ToInt32(reader[9]), reader[7].ToString());
                            }
                            else MessageBox.Show("неверный пароль");
                        }
                    }
                    else MessageBox.Show("нет такого пользователя");
                    return user;
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                return user;
            }
        }
        public static bool CheckPassword(string password, string passRepeat)
        {
            if (password.Length < 6)
            {
                MessageBox.Show("Длина пароля не может быть меньше 6 символов");
                return false;
            }
            else
            {
                bool f, f1, f2;
                f = f1 = f2 = false;
                for (int i = 0; i < password.Length; i++)
                {
                    if (Char.IsDigit(password[i])) f1 = true;
                    if (Char.IsUpper(password[i])) f2 = true;
                    if (f1 && f2) break;

                }
                if (!(f1 && f2))
                {
                    MessageBox.Show("Пароль должен содержать хотя бы одну цифру и одну заглавную букву!");
                    return f1 && f2;
                }
                else
                {
                    string symbols = "!@#$%^";
                    for (int i = 0; i < password.Length; i++)
                    {
                        for (int j = 0; j < symbols.Length; j++)
                        {
                            if (password[i] == symbols[j]) { f = true; break; }
                        }
                    }

                    if (!f) MessageBox.Show("Пароль должен содержать один из символов !@#$%^");

                    if ((password == passRepeat) && f) return true;
                    else
                    {
                        MessageBox.Show("Неверно подтверждаем пароль");
                        return false;
                    }

                }

            }
        }

        public static bool UserCheck(string login)
        {
            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection(Connection.connectionStr))
                {
                    connect.Open();
                    string sqlExp = $"SELECT Login from Users where Login=@login";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connect);
                    cmd.Parameters.AddWithValue("@login", login);
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Такой логин уже есть"); 
                        return false;
                    }
                    else
                    {
                        reader.Close();
                        return true;
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message); return false;
            }
        }

        public static void UserAdd(string login, string password, string firstName, string lastName)
        {
            NpgsqlConnection sqlConnection = new NpgsqlConnection(Connection.connectionStr);
            try
            {
                sqlConnection.Open();
                string sqlQuery = $"Insert into users (Login, Password, FirsName, LastName) Values (@login, @password, @firstName, @lastName)";
                string encrypt_password = Verification.GetSHA512Hash(password);
                NpgsqlCommand command = new NpgsqlCommand(sqlQuery, sqlConnection);
                command.Parameters.AddWithValue("login", login);
                command.Parameters.AddWithValue("password", encrypt_password);
                command.Parameters.AddWithValue("firstName", firstName);
                command.Parameters.AddWithValue("lastName", lastName);

                int i = command.ExecuteNonQuery();
                if (i == 1) MessageBox.Show("Данные добавлены");
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection.Close();
        }
    }
}
