
namespace Animal_Project
{
    partial class Form1
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
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.exitbtn = new System.Windows.Forms.Button();
            this.accTypcb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernametxt
            // 
            this.usernametxt.Location = new System.Drawing.Point(303, 145);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(233, 22);
            this.usernametxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username :";
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(327, 313);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(127, 51);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password :";
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(303, 203);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(233, 22);
            this.passwordtxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(289, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 80);
            this.label3.TabIndex = 6;
            this.label3.Text = "Login";
            // 
            // exitbtn
            // 
            this.exitbtn.Location = new System.Drawing.Point(682, 404);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(106, 34);
            this.exitbtn.TabIndex = 17;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // accTypcb
            // 
            this.accTypcb.FormattingEnabled = true;
            this.accTypcb.Items.AddRange(new object[] {
            "Manager",
            "Employee"});
            this.accTypcb.Location = new System.Drawing.Point(303, 250);
            this.accTypcb.Name = "accTypcb";
            this.accTypcb.Size = new System.Drawing.Size(233, 24);
            this.accTypcb.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Acc Type :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.accTypcb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernametxt);
            this.Name = "Form1";
            this.Text = "Login ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.ComboBox accTypcb;
        private System.Windows.Forms.Label label4;
    }
}

