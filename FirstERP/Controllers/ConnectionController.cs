using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstERP.Controllers
{
    class ConnectionController
    {
        ADODB.Connection cn = new ADODB.Connection();

        /// <summary>
        /// Conexão por ADODB
        /// </summary>
        public void DBConnect()
        {
            string connectionString = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=FirstERP;Data Source=PC\\SQLEXPRESS01";
            cn.Open(connectionString);
        }

        /// <summary>
        /// Conexao por System.Data.SqlClient
        /// </summary>
        public void SqlClientConnection()
        {
            string connectionString = "Data Source=PC\\SQLEXPRESS01;" +
                                  "Initial Catalog=FirstERP;" +
                                  "Integrated Security=SSPI;";

            string sql = "SELECT * FROM Users";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCmd = new SqlCommand(sql,sqlConnection);
            sqlCmd.CommandType = System.Data.CommandType.Text;
            //sqlConnection.ConnectionString = sql;
            sqlConnection.Open();
            SqlDataReader reader = sqlCmd.ExecuteReader();

            while(reader.Read())
            {
                Entity.User user = new Entity.User();

            }



        }
    }


}
