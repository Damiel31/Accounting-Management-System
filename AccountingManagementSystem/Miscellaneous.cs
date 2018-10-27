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
    public partial class Miscellaneous : Form
    {
        MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand mcd;
        public string orptass,orid,horid = string.Empty;
        public Miscellaneous(string inptass,string inid)
        {
            orid = inid;
            orptass = inptass;
            InitializeComponent();
        }

        private void Miscellaneous_Load(object sender, EventArgs e)
        {

            MySqlConnection conn = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
            MySqlCommand comm = new MySqlCommand("select Miscellaneous_Fee,Amount from system.miscellaneoues;", conn);

            MySqlDataAdapter ssda = new MySqlDataAdapter();
            ssda.SelectCommand = comm;
            DataTable ddbdataset = new DataTable();
            ssda.Fill(ddbdataset);
            BindingSource bbsource = new BindingSource();

            bbsource.DataSource = ddbdataset;
            dataGridView1.DataSource = bbsource;
            ssda.Update(ddbdataset);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridView1.Columns[0].ReadOnly = true;
            
          
                int d = 0;
                for (int b = 0; b < dataGridView1.Rows.Count; b++)
                {
                    d += Convert.ToInt32(dataGridView1.Rows[b].Cells[1].Value);
                }
                try
                {
                    lblMiscellaneous.Text = d.ToString();
                    lblTotalAssment.Text = orptass;
                    int ass = Convert.ToInt32(lblTotalAssment.Text);
                    int mis = Convert.ToInt32(lblMiscellaneous.Text);
                    int net = ass + mis;
                    lblNetAssessment.Text = net.ToString();
                }
                catch
                {
                    MessageBox.Show("You dont have yet Total Assessment");
                }

                this.dataGridView2.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                this.dataGridView2.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                this.dataGridView2.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                this.dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                horid = orid;
                string test = "DOWNPAYMENT" + Environment.NewLine + "2ND PAYMENT" + Environment.NewLine + "3RD PAYMENT" + Environment.NewLine + "4TH PAYMENT" + Environment.NewLine + "5TH PAYMENT";
                int and = 3870, ard = 3870, ath = 3870, atth = 3870;
                int dwp = Convert.ToInt32(this.lblNetAssessment.Text) - 15480;
                string ddwp = dwp.ToString() + Environment.NewLine + and.ToString() + Environment.NewLine + ard.ToString() + Environment.NewLine + ath.ToString() + Environment.NewLine + atth.ToString();

                DateTimePicker dt = new DateTimePicker();
                int downpm = dt.Value.Month + 1, downpd = dt.Value.Day + 30, downpy = dt.Value.Year, ndm = dt.Value.Month + 1, ndd = dt.Value.Day + 18, ndy = dt.Value.Year
                    , rdm = dt.Value.Month + 3, rdd = dt.Value.Day + 18, rdy = dt.Value.Year, thm = dt.Value.Month + 4, thd = dt.Value.Day + 18, thy = dt.Value.Year
                    , tthm = dt.Value.Month + 5, tthd = dt.Value.Day + 18, tthy = dt.Value.Year;

                string datedue = dt.Value.Month.ToString() + "/" + dt.Value.Day.ToString() + "/" + dt.Value.Year.ToString();
                string nddate = ndm.ToString() + "/" + "11" + "/" + ndy.ToString();
                string rddate = rdm.ToString() + "/" + "29" + "/" + rdy.ToString();
                string thdate = thm.ToString() + "/" + "16" + "/" + thy.ToString();
                string tthdate = tthm.ToString() + "/" + "3" + "/" + tthy.ToString();

                string datepaid = datedue + Environment.NewLine + nddate + Environment.NewLine + rddate + Environment.NewLine + thdate + Environment.NewLine + tthdate;
                //this.dataGridView2.Rows.Add(5);
                this.dataGridView2.Rows[0].Cells["Column1"].Value = horid;

                this.dataGridView2.Rows[0].Cells["Column2"].Value = test;

                this.dataGridView2.Rows[0].Cells["Column3"].Value = datepaid;

                this.dataGridView2.Rows[0].Cells["Column4"].Value = ddwp;
       
          
        }

        private int CellSum()
        {
                   string a = string.Empty;
                int sum = 0;
                for (int b = 0; b < dataGridView1.Rows.Count; ++b)
                {
                    try
                    {
                        int d = 0;
                        d += Convert.ToInt32(dataGridView1.Rows[b].Cells[1].Value);
                        sum += d;
                    }
                    catch 
                    {
                        MySqlConnection conn = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
                        MySqlCommand comm = new MySqlCommand("select Miscellaneous_Fee,Amount from system.miscellaneoues;", conn);

                        MySqlDataAdapter ssda = new MySqlDataAdapter();
                        ssda.SelectCommand = comm;
                        DataTable ddbdataset = new DataTable();
                        ssda.Fill(ddbdataset);
                        BindingSource bbsource = new BindingSource();

                        bbsource.DataSource = ddbdataset;
                        dataGridView1.DataSource = bbsource;
                        ssda.Update(ddbdataset);
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                        MessageBox.Show("Incorrect Input");
                    }

                }
                return sum;     
          
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == 1)
                lblMiscellaneous.Text = CellSum().ToString();
            lblTotalAssment.Text = orptass;
            try
            {
                int ass = Convert.ToInt32(lblTotalAssment.Text);
                int mis = Convert.ToInt32(lblMiscellaneous.Text);
                int net = ass + mis;
                lblNetAssessment.Text = net.ToString();

            }
            catch
            {
                MessageBox.Show("You dont have yet Total Assessment");
                MySqlConnection conn = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
                MySqlCommand comm = new MySqlCommand("select Miscellaneous_Fee,Amount from system.miscellaneoues;", conn);

                MySqlDataAdapter ssda = new MySqlDataAdapter();
                ssda.SelectCommand = comm;
                DataTable ddbdataset = new DataTable();
                ssda.Fill(ddbdataset);
                BindingSource bbsource = new BindingSource();

                bbsource.DataSource = ddbdataset;
                dataGridView1.DataSource = bbsource;
                ssda.Update(ddbdataset);
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                int d = 0;
                for (int b = 0; b < dataGridView1.Rows.Count; b++)
                {
                    d += Convert.ToInt32(dataGridView1.Rows[b].Cells[1].Value);
                }
                lblMiscellaneous.Text = d.ToString();

            }

            this.dataGridView2.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView2.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView2.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            horid = orid;
            string test = "DOWNPAYMENT" + Environment.NewLine + "2ND PAYMENT" + Environment.NewLine + "3RD PAYMENT" + Environment.NewLine + "4TH PAYMENT" + Environment.NewLine + "5TH PAYMENT";
            int and = 3870, ard = 3870, ath = 3870, atth = 3870;
            int dwp = Convert.ToInt32(this.lblNetAssessment.Text) - 15480;
            string ddwp = dwp.ToString() + Environment.NewLine + and.ToString() + Environment.NewLine + ard.ToString() + Environment.NewLine + ath.ToString() + Environment.NewLine + atth.ToString();

            DateTimePicker dt = new DateTimePicker();
            int downpm = dt.Value.Month + 1, downpd = dt.Value.Day + 30, downpy = dt.Value.Year, ndm = dt.Value.Month + 1, ndd = dt.Value.Day + 18, ndy = dt.Value.Year
                , rdm = dt.Value.Month + 3, rdd = dt.Value.Day + 18, rdy = dt.Value.Year, thm = dt.Value.Month + 4, thd = dt.Value.Day + 18, thy = dt.Value.Year
                , tthm = dt.Value.Month + 5, tthd = dt.Value.Day + 18, tthy = dt.Value.Year;

            string datedue = dt.Value.Month.ToString() + "/" + dt.Value.Day.ToString() + "/" + dt.Value.Year.ToString();
            string nddate = ndm.ToString() + "/" + "11" + "/" + ndy.ToString();
            string rddate = rdm.ToString() + "/" + "29" + "/" + rdy.ToString();
            string thdate = thm.ToString() + "/" + "16" + "/" + thy.ToString();
            string tthdate = tthm.ToString() + "/" + "3" + "/" + tthy.ToString();

            string datepaid = datedue + Environment.NewLine + nddate + Environment.NewLine + rddate + Environment.NewLine + thdate + Environment.NewLine + tthdate;
            //this.dataGridView2.Rows.Add(5);
            this.dataGridView2.Rows[0].Cells["Column1"].Value = horid;

            this.dataGridView2.Rows[0].Cells["Column2"].Value = test;

            this.dataGridView2.Rows[0].Cells["Column3"].Value = datepaid;

            this.dataGridView2.Rows[0].Cells["Column4"].Value = ddwp;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string p = dataGridView2[1, 0].Value.ToString();
            string a = dataGridView2[2, 0].Value.ToString();
            string da = dataGridView2[3, 0].Value.ToString();
            string q = "insert into system.student_paymentsched (Stud_ID,Payments,Date_Due,Amount,Net_Assessment,non) values('" + horid + "','" + p + "','" + a + "','" + da + "','" + this.lblNetAssessment.Text + "'," + 0 + ")";
            ExecuteQuery(q);

            this.Close();
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

        private void Miscellaneous_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                string p = dataGridView2[1, 0].Value.ToString();
                string a = dataGridView2[2, 0].Value.ToString();
                string da = dataGridView2[3, 0].Value.ToString();
                string q = "insert into system.student_paymentsched (Stud_ID,Payments,Date_Due,Amount,Net_Assessment,non) values('" + horid + "','" + p + "','" + a + "','" + da + "','" + this.lblNetAssessment.Text + "'," + 0 + ")";
                ExecuteQuery(q);

                this.Close();
            }
            if(e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
