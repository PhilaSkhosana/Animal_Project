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

namespace Animal_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog = Animals;Integrated Security=SSPI");

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string login = @"SELECT * FROM [Animals].[dbo].[Login/Register] Where Username = '"+usernametxt.Text.Trim()+"' and Password = '"+passwordtxt.Text.Trim()+"' and AccountType = '"+accTypcb.Text.Trim()+"'";
                conn.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(login, conn);
                DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                
                sqlDataAdapter.Fill(dt);
                
                if(accTypcb.Text.Trim() == "Manager")
                { 
                    if (dt.Rows.Count == 1)
                    {
                        Options op = new Options();
                        op.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error Please Check Your Password, Username and Account Type ! ");

                    }
                } 
                else if (accTypcb.Text.Trim() == "Employee")
                {
                    if (dt.Rows.Count == 1)
                    {
                        Form1 f1 = new Form1();
                        f1.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Error Please Check Your Password, Username and Account Type ! ");

                    }
                }
                else 
                {
                    MessageBox.Show("Please Check Your Credentials");
                }

            }
            catch (Exception ex )
            {
                MessageBox.Show("Error : " ,ex.Message);
            }

        }

    }
}
