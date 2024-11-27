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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace практика_2._1.Forms
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void btReg_Click(object sender, EventArgs e)
        {
            if (UserFromDb.UserCheck(textBox4.Text) && UserFromDb.CheckPassword(textBox5.Text, textBox1.Text))
            {
                UserFromDb.UserAdd(textBox4.Text, textBox5.Text, textBox2.Text, textBox3.Text);
                this.Close();
            }
        }

    }
}
