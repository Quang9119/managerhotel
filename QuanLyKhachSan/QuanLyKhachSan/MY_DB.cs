using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_in_class
{
    class MY_DB
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-SH0M4EMV\SQLEXPRESS;Initial Catalog=managerhotel;Integrated Security=True");
        public SqlConnection getConnection
        {
            get { return con; }
        }
        public void OpenConnection()
        {
            if ((con.State == ConnectionState.Closed))
            {
                con.Open();
            }
        }
        public void closeConnection()
        {
            if ((con.State == ConnectionState.Open))
            {
                con.Close();
            }
        }
    }
}
