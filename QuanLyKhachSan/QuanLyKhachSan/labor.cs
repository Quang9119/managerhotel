using project_in_class;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace QuanLyKhachSan
{
    internal class labor
    {
        MY_DB mydb = new MY_DB();
        public DataTable getcheckin(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool inserttimein(int Id, string date, string timein)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Timekeeping (Timekeeping_employee,date,timein,timeout)" +
                "VALUES (@id,@date,@timein,@timeout)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@date", SqlDbType.NVarChar).Value = date;
            command.Parameters.Add("@timein", SqlDbType.NVarChar).Value = timein;
            command.Parameters.Add("@timeout", SqlDbType.NVarChar).Value = DBNull.Value;

            mydb.OpenConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool inserttimeout(int Id, string date, string timeout)
        {
            SqlCommand command = new SqlCommand("UPDATE Timekeeping SET timeout = @out where Timekeeping_employee = @id and date = @date", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@date", SqlDbType.NVarChar).Value = date;
            command.Parameters.Add("@out", SqlDbType.NVarChar).Value = timeout;

            mydb.OpenConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool updatetimein(int Id, string date, string timein)
        {
            SqlCommand command = new SqlCommand("UPDATE Timekeeping SET timein = @in where Timekeeping_employee = @id and date = @date", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@date", SqlDbType.NVarChar).Value = date;
            command.Parameters.Add("@in", SqlDbType.NVarChar).Value = timein;

            mydb.OpenConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool deLetelabor(int Id,string date)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Timekeeping WHERE Timekeeping_employee = @id and date = @date", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@date", SqlDbType.NVarChar).Value = date;

            mydb.OpenConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public DataTable getslabor(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool insertlabor(string name,string gender,string email,string phone,string address,string role,string username,string password)
        {
            SqlCommand command = new SqlCommand("INSERT INTO employees (employee_name, gender, email, phone, address, role, username, password)" +
                "VALUES (@name,@gender,@email,@phone,@address,@role,@username,@password)", mydb.getConnection);
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender;
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@role", SqlDbType.NVarChar).Value = role;
            command.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
            command.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;


            mydb.OpenConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool checkusername(string username)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM employees WHERE username =@username ", mydb.getConnection);
            command.Parameters.Add("username", SqlDbType.VarChar).Value = username;
            
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            System.Data.DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return false;
            }
            else { return true; }
        }
        public bool deLetelabor(int Id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM employees WHERE employee_id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;

            mydb.OpenConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool updatelabor(int Id,string name, string gender, string email, string phone, string address, string role, string username, string password)
        {
            SqlCommand command = new SqlCommand("Update  employees " +
                "SET employee_name = @name, gender = @gender,email = @email,phone = @phone,address = @address,role = @role, username =@username,password = @password WHERE employee_id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;

            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender;
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@role", SqlDbType.NVarChar).Value = role;
            command.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
            command.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;


            mydb.OpenConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool Checkchangpass(string username, string password)
        {
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM employees WHERE username = @user AND password = @pass ",
                mydb.getConnection);
            command.Parameters.AddWithValue("@user", username);
            command.Parameters.AddWithValue("@pass", password);
            

            mydb.OpenConnection();

            int count = Convert.ToInt32(command.ExecuteScalar());

            mydb.closeConnection();

            return count > 0;
        }
        public bool upDateuser(string usernamenew, string password, string usernameold)
        {
            SqlCommand command = new SqlCommand("UPDATE employees SET password = @pass, username = @usernew WHERE username = @userold", mydb.getConnection);
            command.Parameters.Add("@usernew", SqlDbType.VarChar).Value = usernamenew;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@userold", SqlDbType.VarChar).Value = usernameold;

            mydb.OpenConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
    }
}
