using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AirBnbProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*
             * THis is my change
             */
           

            string server = "mydb8.surf-town.net";
            string user = "hdb64894_handin3";
            string pw = "teamhandin3";
            string connStr = $"server={server};user={user};database=hb64894_myNHLdatabase;password={pw};";
            MessageBox.Show(connStr.ToString());
            MySqlConnection conn = new MySqlConnection(connStr);
            Boolean connected = false;
            try
            {
                conn.Open();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
            if (connected)
            {
                MessageBox.Show("Correct login");

            }
            else
            {
                MessageBox.Show("Incorrect login");

            }
        }
    }
}
