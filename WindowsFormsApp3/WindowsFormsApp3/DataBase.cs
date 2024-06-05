using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    internal class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=NE4TOTO\TEST3;Initial Catalog=Авторизация;Integrated Security=True");
        
        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) 
            {
                sqlConnection.Open();
            }
        }
        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return sqlConnection;
        }
    }
}
