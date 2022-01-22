using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;

namespace Animal_Project
{
    public partial class Animalscs : Form
    {
        public Animalscs()
        {
            InitializeComponent();
        }
        Datahandler dh = new Datahandler();
        public SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog = Animals;Integrated Security=SSPI");
        SqlCommand cmd;
        int id;
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        } //works

        private void viewBabyAnimalsBtn_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("ViewAnimals", conn);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            sda.Fill(ds, "Animal");
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[8].Visible = false;



        } // works

        private void addNewAnimalsBtn_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        } // works

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //This allows you to select the animal images to show on the pictureBox
            if (dataGridView1.CurrentRow.Index != -1)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                string query = "SELECT * FROM Animal WHERE ID = '" + id + "' ";
                cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    // This allows us to view the animals in the pictureBox
                    byte[] images = (byte[])reader[8];
                    if (images == null)
                    {
                        pictureBox1.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(images);
                        pictureBox1.Image = Image.FromStream(ms);
                    }

                }
                conn.Close();
            }
        } //works 

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                        using (DataTable dt = new DataTable("Animal"))
                        {
                            using (SqlCommand command = new SqlCommand("SELECT * FROM Animal WHERE DateOfBirth BETWEEN @from AND @to", con))
                            {
                                command.Parameters.AddWithValue("@from", dateTimePicker1.Value);
                                command.Parameters.AddWithValue("@to", dateTimePicker2.Value);
                                SqlDataAdapter sda = new SqlDataAdapter(command);
                                sda.Fill(dt);
                                dataGridView1.DataSource = dt;

                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("error :" + ex.Message);
            }
        } // works

        private void Animalscs_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        public void FillDatagridView()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                SqlDataAdapter sql = new SqlDataAdapter("searchByFirstLetter", conn);
                sql.SelectCommand.CommandType = CommandType.StoredProcedure;
                sql.SelectCommand.Parameters.AddWithValue("@Name", searchbyNOrLtxt.Text.Trim());
                DataTable dt = new DataTable();
                sql.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                conn.Close();
            }
        } // Method 

        private void searchbyNOrLBtn_Click(object sender, EventArgs e)
        {
            try
            {
                FillDatagridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " Error Message ");
            }
        } // works

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM AnimaL WHERE Gender = 'Female'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void viewMaleBtn_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM AnimaL WHERE Gender = 'Male'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        } // works

        private void exportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.SelectAll();
                DataObject copy = dataGridView1.GetClipboardContent();
                if (copy != null) Clipboard.SetDataObject(copy);
                Microsoft.Office.Interop.Excel.Application ex = new Microsoft.Office.Interop.Excel.Application();
                ex.Visible = true;
                Microsoft.Office.Interop.Excel.Workbook work;
                Microsoft.Office.Interop.Excel.Worksheet sheet;
                object misedata = System.Reflection.Missing.Value;
                work = ex.Workbooks.Add(misedata);

                sheet = work.Worksheets.get_Item(1);
                Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[0, 1];
                range.Select();

                sheet.PasteSpecial(range, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            catch (Exception er)
            {

                MessageBox.Show("Error " + er.Message);
            }
        }  // works

        private void tipsBtn_Click(object sender, EventArgs e)
        {
            Word ws = new Word();
            ws.Show();
            this.Hide();
        } // works
    }
}
