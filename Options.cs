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
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register rg = new Register();
            rg.Show();
            this.Hide();
        } // Works

        private void button2_Click(object sender, EventArgs e)
        {
            Animalscs ann = new Animalscs();
            ann.Show();
            this.Hide();
        } // Works

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        } // Works

    }
}
