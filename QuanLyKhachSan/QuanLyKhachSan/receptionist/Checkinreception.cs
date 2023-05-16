﻿using System;
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
    public partial class Checkinreception : Form
    {
        public Checkinreception()
        {
            InitializeComponent();
        }
        labor labor = new labor();
        private void buttonshow_Click(object sender, EventArgs e)
        {
            if (Global.Globalrole.ToString() == "Receptionist")
            {
                DateTime selected_date = dateTimePickerdaymonthyear.Value;
                int year = selected_date.Year;
                int month = selected_date.Month;
                int day = selected_date.Day;
                string date = $"{year}-{month}-{day}";
                SqlCommand command = new SqlCommand("SELECT * FROM Timekeeping WHERE Timekeeping_employee = @id and date = @date");
                command.Parameters.Add("@id", SqlDbType.Int).Value = Global.GlobalUserId;
                command.Parameters.Add("@date", SqlDbType.NVarChar).Value = date;

                dataGridView1.ReadOnly = true;

                dataGridView1.RowTemplate.Height = 80;
                dataGridView1.DataSource = labor.getcheckin(command);
                dataGridView1.Columns[0].Visible = false;
            }
        }

        private void Checkinreception_Load(object sender, EventArgs e)
        {
            if (Global.Globalrole.ToString() == "Receptionist")
            {
                label3.Visible = false;
                textBoxidemployee.Visible = false;
            }
        }

        private void buttoncheckin_Click(object sender, EventArgs e)
        {
            if (Global.Globalrole.ToString() == "Receptionist")
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
        }

        private void buttoncheckout_Click(object sender, EventArgs e)
        {
            if (Global.Globalrole.ToString() == "Receptionist")
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Global.Globalrole.ToString() == "Receptionist")
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
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (Global.Globalrole.ToString() == "Receptionist")
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
        }
    }
}