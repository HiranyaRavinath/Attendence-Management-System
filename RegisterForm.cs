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

namespace attendence_management_system
{
    public partial class RegisterForm : Form
    {
        private string temppass;
        public RegisterForm()
        {
            InitializeComponent();
        }
      /*  public string encryption(String password)
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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if(metroTextBoxRegpassword.Text!= metroTextBoxcpassword.Text)
            {
                MessageBox.Show("Passwords Dont match!");
                return;
            }
            else
            {
                DataSet1TableAdapters.UsersTableAdapter ada = new DataSet1TableAdapters.UsersTableAdapter();


                Crypt new2 = new Crypt();
                temppass =new2.encryption(metroTextBoxRegpassword.Text);

                ada.InsertQuery(metroTextBoxRegusername.Text, temppass);
                MessageBox.Show("Registeration completed");
                Close();


            }


        }
    }
}
