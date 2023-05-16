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
    public partial class ManagementRoom : Form
    {
        public ManagementRoom()
        {
            InitializeComponent();
        }
        labor labor = new labor();
        Receptionist receptionist = new Receptionist();
        private void comboBoxrole_SelectedValueChanged(object sender, EventArgs e)
        {
            if(comboBoxtype.SelectedItem.ToString()=="Single") { textBoxCost.Text = "70000"; }
            else if (comboBoxtype.SelectedItem.ToString() == "Double") { textBoxCost.Text = "100000"; }
            else if (comboBoxtype.SelectedItem.ToString() == "Triple") { textBoxCost.Text = "130000"; }
            else if (comboBoxtype.SelectedItem.ToString() == "Quad") { textBoxCost.Text = "160000"; }
            else if (comboBoxtype.SelectedItem.ToString() == "VIP") { textBoxCost.Text = "300000"; }
        }
        public void fillGrid(SqlCommand command)
        {

            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = labor.getslabor(command);

        }
        private void ManagementRoom_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("SELECT * FROM rooms"));
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            int cost = Convert.ToInt32(textBoxCost.Text);
            string type = comboBoxtype.SelectedItem.ToString();
            if (receptionist.checknameroom(name))
            {
                if (receptionist.insertroom(name, type, cost))
                {
                    MessageBox.Show("Success");
                    ManagementRoom_Load(null, null);
                }
            }
            else
            {
                MessageBox.Show("Room exist");
                return;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(textBoxID.Text);


            string name = textBoxName.Text;
            int cost = Convert.ToInt32(textBoxCost.Text);
            string type = comboBoxtype.SelectedItem.ToString();
            try
            {

                if (receptionist.updateroom(Id, name, type, cost))
                {
                    MessageBox.Show("Room information updated ", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ManagementRoom_Load(null, null);

                }
                else
                {
                    MessageBox.Show("Error", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxID.Text.ToString());

                if (MessageBox.Show("Are you sure you want to delete room", "Delete room", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (receptionist.deLeteroom(id))
                    {
                        MessageBox.Show("Room deleted", "Delete Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ManagementRoom_Load(null, null);


                        buttonReset_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Room not deleted", "Delete Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please choose a valid ID", "Delete Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxID.Text = string.Empty;
            textBoxName.Text = string.Empty;
            textBoxCost.Text = string.Empty;
            comboBoxtype.Text = string.Empty;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBoxtype.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxCost.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }
    }
}
