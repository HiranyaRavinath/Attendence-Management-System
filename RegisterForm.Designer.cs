namespace attendence_management_system
{
    partial class RegisterForm
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
            this.metroTextBoxRegusername = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxcpassword = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxRegpassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroTextBoxRegusername
            // 
            this.metroTextBoxRegusername.Location = new System.Drawing.Point(323, 157);
            this.metroTextBoxRegusername.Name = "metroTextBoxRegusername";
            this.metroTextBoxRegusername.Size = new System.Drawing.Size(240, 23);
            this.metroTextBoxRegusername.TabIndex = 0;
            // 
            // metroTextBoxcpassword
            // 
            this.metroTextBoxcpassword.Location = new System.Drawing.Point(323, 293);
            this.metroTextBoxcpassword.Name = "metroTextBoxcpassword";
            this.metroTextBoxcpassword.PasswordChar = '*';
            this.metroTextBoxcpassword.Size = new System.Drawing.Size(240, 23);
            this.metroTextBoxcpassword.TabIndex = 1;
            // 
            // metroTextBoxRegpassword
            // 
            this.metroTextBoxRegpassword.Location = new System.Drawing.Point(323, 230);
            this.metroTextBoxRegpassword.Name = "metroTextBoxRegpassword";
            this.metroTextBoxRegpassword.PasswordChar = '*';
            this.metroTextBoxRegpassword.Size = new System.Drawing.Size(240, 23);
            this.metroTextBoxRegpassword.TabIndex = 2;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(134, 157);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(80, 20);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "User Name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(134, 296);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(119, 20);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Confirm Password";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(134, 230);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(66, 20);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Password";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(278, 373);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(126, 56);
            this.metroButton1.TabIndex = 7;
            this.metroButton1.Text = "Accept";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(646, 670);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTextBoxRegpassword);
            this.Controls.Add(this.metroTextBoxcpassword);
            this.Controls.Add(this.metroTextBoxRegusername);
            this.Name = "RegisterForm";
            this.Text = "Registerform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBoxRegusername;
        private MetroFramework.Controls.MetroTextBox metroTextBoxcpassword;
        private MetroFramework.Controls.MetroTextBox metroTextBoxRegpassword;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}