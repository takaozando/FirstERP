using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstERP.Views
{
    public partial class Login : Form
    {
        ADODB.Connection ado = new ADODB.Connection();
        ADODB.Recordset recordset = new ADODB.Recordset();
        private object recs;

        public Login()
        {
            InitializeComponent();
        }

        private void b_Login_Click(object sender, EventArgs e)
        {

            string sql = "SELECT NAME FROM USERS";
            SqlConnection 


            l_Teste.Text = recordset.Fields["name"].Value.ToString();
            int test = recordset.RecordCount;
            string tester = recordset.Fields["name"].Value.ToString();

        }
    }
}
