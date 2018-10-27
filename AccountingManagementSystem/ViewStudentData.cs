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
    public partial class lblStatus : Form
    {
        MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand mcd;
        public lblStatus()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            MySqlDataReader reader;
            MySqlDataReader readerr;
            MySqlConnection con = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
            MySqlCommand com = new MySqlCommand("select * from system.student where Stud_ID = '" + this.txtStudID.Text + "';", con);
            mcon = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
            mcd = new MySqlCommand("select * from system.student ;", mcon);

            con.Open();
            reader = com.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count = count + 1;
            }
            if (count == 1)
            {
                try
                {
                    mcon.Open();
                    readerr = mcd.ExecuteReader();

                    while (readerr.Read())
                    {
                        string last = reader.GetString("Last_Name");
                        string first = reader.GetString("First_Name");
                        string middle = reader.GetString("Middle_Name");
                        string gender = reader.GetString("Gender");
                        DateTimePicker dt = new DateTimePicker();
                        string age = reader.GetString("Yr");
                        int age2 = dt.Value.Year;
                        int total = age2 - Convert.ToInt32(age);
                        string nowage = total.ToString();
                        string course = reader.GetString("Program");
                        string syr = reader.GetString("Year");
                        string mobile = reader.GetString("Mobile_No");
                        string email = reader.GetString("Email");
                        string address = reader.GetString("Address");
                        string semester = reader.GetString("Semester");
                        string sched = reader.GetString("Schedule");
                        string stat = reader.GetString("Status");
                        string rel = reader.GetString("Religion");
                        string birthday = reader.GetString("BirthDate");
                        /*int age2 = Convert.ToInt32(age);
                        int tg = age2 - Convert.ToInt32(age);
                        string ttg = age2.ToString();*/
                        txtLastName.Text= last;
                        txtFirstName.Text = first;
                        txtMiddleName.Text = middle;
                        lblGender.Text = gender;
                        lblAge.Text = nowage;
                        lblCourse.Text = course;
                        lblYear.Text = syr;
                        lblSemester.Text = semester;
                        lblSchedule.Text = sched;
                        txtmobileno.Text = mobile;
                        txtEmail.Text = email;
                        txtHomeAddress.Text = address;
                        label14.Text = stat;
                        lblReligion.Text = rel;
                        lblDateOfBirth.Text = birthday;
                       
                    }
                    mcon.Close();
                }
                catch
                {

                }

                if (lblGender.Text == "Male")
                {
                    ptbPicture.Image = AccountingManagementSystem.Properties.Resources.Use_20professional_20looking_20profile_picture;
                }
                if (lblGender.Text == "Female")
                {
                    ptbPicture.Image = AccountingManagementSystem.Properties.Resources.default_dp;
                }
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

        public void openCon()
        {
            if (mcon.State == ConnectionState.Closed)
            {
                mcon.Open();
            }
        }

        public void closeCon()
        {
            if (mcon.State == ConnectionState.Open)
            {
                mcon.Close();
            }
        }

        public void ExecuteQuery(string q)
        {
            try
            {
                openCon();
                mcd = new MySqlCommand(q, mcon);
                if (mcd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Saved");
                }
                else
                {
                    MessageBox.Show("Invalid");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeCon();
            }
        }

        private void lblStatus_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblStatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
               
            }
            if(e.KeyData == Keys.P)
            {
                StatementofAcc sa = new StatementofAcc();
                sa.ShowDialog();
            }
        }

        private void btnStatementOfAccount_Click(object sender, EventArgs e)
        {
            StatementofAcc sa = new StatementofAcc();
            sa.ShowDialog();
        }
    }
}
