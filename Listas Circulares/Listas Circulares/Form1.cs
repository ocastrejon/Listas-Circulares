using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas_Circulares
{
    public partial class Form1 : Form
    {
        Ruta r = new Ruta();
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void bttnAgregarBase_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBxNombreBase.Text) || string.IsNullOrEmpty(txtBxMinutosBase.Text))
                MessageBox.Show("Faltan datos por agregar");
            else
            {
                Base b = new Base();
                b.Nombre = txtBxNombreBase.Text;
                b.Minutos = Convert.ToInt32(txtBxMinutosBase.Text);

                r.Agregar(b);

                txtBxMinutosBase.Clear();
                txtBxNombreBase.Clear();
            }
        }

        private void bttnReporte_Click(object sender, EventArgs e)
        {
            if(r.inicio == null)
                MessageBox.Show("No hay reportes existentes.");
            else
            {
                txtBxRecorrido.Clear();
                txtBxRecorrido.Text += r.Reporte().ToString();
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bttnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBxNombreBase.Text))
                MessageBox.Show("Ingrese un nombre de busqueda");
            else
            {
                Base buscado = r.Buscar(txtBxNombreBase.Text);
                if (buscado == null)
                {
                    MessageBox.Show("No existe");
                }
                else
                    txtBxRecorrido.Text = buscado.ToString();
            }
        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBxNombreBase.Text))
                MessageBox.Show("Agregar Nombre que desea eliminar");
            else
            {
                r.Eliminar(txtBxNombreBase.Text);
                txtBxNombreBase.Clear();
                MessageBox.Show("Producto eliminado");
            }
        }

        private void bttnAgregarInicio_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBxNombreBase.Text) || string.IsNullOrEmpty(txtBxMinutosBase.Text))
                MessageBox.Show("Faltan datos por agregar");
            else
            {
                Base b = new Base();
                b.Nombre = txtBxNombreBase.Text;
                b.Minutos = Convert.ToInt32(txtBxMinutosBase.Text);

                r.AgregarInicio(b);

                txtBxMinutosBase.Clear();
                txtBxNombreBase.Clear();
            }
        }

        private void bttnEliminarUltimo_Click(object sender, EventArgs e)
        {
            r.EliminarUltimo();
        }

        private void bttnEliminarPrimero_Click(object sender, EventArgs e)
        {
            r.EliminarPrimero();
        }

        private void bttnInsertarDespuesDe_Click(object sender, EventArgs e)
        {

        }
    }
}
