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
    public partial class Checkinlabor : Form
    {
        public Checkinlabor()
        {
            InitializeComponent();
        }
        labor labor = new labor();
        private void buttonshow_Click(object sender, EventArgs e)
        {
            if (Global.Globalrole.ToString() == "Labor")
            {
                DateTime selected_date = dateTimePickerdaymonthyear.Value;
                int year = selected_date.Year;
                int month = selected_date.Month;
                int day = selected_date.Day;
                string date = $"{year}-{month}-{day}";
                SqlCommand command = new SqlCommand("SELECT Timekeeping.*,employee_name,role FROM Timekeeping,employees WHERE Timekeeping_employee = @id and date = @date and Timekeeping_employee = employee_id");
                command.Parameters.Add("@id", SqlDbType.Int).Value = Global.GlobalUserId;
                command.Parameters.Add("@date", SqlDbType.NVarChar).Value = date;

                dataGridView1.ReadOnly = true;

                dataGridView1.RowTemplate.Height = 80;
                dataGridView1.DataSource = labor.getcheckin(command);
                dataGridView1.Columns[0].Visible = false;
            }
            else 
            {
                DateTime selected_date = dateTimePickerdaymonthyear.Value;
                int year = selected_date.Year;
                int month = selected_date.Month;
                int day = selected_date.Day;
                string date = $"{year}-{month}-{day}";
                SqlCommand command = new SqlCommand("SELECT Timekeeping_id,Timekeeping_employee,date,timein,timeout,employee_name,role FROM Timekeeping,employees WHERE  date = @date and role ='Labor' and Timekeeping_employee = employee_id");

                command.Parameters.Add("@date", SqlDbType.NVarChar).Value = date;

                dataGridView1.ReadOnly = true;

                dataGridView1.RowTemplate.Height = 80;
                dataGridView1.DataSource = labor.getcheckin(command);
                dataGridView1.Columns[0].Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Global.Globalrole.ToString() == "Labor")
            {
                DateTime selected_date = dateTimePickerdaymonthyear.Value;
                int year = selected_date.Year;
                int month = selected_date.Month;
                int day = selected_date.Day;
                DateTime selected_timein = dateTimePickertimein.Value;
                int hour = selected_timein.Hour;
                int minute = selected_timein.Minute;
                int second = selected_timein.Second;

                string date = $"{year}-{month}-{day}";
                string timein = $"{hour}:{minute}:{second}";
                try
                {
                    if (labor.inserttimein(Global.GlobalUserId, date, timein))
                    {
                        MessageBox.Show("Success");
                        buttonshow_Click(null, null);
                    }
                }
                catch
                {
                    if (labor.updatetimein(Global.GlobalUserId, date, timein))
                    {
                        MessageBox.Show("Success");
                        buttonshow_Click(null, null);
                    }
                }
            }
            else 
            {
                int ideploy = Convert.ToInt32(textBoxidemployee.Text);
                DateTime selected_date = dateTimePickerdaymonthyear.Value;
                int year = selected_date.Year;
                int month = selected_date.Month;
                int day = selected_date.Day;
                DateTime selected_timein = dateTimePickertimein.Value;
                int hour = selected_timein.Hour;
                int minute = selected_timein.Minute;
                int second = selected_timein.Second;

                string date = $"{year}-{month}-{day}";
                string timein = $"{hour}:{minute}:{second}";
                try
                {
                    if (labor.inserttimein(ideploy, date, timein))
                    {
                        MessageBox.Show("Success");
                        buttonshow_Click(null, null);
                    }
                }
                catch
                {
                    if (labor.updatetimein(ideploy, date, timein))
                    {
                        MessageBox.Show("Success");
                        buttonshow_Click(null, null);
                    }
                }
            }
                
        }

        private void buttoncheckout_Click(object sender, EventArgs e)
        {
            if (Global.Globalrole.ToString() == "Labor")
            {
                DateTime selected_date = dateTimePickerdaymonthyear.Value;
                int year = selected_date.Year;
                int month = selected_date.Month;
                int day = selected_date.Day;
                DateTime selected_timeout = dateTimePickertimeout.Value;
                int hour = selected_timeout.Hour;
                int minute = selected_timeout.Minute;
                int second = selected_timeout.Second;

                string date = $"{year}-{month}-{day}";
                string timeout = $"{hour}:{minute}:{second}";
                if (labor.inserttimeout(Global.GlobalUserId, date, timeout))
                {
                    MessageBox.Show("Success");
                    buttonshow_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Please check in advance");
                }
            }
            else 
            {
                int ideploy = Convert.ToInt32(textBoxidemployee.Text);

                DateTime selected_date = dateTimePickerdaymonthyear.Value;
                int year = selected_date.Year;
                int month = selected_date.Month;
                int day = selected_date.Day;
                DateTime selected_timeout = dateTimePickertimeout.Value;
                int hour = selected_timeout.Hour;
                int minute = selected_timeout.Minute;
                int second = selected_timeout.Second;

                string date = $"{year}-{month}-{day}";
                string timeout = $"{hour}:{minute}:{second}";
                if (labor.inserttimeout(ideploy, date, timeout))
                {
                    MessageBox.Show("Success");
                    buttonshow_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Please check in advance");
                }
            }
                
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (Global.Globalrole.ToString() == "Labor")
            {
                string timein = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                DateTime time;

                if (DateTime.TryParse(timein, out time))
                {
                    dateTimePickertimein.Value = time;
                }
                string timeout = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                DateTime time1;

                if (DateTime.TryParse(timeout, out time1))
                {
                    dateTimePickertimeout.Value = time1;
                }
            }
            else 
            {
                textBoxidemployee.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string timein = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                DateTime time;

                if (DateTime.TryParse(timein, out time))
                {
                    dateTimePickertimein.Value = time;
                }
                string timeout = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                DateTime time1;

                if (DateTime.TryParse(timeout, out time1))
                {
                    dateTimePickertimeout.Value = time1;
                }
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Global.Globalrole.ToString() == "Labor")
            {
                DateTime selected_date = dateTimePickerdaymonthyear.Value;
                int year = selected_date.Year;
                int month = selected_date.Month;
                int day = selected_date.Day;
                string date = $"{year}-{month}-{day}";
                if (labor.deLetelabor(Global.GlobalUserId, date))
                {
                    MessageBox.Show("Success");
                    buttonshow_Click(null, null);
                }
            }
            else 
            {
                int ideploy = Convert.ToInt32(textBoxidemployee.Text);

                DateTime selected_date = dateTimePickerdaymonthyear.Value;
                int year = selected_date.Year;
                int month = selected_date.Month;
                int day = selected_date.Day;
                string date = $"{year}-{month}-{day}";
                if (labor.deLetelabor(ideploy, date))
                {
                    MessageBox.Show("Success");
                    buttonshow_Click(null, null);
                }
            }
                
        }

        private void Checkinlaborbyreception_Load(object sender, EventArgs e)
        {
            buttonshow_Click(null,null);
            if (Global.Globalrole.ToString() == "Labor")
            {
                textBoxidemployee.Visible = false;
                label3.Visible = false;

            }
            else
            {

            }
        }
    }
}
