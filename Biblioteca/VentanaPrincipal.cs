using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer;

namespace Biblioteca
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
            this.ControlBox = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();




            

        }

        private void buttonVerLibros_Click(object sender, EventArgs e)
        {
            VentanaListaLibro VentanaLibros = new VentanaListaLibro();
            VentanaLibros.Show(this);
            this.Hide();




        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void buttonAgregarSocio_Click(object sender, EventArgs e)
        {
            

        }

        private void buttonVerSocios_Click(object sender, EventArgs e)
        {
            VentanaListaSocio VentanaSocios = new VentanaListaSocio();
            VentanaSocios.Show(this);
            this.Hide();

        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void buttonGestionarPrestamos_Click(object sender, EventArgs e)
        {
            VentanaGestionarPrestamos VentanaPrestamos = new VentanaGestionarPrestamos();
            VentanaPrestamos.Show(this);
            this.Hide();

        }
    }
}
