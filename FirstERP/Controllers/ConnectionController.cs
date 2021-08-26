using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
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

        public void GetAllServers()
        {
            string myServer = Environment.MachineName;

            DataTable servers = SqlDataSourceEnumerator.Instance.GetDataSources();
            for (int i = 0; i < servers.Rows.Count; i++)
            {
                if (myServer == servers.Rows[i]["ServerName"].ToString()) ///// used to get the servers in the local machine////
                {
                    if ((servers.Rows[i]["InstanceName"] as string) != null)
                       // CmbServerName.Items.Add(servers.Rows[i]["ServerName"] + "\\" + servers.Rows[i]["InstanceName"]);
                    Console.WriteLine(servers.Rows[i]["ServerName"].ToString());
                    Console.WriteLine(servers.Rows[i]["InstanceName"].ToString());
                    else
                        //CmbServerName.Items.Add(servers.Rows[i]["ServerName"].ToString());
                }
            }




        }
    }


}
