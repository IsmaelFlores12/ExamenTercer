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
    public partial class Inicio : Form
    {
        Acciones Acciones = new Acciones();
        public Inicio()
        {
            InitializeComponent();
        }

        private void BTNmostrar_Click(object sender, EventArgs e)
        {
            DGdatos.DataSource=null;
            DGdatos.DataSource = Acciones.mostrar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Acciones.eliminarP(Convert.ToInt32(tbxEliminar.Text))) 
                MessageBox.Show("Eliminada con exito");
            else
                MessageBox.Show("Fallo");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Acciones.insertar(tbxColor.Text, Convert.ToInt32(tbxID.Text), tbxNombre.Text, Convert.ToDateTime(tbxFecha.Text), Convert.ToBoolean(tbxActivo.Text)))
                MessageBox.Show("Agregado con exito");
            else
                MessageBox.Show("Fallo");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (Acciones.actualizar(tbxColor.Text, Convert.ToInt32(tbxID.Text), tbxNombre.Text, Convert.ToDateTime(tbxFecha.Text), Convert.ToBoolean(tbxActivo.Text)))
                MessageBox.Show("Actualizado con exito");
            else
                MessageBox.Show("Fallo");
        }
    }
}
