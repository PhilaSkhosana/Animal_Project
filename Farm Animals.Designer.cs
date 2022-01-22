
namespace Animal_Project
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.viewAnimalBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.viewBabyAnimalBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.typeoffoodtxt = new System.Windows.Forms.TextBox();
            this.femaleRb = new System.Windows.Forms.RadioButton();
            this.maleRb = new System.Windows.Forms.RadioButton();
            this.typeofAnimalCB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.nicknametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.purposetxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.clearBTn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(17, 725);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(159, 66);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add Animal ";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(201, 724);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(159, 66);
            this.removeBtn.TabIndex = 1;
            this.removeBtn.Text = "Remove Animal ";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // viewAnimalBtn
            // 
            this.viewAnimalBtn.Location = new System.Drawing.Point(560, 724);
            this.viewAnimalBtn.Name = "viewAnimalBtn";
            this.viewAnimalBtn.Size = new System.Drawing.Size(159, 66);
            this.viewAnimalBtn.TabIndex = 3;
            this.viewAnimalBtn.Text = "View Animals";
            this.viewAnimalBtn.UseVisualStyleBackColor = true;
            this.viewAnimalBtn.Click += new System.EventHandler(this.viewAnimalBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(380, 724);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(159, 66);
            this.updateBtn.TabIndex = 2;
            this.updateBtn.Text = "Update Animal Details ";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(702, 599);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(422, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Farm Animals";
            // 
            // viewBabyAnimalBtn
            // 
            this.viewBabyAnimalBtn.Location = new System.Drawing.Point(747, 725);
            this.viewBabyAnimalBtn.Name = "viewBabyAnimalBtn";
            this.viewBabyAnimalBtn.Size = new System.Drawing.Size(159, 66);
            this.viewBabyAnimalBtn.TabIndex = 8;
            this.viewBabyAnimalBtn.Text = "More Edits ";
            this.viewBabyAnimalBtn.UseVisualStyleBackColor = true;
            this.viewBabyAnimalBtn.Click += new System.EventHandler(this.button7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(862, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 259);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // typeoffoodtxt
            // 
            this.typeoffoodtxt.Location = new System.Drawing.Point(899, 638);
            this.typeoffoodtxt.Name = "typeoffoodtxt";
            this.typeoffoodtxt.Size = new System.Drawing.Size(259, 22);
            this.typeoffoodtxt.TabIndex = 39;
            // 
            // femaleRb
            // 
            this.femaleRb.AutoSize = true;
            this.femaleRb.Location = new System.Drawing.Point(992, 489);
            this.femaleRb.Name = "femaleRb";
            this.femaleRb.Size = new System.Drawing.Size(75, 21);
            this.femaleRb.TabIndex = 38;
            this.femaleRb.TabStop = true;
            this.femaleRb.Text = "Female";
            this.femaleRb.UseVisualStyleBackColor = true;
            // 
            // maleRb
            // 
            this.maleRb.AutoSize = true;
            this.maleRb.Location = new System.Drawing.Point(899, 491);
            this.maleRb.Name = "maleRb";
            this.maleRb.Size = new System.Drawing.Size(59, 21);
            this.maleRb.TabIndex = 37;
            this.maleRb.TabStop = true;
            this.maleRb.Text = "Male";
            this.maleRb.UseVisualStyleBackColor = true;
            // 
            // typeofAnimalCB
            // 
            this.typeofAnimalCB.FormattingEnabled = true;
            this.typeofAnimalCB.Items.AddRange(new object[] {
            "Cattle",
            "Chicken",
            "Goat",
            "Sheep",
            "Horse",
            "Dog",
            "Poultry",
            "Birds",
            "Dairy Cattle",
            "Duck",
            "Rabbit",
            "Goose",
            "Donkey",
            "Fish",
            "Alpaca",
            "Llama",
            "Broiler",
            "Guineafowls",
            "Fowl",
            "Ostritches",
            "Orpington Chicken"});
            this.typeofAnimalCB.Location = new System.Drawing.Point(899, 536);
            this.typeofAnimalCB.Name = "typeofAnimalCB";
            this.typeofAnimalCB.Size = new System.Drawing.Size(259, 24);
            this.typeofAnimalCB.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(762, 643);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "Type Of Food :";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(762, 588);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Date Of Birth :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(899, 588);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(259, 22);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(762, 541);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Type Of Animal :";
            // 
            // nicknametxt
            // 
            this.nicknametxt.Location = new System.Drawing.Point(899, 452);
            this.nicknametxt.Name = "nicknametxt";
            this.nicknametxt.Size = new System.Drawing.Size(259, 22);
            this.nicknametxt.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(762, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Nickname :";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(899, 411);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(259, 22);
            this.nametxt.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(762, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Name :";
            // 
            // uploadBtn
            // 
            this.uploadBtn.Location = new System.Drawing.Point(955, 366);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(112, 27);
            this.uploadBtn.TabIndex = 42;
            this.uploadBtn.Text = "Upload Image";
            this.uploadBtn.UseVisualStyleBackColor = true;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // purposetxt
            // 
            this.purposetxt.Location = new System.Drawing.Point(899, 676);
            this.purposetxt.Name = "purposetxt";
            this.purposetxt.Size = new System.Drawing.Size(259, 22);
            this.purposetxt.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(762, 681);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 17);
            this.label9.TabIndex = 43;
            this.label9.Text = "Produce :";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(762, 493);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Gender :";
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(1106, 724);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(159, 66);
            this.exitBtn.TabIndex = 45;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // clearBTn
            // 
            this.clearBTn.Location = new System.Drawing.Point(931, 724);
            this.clearBTn.Name = "clearBTn";
            this.clearBTn.Size = new System.Drawing.Size(159, 66);
            this.clearBTn.TabIndex = 46;
            this.clearBTn.Text = "Clear Textboxes";
            this.clearBTn.UseVisualStyleBackColor = true;
            this.clearBTn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 800);
            this.Controls.Add(this.clearBTn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.purposetxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.typeoffoodtxt);
            this.Controls.Add(this.femaleRb);
            this.Controls.Add(this.maleRb);
            this.Controls.Add(this.typeofAnimalCB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nicknametxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.viewBabyAnimalBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.viewAnimalBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.addBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Animal ";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button viewAnimalBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewBabyAnimalBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox typeoffoodtxt;
        private System.Windows.Forms.RadioButton femaleRb;
        private System.Windows.Forms.RadioButton maleRb;
        private System.Windows.Forms.ComboBox typeofAnimalCB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nicknametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.TextBox purposetxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button clearBTn;
    }
}