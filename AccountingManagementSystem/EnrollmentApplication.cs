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
    public partial class EnrollmentApplication : Form
    {
        MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand mcd;
        public string uacc,tass,ptass = string.Empty;

        public EnrollmentApplication(string acc)
        {
            uacc = acc;
            InitializeComponent();
        }

        private void EnrollmentApplication_Load(object sender, EventArgs e)
        {

            string newguid = System.Guid.NewGuid().ToString();
            string tnewguid = String.Format("{0:d9}", (DateTime.Now.Ticks / 10) % 1000).Replace("0", "");
            this.label1.Text = "STI-" + tnewguid + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "-" + DateTime.Now.Year;
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker2.CustomFormat = "MM/dd/yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;

            cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cmbCourse.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCourse.AutoCompleteSource = AutoCompleteSource.ListItems;

            cmbSchedule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cmbSchedule.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbSchedule.AutoCompleteSource = AutoCompleteSource.ListItems;

            cmbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cmbSemester.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbSemester.AutoCompleteSource = AutoCompleteSource.ListItems;

            cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cmbStatus.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbStatus.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void rdbMale_CheckedChanged(object sender, EventArgs e)
        {
            ptbPicture.Image = AccountingManagementSystem.Properties.Resources.Use_20professional_20looking_20profile_picture;
        }

        private void rdbFemale_CheckedChanged(object sender, EventArgs e)
        {
            ptbPicture.Image = AccountingManagementSystem.Properties.Resources.default_dp;
        }

        

        private void btnLoadSubject_Click(object sender, EventArgs e)
        {
            if (cmbCourse.Text != string.Empty && txtFirstName.Text != string.Empty && txtLastName.Text != string.Empty && txtMiddleName.Text != string.Empty && cmbSemester.Text != string.Empty &&
                cmbSchedule.Text != string.Empty)
            {
                
                if (rdb1styear.Checked == true)
                {
                    EnrollSubject es = new EnrollSubject(this.label1.Text, this.txtLastName.Text, this.txtFirstName.Text, this.txtMiddleName.Text
                                                    , this.cmbCourse.Text, this.cmbSemester.Text, this.rdb1styear.Text,this);
                    es.ShowDialog();
                }

                if (rdb2ndyear.Checked == true)
                {
                    EnrollSubject es = new EnrollSubject(this.label1.Text, this.txtLastName.Text, this.txtFirstName.Text, this.txtMiddleName.Text
                                                    , this.cmbCourse.Text, this.cmbSemester.Text, this.rdb2ndyear.Text,this);
                    es.ShowDialog();
                }

                if (rdb3rdyear.Checked == true)
                {
                    EnrollSubject es = new EnrollSubject(this.label1.Text, this.txtLastName.Text, this.txtFirstName.Text, this.txtMiddleName.Text
                                                   , this.cmbCourse.Text, this.cmbSemester.Text, this.rdb3rdyear.Text, this);
                    es.ShowDialog();
                }

                if (rdb4thyear.Checked == true)
                {
                    EnrollSubject es = new EnrollSubject(this.label1.Text, this.txtLastName.Text, this.txtFirstName.Text, this.txtMiddleName.Text
                                                   , this.cmbCourse.Text, this.cmbSemester.Text, this.rdb4thyear.Text, this);
                    es.ShowDialog();
                }
            }

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Main m = new Main(uacc);
            m.Show();
        }

        private void btnAssesment_Click(object sender, EventArgs e)
        {
            Miscellaneous ms = new Miscellaneous(this.ptass,this.label1.Text);
            ms.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int a = dateTimePicker1.Value.Year;
            if(rdb1styear.Checked == true && rdbMale.Checked == true)
            {
                string q = "update system.student set Last_Name='" + txtLastName.Text + "',First_Name='" + txtFirstName.Text + "',Middle_Name='" + txtMiddleName.Text + "',Gender='" + rdbMale.Text + "',Birthdate='" + dateTimePicker1.Text + "',Program='" + cmbCourse.Text + "',Mobile_No='" + txtmobileno.Text + "',Email='" + txtEmail.Text + "',Address='" + txtHomeAddress.Text + "',Status='" + cmbStatus.Text + "',Religion='" + txtReligion.Text + "',Year='" + rdb1styear.Text + "',Semester='" + cmbSemester.Text + "',Schedule='" + cmbSchedule.Text + "',Yr='"+ a.ToString() + "' where Stud_ID='" + label1.Text + "'" ;
                ExecuteQuery(q);
            }

            if (rdb1styear.Checked == true && rdbFemale.Checked == true)
            {
                string q = "update system.student set Last_Name='" + txtLastName.Text + "',First_Name='" + txtFirstName.Text + "',Middle_Name='" + txtMiddleName.Text + "',Gender='" + rdbFemale.Text + "',Birthdate='" + dateTimePicker1.Text + "',Program='" + cmbCourse.Text + "',Mobile_No='" + txtmobileno.Text + "',Email='" + txtEmail.Text + "',Address='" + txtHomeAddress.Text + "',Status='" + cmbStatus.Text + "',Religion='" + txtReligion.Text + "',Year='" + rdb1styear.Text + "',Semester='" + cmbSemester.Text + "',Schedule='" + cmbSchedule.Text + "',Yr='" + a.ToString() + "' where Stud_ID='" + label1.Text + "'";
                ExecuteQuery(q);
            }

            if (rdb2ndyear.Checked == true && rdbMale.Checked == true)
            {
                string q = "update system.student set Last_Name='" + txtLastName.Text + "',First_Name='" + txtFirstName.Text + "',Middle_Name='" + txtMiddleName.Text + "',Gender='" + rdbFemale.Text + "',Birthdate='" + dateTimePicker1.Text + "',Program='" + cmbCourse.Text + "',Mobile_No='" + txtmobileno.Text + "',Email='" + txtEmail.Text + "',Address='" + txtHomeAddress.Text + "',Status='" + cmbStatus.Text + "',Religion='" + txtReligion.Text + "',Year='" + rdb1styear.Text + "',Semester='" + cmbSemester.Text + "',Schedule='" + cmbSchedule.Text + "',Yr='" + a.ToString() + "' where Stud_ID='" + label1.Text + "'";
                ExecuteQuery(q);
            }

            if (rdb2ndyear.Checked == true && rdbFemale.Checked == true)
            {
                string q = "update system.student set Last_Name='" + txtLastName.Text + "',First_Name='" + txtFirstName.Text + "',Middle_Name='" + txtMiddleName.Text + "',Gender='" + rdbFemale.Text + "',Birthdate='" + dateTimePicker1.Text + "',Program='" + cmbCourse.Text + "',Mobile_No='" + txtmobileno.Text + "',Email='" + txtEmail.Text + "',Address='" + txtHomeAddress.Text + "',Status='" + cmbStatus.Text + "',Religion='" + txtReligion.Text + "',Year='" + rdb1styear.Text + "',Semester='" + cmbSemester.Text + "',Schedule='" + cmbSchedule.Text + "',Yr='" + a.ToString() + "' where Stud_ID='" + label1.Text + "'";
                ExecuteQuery(q);
            }

            if (rdb3rdyear.Checked == true && rdbMale.Checked == true)
            {
                string q = "update system.student set Last_Name='" + txtLastName.Text + "',First_Name='" + txtFirstName.Text + "',Middle_Name='" + txtMiddleName.Text + "',Gender='" + rdbFemale.Text + "',Birthdate='" + dateTimePicker1.Text + "',Program='" + cmbCourse.Text + "',Mobile_No='" + txtmobileno.Text + "',Email='" + txtEmail.Text + "',Address='" + txtHomeAddress.Text + "',Status='" + cmbStatus.Text + "',Religion='" + txtReligion.Text + "',Year='" + rdb1styear.Text + "',Semester='" + cmbSemester.Text + "',Schedule='" + cmbSchedule.Text + "',Yr='" + a.ToString() + "' where Stud_ID='" + label1.Text + "'";
                ExecuteQuery(q);
            }

            if (rdb3rdyear.Checked == true && rdbFemale.Checked == true)
            {
                string q = "update system.student set Last_Name='" + txtLastName.Text + "',First_Name='" + txtFirstName.Text + "',Middle_Name='" + txtMiddleName.Text + "',Gender='" + rdbFemale.Text + "',Birthdate='" + dateTimePicker1.Text + "',Program='" + cmbCourse.Text + "',Mobile_No='" + txtmobileno.Text + "',Email='" + txtEmail.Text + "',Address='" + txtHomeAddress.Text + "',Status='" + cmbStatus.Text + "',Religion='" + txtReligion.Text + "',Year='" + rdb1styear.Text + "',Semester='" + cmbSemester.Text + "',Schedule='" + cmbSchedule.Text + "',Yr='" + a.ToString() + "' where Stud_ID='" + label1.Text + "'";
                ExecuteQuery(q);
            }

            if (rdb4thyear.Checked == true && rdbMale.Checked == true)
            {
                string q = "update system.student set Last_Name='" + txtLastName.Text + "',First_Name='" + txtFirstName.Text + "',Middle_Name='" + txtMiddleName.Text + "',Gender='" + rdbFemale.Text + "',Birthdate='" + dateTimePicker1.Text + "',Program='" + cmbCourse.Text + "',Mobile_No='" + txtmobileno.Text + "',Email='" + txtEmail.Text + "',Address='" + txtHomeAddress.Text + "',Status='" + cmbStatus.Text + "',Religion='" + txtReligion.Text + "',Year='" + rdb1styear.Text + "',Semester='" + cmbSemester.Text + "',Schedule='" + cmbSchedule.Text + "',Yr='" + a.ToString() + "' where Stud_ID='" + label1.Text + "'";
                ExecuteQuery(q);
            }

            if (rdb4thyear.Checked == true && rdbFemale.Checked == true)
            {
                string q = "update system.student set Last_Name='" + txtLastName.Text + "',First_Name='" + txtFirstName.Text + "',Middle_Name='" + txtMiddleName.Text + "',Gender='" + rdbFemale.Text + "',Birthdate='" + dateTimePicker1.Text + "',Program='" + cmbCourse.Text + "',Mobile_No='" + txtmobileno.Text + "',Email='" + txtEmail.Text + "',Address='" + txtHomeAddress.Text + "',Status='" + cmbStatus.Text + "',Religion='" + txtReligion.Text + "',Year='" + rdb1styear.Text + "',Semester='" + cmbSemester.Text + "',Schedule='" + cmbSchedule.Text + "',Yr='" + a.ToString() +"' where Stud_ID='" + label1.Text + "'";
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

        internal void populate()
        {
            ptass = tass;
        }

        private void EnrollmentApplication_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
                Main m = new Main(uacc);
                m.Show();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            string newguid = System.Guid.NewGuid().ToString();
            string tnewguid = String.Format("{0:d9}", (DateTime.Now.Ticks / 10) % 1000).Replace("0", "");
            this.label1.Text = "STI-" + tnewguid + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "-" + DateTime.Now.Year;

            cmbCourse.Text = "";
            rdb1styear.Checked = false;
            rdb2ndyear.Checked = false;
            rdb3rdyear.Checked = false;
            rdb4thyear.Checked = false;
            rdbFemale.Checked = false;
            rdbMale.Checked = false;
            ptbPicture.Image = pictureBox1.Image;
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtMiddleName.Text = "";
            txtmobileno.Text = "";
            txtEmail.Text = "";
            txtHomeAddress.Text = "";
            cmbStatus.Text = "";
            txtReligion.Text = "";
            dateTimePicker1 = dateTimePicker2;

        }
    }
}
