﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace Animal_Project
{
    public partial class Word : Form
    {
        public Word()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        } // works

        private void button3_Click(object sender, EventArgs e)
        {
            Animalscs an = new Animalscs();
            an.Show();
            this.Hide();
        } // works
    }
}
