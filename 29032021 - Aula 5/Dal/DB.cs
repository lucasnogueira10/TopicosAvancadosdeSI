using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class DB : IDisposable
    {
        private SqlConnection myConnection;

        public DB()
        {
            myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionSQLServer"].ConnectionString);
            myConnection.Open();
        }

        public void Dispose()
        {
            if (myConnection.State == ConnectionState.Open)
            {
                myConnection.Close();
            }
        }

        public bool ExecQuery(string query)
        {
            var cmd = new SqlCommand
            {
                CommandText = query,
                CommandType = CommandType.Text,
                Connection = myConnection
            };

            return (cmd.ExecuteNonQuery() == 1) ? true : false;
        }

        public SqlDataReader ExecQueryReturn(string query)
        {
            var cmd = new SqlCommand(query, myConnection);
            return cmd.ExecuteReader();
        }
    }
}
