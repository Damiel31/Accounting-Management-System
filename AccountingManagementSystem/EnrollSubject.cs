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
    public partial class EnrollSubject : Form
    {
        MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand mcd;
        public string orstuid, orlastname, orfirstname, ormiddlename, orcourse, orsemester, oryear;
        EnrollmentApplication orea;
        public EnrollSubject(string instuid , string inlastname , string infirstname , string inmiddlename , string incourse , string insemester , string inyear ,EnrollmentApplication inea )
        {
            orstuid = instuid;
            orlastname = inlastname;
            orfirstname = infirstname;
            ormiddlename = inmiddlename;
            orcourse = incourse;
            orsemester = insemester;
            oryear = inyear;
            orea = inea;
            
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EnrollSubject_Load(object sender, EventArgs e)
        {

            txtIDno.Text = orstuid;
            txtFamilyName.Text = orlastname;
            txtFirstname.Text = orfirstname;
            txtMiddleName.Text = ormiddlename;
            txtCourse.Text = orcourse;
            txtSemester.Text = orsemester;
            lblYear.Text = oryear;

            MySqlConnection conn = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
            MySqlCommand comm = new MySqlCommand("select Fee,Amount from system.other_school_fees ;", conn);
  

                
            
                MySqlDataAdapter ssda = new MySqlDataAdapter();
                ssda.SelectCommand = comm;
                DataTable ddbdataset = new DataTable();
                ssda.Fill(ddbdataset);
                BindingSource bbsource = new BindingSource();

                bbsource.DataSource = ddbdataset;
                dataGridView2.DataSource = bbsource;
                ssda.Update(ddbdataset);
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                int d = 0;
                for (int b = 0; b < dataGridView2.Rows.Count; b++)
                {
                    d += Convert.ToInt32(dataGridView2.Rows[b].Cells[1].Value);
                }

                lblOSF.Text = d.ToString();


            if(txtCourse.Text == "BSIT" && lblYear.Text == "1st" && txtSemester.Text == "First Semester")
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
                MySqlCommand com = new MySqlCommand("select Course_Code,Description,Unit,Amount from system.bsit_1yr_1term ;", con);
                
                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = com;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;
                    dataGridView1.DataSource = bsource;
                    sda.Update(dbdataset);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    int a = 0;
                    int c = 0;
                    for(int b = 0;b<dataGridView1.Rows.Count;b++)
                    {
                        a += Convert.ToInt32(dataGridView1.Rows[b].Cells[2].Value);
                        c += Convert.ToInt32(dataGridView1.Rows[b].Cells[3].Value);
                    }
                    lblunit.Text = a.ToString();
                    lblTuitionFee.Text = c.ToString();

                    int subt = Convert.ToInt32(lblTuitionFee.Text) + Convert.ToInt32(lblOSF.Text);
                    lblSubTotal.Text = subt.ToString();

                    dataGridView1.Columns[1].ReadOnly = true;
                    dataGridView1.Columns[3].ReadOnly = true;
      
                } 
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
            if(txtCourse.Text == "BSIT" && lblYear.Text == "1st" && txtSemester.Text == "Second Semester")
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
                MySqlCommand com = new MySqlCommand("select Course_Code,Description,Unit,Amount from system.bsit_1yr_2term ;", con);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = com;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;
                    dataGridView1.DataSource = bsource;
                    sda.Update(dbdataset);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    int a = 0;
                    int c = 0;
                    for (int b = 0; b < dataGridView1.Rows.Count; b++)
                    {
                        a += Convert.ToInt32(dataGridView1.Rows[b].Cells[2].Value);
                        c += Convert.ToInt32(dataGridView1.Rows[b].Cells[3].Value);
                    }
                    lblunit.Text = a.ToString();
                    lblTuitionFee.Text = c.ToString();

                    int subt = Convert.ToInt32(lblTuitionFee.Text) + Convert.ToInt32(lblOSF.Text);
                    lblSubTotal.Text = subt.ToString();

                    dataGridView1.Columns[1].ReadOnly = true;
                    dataGridView1.Columns[3].ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

             if(txtCourse.Text == "BSIT" && lblYear.Text == "2nd" && txtSemester.Text == "First Semester")
             {
                 MySqlConnection con = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
                 MySqlCommand com = new MySqlCommand("select Course_Code,Description,Unit,Amount from system.bsit_2yr_1term ;", con);

                 try
                 {
                     MySqlDataAdapter sda = new MySqlDataAdapter();
                     sda.SelectCommand = com;
                     DataTable dbdataset = new DataTable();
                     sda.Fill(dbdataset);
                     BindingSource bsource = new BindingSource();

                     bsource.DataSource = dbdataset;
                     dataGridView1.DataSource = bsource;
                     sda.Update(dbdataset);
                     dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                     int a = 0;
                     int c = 0;
                     for (int b = 0; b < dataGridView1.Rows.Count; b++)
                     {
                         a += Convert.ToInt32(dataGridView1.Rows[b].Cells[2].Value);
                         c += Convert.ToInt32(dataGridView1.Rows[b].Cells[3].Value);
                     }
                     lblunit.Text = a.ToString();
                     lblTuitionFee.Text = c.ToString();

                     int subt = Convert.ToInt32(lblTuitionFee.Text) + Convert.ToInt32(lblOSF.Text);
                     lblSubTotal.Text = subt.ToString();

                     dataGridView1.Columns[1].ReadOnly = true;
                     dataGridView1.Columns[3].ReadOnly = true;
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message);
                 }
             }

            if(txtCourse.Text == "BSIT" && lblYear.Text == "2nd" && txtSemester.Text == "Second Semester")
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
                MySqlCommand com = new MySqlCommand("select Course_Code,Description,Unit,Amount from system.bsit_2yr_2term ;", con);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = com;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;
                    dataGridView1.DataSource = bsource;
                    sda.Update(dbdataset);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    int a = 0;
                    int c = 0;
                    for (int b = 0; b < dataGridView1.Rows.Count; b++)
                    {
                        a += Convert.ToInt32(dataGridView1.Rows[b].Cells[2].Value);
                        c += Convert.ToInt32(dataGridView1.Rows[b].Cells[3].Value);
                    }
                    lblunit.Text = a.ToString();
                    lblTuitionFee.Text = c.ToString();

                    int subt = Convert.ToInt32(lblTuitionFee.Text) + Convert.ToInt32(lblOSF.Text);
                    lblSubTotal.Text = subt.ToString();

                    dataGridView1.Columns[1].ReadOnly = true;
                    dataGridView1.Columns[3].ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if(txtCourse.Text == "BSIT" && lblYear.Text == "3rd" && txtSemester.Text == "First Semester")
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
                MySqlCommand com = new MySqlCommand("select Course_Code,Description,Unit,Amount  from system.bsit_3yr_1term ;", con);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = com;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;
                    dataGridView1.DataSource = bsource;
                    sda.Update(dbdataset);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    int a = 0;
                    int c = 0;
                    for (int b = 0; b < dataGridView1.Rows.Count; b++)
                    {
                        a += Convert.ToInt32(dataGridView1.Rows[b].Cells[2].Value);
                        c += Convert.ToInt32(dataGridView1.Rows[b].Cells[3].Value);
                    }
                    lblunit.Text = a.ToString();
                    lblTuitionFee.Text = c.ToString();

                    int subt = Convert.ToInt32(lblTuitionFee.Text) + Convert.ToInt32(lblOSF.Text);
                    lblSubTotal.Text = subt.ToString();

                    dataGridView1.Columns[1].ReadOnly = true;
                    dataGridView1.Columns[3].ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if(txtCourse.Text == "BSIT" && lblYear.Text == "3rd" && txtSemester.Text == "Second Semester")
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
                MySqlCommand com = new MySqlCommand("select Course_Code,Description,Unit,Amount from system.bsit_3yr_2term ;", con);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = com;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;
                    dataGridView1.DataSource = bsource;
                    sda.Update(dbdataset);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    int a = 0;
                    int c = 0;
                    for (int b = 0; b < dataGridView1.Rows.Count; b++)
                    {
                        a += Convert.ToInt32(dataGridView1.Rows[b].Cells[2].Value);
                        c += Convert.ToInt32(dataGridView1.Rows[b].Cells[3].Value);
                    }
                    lblunit.Text = a.ToString();
                    lblTuitionFee.Text = c.ToString();

                    int subt = Convert.ToInt32(lblTuitionFee.Text) + Convert.ToInt32(lblOSF.Text);
                    lblSubTotal.Text = subt.ToString();

                    dataGridView1.Columns[1].ReadOnly = true;
                    dataGridView1.Columns[3].ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if(txtCourse.Text == "BSIT" && lblYear.Text == "4th" && txtSemester.Text == "First Semester")
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
                MySqlCommand com = new MySqlCommand("select Course_Code,Description,Unit,Amount from system.bsit_4yr_1term ;", con);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = com;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;
                    dataGridView1.DataSource = bsource;
                    sda.Update(dbdataset);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    int a = 0;
                    int c = 0;
                    for (int b = 0; b < dataGridView1.Rows.Count; b++)
                    {
                        a += Convert.ToInt32(dataGridView1.Rows[b].Cells[2].Value);
                        c += Convert.ToInt32(dataGridView1.Rows[b].Cells[3].Value);
                    }
                    lblunit.Text = a.ToString();
                    lblTuitionFee.Text = c.ToString();

                    int subt = Convert.ToInt32(lblTuitionFee.Text) + Convert.ToInt32(lblOSF.Text);
                    lblSubTotal.Text = subt.ToString();

                    dataGridView1.Columns[1].ReadOnly = true;
                    dataGridView1.Columns[3].ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if(txtCourse.Text == "BSIT" && lblYear.Text == "4th" && txtSemester.Text == "Second Semester")
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
                MySqlCommand com = new MySqlCommand("select Course_Code,Description,Unit,Amount from system.bsit_4yr_2term ;", con);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = com;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;
                    dataGridView1.DataSource = bsource;
                    sda.Update(dbdataset);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    int a = 0;
                    int c = 0;
                    for (int b = 0; b < dataGridView1.Rows.Count; b++)
                    {
                        a += Convert.ToInt32(dataGridView1.Rows[b].Cells[2].Value);
                        c += Convert.ToInt32(dataGridView1.Rows[b].Cells[3].Value);
                    }
                    lblunit.Text = a.ToString();
                    lblTuitionFee.Text = c.ToString();

                    int subt = Convert.ToInt32(lblTuitionFee.Text) + Convert.ToInt32(lblOSF.Text);
                    lblSubTotal.Text = subt.ToString();

                    dataGridView1.Columns[1].ReadOnly = true;
                    dataGridView1.Columns[3].ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (txtCourse.Text == "BSCS" && lblYear.Text == "1st" && txtSemester.Text == "First Semester")
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
                MySqlCommand com = new MySqlCommand("select Course_Code,Description,Unit,Amount from system.bscs_1yr_1term ;", con);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = com;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;
                    dataGridView1.DataSource = bsource;
                    sda.Update(dbdataset);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    int a = 0;
                    int c = 0;
                    for (int b = 0; b < dataGridView1.Rows.Count; b++)
                    {
                        a += Convert.ToInt32(dataGridView1.Rows[b].Cells[2].Value);
                        c += Convert.ToInt32(dataGridView1.Rows[b].Cells[3].Value);
                    }
                    lblunit.Text = a.ToString();
                    lblTuitionFee.Text = c.ToString();

                    int subt = Convert.ToInt32(lblTuitionFee.Text) + Convert.ToInt32(lblOSF.Text);
                    lblSubTotal.Text = subt.ToString();

                    dataGridView1.Columns[1].ReadOnly = true;
                    dataGridView1.Columns[3].ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (txtCourse.Text == "BSCS" && lblYear.Text == "1st" && txtSemester.Text == "Second Semester")
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
                MySqlCommand com = new MySqlCommand("select Course_Code,Description,Unit,Amount from system.bscs_1yr_2term ;", con);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = com;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;
                    dataGridView1.DataSource = bsource;
                    sda.Update(dbdataset);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    int a = 0;
                    int c = 0;
                    for (int b = 0; b < dataGridView1.Rows.Count; b++)
                    {
                        a += Convert.ToInt32(dataGridView1.Rows[b].Cells[2].Value);
                        c += Convert.ToInt32(dataGridView1.Rows[b].Cells[3].Value);
                    }
                    lblunit.Text = a.ToString();
                    lblTuitionFee.Text = c.ToString();

                    int subt = Convert.ToInt32(lblTuitionFee.Text) + Convert.ToInt32(lblOSF.Text);
                    lblSubTotal.Text = subt.ToString();

                    dataGridView1.Columns[1].ReadOnly = true;
                    dataGridView1.Columns[3].ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (txtCourse.Text == "BSCS" && lblYear.Text == "2nd" && txtSemester.Text == "First Semester")
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
                MySqlCommand com = new MySqlCommand("select Course_Code,Description,Unit,Amount from system.bscs_2yr_1term ;", con);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = com;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;
                    dataGridView1.DataSource = bsource;
                    sda.Update(dbdataset);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    int a = 0;
                    int c = 0;
                    for (int b = 0; b < dataGridView1.Rows.Count; b++)
                    {
                        a += Convert.ToInt32(dataGridView1.Rows[b].Cells[2].Value);
                        c += Convert.ToInt32(dataGridView1.Rows[b].Cells[3].Value);
                    }
                    lblunit.Text = a.ToString();
                    lblTuitionFee.Text = c.ToString();

                    int subt = Convert.ToInt32(lblTuitionFee.Text) + Convert.ToInt32(lblOSF.Text);
                    lblSubTotal.Text = subt.ToString();

                    dataGridView1.Columns[1].ReadOnly = true;
                    dataGridView1.Columns[3].ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (txtCourse.Text == "BSCS" && lblYear.Text == "2nd" && txtSemester.Text == "Second Semester")
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
                MySqlCommand com = new MySqlCommand("select Course_Code,Description,Unit,Amount from system.bscs_2yr_2term ;", con);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = com;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;
                    dataGridView1.DataSource = bsource;
                    sda.Update(dbdataset);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    int a = 0;
                    int c = 0;
                    for (int b = 0; b < dataGridView1.Rows.Count; b++)
                    {
                        a += Convert.ToInt32(dataGridView1.Rows[b].Cells[2].Value);
                        c += Convert.ToInt32(dataGridView1.Rows[b].Cells[3].Value);
                    }
                    lblunit.Text = a.ToString();
                    lblTuitionFee.Text = c.ToString();

                    int subt = Convert.ToInt32(lblTuitionFee.Text) + Convert.ToInt32(lblOSF.Text);
                    lblSubTotal.Text = subt.ToString();

                    dataGridView1.Columns[1].ReadOnly = true;
                    dataGridView1.Columns[3].ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (txtCourse.Text == "BSCS" && lblYear.Text == "3rd" && txtSemester.Text == "First Semester")
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
                MySqlCommand com = new MySqlCommand("select Course_Code,Description,Unit,Amount from system.bscs_3yr_1term ;", con);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = com;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;
                    dataGridView1.DataSource = bsource;
                    sda.Update(dbdataset);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    int a = 0;
                    int c = 0;
                    for (int b = 0; b < dataGridView1.Rows.Count; b++)
                    {
                        a += Convert.ToInt32(dataGridView1.Rows[b].Cells[2].Value);
                        c += Convert.ToInt32(dataGridView1.Rows[b].Cells[3].Value);
                    }
                    lblunit.Text = a.ToString();
                    lblTuitionFee.Text = c.ToString();

                    int subt = Convert.ToInt32(lblTuitionFee.Text) + Convert.ToInt32(lblOSF.Text);
                    lblSubTotal.Text = subt.ToString();

                    dataGridView1.Columns[1].ReadOnly = true;
                    dataGridView1.Columns[3].ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (txtCourse.Text == "BSCS" && lblYear.Text == "3rd" && txtSemester.Text == "Second Semester")
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
                MySqlCommand com = new MySqlCommand("select Course_Code,Description,Unit,Amount from system.bscs_3yr_2term ;", con);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = com;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;
                    dataGridView1.DataSource = bsource;
                    sda.Update(dbdataset);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    int a = 0;
                    int c = 0;
                    for (int b = 0; b < dataGridView1.Rows.Count; b++)
                    {
                        a += Convert.ToInt32(dataGridView1.Rows[b].Cells[2].Value);
                        c += Convert.ToInt32(dataGridView1.Rows[b].Cells[3].Value);
                    }
                    lblunit.Text = a.ToString();
                    lblTuitionFee.Text = c.ToString();

                    int subt = Convert.ToInt32(lblTuitionFee.Text) + Convert.ToInt32(lblOSF.Text);
                    lblSubTotal.Text = subt.ToString();

                    dataGridView1.Columns[1].ReadOnly = true;
                    dataGridView1.Columns[3].ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (txtCourse.Text == "BSCS" && lblYear.Text == "3rd" && txtSemester.Text == "Summer")
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
                MySqlCommand com = new MySqlCommand("select Course_Code,Description,Unit,Amount from system.bscs_3yr_summer ;", con);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = com;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;
                    dataGridView1.DataSource = bsource;
                    sda.Update(dbdataset);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    int a = 0;
                    int c = 0;
                    for (int b = 0; b < dataGridView1.Rows.Count; b++)
                    {
                        a += Convert.ToInt32(dataGridView1.Rows[b].Cells[2].Value);
                        c += Convert.ToInt32(dataGridView1.Rows[b].Cells[3].Value);
                    }
                    lblunit.Text = a.ToString();
                    lblTuitionFee.Text = c.ToString();

                    int subt = Convert.ToInt32(lblTuitionFee.Text) + Convert.ToInt32(lblOSF.Text);
                    lblSubTotal.Text = subt.ToString();

                    dataGridView1.Columns[1].ReadOnly = true;
                    dataGridView1.Columns[3].ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (txtCourse.Text == "BSCS" && lblYear.Text == "4th" && txtSemester.Text == "First Semester")
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
                MySqlCommand com = new MySqlCommand("select Course_Code,Description,Unit,Amount from system.bscs_4yr_1term ;", con);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = com;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;
                    dataGridView1.DataSource = bsource;
                    sda.Update(dbdataset);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    int a = 0;
                    int c = 0;
                    for (int b = 0; b < dataGridView1.Rows.Count; b++)
                    {
                        a += Convert.ToInt32(dataGridView1.Rows[b].Cells[2].Value);
                        c += Convert.ToInt32(dataGridView1.Rows[b].Cells[3].Value);
                    }
                    lblunit.Text = a.ToString();
                    lblTuitionFee.Text = c.ToString();

                    int subt = Convert.ToInt32(lblTuitionFee.Text) + Convert.ToInt32(lblOSF.Text);
                    lblSubTotal.Text = subt.ToString();

                    dataGridView1.Columns[1].ReadOnly = true;
                    dataGridView1.Columns[3].ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (txtCourse.Text == "BSCS" && lblYear.Text == "4th" && txtSemester.Text == "Second Semester")
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
                MySqlCommand com = new MySqlCommand("select Course_Code,Description,Unit,Amount from system.bscs_4yr_2term ;", con);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = com;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;
                    dataGridView1.DataSource = bsource;
                    sda.Update(dbdataset);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    int a = 0;
                    int c = 0;
                    for (int b = 0; b < dataGridView1.Rows.Count; b++)
                    {
                        a += Convert.ToInt32(dataGridView1.Rows[b].Cells[2].Value);
                        c += Convert.ToInt32(dataGridView1.Rows[b].Cells[3].Value);
                    }
                    lblunit.Text = a.ToString();
                    lblTuitionFee.Text = c.ToString();

                    int subt = Convert.ToInt32(lblTuitionFee.Text) + Convert.ToInt32(lblOSF.Text);
                    lblSubTotal.Text = subt.ToString();

                    dataGridView1.Columns[1].ReadOnly = true;
                    dataGridView1.Columns[3].ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (txtCourse.Text == "BSAT" && lblYear.Text == "1st" && txtSemester.Text == "First Semester")
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
                MySqlCommand com = new MySqlCommand("select Course_Code,Description,Unit,Amount from system.bsat_1yr_1term ;", con);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = com;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;
                    dataGridView1.DataSource = bsource;
                    sda.Update(dbdataset);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    int a = 0;
                    int c = 0;
                    for (int b = 0; b < dataGridView1.Rows.Count; b++)
                    {
                        a += Convert.ToInt32(dataGridView1.Rows[b].Cells[2].Value);
                        c += Convert.ToInt32(dataGridView1.Rows[b].Cells[3].Value);
                    }
                    lblunit.Text = a.ToString();
                    lblTuitionFee.Text = c.ToString();

                    int subt = Convert.ToInt32(lblTuitionFee.Text) + Convert.ToInt32(lblOSF.Text);
                    lblSubTotal.Text = subt.ToString();

                    dataGridView1.Columns[1].ReadOnly = true;
                    dataGridView1.Columns[3].ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (txtCourse.Text == "BSAT" && lblYear.Text == "1st" && txtSemester.Text == "Second Semester")
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
                MySqlCommand com = new MySqlCommand("select Course_Code,Description,Unit,Amount from system.bsat_1yr_2term ;", con);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = com;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;
                    dataGridView1.DataSource = bsource;
                    sda.Update(dbdataset);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    int a = 0;
                    int c = 0;
                    for (int b = 0; b < dataGridView1.Rows.Count; b++)
                    {
                        a += Convert.ToInt32(dataGridView1.Rows[b].Cells[2].Value);
                        c += Convert.ToInt32(dataGridView1.Rows[b].Cells[3].Value);
                    }
                    lblunit.Text = a.ToString();
                    lblTuitionFee.Text = c.ToString();

                    int subt = Convert.ToInt32(lblTuitionFee.Text) + Convert.ToInt32(lblOSF.Text);
                    lblSubTotal.Text = subt.ToString();

                    dataGridView1.Columns[1].ReadOnly = true;
                    dataGridView1.Columns[3].ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (txtCourse.Text == "BSAT" && lblYear.Text == "2nd" && txtSemester.Text == "First Semester")
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
                MySqlCommand com = new MySqlCommand("select Course_Code,Description,Unit,Amount from system.bsat_2yr_1term ;", con);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = com;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;
                    dataGridView1.DataSource = bsource;
                    sda.Update(dbdataset);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    int a = 0;
                    int c = 0;
                    for (int b = 0; b < dataGridView1.Rows.Count; b++)
                    {
                        a += Convert.ToInt32(dataGridView1.Rows[b].Cells[2].Value);
                        c += Convert.ToInt32(dataGridView1.Rows[b].Cells[3].Value);
                    }
                    lblunit.Text = a.ToString();
                    lblTuitionFee.Text = c.ToString();

                    int subt = Convert.ToInt32(lblTuitionFee.Text) + Convert.ToInt32(lblOSF.Text);
                    lblSubTotal.Text = subt.ToString();

                    dataGridView1.Columns[1].ReadOnly = true;
                    dataGridView1.Columns[3].ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (txtCourse.Text == "BSAT" && lblYear.Text == "2nd" && txtSemester.Text == "Second Semester")
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
                MySqlCommand com = new MySqlCommand("select Course_Code,Description,Unit,Amount from system.bsat_2yr_2term ;", con);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = com;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;
                    dataGridView1.DataSource = bsource;
                    sda.Update(dbdataset);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    int a = 0;
                    int c = 0;
                    for (int b = 0; b < dataGridView1.Rows.Count; b++)
                    {
                        a += Convert.ToInt32(dataGridView1.Rows[b].Cells[2].Value);
                        c += Convert.ToInt32(dataGridView1.Rows[b].Cells[3].Value);
                    }
                    lblunit.Text = a.ToString();
                    lblTuitionFee.Text = c.ToString();

                    int subt = Convert.ToInt32(lblTuitionFee.Text) + Convert.ToInt32(lblOSF.Text);
                    lblSubTotal.Text = subt.ToString();

                    dataGridView1.Columns[1].ReadOnly = true;
                    dataGridView1.Columns[3].ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (txtCourse.Text == "BSAT" && lblYear.Text == "3rd" && txtSemester.Text == "First Semester")
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
                MySqlCommand com = new MySqlCommand("select Course_Code,Description,Unit,Amount from system.bsat_3yr_1term ;", con);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = com;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;
                    dataGridView1.DataSource = bsource;
                    sda.Update(dbdataset);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    int a = 0;
                    int c = 0;
                    for (int b = 0; b < dataGridView1.Rows.Count; b++)
                    {
                        a += Convert.ToInt32(dataGridView1.Rows[b].Cells[2].Value);
                        c += Convert.ToInt32(dataGridView1.Rows[b].Cells[3].Value);
                    }
                    lblunit.Text = a.ToString();
                    lblTuitionFee.Text = c.ToString();

                    int subt = Convert.ToInt32(lblTuitionFee.Text) + Convert.ToInt32(lblOSF.Text);
                    lblSubTotal.Text = subt.ToString();

                    dataGridView1.Columns[1].ReadOnly = true;
                    dataGridView1.Columns[3].ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (txtCourse.Text == "BSAT" && lblYear.Text == "3rd" && txtSemester.Text == "Second Semester")
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
                MySqlCommand com = new MySqlCommand("select Course_Code,Description,Unit,Amount from system.bsat_3yr_2term ;", con);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = com;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;
                    dataGridView1.DataSource = bsource;
                    sda.Update(dbdataset);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    int a = 0;
                    int c = 0;
                    for (int b = 0; b < dataGridView1.Rows.Count; b++)
                    {
                        a += Convert.ToInt32(dataGridView1.Rows[b].Cells[2].Value);
                        c += Convert.ToInt32(dataGridView1.Rows[b].Cells[3].Value);
                    }
                    lblunit.Text = a.ToString();
                    lblTuitionFee.Text = c.ToString();

                    int subt = Convert.ToInt32(lblTuitionFee.Text) + Convert.ToInt32(lblOSF.Text);
                    lblSubTotal.Text = subt.ToString();

                    dataGridView1.Columns[1].ReadOnly = true;
                    dataGridView1.Columns[3].ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (txtCourse.Text == "BSAT" && lblYear.Text == "3rd" && txtSemester.Text == "Summer")
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
                MySqlCommand com = new MySqlCommand("select Course_Code,Description,Unit,Amount from system.bsat_3yr_summer ;", con);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = com;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;
                    dataGridView1.DataSource = bsource;
                    sda.Update(dbdataset);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    int a = 0;
                    int c = 0;
                    for (int b = 0; b < dataGridView1.Rows.Count; b++)
                    {
                        a += Convert.ToInt32(dataGridView1.Rows[b].Cells[2].Value);
                        c += Convert.ToInt32(dataGridView1.Rows[b].Cells[3].Value);
                    }
                    lblunit.Text = a.ToString();
                    lblTuitionFee.Text = c.ToString();

                    int subt = Convert.ToInt32(lblTuitionFee.Text) + Convert.ToInt32(lblOSF.Text);
                    lblSubTotal.Text = subt.ToString();

                    dataGridView1.Columns[1].ReadOnly = true;
                    dataGridView1.Columns[3].ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (txtCourse.Text == "BSAT" && lblYear.Text == "4th" && txtSemester.Text == "First Semester")
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
                MySqlCommand com = new MySqlCommand("select Course_Code,Description,Unit,Amount from system.bsat_4yr_1term ;", con);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = com;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;
                    dataGridView1.DataSource = bsource;
                    sda.Update(dbdataset);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    int a = 0;
                    int c = 0;
                    for (int b = 0; b < dataGridView1.Rows.Count; b++)
                    {
                        a += Convert.ToInt32(dataGridView1.Rows[b].Cells[2].Value);
                        c += Convert.ToInt32(dataGridView1.Rows[b].Cells[3].Value);
                    }
                    lblunit.Text = a.ToString();
                    lblTuitionFee.Text = c.ToString();

                    int subt = Convert.ToInt32(lblTuitionFee.Text) + Convert.ToInt32(lblOSF.Text);
                    lblSubTotal.Text = subt.ToString();

                    dataGridView1.Columns[1].ReadOnly = true;
                    dataGridView1.Columns[3].ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (txtCourse.Text == "BSAT" && lblYear.Text == "4th" && txtSemester.Text == "Second Semester")
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
                MySqlCommand com = new MySqlCommand("select Course_Code,Description,Unit,Amount from system.bsat_4yr_2term ;", con);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = com;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;
                    dataGridView1.DataSource = bsource;
                    sda.Update(dbdataset);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    int a = 0;
                    int c = 0;
                    for (int b = 0; b < dataGridView1.Rows.Count; b++)
                    {
                        a += Convert.ToInt32(dataGridView1.Rows[b].Cells[2].Value);
                        c += Convert.ToInt32(dataGridView1.Rows[b].Cells[3].Value);
                    }
                    lblunit.Text = a.ToString();
                    lblTuitionFee.Text = c.ToString();

                    int subt = Convert.ToInt32(lblTuitionFee.Text) + Convert.ToInt32(lblOSF.Text);
                    lblSubTotal.Text = subt.ToString();

                    dataGridView1.Columns[1].ReadOnly = true;
                    dataGridView1.Columns[3].ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (txtCourse.Text == "BSHRM" && lblYear.Text == "1st" && txtSemester.Text == "First Semester")
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
                MySqlCommand com = new MySqlCommand("select Course_Code,Description,Unit,Amount from system.bshrm_1yr_1term ;", con);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = com;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;
                    dataGridView1.DataSource = bsource;
                    sda.Update(dbdataset);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    int a = 0;
                    int c = 0;
                    for (int b = 0; b < dataGridView1.Rows.Count; b++)
                    {
                        a += Convert.ToInt32(dataGridView1.Rows[b].Cells[2].Value);
                        c += Convert.ToInt32(dataGridView1.Rows[b].Cells[3].Value);
                    }
                    lblunit.Text = a.ToString();
                    lblTuitionFee.Text = c.ToString();

                    int subt = Convert.ToInt32(lblTuitionFee.Text) + Convert.ToInt32(lblOSF.Text);
                    lblSubTotal.Text = subt.ToString();

                    dataGridView1.Columns[1].ReadOnly = true;
                    dataGridView1.Columns[3].ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (txtCourse.Text == "BSHRM" && lblYear.Text == "1st" && txtSemester.Text == "Second Semester")
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
                MySqlCommand com = new MySqlCommand("select Course_Code,Description,Unit,Amount from system.bshrm_1yr_2term ;", con);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = com;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;
                    dataGridView1.DataSource = bsource;
                    sda.Update(dbdataset);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    int a = 0;
                    int c = 0;
                    for (int b = 0; b < dataGridView1.Rows.Count; b++)
                    {
                        a += Convert.ToInt32(dataGridView1.Rows[b].Cells[2].Value);
                        c += Convert.ToInt32(dataGridView1.Rows[b].Cells[3].Value);
                    }
                    lblunit.Text = a.ToString();
                    lblTuitionFee.Text = c.ToString();

                    int subt = Convert.ToInt32(lblTuitionFee.Text) + Convert.ToInt32(lblOSF.Text);
                    lblSubTotal.Text = subt.ToString();

                    dataGridView1.Columns[1].ReadOnly = true;
                    dataGridView1.Columns[3].ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (txtCourse.Text == "BSHRM" && lblYear.Text == "2nd" && txtSemester.Text == "First Semester")
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
                MySqlCommand com = new MySqlCommand("select Course_Code,Description,Unit,Amount from system.bshrm_2yr_1term ;", con);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = com;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;
                    dataGridView1.DataSource = bsource;
                    sda.Update(dbdataset);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    int a = 0;
                    int c = 0;
                    for (int b = 0; b < dataGridView1.Rows.Count; b++)
                    {
                        a += Convert.ToInt32(dataGridView1.Rows[b].Cells[2].Value);
                        c += Convert.ToInt32(dataGridView1.Rows[b].Cells[3].Value);
                    }
                    lblunit.Text = a.ToString();
                    lblTuitionFee.Text = c.ToString();

                    int subt = Convert.ToInt32(lblTuitionFee.Text) + Convert.ToInt32(lblOSF.Text);
                    lblSubTotal.Text = subt.ToString();

                    dataGridView1.Columns[1].ReadOnly = true;
                    dataGridView1.Columns[3].ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (txtCourse.Text == "BSHRM" && lblYear.Text == "2nd" && txtSemester.Text == "Second Semester")
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
                MySqlCommand com = new MySqlCommand("select Course_Code,Description,Unit,Amount from system.bshrm_2yr_2term ;", con);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = com;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;
                    dataGridView1.DataSource = bsource;
                    sda.Update(dbdataset);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    int a = 0;
                    int c = 0;
                    for (int b = 0; b < dataGridView1.Rows.Count; b++)
                    {
                        a += Convert.ToInt32(dataGridView1.Rows[b].Cells[2].Value);
                        c += Convert.ToInt32(dataGridView1.Rows[b].Cells[3].Value);
                    }
                    lblunit.Text = a.ToString();
                    lblTuitionFee.Text = c.ToString();

                    int subt = Convert.ToInt32(lblTuitionFee.Text) + Convert.ToInt32(lblOSF.Text);
                    lblSubTotal.Text = subt.ToString();

                    dataGridView1.Columns[1].ReadOnly = true;
                    dataGridView1.Columns[3].ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (txtCourse.Text == "BSHRM" && lblYear.Text == "2nd" && txtSemester.Text == "Summer")
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
                MySqlCommand com = new MySqlCommand("select Course_Code,Description,Unit,Amount from system.bshrm_2yr_summer ;", con);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = com;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;
                    dataGridView1.DataSource = bsource;
                    sda.Update(dbdataset);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    int a = 0;
                    int c = 0;
                    for (int b = 0; b < dataGridView1.Rows.Count; b++)
                    {
                        a += Convert.ToInt32(dataGridView1.Rows[b].Cells[2].Value);
                        c += Convert.ToInt32(dataGridView1.Rows[b].Cells[3].Value);
                    }
                    lblunit.Text = a.ToString();
                    lblTuitionFee.Text = c.ToString();

                    int subt = Convert.ToInt32(lblTuitionFee.Text) + Convert.ToInt32(lblOSF.Text);
                    lblSubTotal.Text = subt.ToString();

                    dataGridView1.Columns[1].ReadOnly = true;
                    dataGridView1.Columns[3].ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (txtCourse.Text == "BSHRM" && lblYear.Text == "3rd" && txtSemester.Text == "First Semester")
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
                MySqlCommand com = new MySqlCommand("select Course_Code,Description,Unit,Amount from system.bshrm_3yr_1term ;", con);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = com;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;
                    dataGridView1.DataSource = bsource;
                    sda.Update(dbdataset);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    int a = 0;
                    int c = 0;
                    for (int b = 0; b < dataGridView1.Rows.Count; b++)
                    {
                        a += Convert.ToInt32(dataGridView1.Rows[b].Cells[2].Value);
                        c += Convert.ToInt32(dataGridView1.Rows[b].Cells[3].Value);
                    }
                    lblunit.Text = a.ToString();
                    lblTuitionFee.Text = c.ToString();

                    int subt = Convert.ToInt32(lblTuitionFee.Text) + Convert.ToInt32(lblOSF.Text);
                    lblSubTotal.Text = subt.ToString();

                    dataGridView1.Columns[1].ReadOnly = true;
                    dataGridView1.Columns[3].ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (txtCourse.Text == "BSHRM" && lblYear.Text == "3rd" && txtSemester.Text == "Second Semester")
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
                MySqlCommand com = new MySqlCommand("select Course_Code,Description,Unit,Amount from system.bshrm_3yr_2term ;", con);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = com;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;
                    dataGridView1.DataSource = bsource;
                    sda.Update(dbdataset);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    int a = 0;
                    int c = 0;
                    for (int b = 0; b < dataGridView1.Rows.Count; b++)
                    {
                        a += Convert.ToInt32(dataGridView1.Rows[b].Cells[2].Value);
                        c += Convert.ToInt32(dataGridView1.Rows[b].Cells[3].Value);
                    }
                    lblunit.Text = a.ToString();
                    lblTuitionFee.Text = c.ToString();

                    int subt = Convert.ToInt32(lblTuitionFee.Text) + Convert.ToInt32(lblOSF.Text);
                    lblSubTotal.Text = subt.ToString();

                    dataGridView1.Columns[1].ReadOnly = true;
                    dataGridView1.Columns[3].ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (txtCourse.Text == "BSHRM" && lblYear.Text == "3rd" && txtSemester.Text == "Summer")
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
                MySqlCommand com = new MySqlCommand("select Course_Code,Description,Unit,Amount from system.bshrm_3yr_summer ;", con);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = com;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;
                    dataGridView1.DataSource = bsource;
                    sda.Update(dbdataset);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    int a = 0;
                    int c = 0;
                    for (int b = 0; b < dataGridView1.Rows.Count; b++)
                    {
                        a += Convert.ToInt32(dataGridView1.Rows[b].Cells[2].Value);
                        c += Convert.ToInt32(dataGridView1.Rows[b].Cells[3].Value);
                    }
                    lblunit.Text = a.ToString();
                    lblTuitionFee.Text = c.ToString();

                    int subt = Convert.ToInt32(lblTuitionFee.Text) + Convert.ToInt32(lblOSF.Text);
                    lblSubTotal.Text = subt.ToString();

                    dataGridView1.Columns[1].ReadOnly = true;
                    dataGridView1.Columns[3].ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (txtCourse.Text == "BSHRM" && lblYear.Text == "3rd" && txtSemester.Text == "Summer")
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
                MySqlCommand com = new MySqlCommand("select Course_Code,Description,Unit,Amount from system.bshrm_3yr_summer ;", con);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = com;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;
                    dataGridView1.DataSource = bsource;
                    sda.Update(dbdataset);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    int a = 0;
                    int c = 0;
                    for (int b = 0; b < dataGridView1.Rows.Count; b++)
                    {
                        a += Convert.ToInt32(dataGridView1.Rows[b].Cells[2].Value);
                        c += Convert.ToInt32(dataGridView1.Rows[b].Cells[3].Value);
                    }
                    lblunit.Text = a.ToString();
                    lblTuitionFee.Text = c.ToString();

                    int subt = Convert.ToInt32(lblTuitionFee.Text) + Convert.ToInt32(lblOSF.Text);
                    lblSubTotal.Text = subt.ToString();

                    dataGridView1.Columns[1].ReadOnly = true;
                    dataGridView1.Columns[3].ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (txtCourse.Text == "BSHRM" && lblYear.Text == "4th" && txtSemester.Text == "First Semester")
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
                MySqlCommand com = new MySqlCommand("select Course_Code,Description,Unit,Amount from system.bshrm_4yr_1term ;", con);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = com;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;
                    dataGridView1.DataSource = bsource;
                    sda.Update(dbdataset);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    int a = 0;
                    int c = 0;
                    for (int b = 0; b < dataGridView1.Rows.Count; b++)
                    {
                        a += Convert.ToInt32(dataGridView1.Rows[b].Cells[2].Value);
                        c += Convert.ToInt32(dataGridView1.Rows[b].Cells[3].Value);
                    }
                    lblunit.Text = a.ToString();
                    lblTuitionFee.Text = c.ToString();

                    int subt = Convert.ToInt32(lblTuitionFee.Text) + Convert.ToInt32(lblOSF.Text);
                    lblSubTotal.Text = subt.ToString();

                    dataGridView1.Columns[1].ReadOnly = true;
                    dataGridView1.Columns[3].ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (txtCourse.Text == "BSHRM" && lblYear.Text == "4th" && txtSemester.Text == "Second Semester")
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
                MySqlCommand com = new MySqlCommand("select Course_Code,Description,Unit,Amount from system.bshrm_4yr_2term ;", con);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = com;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;
                    dataGridView1.DataSource = bsource;
                    sda.Update(dbdataset);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    int a = 0;
                    int c = 0;
                    for (int b = 0; b < dataGridView1.Rows.Count; b++)
                    {
                        a += Convert.ToInt32(dataGridView1.Rows[b].Cells[2].Value);
                        c += Convert.ToInt32(dataGridView1.Rows[b].Cells[3].Value);
                        
                    }
                    lblunit.Text = a.ToString();
                    lblTuitionFee.Text = c.ToString();
                    

                    int subt = Convert.ToInt32(lblTuitionFee.Text) + Convert.ToInt32(lblOSF.Text);
                    lblSubTotal.Text = subt.ToString();

                    dataGridView1.Columns[1].ReadOnly = true;
                    dataGridView1.Columns[3].ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void txtAdvPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if(!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;

                try
                {
                    int total = Convert.ToInt32(this.lblSubTotal.Text) - Convert.ToInt32(txtAdvPayment.Text);
                    txtTotalAssessment.Text = total.ToString();
                }
                catch
                {
                    MessageBox.Show("The Amount You Entered is Invalid");
                }
            }
            
        }

        private void txtTotalAssessment_TextChanged(object sender, EventArgs e)
        {
            if (txtTotalAssessment.Text.Length >= 2)
            {
                int acceptednumber = Convert.ToInt32(txtTotalAssessment.Text);
                if (acceptednumber < 0)
                {
                    txtTotalAssessment.Text = "";
                    MessageBox.Show("Negative values are not allowed");
                }
                else
                {
                    
                    txtTotalAssessment.Text = txtTotalAssessment.Text;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            string q = "insert into system.student (Stud_ID,Tuition_Fees,Advance_Payment,Total_Assessment) values('" + txtIDno.Text + "','" + lblTuitionFee.Text + "','" + txtAdvPayment.Text + "'," 
                        + txtTotalAssessment.Text + ")";
            ExecuteQuery(q);

            orea.tass = this.txtTotalAssessment.Text;
            orea.populate();

            this.Hide();
        }

        public void openCon()
        {
            if(mcon.State == ConnectionState.Closed)
            {
                mcon.Open();
            }
        }

        public void closeCon()
        {
            if(mcon.State == ConnectionState.Open)
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
                if(mcd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Saved");
                }
                else
                {
                    MessageBox.Show("Invalid");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeCon();
            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtCourse.Text == "BSHRM" && lblYear.Text == "4th" && txtSemester.Text == "Second Semester")
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port = 3306;username = root;password = ");
                MySqlCommand com = new MySqlCommand("select Course_Code,Description,Unit,Amount from system.bshrm_4yr_2term ;", con);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = com;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;
                    dataGridView1.DataSource = bsource;
                    sda.Update(dbdataset);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    int a = 0;
                    int c = 0;
                    for (int b = 0; b < dataGridView1.Rows.Count; b++)
                    {
                        a += Convert.ToInt32(dataGridView1.Rows[b].Cells[2].Value);
                        c += Convert.ToInt32(dataGridView1.Rows[b].Cells[3].Value);
                    }
                    lblunit.Text = a.ToString();
                    lblTuitionFee.Text = c.ToString();

                    int subt = Convert.ToInt32(lblTuitionFee.Text) + Convert.ToInt32(lblOSF.Text);
                    lblSubTotal.Text = subt.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                dataGridView1.ReadOnly = false;
            }
        }

        private void EnrollSubject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
