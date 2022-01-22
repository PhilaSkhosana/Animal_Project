
namespace Animal_Project
{
    partial class Register
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
            this.label3 = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.confirmtxt = new System.Windows.Forms.TextBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.accTypcb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(173, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(458, 80);
            this.label3.TabIndex = 13;
            this.label3.Text = "Registeration ";
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(239, 387);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(127, 51);
            this.registerBtn.TabIndex = 12;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password :";
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(331, 277);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(233, 22);
            this.passwordtxt.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username :";
            // 
            // usernametxt
            // 
            this.usernametxt.Location = new System.Drawing.Point(331, 178);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(233, 22);
            this.usernametxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Confirm Password :";
            // 
            // confirmtxt
            // 
            this.confirmtxt.Location = new System.Drawing.Point(331, 327);
            this.confirmtxt.Name = "confirmtxt";
            this.confirmtxt.Size = new System.Drawing.Size(233, 22);
            this.confirmtxt.TabIndex = 14;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(402, 387);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(162, 51);
            this.exitBtn.TabIndex = 16;
            this.exitBtn.Text = "Return To Options ";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // accTypcb
            // 
            this.accTypcb.FormattingEnabled = true;
            this.accTypcb.Items.AddRange(new object[] {
            "Manager",
            "Employee"});
            this.accTypcb.Location = new System.Drawing.Point(331, 231);
            this.accTypcb.Name = "accTypcb";
            this.accTypcb.Size = new System.Drawing.Size(233, 24);
            this.accTypcb.TabIndex = 43;
            this.accTypcb.SelectedIndexChanged += new System.EventHandler(this.accTypcb_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "Acc Type :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(691, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 51);
            this.button1.TabIndex = 44;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.accTypcb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.confirmtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernametxt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox confirmtxt;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.ComboBox accTypcb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}