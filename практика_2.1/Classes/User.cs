using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практика_2._1.Class
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronym { get; set; }
        public DateTime DateOfBirt { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public int RoleId { get; set; }

        public User(int userId, string firstName, string lastName, string patronymic, DateTime dataOfBirt, string login, string password, string adress, int roleId, string phone)
        {
            this.UserId = userId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Patronym = patronymic;
            this.DateOfBirt = dataOfBirt;
            this.Login = login;
            this.Password = password;
            this.Phone = phone;
            this.Adress = adress;
            this.RoleId = roleId;
        }
    }
}
