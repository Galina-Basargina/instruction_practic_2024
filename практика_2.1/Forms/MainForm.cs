using практика_2._1.Classes;
using практика_2._1.Forms;
using практика_2._1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace практика_2._1
{
    public partial class MainForm : Form
    {
        public List<Dish> dishes = new List<Dish>();
        DishFromDb dishFromDb = new DishFromDb();

        public static List<Classes.Type> types = new List<Classes.Type>();
        TypeFromDb typeFromDb = new TypeFromDb();

        List<Composition> compositionDish = new List<Composition>();
        int selectedIndex = -1;
        bool noSelectedIndex = true;
        public MainForm()
        {
            InitializeComponent();
            dataGridView1.Columns[0].DataPropertyName = "Id";
            dataGridView1.Columns[1].DataPropertyName = "Image";
            dataGridView1.Columns[2].DataPropertyName = "DishName";
            dataGridView1.Columns[3].DataPropertyName = "Type";
            dataGridView1.Columns[4].DataPropertyName = "Base";
            dataGridView1.Columns[5].DataPropertyName = "Weight";
            dataGridView1.Columns[0].Visible = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ViewAllDishes();

            types = typeFromDb.LoadType();

            types.Insert(0, new Classes.Type(0, "All"));

            comboBox1.DataSource = types;

            comboBox1.DisplayMember = "TypeName";
            comboBox1.ValueMember = "Id";

            switch (AuthorizationForm.currentUser.RoleId)
            {
                case 2:
                    toolStripMenuItemAdd.Visible = false;
                    toolStripMenuItemDel.Visible = false;
                    break;
                case 3:
                    добавитьПродуктToolStripMenuItem.Visible = false;
                    break;
            }

            fIOToolStripMenuItem.Text = AuthorizationForm.currentUser.FirstName + " " + AuthorizationForm.currentUser.LastName;
        }

        private void ViewAllDishes()
        {
            dishes = dishFromDb.LoadDishes();
            dataGridView1.DataSource = dishes;
        }
    }
}
