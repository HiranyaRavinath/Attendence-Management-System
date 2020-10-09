using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;







namespace attendence_management_system
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        private string passwordTemfordec;
        public bool loginFlag { get; set; }
        public int UserID { get; set; }

        public LoginForm()
        {
            InitializeComponent();
            loginFlag = false;

           




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


     /*   public string encryption(String password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();
            //encrypt the given password string into Encrypted data  
            encrypt = md5.ComputeHash(encode.GetBytes(password));
            StringBuilder encryptdata = new StringBuilder();
            //Create a new string by using the encrypted data  
            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }
            return encryptdata.ToString();
        }
     */


        private void metroButtonLogin_Click(object sender, EventArgs e)


        {



            DataSet1TableAdapters.UsersTableAdapter userAda = new DataSet1TableAdapters.UsersTableAdapter();


            Crypt new1 = new Crypt();
            passwordTemfordec=new1.encryption(metroTextBoxpassword.Text);

           //passwordTemfordec = encryption(metroTextBoxpassword.Text);
   
            DataTable dt = userAda.GetDataByUserAndPass(metroTextBoxusername.Text, passwordTemfordec);


          //  MessageBox.Show(metroTextBoxusername.Text+"  test   " + passwordTemfordec); // test  
          //   int UserIdtest = int.Parse(dt.Rows[0]["UserID"].ToString());
         //   MessageBox.Show"UserIdtest");

            if (dt.Rows.Count > 0)
            {
                //valid
               // MessageBox.Show("Login successful");
                UserID = int.Parse(dt.Rows[0]["UserID"].ToString());
                loginFlag = true;
                
            }
            else
            {
                // not valid
                MessageBox.Show("login error");
                loginFlag = false;

            }

           Close(); //here i changed the plan guys


        }
    }
}
