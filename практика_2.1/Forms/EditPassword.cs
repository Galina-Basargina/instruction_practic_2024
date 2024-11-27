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
using практика_2._1.Model;

namespace практика_2._1.Forms
{
    public partial class EditPassword : Form
    {
        UserFromDb userFromDb = new UserFromDb();

        public EditPassword()
        {
            InitializeComponent();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
                userFromDb.PasswordUpdate(tb_login.Text, tb_old_password.Text, tb_new_password.Text, tb_repeat_password.Text);
        }
    }
}
