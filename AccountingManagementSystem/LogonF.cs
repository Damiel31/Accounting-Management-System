using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AccountingManagementSystem
{
    public partial class LogonF : Form
    {
        public LogonF()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
            MySqlCommand com = new MySqlCommand("select * from sadsignproject.identification_staff where StaffID = '" + this.txtUser.Text +
                                                    "' and Unit = '" + this.txtPass.Text + "';", con);
            MySqlDataReader reader;
            con.Open();
            reader = com.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                
                count = count + 1;
            }
            if(count == 1 )
            {
                MessageBox.Show("Welcome");
                Main m = new Main(this.txtUser.Text);
                m.Show();
                this.Hide();
            }
            else if(count > 1)
            {
                MessageBox.Show("Access Denied");
            }
            else
            {
                MessageBox.Show("Incorrect User or Pass");
            }
            con.Close();
        }

        private void LogonF_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
                MySqlCommand com = new MySqlCommand("select * from sadsignproject.identification_staff where StaffID = '" + this.txtuser.Text +
                                                        "' and StaffPass = '" + this.txtpass.Text + "';", con);
                MySqlDataReader reader;
                con.Open();
                reader = com.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {

                    count = count + 1;
                }
                if (count == 1)
                {

                    string enablei = " ";
                    ork.enablelist = enablei;
                    ork.populateenb();
                    this.Dispose();
                }
                else if (count > 1)
                {
                    MessageBox.Show("Access Denied");
                }
                else
                {
                    MessageBox.Show("Incorrect User or Pass");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please input Username and Password");
            }
        }

        private void LogonF_Load(object sender, EventArgs e)
        {
            pictureBox11.Parent = pictureBox2;
            pictureBox11.BackColor = Color.Transparent;
            pictureBox2.Location = new Point(2, 2);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }
    }
}
