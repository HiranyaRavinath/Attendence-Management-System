using attendence_management_system.DataSet1TableAdapters;
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
    public partial class mainfrm : MetroFramework.Forms.MetroForm
    {
        
        public int loggedIn { get; set; }
        public int UserID { get; set; }

        public mainfrm()
        {
            InitializeComponent();
            loggedIn = 0;



            // 
            this.StyleManager = metroSM;




        }




        private void load(object sender, EventArgs e)
        {



        }

        private void mainfrm_Act(object sender, EventArgs e)
        {
            /*  if (loggedIn == 0)
              {
                  //Open Login Form
                  LoginForm newLogin = new LoginForm();
                  newLogin.ShowDialog();

                  if (newLogin.loginFlag == false)
                  {
                      Close();
                  }

                  else
                  {
                      // UserID = newLogin.UserID;
                      // statLblUser.Text = UserID.ToString();
                      loggedIn = 1;

                      // this.classesTBLTableAdapter.Fill(this.dataSet1.ClassesTBL);
                      //classesTBLB  indingSource.Filter = "UserID = '" + UserID.ToString() + "'";

                  }*/
            if (loggedIn == 0)
            {
                //Open Login Form
                LoginForm newLogin = new LoginForm();
                newLogin.ShowDialog();

                if (newLogin.loginFlag == false)
                {

                    Close();
                }
                else
                {
                    UserID = newLogin.UserID;
                    // statLblUser.Text = UserID.ToString();
                    statusLabelUSer.Text = UserID.ToString();
                    loggedIn = 1;


                    // TODO: This line of code loads data into the 'dataSet1.ClassesTBL' table. You can move, or remove it, as needed.
                    this.classesTBLTableAdapter.Fill(this.dataSet1.ClassesTBL);

                    //for get filterd userids for the combo box 
                    classesTBLBindingSource.Filter = "UserID = '" + UserID.ToString() + "'";



                    // this.classesTBLTableAdapter.Fill(this.dataSet1.ClassesTBL);
                    // classesTBLBindingSource.Filter = "UserID = '" + UserID.ToString() + "'";


                }


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            StudentsFrm students = new StudentsFrm();
            students.ClassName = metroComboBox1.Text;
            students.ClassID = (int)metroComboBox1.SelectedValue;
            students.ShowDialog();
            refresh1();


        }



        private void metroButton3_Click(object sender, EventArgs e)
        {
            FrmAddClass addclass = new FrmAddClass();
            addclass.UserID = this.UserID;
            addclass.ShowDialog();
            refresh1();
            









        }

        private void metroButtonGet_Click(object sender, EventArgs e)
        {

            //check if records exixts load em for edit if not create a record for each student and load for edit

            AttendanceRecordTBLTableAdapter ada = new AttendanceRecordTBLTableAdapter();
            DataTable dt = ada.GetDataBy((int)metroComboBox1.SelectedValue, dateTimePicker1.Text);

            if (dt.Rows.Count > 0)
            {
                //we have records,so we can edit

                DataTable dt_new = ada.GetDataBy((int)metroComboBox1.SelectedValue, dateTimePicker1.Text);
                dataGridView1.DataSource = dt_new;




            }
            else
            {
                //creatr a record for each student
                //Get the class students list
                StudentsTBLTableAdapter students_adapter = new StudentsTBLTableAdapter();
                DataTable dt_Student = students_adapter.GetDataByClassID((int)metroComboBox1.SelectedValue);

                foreach (DataRow row in dt_Student.Rows)
                {
                    //Insert a new record for this student



                    ada.InsertQuery((int)row[0], (int)metroComboBox1.SelectedValue, dateTimePicker1.Text, "", row[1].ToString(), metroComboBox1.Text);


                }


                DataTable dt_new = ada.GetDataBy((int)metroComboBox1.SelectedValue, dateTimePicker1.Text);
                dataGridView1.DataSource = dt_new;




            }





            // TODO: This line of code loads data into the 'dataSet1.AttendanceRecordTBL' table. You can move, or remove it, as needed.
            this.attendanceRecordTBLTableAdapter.Fill(this.dataSet1.AttendanceRecordTBL);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

             
           /// MessageBox.Show(dateTimePicker1.Text); test

            AttendanceRecordTBLTableAdapter ada = new AttendanceRecordTBLTableAdapter();
       

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value != null)
                {
           
                    
                    ada.UpdateQuery(row.Cells[1].Value.ToString(),row.Cells[0].Value.ToString(),(int)metroComboBox1.SelectedValue, dateTimePicker1.Text);

                }


                DataTable dt_new = ada.GetDataBy((int)metroComboBox1.SelectedValue, dateTimePicker1.Text);
                dataGridView1.DataSource = dt_new;

            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

            AttendanceRecordTBLTableAdapter ada = new AttendanceRecordTBLTableAdapter();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    ada.UpdateQuery("", row.Cells[0].Value.ToString(), (int)metroComboBox1.SelectedValue, dateTimePicker1.Text);

                }


                DataTable dt_new = ada.GetDataBy((int)metroComboBox1.SelectedValue, dateTimePicker1.Text);
                dataGridView1.DataSource = dt_new;

            }
        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        { 
           /* //get students
            StudentsTBLTableAdapter students_adapter = new StudentsTBLTableAdapter();
            DataTable dt_Student = students_adapter.GetDataByClassID((int)metroComboBox2.SelectedValue);



            AttendanceRecordTBLTableAdapter ada = new AttendanceRecordTBLTableAdapter();


            int p = 0;
            int A = 0;
            int L = 0;
            int E = 0;

            //loop through students and get the values
            foreach (DataRow row in dt_Student.Rows)
            {
                //Presence count
                p = (int)ada.GetDataByReport(dateTimePicker2.Value.Month, row[1].ToString(), "present").Rows[0][6];

                // Absence
                A = (int)ada.GetDataByReport(dateTimePicker2.Value.Month, row[1].ToString(), "absent").Rows[0][6];

                // late
                L = (int)ada.GetDataByReport(dateTimePicker2.Value.Month, row[1].ToString(), "late").Rows[0][6];


                //Execuse
                E = (int)ada.GetDataByReport(dateTimePicker2.Value.Month, row[1].ToString(), "execused").Rows[0][6];


                ListViewItem litem = new ListViewItem();
                litem.Text = row[1].ToString();
                litem.SubItems.Add(p.ToString());
                litem.SubItems.Add(A.ToString());
                litem.SubItems.Add(L.ToString());
                litem.SubItems.Add(E.ToString());
                listView.Items.Add(litem);
            }


            //add to listview*/
            
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            RegisterForm reg = new RegisterForm();
            reg.ShowDialog();
            refresh1();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroButton6_Click(object sender, EventArgs e)
        {

            //get students
            StudentsTBLTableAdapter students_adapter = new StudentsTBLTableAdapter();
            DataTable dt_Student = students_adapter.GetDataByClassID((int)metroComboBox2.SelectedValue);



            AttendanceRecordTBLTableAdapter ada = new AttendanceRecordTBLTableAdapter();

            int P=0,A=0,L=0,E=0;





            //loop through students and get the values
            foreach (DataRow row in dt_Student.Rows)
            {



                int x = dateTimePicker2.Value.Month;

                string y = row[1].ToString();


                /*
                P = (int)ada.GetDataByReport(dateTimePicker2.Value.Month, row[2].ToString(), "present").Rows[0][6];

                // Absence
                A = (int)ada.GetDataByReport(dateTimePicker2.Value.Month, row[2].ToString(), "absent").Rows[0][6];

                // late
                L = (int)ada.GetDataByReport(dateTimePicker2.Value.Month, row[2].ToString(), "late").Rows[0][6];


                //Execuse
                E = (int)ada.GetDataByReport(dateTimePicker2.Value.Month, row[2].ToString(), "execused").Rows[0][6];


                */



                //Presence count


                P = (int)ada.ScalarQuery(dateTimePicker2.Value.Month, row[1].ToString(),"present");

                // Absence
                A = (int)ada.ScalarQuery(dateTimePicker2.Value.Month, row[1].ToString(),"absence");

                // late

                A = (int)ada.ScalarQuery(dateTimePicker2.Value.Month, row[1].ToString(),"late");

                //Execuse

                A = (int)ada.ScalarQuery(dateTimePicker2.Value.Month, row[1].ToString(),"execuse");  

 
                /*       //Presence count
                        p = 1;
                dateTimePicker2.Value.Month, row[1].ToString(), "late"
                        // Absence
                        A = 1;

                        // late
                        L = 1;


                        //Execuse
                        E = 1;

       */



                ListViewItem listitem = new ListViewItem();
                listitem.Text = row[1].ToString();
                listitem.SubItems.Add(P.ToString());
                listitem.SubItems.Add(A.ToString());
                listitem.SubItems.Add(L.ToString());
                listitem.SubItems.Add(E.ToString());
                listViewreport.Items.Add(listitem);





            }







        }











        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void statusLabelUSer_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            
        }

        private void metroButtonlight_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            metroSM.Theme = MetroFramework.MetroThemeStyle.Dark;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            metroSM.Theme = MetroFramework.MetroThemeStyle.Light;
        }

        private void metroButton7_Click_1(object sender, EventArgs e)
        {
           
            
            LoginForm ss = new LoginForm();
            ss.loginFlag = false;
            ss.Show();
           // this.Close();

        }


        public void refresh1()
        {
           
                this.Refresh();
            
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void statusStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            DeleteClass del = new DeleteClass();
            del.Show();
            refresh1();
        }
    }
}