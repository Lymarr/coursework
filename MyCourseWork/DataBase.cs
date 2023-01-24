using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace MyCourseWork
{
    internal class DataBase
    {
        SqlConnection sql_connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=master;Integrated Security=true");

        public void OpenConnection()
        {
            if (sql_connection.State == System.Data.ConnectionState.Closed)
            {
                sql_connection.Open();
            }
        }

            public void CloseConnection()
            {
                if (sql_connection.State == System.Data.ConnectionState.Open)
                {
                    sql_connection.Close();
                }

            }
        
        public SqlConnection GetConnection()
        {
            return sql_connection;
        }
    }
}
