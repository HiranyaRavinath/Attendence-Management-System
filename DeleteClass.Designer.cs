namespace attendence_management_system
{
    partial class DeleteClass
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
            this.metroTextBoxDelete = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonDelete = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroTextBoxDelete
            // 
            this.metroTextBoxDelete.Location = new System.Drawing.Point(193, 150);
            this.metroTextBoxDelete.Name = "metroTextBoxDelete";
            this.metroTextBoxDelete.Size = new System.Drawing.Size(302, 23);
            this.metroTextBoxDelete.TabIndex = 0;
            this.metroTextBoxDelete.Click += new System.EventHandler(this.metroTextBoxDelete_Click);
            // 
            // metroButtonDelete
            // 
            this.metroButtonDelete.Location = new System.Drawing.Point(231, 221);
            this.metroButtonDelete.Name = "metroButtonDelete";
            this.metroButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.metroButtonDelete.TabIndex = 1;
            this.metroButtonDelete.Text = "Delete";
            this.metroButtonDelete.Click += new System.EventHandler(this.metroButtonDelete_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(61, 150);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(94, 20);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Enter Class ID";
            // 
            // DeleteClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 327);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButtonDelete);
            this.Controls.Add(this.metroTextBoxDelete);
            this.Name = "DeleteClass";
            this.Text = "Delete Class";
            this.Load += new System.EventHandler(this.DeleteClass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBoxDelete;
        private MetroFramework.Controls.MetroButton metroButtonDelete;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}