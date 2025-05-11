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

namespace Act2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBoxUsuario.Text;
            string password = textBoxPassword.Text;
            string host = textBoxHost.Text;
            string puerto = textBoxPuerto.Text;
            string database = textBoxDatabase.Text;
            string connectionString = $"Server={host};Port={puerto};Database={database};User Id={user};Password={password};";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Conexión exitosa a la base de datos.");
                }
                catch (MySqlException ex)
                {
                    connection.Close();
                    MessageBox.Show($"Error al conectar a la base de datos: {ex.Message}");
                }
            }   
        }

    }
}
