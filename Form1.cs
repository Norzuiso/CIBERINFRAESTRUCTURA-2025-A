using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Evento que se dispara cuando se hace clic en el botón "Validar"
        private void btnValidar_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;
            string password2 = txtConfirmar.Text;
            // Regex para al menos 1 mayúscula, 1 minúscula, 1 número, 1 símbolo
            Regex regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]$");

            // Validamos la estructura con Regex
            if (!regex.IsMatch(password))
            {
                MessageBox.Show("La contraseña no cumple con los requisitos.");
                return;
            }

            // Comparamos las dos contraseñas
            if (password != password2)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            // Si pasa todo, mostramos éxito
            MessageBox.Show("La contraseña ha sido validada.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
