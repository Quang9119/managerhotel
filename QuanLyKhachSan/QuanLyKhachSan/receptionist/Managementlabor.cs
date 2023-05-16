using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;

namespace QuanLyKhachSan.receptionist
{
    public partial class Managementlabor : Form
    {
        public Managementlabor()
        {
            InitializeComponent();
        }
        labor labor = new labor();
        public void fillGrid(SqlCommand command)
        {
            
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = labor.getslabor(command);
            
        }
        private void Managementlabor_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("SELECT * FROM employees WHERE role = 'Labor'"));
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string gender="";
            string name = textBoxName.Text;
            if(radioButtonFemale.Checked )
            {
                 gender = "Female";
            }
            else if(radioButtonMale.Checked ) {  gender = "Male"; }
            if (gender != "")
            {
                string email = textBoxemail.Text;
                string phone = textBoxPhone.Text;
                string address = textBoxAddress.Text;
                string role = comboBoxrole.Text;
                string username = textBoxusername.Text;
                string password = textBoxpassword.Text;
                if(labor.checkusername(username))
                {
                    if (labor.insertlabor(name, gender, email, phone, address, role, username, password))
                    {
                        MessageBox.Show("Success");
                        Managementlabor_Load(null, null);
                    }
                }
                else
                {
                        MessageBox.Show("Username already registered");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please Choose gender");

            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            textBoxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            if ((dataGridView1.CurrentRow.Cells[2].Value.ToString().Trim() == "Female"))
            {
                radioButtonFemale.Checked = true;
            }
            else
            {
                radioButtonMale.Checked = true;
            }
            textBoxemail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxPhone.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxAddress.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboBoxrole.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
           
            textBoxusername.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBoxpassword.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {

            try
            {
                int id = Convert.ToInt32(textBoxID.Text.ToString());

                if (MessageBox.Show("Are you sure you want to delete employee", "Delete employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (labor.deLetelabor(id))
                    {
                        MessageBox.Show("employee deleted", "Delete employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Managementlabor_Load(null, null);
                        buttonReset_Click(null,null);

                    }
                    else
                    {
                        MessageBox.Show("employee not deleted", "Delete employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please choose a valid ID", "Delete employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(textBoxID.Text);

            string gender = "";
            string name = textBoxName.Text;
            if (radioButtonFemale.Checked)
            {
                gender = "Female";
            }
            else if (radioButtonMale.Checked) { gender = "Male"; }
            if (gender != "")
            {
                string email = textBoxemail.Text;
                string phone = textBoxPhone.Text;
                string address = textBoxAddress.Text;
                string role = comboBoxrole.Text;
                string username = textBoxusername.Text;
                string password = textBoxpassword.Text;
                try
                {

                    if (labor.updatelabor(Id, name, gender, email, phone, address, role, username, password))
                    {
                        MessageBox.Show("Employee information updated ", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Managementlabor_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please Choose gender");

            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";

            radioButtonFemale.Checked = false;
            radioButtonMale.Checked = false;
            textBoxPhone.Text = "";
            textBoxAddress.Text = "";
            textBoxName.Text = "";
            textBoxemail.Text = "";
            comboBoxrole.Text = "";
            textBoxusername.Text = "";
            textBoxpassword.Text = "";
        }
    }
}
