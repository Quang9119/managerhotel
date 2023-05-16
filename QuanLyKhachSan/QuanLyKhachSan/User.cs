using project_in_class;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan
{
    internal class User
    {
        MY_DB mydb = new MY_DB();
        public bool insertUser(string username, string password, string email)
        {
            SqlCommand command = new SqlCommand("INSERT INTO log_in (username,password,email)" +
                "VALUES (@Un,@Pw,@Em)", mydb.getConnection);
            command.Parameters.Add("@Un", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@Pw", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@Em", SqlDbType.VarChar).Value = email;

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
        public DataTable getusers(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool deLeteuser(string username)
        {
            SqlCommand command = new SqlCommand("DELETE FROM log_in WHERE username = @user ", mydb.getConnection);
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = username;

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
        public bool upDateuser(string usernamenew, string password, string usernameold)
        {
            SqlCommand command = new SqlCommand("UPDATE log_in SET password = @pass, username = @usernew WHERE username = @userold", mydb.getConnection);
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
        public bool getpassword(string username, out string password, out string email)
        {
            password = null;
            email = null;
            SqlCommand command = new SqlCommand("SELECT password,email FROM log_in WHERE username = @user ", mydb.getConnection);
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = username;
            mydb.OpenConnection();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                password = reader["password"].ToString();
                email = reader["email"].ToString();
            }
            mydb.closeConnection();
            return !string.IsNullOrEmpty(password);
        }
        public bool Checkchangpass(string username, string password, string email)
        {
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM log_in WHERE username = @user AND password = @pass AND email = @email",
                mydb.getConnection);
            command.Parameters.AddWithValue("@user", username);
            command.Parameters.AddWithValue("@pass", password);
            command.Parameters.AddWithValue("@email", email);

            mydb.OpenConnection();

            int count = Convert.ToInt32(command.ExecuteScalar());

            mydb.closeConnection();

            return count > 0;
        }
    }
}
