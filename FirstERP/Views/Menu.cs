using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstERP
{
    public partial class Menu : Form
    {
        Controllers.ConnectionController connection = new Controllers.ConnectionController();
        Views.Login fLogin = new Views.Login();
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet1.Item'. Você pode movê-la ou removê-la conforme necessário.
            this.itemTableAdapter.Fill(this.dataSet1.Item);
            // TODO: esta linha de código carrega dados na tabela 'dataSet1.Users'. Você pode movê-la ou removê-la conforme necessário.
            this.usersTableAdapter.Fill(this.dataSet1.Users);
            try
            {
                connection.DBConnect();
                //connection.GetAllServers();
                fLogin.Show();
            }
            catch (Exception ex)
            {

                Console.WriteLine("Exceção lançada em" + this.GetType().Name + ": " + ex);
            }
            
        }
    }
}
