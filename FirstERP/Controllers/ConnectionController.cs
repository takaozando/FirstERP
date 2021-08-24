using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstERP.Controllers
{
    class ConnectionController
    {
        ADODB.Connection cn = new ADODB.Connection();

        public void DBConnect()
        {
            string connectionString = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=FirstERP;Data Source=PC\\SQLEXPRESS01";
            cn.Open(connectionString);
        }
    }
}
