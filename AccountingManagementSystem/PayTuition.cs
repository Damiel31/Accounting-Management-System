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
    public partial class PayTuition : Form
    {
        MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand mcd;
        public PayTuition()
        {
            InitializeComponent();
        }

        private void PayTuition_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            DateTimePicker datime = new DateTimePicker();
            datime.CustomFormat = "MM/dd/yyyy";
            datime.Format = DateTimePickerFormat.Custom;
            string d = datime.Text;
            string id = txtStudID.Text;
            this.dataGridView1.Rows[0].Cells["Column2"].Value = d;
            this.dataGridView1.Rows[0].Cells["Column1"].Value = id;



            
            
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
                        /*int age2 = Convert.ToInt32(age);
                        int tg = age2 - Convert.ToInt32(age);
                        string ttg = age2.ToString();*/
                        lblLast.Text = last;
                        lblFirst.Text = first;
                        lblMiddle.Text = middle;
                        lblGender.Text = gender;
                        lblAge.Text = nowage;
                        lblCourse.Text = course;
                        lblYeaer.Text = syr;
                    }
                    mcon.Close();
                }
                catch
                {

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

           // MySqlConnection conn = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
            MySqlCommand comm= new MySqlCommand("select * from system.student_paymentsched where Stud_ID = '" + txtStudID.Text + "';", con);
            MySqlDataReader readerrr;
            try
            {
                con.Open();
                readerrr = comm.ExecuteReader();

                while (readerrr.Read())
                {
                    string astat = readerrr.GetString("Net_Assessment");
                    lblnetass.Text = astat;

                }
                con.Close();
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

        public void ExecuteQuery(string q,string d)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            MySqlDataReader reader;
            MySqlDataReader readerr;
            MySqlConnection con = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
            MySqlCommand com = new MySqlCommand("select * from system.student_paymentsched where Stud_ID = '" + this.txtStudID.Text + "';", con);
            mcon = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
            mcd = new MySqlCommand("select * from system.student_paymentsched ;", mcon);

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

                        string neta = reader.GetString("Net_Assessment");
                        this.dataGridView1.Rows[0].Cells["Column4"].Value = neta;
                        
                    }
                    mcon.Close();
                }
                catch
                {

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
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView1.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView1.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            DateTimePicker datime = new DateTimePicker();
            datime.CustomFormat = "MM/dd/yyyy";
            datime.Format = DateTimePickerFormat.Custom;
            string id = txtStudID.Text;
            this.dataGridView1.Rows[0].Cells["Column1"].Value = Environment.NewLine + id;
            this.dataGridView1.Rows[0].Cells["Column2"].Value = Environment.NewLine + datime.Value.Month + "/" + datime.Value.Day + "/" + datime.Value.Year + Environment.NewLine;
            this.dataGridView1.Rows[0].Cells["Column3"].Value = Environment.NewLine + txtPayment.Text + Environment.NewLine;

            string amnt = dataGridView1[2, 0].Value.ToString();
            string netass = dataGridView1[3, 0].Value.ToString();
            int bal = Convert.ToInt32(netass) - Convert.ToInt32(amnt);
            this.dataGridView1.Rows[0].Cells["Column4"].Value = bal.ToString();
            string datee = dataGridView1[1, 0].Value.ToString();
            

            if (txtPayment.Text != string.Empty)
            {
                string q = "update system.student set Tuition_Payment='" + txtPayment.Text + "' where Stud_ID='" + txtStudID.Text + "'";
                string d = "insert into system.student_paymenthistory (Stud_ID,Date,Amt_Paid,Balance,non) values('" + id + "','" + datee + "','" + amnt + "','" + bal + "'," + 0 + ")";
                ExecuteQuery(q,d);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PayTuition_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Hide();
            }
            if(e.KeyData == Keys.Enter)
            {
                MySqlDataReader reader;
                MySqlDataReader readerr;
                MySqlConnection con = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
                MySqlCommand com = new MySqlCommand("select * from system.student_paymentsched where Stud_ID = '" + this.txtStudID.Text + "';", con);
                mcon = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
                mcd = new MySqlCommand("select * from system.student_paymentsched ;", mcon);

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

                            string neta = reader.GetString("Net_Assessment");
                            this.dataGridView1.Rows[0].Cells["Column4"].Value = neta;

                        }
                        mcon.Close();
                    }
                    catch
                    {

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
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                this.dataGridView1.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                this.dataGridView1.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                this.dataGridView1.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                this.dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                DateTimePicker datime = new DateTimePicker();
                datime.CustomFormat = "MM/dd/yyyy";
                datime.Format = DateTimePickerFormat.Custom;
                string id = txtStudID.Text;
                this.dataGridView1.Rows[0].Cells["Column1"].Value = Environment.NewLine + id;
                this.dataGridView1.Rows[0].Cells["Column2"].Value = Environment.NewLine + datime.Value.Month + "/" + datime.Value.Day + "/" + datime.Value.Year + Environment.NewLine;
                this.dataGridView1.Rows[0].Cells["Column3"].Value = Environment.NewLine + txtPayment.Text + Environment.NewLine;

                string amnt = dataGridView1[2, 0].Value.ToString();
                string netass = dataGridView1[3, 0].Value.ToString();
                int bal = Convert.ToInt32(netass) - Convert.ToInt32(amnt);
                this.dataGridView1.Rows[0].Cells["Column4"].Value = bal.ToString();
                string datee = dataGridView1[1, 0].Value.ToString();


                if (txtPayment.Text != string.Empty)
                {
                    string q = "update system.student set Tuition_Payment='" + txtPayment.Text + "' where Stud_ID='" + txtStudID.Text + "'";
                    string d = "insert into system.student_paymenthistory (Stud_ID,Date,Amt_Paid,Balance,non) values('" + id + "','" + datee + "','" + amnt + "','" + bal + "'," + 0 + ")";
                    ExecuteQuery(q, d);
                }
            }
        }


    }
}
