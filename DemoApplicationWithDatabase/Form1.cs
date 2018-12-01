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

namespace DemoApplicationWithDatabase
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection sql_connection;
            connetionString = @"Data Source=WIN-50GP30FGO75;Initial Catalog=Demodb;User ID=sa;Password=demol23";
            sql_connection = new SqlConnection(connetionString);
            sql_connection.Open();
            MessageBox.Show("Connection Open  !");
            sql_connection.Close();
        }
    }
}
