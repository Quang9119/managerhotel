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
            textBoxOTP.Enabled = false;
        }

        private void buttonSendOTP_Click(object sender, EventArgs e)
        {
            try
            {
                otp = random.Next(100000, 1000000);
                var fromAddress = new MailAddress("nguyenminhquangquangquang@gmail.com");
                var toAddress = new MailAddress(textBoxemail.ToString());
                const string frompass = "ccmxillgefdyetrr";
                const string subject = "Verify your email address";
                string body = otp.ToString();
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, frompass),
                    Timeout = 200000
                };
                using (var message = new System.Net.Mail.MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = "To verify your email address use this security code: " + body + ". \nIf you didn't request this code, you can safely ignore this email. Someone else might have typed your email address by mistake."

                })
                {
                    smtp.Send(message);
                }
                MessageBox.Show("OTP sent to mail");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBoxOTP.Enabled = true;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (!otp.ToString().Equals(textBoxOTP.Text))
            {
                MessageBox.Show("Incorrect OTP");
                return;
            }
            string username = textBoxusername.Text;
            string passwordold = textBoxpasswordold.Text;
            string passwordnew = textBoxpasswordnew.Text;
            string email = textBoxemail.Text;
            if (user.Checkchangpass(username, passwordold, email))
            {
                try
                {
                    if (user.upDateuser(username, passwordnew, username))
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
