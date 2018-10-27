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
    public partial class Main : Form
    {
        
        public string uorform;
        public Main(string uinform)
        {
            uorform = uinform;
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            pictureBox2.Parent = pictureBox1;
            pictureBox2.BackColor = Color.Transparent;
            //pictureBox2.Location = new Point(2, 2);
            label5.Text = "[" + uorform + "]";
            MySqlConnection con = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
            MySqlCommand com = new MySqlCommand("select * from system.logon ;",con);
            MySqlDataReader reader;
            try
            {
                con.Open();
                reader = com.ExecuteReader();
                
                while(reader.Read())
                {
                    string astat = reader.GetString("Password");
                    label7.Text = astat;

                }
                con.Close();
            }
            catch
            {

            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnrollmentApplication ep = new EnrollmentApplication(this.uorform);
            ep.Show();
            this.Close();
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Escape)
            {
                this.Close();
                LogonF lf = new LogonF();
                lf.ShowDialog();
            }
        }

        private void payTuitionFeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PayTuition pt = new PayTuition();
            pt.ShowDialog();
            
        }

        private void studentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lblStatus vs = new lblStatus();
            vs.ShowDialog();
        }

        private void enrolledStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnrolledStudents es = new EnrolledStudents();
            es.ShowDialog();
        }

        private void editStudentDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditStudentData esd = new EditStudentData();
            esd.ShowDialog();
        }
    }
}
