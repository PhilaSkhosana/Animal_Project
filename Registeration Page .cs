using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animal_Project
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        Datahandler dh = new Datahandler();
      
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            op.Show();
            this.Hide();
        } // done 

        private void registerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dh.RegisterPeople(usernametxt.Text.Trim(), passwordtxt.Text.Trim(), accTypcb.Text.Trim());
                Options op = new Options();
                op.Show();
                this.Hide();

                if (passwordtxt.Text.Trim() != confirmtxt.Text.Trim())
                {
                    MessageBox.Show("Passwords missmatch error, Re-try!");
                }

            }
            catch (Exception s)
            {
                MessageBox.Show("Error  :", s.Message);
            }
            
        } // done

        private void accTypcb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        } // done 
    }
}
