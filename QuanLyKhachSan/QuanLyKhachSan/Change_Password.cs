using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class Change_Password : Form
    {
        Random random = new Random();
        int otp;
        User user = new User();

        public Change_Password()
        {
            InitializeComponent();
        }

        private void Change_Password_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonSendOTP_Click(object sender, EventArgs e)
        {
            
           
            
        }
        labor labor = new labor();
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            
            string username = textBoxusername.Text;
            string passwordold = textBoxpasswordold.Text;
            string passwordnew = textBoxpasswordnew.Text;
            
            if (labor.Checkchangpass(username, passwordold))
            {
                try
                {
                    if (labor.upDateuser(username, passwordnew, username))
                    {
                        MessageBox.Show("Information the user Updated", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
                catch
                {
                    MessageBox.Show("Username registered , Please choose another username ", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("There are no Accounts with the information you provided.", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void checkBoxpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxpasswordold.Checked)
            {
                textBoxpasswordold.UseSystemPasswordChar = false;

            }
            else
            {
                textBoxpasswordold.UseSystemPasswordChar = true;

            }
        }

        private void checkBoxpasswordnew_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxpasswordnew.Checked)
            {
                textBoxpasswordnew.UseSystemPasswordChar = false;

            }
            else
            {
                textBoxpasswordnew.UseSystemPasswordChar = true;

            }
        }
    }
}
