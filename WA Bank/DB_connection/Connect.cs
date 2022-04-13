using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WA_Bank.DB_connection
{
    internal class Connect
    {
        SqlConnection con = new SqlConnection();

        //constutor
        public Connect()
        {
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        //metodos
        public SqlConnection OpenConection()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();

            }
            return con;
        }

        public void CloseConection()
        {
            if(con.State != System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
