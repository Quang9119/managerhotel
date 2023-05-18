using Microsoft.Win32;
using project_in_class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabelForgotpassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgot_password forgot_Password = new forgot_password();
            forgot_Password.ShowDialog();
        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
                MY_DB db = new MY_DB();
                
                SqlCommand command = new SqlCommand();
            command.Connection = db.getConnection;

            command.CommandText = "SELECT * FROM employees WHERE username = @User AND password = @Pass";
                command.Parameters.Add("@User", SqlDbType.VarChar).Value = textBoxusername.Text;
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = textBoxpassword.Text;
            if (radioButtonlabor.Checked)
            {
                command.CommandText += " and role = 'Labor'";
            }
            else if (radioButtonrêcptionist.Checked)
            {
                command.CommandText += " and role = 'Receptionist'";
            }
            else if (radioButtonmanager.Checked)
            {
                command.CommandText += " and role = 'Manager'";
            }
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if ((table.Rows.Count > 0))
                {
                    MessageBox.Show("Ok, next time will be go to Main menu of app.");
                    int userid = Convert.ToInt32(table.Rows[0][0].ToString());
                    Global.SetGlobalUserId(userid);
                    string role = table.Rows[0][6].ToString();
                    Global.SetGlobalrole(role);

                    this.DialogResult = DialogResult.OK;
                    
                    Mainformreceptionist mflb = new Mainformreceptionist();
                    mflb.Width = 1000;
                    mflb.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Ivalid username or password!");
                    
                }
            
        }
        private void textBoxusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxusername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxusername.Text))
            {
                e.Cancel = true;
                textBoxusername.Focus();
                errorProvider.SetError(textBoxusername, "Username not empty!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBoxusername, null);

            }
        }

        private void linkLabelforgotpassword_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgot_password fogpass = new forgot_password();
            fogpass.ShowDialog();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void textBoxpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxpassword.Checked)
            {
                textBoxpassword.UseSystemPasswordChar = false;

            }
            else
            {
                textBoxpassword.UseSystemPasswordChar = true;

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Change_Password changepass = new Change_Password();
            changepass.ShowDialog();
        }
    }
}
