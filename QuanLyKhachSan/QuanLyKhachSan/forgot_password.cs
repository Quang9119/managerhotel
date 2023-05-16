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
    public partial class forgot_password : Form
    {
        public forgot_password()
        {
            InitializeComponent();
        }
        private void labelusernameforgot_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        User user = new User();
        private void buttonSubmitpassword_Click(object sender, EventArgs e)
        {
            string username = textBoxusername.Text;
            string password = "";
            string email = "";

            if (radioButtonstudent.Checked)
            {
                if (user.getpassword(username, out password, out email))
                {
                    try
                    {

                        var fromAddress = new MailAddress("nguyenminhquangquangquang@gmail.com");
                        var toAddress = new MailAddress(email);
                        const string frompass = "ccmxillgefdyetrr";
                        const string subject = "Verify your email address";
                        string body = password;
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
                        using (var message = new MailMessage(fromAddress, toAddress)
                        {
                            Subject = subject,
                            Body = "Your password is : " + body + ". \n Never share with anyone."

                        })
                        {
                            smtp.Send(message);
                        }
                        MessageBox.Show("Password sent to your email , Please check", "Forgot password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("There are no Accounts with the information you provided.", "Forgot password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void forgot_password_Load(object sender, EventArgs e)
        {

        }
    }
}
