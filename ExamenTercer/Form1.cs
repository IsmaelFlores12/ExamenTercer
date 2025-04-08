using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenTercer
{
    public partial class Form1 : Form
    {
        Usuarios usuarios = new Usuarios();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            string User = txbUsuario.Text;
            string password = txbContra.Text;

            var lista = usuarios.obtenerUsuario();
            var validar = lista.FirstOrDefault(u => u.NomUsuario == User && u.ContraUsuario == password);
            if (validar != null)
            {
                this.Hide();
                Inicio inicio = new Inicio();
                inicio.Show();
            }
            else
            {
                MessageBox.Show("Fallaste");
            }
        }
    }
}
