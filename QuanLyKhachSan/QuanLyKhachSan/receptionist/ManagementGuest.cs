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

namespace QuanLyKhachSan.receptionist
{
    public partial class ManagementGuest : Form
    {
        public ManagementGuest()
        {
            InitializeComponent();
        }
        labor labor = new labor();
        Receptionist receptionist = new Receptionist();
        public void fillGrid(SqlCommand command)
        {

            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = labor.getslabor(command);

        }
        private void ManagementGuest_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("SELECT * FROM guests"));
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string gender = "";
            string name = textBoxName.Text;
            if (radioButtonFemale.Checked)
            {
                gender = "Female";
            }
            else if (radioButtonMale.Checked) { gender = "Male"; }
            if (gender != "")
            {
                
                string phone = textBoxPhone.Text;
                
                
                string identi = textBoxidentification.Text;
                
                if (receptionist.checkidenti(identi))
                {
                    if (receptionist.insertguest(name, gender,phone, identi))
                    {
                        MessageBox.Show("Success");
                        ManagementGuest_Load(null, null);
                    }
                }
                else
                {
                    MessageBox.Show("Identity Card exist");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please Choose gender");

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
                string identi = textBoxidentification.Text;

                string phone = textBoxPhone.Text;
                
                try
                {

                    if (receptionist.updateguest(Id, name, gender,phone,  identi))
                    {
                        MessageBox.Show("Guest information updated ", "Edit Guest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ManagementGuest_Load(null, null);

                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Guest", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error", "Edit Guest", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please Choose gender");

            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxID.Text.ToString());

                if (MessageBox.Show("Are you sure you want to delete guest", "Delete guest", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (receptionist.deLeteguest(id))
                    {
                        MessageBox.Show("guest deleted", "Delete guest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ManagementGuest_Load(null, null);
                        buttonReset_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("guest not deleted", "Delete guest", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please choose a valid ID", "Delete guest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";

            radioButtonFemale.Checked = false;
            radioButtonMale.Checked = false;
            textBoxPhone.Text = "";
            
            textBoxName.Text = "";
            textBoxidentification.Text = "";
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            textBoxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            if ((dataGridView1.CurrentRow.Cells[3].Value.ToString().Trim() == "Female"))
            {
                radioButtonFemale.Checked = true;
            }
            else
            {
                radioButtonMale.Checked = true;
            }
            
            textBoxPhone.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxidentification.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            
        }
    }
}
