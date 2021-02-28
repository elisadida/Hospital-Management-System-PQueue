using System;
using System.Windows.Forms;

namespace HospitalManagementSystemCSharp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "pass")
            {
                MessageBox.Show("Jeni Loguar Si Admin.");
                this.Visible = false;
                Home obj1 = new Home();
                obj1.ShowDialog();
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else if (textBox1.Text == "recep" && textBox2.Text == "pass")
            {
                MessageBox.Show("Jeni Loguar Si Recepsionist.");
                this.Visible = false;
                Recep obj1 = new Recep();
                obj1.ShowDialog();
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
            {
                MessageBox.Show("Invalid Username Or Password.");
            }
         }

        
    }
}
