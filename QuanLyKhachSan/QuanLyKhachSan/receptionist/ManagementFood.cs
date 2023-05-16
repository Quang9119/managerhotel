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
    public partial class ManagementFood : Form
    {
        labor labor = new labor();
        Receptionist receptionist = new Receptionist();
        public ManagementFood()
        {
            InitializeComponent();
        }
        public void fillGrid(SqlCommand command)
        {

            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = labor.getslabor(command);

        }
        private void ManagementFood_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("SELECT * FROM foods"));
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
            string name = textBoxName.Text;
            int cost = Convert.ToInt32(textBoxcost.Text);
            int quantity = Convert.ToInt32(textBoxquantity.Text);
            if (receptionist.checknamefood(name))
            {
                if (receptionist.insertfood(name, cost, quantity))
                {
                    MessageBox.Show("Success");
                    ManagementFood_Load(null, null);
                }
            }
            else
            {
                MessageBox.Show("Food exist");
                return;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(textBoxID.Text);

            
            string name = textBoxName.Text;
            int cost = Convert.ToInt32(textBoxcost.Text);
            int quantity = Convert.ToInt32(textBoxquantity.Text);
            try
                {

                    if (receptionist.updatefood(Id, name,cost, quantity))
                    {
                        MessageBox.Show("Food information updated ", "Edit Food", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ManagementFood_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Food", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error", "Edit Food", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxID.Text.ToString());

                if (MessageBox.Show("Are you sure you want to delete food", "Delete food", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (receptionist.deLetefood(id))
                    {
                        MessageBox.Show("food deleted", "Delete food", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ManagementFood_Load(null, null);

                        buttonReset_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("food not deleted", "Delete food", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please choose a valid ID", "Delete food", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxID.Text = null;
            textBoxName.Text = null;
            textBoxcost.Text = null;
            textBoxquantity.Text = null;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxcost.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxquantity.Text  = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
