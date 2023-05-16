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
    internal class Receptionist
    {
        MY_DB mydb = new MY_DB();
        public bool checkidenti(string ident)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM guests WHERE guest_identity_card =@ident ", mydb.getConnection);
            command.Parameters.Add("@ident", SqlDbType.VarChar).Value = ident;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            System.Data.DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return false;
            }
            else { return true; }
        }
        public bool insertguest(string name, string gender, string phone, string ident)
        {
            SqlCommand command = new SqlCommand("INSERT INTO guests (guest_name, guest_phone, guest_gender, guest_identity_card)" +
                "VALUES (@name,@phone,@gender,@ident)", mydb.getConnection);
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender;
            
            command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@ident", SqlDbType.NVarChar).Value = ident; 


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
        public bool updateguest(int Id, string name, string gender, string phone, string ident)
        {
            SqlCommand command = new SqlCommand("Update  guests " +
                "SET guest_name = @name, guest_gender = @gender,guest_phone = @phone,guest_identity_card = @ident where guest_id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;

            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender;
            
            command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@ident", SqlDbType.NVarChar).Value = ident;
            


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
        public bool deLeteguest(int Id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM guests WHERE guest_id = @id", mydb.getConnection);
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
        public bool checknamefood(string name)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM foods WHERE food_name =@name ", mydb.getConnection);
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            System.Data.DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return false;
            }
            else { return true; }
        }
        public bool insertfood(string name, int cost,int quantity)
        {
            SqlCommand command = new SqlCommand("INSERT INTO foods (food_name, cost,quantity)" +
                "VALUES (@name,@cost,@quan)", mydb.getConnection);
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@cost", SqlDbType.Int).Value = cost;
            command.Parameters.Add("@quan", SqlDbType.Int).Value = quantity;

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
        public bool updatefood(int Id, string name, int cost,int quantity)
        {
            SqlCommand command = new SqlCommand("Update  foods " +
                "SET food_name = @name, cost = @cost , quantity = @quan where food_id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;

            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@cost", SqlDbType.Int).Value = cost;
            command.Parameters.Add("@quan", SqlDbType.Int).Value = quantity;

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
        public bool deLetefood(int Id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM foods WHERE food_id = @id", mydb.getConnection);
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
        public bool checknameroom(string name)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM rooms WHERE room_name =@name ", mydb.getConnection);
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            System.Data.DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return false;
            }
            else { return true; }
        }
        public bool insertroom(string name, string type, int cost)
        {
            SqlCommand command = new SqlCommand("INSERT INTO rooms (room_name, room_type,cost)" +
                "VALUES (@name,@type,@cost)", mydb.getConnection);
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@cost", SqlDbType.Int).Value = cost;
            command.Parameters.Add("@type", SqlDbType.NVarChar).Value = type;
            


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
        public bool updateroom(int Id, string name, string type, int cost)
        {
            SqlCommand command = new SqlCommand("Update  rooms " +
                "SET room_name = @name, cost = @cost , room_type = @type where room_id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;

            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@cost", SqlDbType.Int).Value = cost;
            command.Parameters.Add("@type", SqlDbType.NVarChar).Value = type;

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
        public bool deLeteroom(int Id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM rooms WHERE room_id = @id", mydb.getConnection);
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
    }
}
