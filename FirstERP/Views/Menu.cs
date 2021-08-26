﻿using System;
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
            try
            {
                connection.DBConnect();
                connection.GetAllServers();
                fLogin.Show();
            }
            catch (Exception ex)
            {

                Console.WriteLine("Exceção lançada em" + this.GetType().Name + ": " + ex);
            }
            
        }
    }
}
