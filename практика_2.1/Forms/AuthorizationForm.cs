using практика_2._1.Classes;
using практика_2._1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using практика_2._1.Class;

namespace практика_2._1.Forms
{
    public partial class AuthorizationForm : Form
    {
        UserFromDb userFromDb = new UserFromDb();

        public static User currentUser { get; set; } = null;
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(textBoxLogin.Text != "" && textBoxPsw.Text != ""))
            {
                MessageBox.Show("Введите данные"); return;
            }
            else
            {
                currentUser = userFromDb.GetUser(textBoxLogin.Text, textBoxPsw.Text);
                if (currentUser != null)
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Нет такого пользователя"); return;
                }
            }
        }
    }
}
