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

namespace Animal_Project
{
    public partial class Form2 : Form
    {
        Datahandler dh = new Datahandler();
        string gender;
        public SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog = Animals;Integrated Security=SSPI");
        int id = 0;
        SqlCommand cmd;
        string location = "";
        int selectedRowIndex;

        public Form2()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Animalscs an = new Animalscs();
            an.Show();
            this.Hide();
        } 

        private void removeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dh.RemoveAnimal(id);
                SqlDataAdapter sda = new SqlDataAdapter("ViewAnimals", conn);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                sda.Fill(ds, "Animal");
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[8].Visible = false;

                //clearing textboxes
                nicknametxt.Clear();
                purposetxt.Clear();
                nametxt.Clear();
                typeoffoodtxt.Clear();

                // Clearing Cb & Date & Image
                dateTimePicker1.ResetText();
                typeofAnimalCB.ResetText();
                pictureBox1.Image = null;

                //Clear Radio Buttons 
                femaleRb.Checked = false;
                maleRb.Checked = false;

            }
            catch (Exception)
            {
                MessageBox.Show("Error: Please Select The Row You Would Like To Delete. ");
            }
        } // Works

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (femaleRb.Checked == true)
                {
                    gender = "Female";
                }
                else
                {
                    gender = "Male";
                }
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] img = ms.ToArray();
                selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
                if (selectedRowIndex >= 0)
                {
                    // Updates the animal into database 
                    DataGridViewRow update = dataGridView1.Rows[selectedRowIndex];
                    conn.Open();
                    cmd = new SqlCommand("UpdateAnimals", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@mode", "Update");
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Name", update.Cells[1].Value = nametxt.Text.Trim().Trim());
                    cmd.Parameters.AddWithValue("@Nickname", update.Cells[2].Value = nicknametxt.Text.Trim().ToString());
                    cmd.Parameters.AddWithValue("@Gender", update.Cells[3].Value = gender.Trim().ToString());
                    cmd.Parameters.AddWithValue("@TypeOFAnimal", update.Cells[4].Value = typeofAnimalCB.Text.Trim().ToString());
                    cmd.Parameters.AddWithValue("@DateOfBirth", update.Cells[5].Value = dateTimePicker1.Text.Trim().ToString());
                    cmd.Parameters.AddWithValue("@TypeofFood", update.Cells[6].Value = typeoffoodtxt.Text.Trim().ToString());
                    cmd.Parameters.AddWithValue("@Purpose", update.Cells[7].Value = purposetxt.Text.Trim().ToString());
                    cmd.Parameters.AddWithValue("@Image", update.Cells[8].Value = img);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    // clearing textboxes
                    nicknametxt.Clear();
                    purposetxt.Clear();
                    nametxt.Clear();
                    typeoffoodtxt.Clear();

                    // Clearing Cb & Date & Image
                    dateTimePicker1.ResetText();
                    typeofAnimalCB.ResetText();
                    pictureBox1.Image = null;

                    //Clear Radio Buttons 
                    femaleRb.Checked = false;
                    maleRb.Checked = false;
                    MessageBox.Show("Animal Has Been Edited");

                    // Updates the datagrview
                    SqlDataAdapter sda = new SqlDataAdapter("ViewAnimals", conn);
                    sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "Animal");
                    dataGridView1.DataSource = ds.Tables[0];
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[8].Visible = false;
                }
            }
            catch (Exception ex )
            {

                MessageBox.Show("Error :"+ ex.Message);
            }


        } // Works

        private void viewAnimalBtn_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("ViewAnimals", conn);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            sda.Fill(ds, "Animal");
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            

        } // Works

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog dialog = new OpenFileDialog())
                {
                    
                    dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG (*.png)|*.png| All Files (*.*)|*.*";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        location = dialog.FileName.ToString();
                        pictureBox1.ImageLocation = location;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured ", " Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } // works

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                byte[] images = null;
                FileStream fs = new FileStream(location, FileMode.Open, FileAccess.Read);
                BinaryReader Binary = new BinaryReader(fs);
                images = Binary.ReadBytes((int)fs.Length);

                if (femaleRb.Checked == true)
                {
                    gender = "Female";
                }
                else
                {
                    gender = "Male";
                }

                dh.AddAnimal(0, typeoffoodtxt.Text.Trim(), purposetxt.Text.Trim(), nametxt.Text.Trim(), nicknametxt.Text.Trim(), dateTimePicker1.Text.Trim(), gender, typeofAnimalCB.Text, images);
                // clearing textboxes
                nicknametxt.Clear();
                purposetxt.Clear();
                nametxt.Clear();
                typeoffoodtxt.Clear();

                // Clearing Cb & Date & Image
                dateTimePicker1.ResetText();
                typeofAnimalCB.ResetText();
                pictureBox1.Image = null;

                //Clear Radio Buttons 
                femaleRb.Checked = false;
                maleRb.Checked = false;

                // Views Animal onto the datagridView 
                SqlDataAdapter sda = new SqlDataAdapter("ViewAnimals", conn);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                sda.Fill(ds, "Animal");
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[8].Visible = false;
            }
            catch (Exception )
            {
                MessageBox.Show("Error : Please insert values in textbox");
            }
        } //works

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                // Checks if gender row has female in it so it can check the RadioButton 
                if (dataGridView1.CurrentRow.Cells[3].Value.ToString() == "Female")
                {
                    femaleRb.Checked = true;

                }
                else
                {
                    maleRb.Checked = true;
                }

                if (dataGridView1.CurrentRow.Index != -1)
                {


                    id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    nametxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    nicknametxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

                    typeofAnimalCB.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    typeoffoodtxt.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    purposetxt.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    dataGridView1.Columns[8].Visible = false;
                    dataGridView1.Columns[0].Visible = false;
                    conn.Open();
                    string query = "SELECT * FROM Animal WHERE ID = '" + id + "' ";
                    cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        //This allows us to view the animal image in the pictureBox
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
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("This Data Not Available");
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        } // Works

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        } // Works

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                // clearing textboxes
                nicknametxt.Clear();
                purposetxt.Clear();
                nametxt.Clear();
                typeoffoodtxt.Clear();

                // Clearing Cb & Date & Image
                dateTimePicker1.ResetText();
                typeofAnimalCB.ResetText();
                pictureBox1.Image = null;

                //Clear Radio Buttons 
                femaleRb.Checked = false;
                maleRb.Checked = false;

                MessageBox.Show(" You Have Cleared All The Textboxes. ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  : " + ex.Message);
            }
        } // Works
    }
   
}
