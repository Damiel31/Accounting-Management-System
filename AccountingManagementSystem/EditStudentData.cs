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
    public partial class EditStudentData : Form
    {
        MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand mcd;
        public EditStudentData()
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
                        string birth = reader.GetString("BirthDate");
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
                        txtLastName.Text = last;
                        txtFirstName.Text = first;
                        txtMiddleName.Text = middle;
                        txtEmail.Text = email;
                        txtHomeAddress.Text = address;
                        cmbStatus.Text = stat;
                        txtReligion.Text = rel;
                        lblscam.Text = gender;
                        //lblAge.Text = nowage;
                        cmbCourse.Text = course;
                        if (syr == rdb1styear.Text)
                        {
                            rdb1styear.Checked = true;
                        }
                        if (syr == rdb2ndyear.Text)
                        {
                            rdb2ndyear.Checked = true;
                        }
                        if (syr == rdb3rdyear.Text)
                        {
                            rdb3rdyear.Checked = true;
                        }
                        if (syr == rdb4thyear.Text)
                        {
                            rdb4thyear.Checked = true;
                        }
                        cmbSemester.Text = semester;
                        cmbSchedule.Text = sched;
                        txtmobileno.Text = mobile;
                        dateTimePicker1.Text = birth;
                        if (lblscam.Text == rdbMale.Text)
                        {
                            rdbMale.Checked = true;
                        }

                        if (lblscam.Text == rdbFemale.Text)
                        {
                            rdbFemale.Checked = true;
                        }


                        if (gender == "Male")
                        {
                            ptbPicture.Image = AccountingManagementSystem.Properties.Resources.Use_20professional_20looking_20profile_picture;
                        }
                        if (gender == "Female")
                        {
                            ptbPicture.Image = AccountingManagementSystem.Properties.Resources.default_dp;
                        }
                       
                    }
                    mcon.Close();
                }
                catch
                {

                }

            }
        }

        private void EditStudentData_Load(object sender, EventArgs e)
        {
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;

            
            
        }

        private void rdbMale_CheckedChanged(object sender, EventArgs e)
        {
            ptbPicture.Image = AccountingManagementSystem.Properties.Resources.Use_20professional_20looking_20profile_picture;
        }

        private void rdbFemale_CheckedChanged(object sender, EventArgs e)
        {
            ptbPicture.Image = AccountingManagementSystem.Properties.Resources.default_dp;
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int a = dateTimePicker1.Value.Year;
            if (rdb1styear.Checked == true && rdbMale.Checked == true)
            {
                string q = "update system.student set Last_Name='" + txtLastName.Text + "',First_Name='" + txtFirstName.Text + "',Middle_Name='" + txtMiddleName.Text + "',Gender='" + rdbMale.Text + "',Birthdate='" + dateTimePicker1.Text + "',Program='" + cmbCourse.Text + "',Mobile_No='" + txtmobileno.Text + "',Email='" + txtEmail.Text + "',Address='" + txtHomeAddress.Text + "',Status='" + cmbStatus.Text + "',Religion='" + txtReligion.Text + "',Year='" + rdb1styear.Text + "',Semester='" + cmbSemester.Text + "',Schedule='" + cmbSchedule.Text + "',Yr='" + a.ToString() + "' where Stud_ID='" + label1.Text + "'";
                ExecuteQuery(q);
            }

            if (rdb1styear.Checked == true && rdbFemale.Checked == true)
            {
                string q = "update system.student set Last_Name='" + txtLastName.Text + "',First_Name='" + txtFirstName.Text + "',Middle_Name='" + txtMiddleName.Text + "',Gender='" + rdbFemale.Text + "',Birthdate='" + dateTimePicker1.Text + "',Program='" + cmbCourse.Text + "',Mobile_No='" + txtmobileno.Text + "',Email='" + txtEmail.Text + "',Address='" + txtHomeAddress.Text + "',Status='" + cmbStatus.Text + "',Religion='" + txtReligion.Text + "',Year='" + rdb1styear.Text + "',Semester='" + cmbSemester.Text + "',Schedule='" + cmbSchedule.Text + "',Yr='" + a.ToString() + "' where Stud_ID='" + txtStudID.Text + "'";
                ExecuteQuery(q);
            }

            if (rdb2ndyear.Checked == true && rdbMale.Checked == true)
            {
                string q = "update system.student set Last_Name='" + txtLastName.Text + "',First_Name='" + txtFirstName.Text + "',Middle_Name='" + txtMiddleName.Text + "',Gender='" + rdbFemale.Text + "',Birthdate='" + dateTimePicker1.Text + "',Program='" + cmbCourse.Text + "',Mobile_No='" + txtmobileno.Text + "',Email='" + txtEmail.Text + "',Address='" + txtHomeAddress.Text + "',Status='" + cmbStatus.Text + "',Religion='" + txtReligion.Text + "',Year='" + rdb1styear.Text + "',Semester='" + cmbSemester.Text + "',Schedule='" + cmbSchedule.Text + "',Yr='" + a.ToString() + "' where Stud_ID='" + txtStudID.Text + "'";
                ExecuteQuery(q);
            }

            if (rdb2ndyear.Checked == true && rdbFemale.Checked == true)
            {
                string q = "update system.student set Last_Name='" + txtLastName.Text + "',First_Name='" + txtFirstName.Text + "',Middle_Name='" + txtMiddleName.Text + "',Gender='" + rdbFemale.Text + "',Birthdate='" + dateTimePicker1.Text + "',Program='" + cmbCourse.Text + "',Mobile_No='" + txtmobileno.Text + "',Email='" + txtEmail.Text + "',Address='" + txtHomeAddress.Text + "',Status='" + cmbStatus.Text + "',Religion='" + txtReligion.Text + "',Year='" + rdb1styear.Text + "',Semester='" + cmbSemester.Text + "',Schedule='" + cmbSchedule.Text + "',Yr='" + a.ToString() + "' where Stud_ID='" + txtStudID.Text + "'";
                ExecuteQuery(q);
            }

            if (rdb3rdyear.Checked == true && rdbMale.Checked == true)
            {
                string q = "update system.student set Last_Name='" + txtLastName.Text + "',First_Name='" + txtFirstName.Text + "',Middle_Name='" + txtMiddleName.Text + "',Gender='" + rdbFemale.Text + "',Birthdate='" + dateTimePicker1.Text + "',Program='" + cmbCourse.Text + "',Mobile_No='" + txtmobileno.Text + "',Email='" + txtEmail.Text + "',Address='" + txtHomeAddress.Text + "',Status='" + cmbStatus.Text + "',Religion='" + txtReligion.Text + "',Year='" + rdb1styear.Text + "',Semester='" + cmbSemester.Text + "',Schedule='" + cmbSchedule.Text + "',Yr='" + a.ToString() + "' where Stud_ID='" + txtStudID.Text + "'";
                ExecuteQuery(q);
            }

            if (rdb3rdyear.Checked == true && rdbFemale.Checked == true)
            {
                string q = "update system.student set Last_Name='" + txtLastName.Text + "',First_Name='" + txtFirstName.Text + "',Middle_Name='" + txtMiddleName.Text + "',Gender='" + rdbFemale.Text + "',Birthdate='" + dateTimePicker1.Text + "',Program='" + cmbCourse.Text + "',Mobile_No='" + txtmobileno.Text + "',Email='" + txtEmail.Text + "',Address='" + txtHomeAddress.Text + "',Status='" + cmbStatus.Text + "',Religion='" + txtReligion.Text + "',Year='" + rdb1styear.Text + "',Semester='" + cmbSemester.Text + "',Schedule='" + cmbSchedule.Text + "',Yr='" + a.ToString() + "' where Stud_ID='" + txtStudID.Text + "'";
                ExecuteQuery(q);
            }

            if (rdb4thyear.Checked == true && rdbMale.Checked == true)
            {
                string q = "update system.student set Last_Name='" + txtLastName.Text + "',First_Name='" + txtFirstName.Text + "',Middle_Name='" + txtMiddleName.Text + "',Gender='" + rdbFemale.Text + "',Birthdate='" + dateTimePicker1.Text + "',Program='" + cmbCourse.Text + "',Mobile_No='" + txtmobileno.Text + "',Email='" + txtEmail.Text + "',Address='" + txtHomeAddress.Text + "',Status='" + cmbStatus.Text + "',Religion='" + txtReligion.Text + "',Year='" + rdb1styear.Text + "',Semester='" + cmbSemester.Text + "',Schedule='" + cmbSchedule.Text + "',Yr='" + a.ToString() + "' where Stud_ID='" + txtStudID.Text + "'";
                ExecuteQuery(q);
            }

            if (rdb4thyear.Checked == true && rdbFemale.Checked == true)
            {
                string q = "update system.student set Last_Name='" + txtLastName.Text + "',First_Name='" + txtFirstName.Text + "',Middle_Name='" + txtMiddleName.Text + "',Gender='" + rdbFemale.Text + "',Birthdate='" + dateTimePicker1.Text + "',Program='" + cmbCourse.Text + "',Mobile_No='" + txtmobileno.Text + "',Email='" + txtEmail.Text + "',Address='" + txtHomeAddress.Text + "',Status='" + cmbStatus.Text + "',Religion='" + txtReligion.Text + "',Year='" + rdb1styear.Text + "',Semester='" + cmbSemester.Text + "',Schedule='" + cmbSchedule.Text + "',Yr='" + a.ToString() + "' where Stud_ID='" + txtStudID.Text + "'";
                ExecuteQuery(q);
            }
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditStudentData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}