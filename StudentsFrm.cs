using MetroFramework.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace attendence_management_system
{
    public partial class StudentsFrm : Form
    {
        //internal MetroStyleManager StyleManager;

        public int ClassID { get; set; }
        public string ClassName { get; set; }







        public StudentsFrm()
        {
            InitializeComponent();
        }

        private void StudentsFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.StudentsTBL' table. You can move, or remove it, as needed.
            this.studentsTBLTableAdapter.Fill(this.dataSet1.StudentsTBL);
            metroLabelclassid1.Text = ClassID.ToString();
            metroLabelclassname1.Text = ClassName.ToString();

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            // everything enterd saved to db
            this.studentsTBLBindingSource.EndEdit();
            this.studentsTBLTableAdapter.Update(dataSet1.StudentsTBL);
        }
    }
}
