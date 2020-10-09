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
    public partial class DeleteClass : MetroFramework.Forms.MetroForm
    {
        public DeleteClass()
        {
            InitializeComponent();
        }

        private void DeleteClass_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBoxDelete_Click(object sender, EventArgs e)
        {

        }

        private void metroButtonDelete_Click(object sender, EventArgs e)
        {


            try
            {


                DataSet1TableAdapters.ClassesTBLTableAdapter adapt1 = new DataSet1TableAdapters.ClassesTBLTableAdapter();
                string del = metroTextBoxDelete.Text;
                int z = Int32.Parse(del);
                adapt1.DeleteClass(z);
                Close();
                DataSet1TableAdapters.StudentsTBLTableAdapter adapt2 = new DataSet1TableAdapters.StudentsTBLTableAdapter();
                adapt2.DeleteByClassID(z);
                Close();
                MessageBox.Show("delete succesful");
                this.Refresh();

            }
            catch (FormatException)
            {
                MessageBox.Show("invalid class this should only contain numbers");
            }
          






          
        }
    }
}
