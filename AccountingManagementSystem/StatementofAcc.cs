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
    public partial class StatementofAcc : Form
    {
        MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand mcd;
        public StatementofAcc()
        {
            InitializeComponent();
        }

        private void StatementofAcc_Load(object sender, EventArgs e)
        {
            
            this.dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
                        string payment = reader.GetString("Tuition_Payment");
                        label4.Text = payment;
                        lbllast.Text = last;
                        lblfirst.Text = first;
                        lblmiddle.Text = middle;

                        MySqlConnection conn = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
                        MySqlCommand comm = new MySqlCommand("select Stud_ID,Payments,Date_Due,Amount,Net_Assessment from system.student_paymentsched ;", conn);

                       

                        MySqlDataAdapter ssda = new MySqlDataAdapter();
                        ssda.SelectCommand = comm;
                        DataTable ddbdataset = new DataTable();
                        ssda.Fill(ddbdataset);
                        BindingSource bbsource = new BindingSource();

                        bbsource.DataSource = ddbdataset;
                        dataGridView1.DataSource = bbsource;
                        ssda.Update(ddbdataset);
                        this.dataGridView1.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                        this.dataGridView1.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                        this.dataGridView1.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                        this.dataGridView1.Columns[4].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                        this.dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                    MySqlConnection    mconnn = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
                    MySqlCommand mcddd = new MySqlCommand("select * from system.student_paymentsched ;", mcon);
                 try
                {
                    mconnn.Open();
                    readerr = mcddd.ExecuteReader();

                    while (readerr.Read())
                    {

                        
                        
                        string netass = reader.GetString("Net_Assessment");
                        label3.Text = netass;
                        string g = label3.Text;
                        
                    }
                    mcon.Close();
                }
                catch
                {

                }
                    }
                    mcon.Close();
                }
                catch
                {

               }
                
            }
        }
    }
}
