using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class VentanaGestionarPrestamos : Form
    {
        string DNIprestamista;

        public VentanaGestionarPrestamos()
        {
            InitializeComponent();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonVerListaLibros_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ControladorPrestamo.ListaPrestamo();

        }

        private void buttonRegistrarPrestamo_Click(object sender, EventArgs e)
        {
            VentanaPrestarLibro VentanaPrestar = new VentanaPrestarLibro();
            VentanaPrestar.Show(this);
            this.Hide();

        }

        private void VentanaGestionarPrestamos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ControladorPrestamo.ListaPrestamo();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            List<Prestamo> ListaPrueba = (List<Prestamo>)dataGridView1.DataSource;
            //Se crea un objeto Socio y se le da los valores del Socio que pertenece a la celda en que se realizo click
            Prestamo PrestamoPrueba = ListaPrueba[e.RowIndex];
            //Se muestra un mensaje notificando la seleccion
            MessageBox.Show("Prestamo Seleccionado");

            //Se toma el valor del dni del socio, para luego poder usarlo en caso de que se lo quiera borrar...
            DNIprestamista = PrestamoPrueba.DNI_Deudor;

        }

        private void buttonDevolucion_Click(object sender, EventArgs e)
        {
            if (DNIprestamista != "")//El DNI tiene que ser diferente a vacio, para asegurarse que se haya elegido un socio, y no se borre cualquiera..
            {
                string codigoParaReconocerLibro;

               codigoParaReconocerLibro = ControladorPrestamo.BorrarPrestamo(DNIprestamista);
               ControladorLibros.HacerDisponible(codigoParaReconocerLibro);
                
               
                MessageBox.Show("Devolución registrada");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ControladorPrestamo.ListaPrestamo();

            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ControladorPrestamo.BuscarPrestamo(textBoxTitulo.Text, textBoxAutor.Text, textBoxEditorial.Text, textBoxDNI.Text, textBoxApellido.Text, textBoxNombre.Text);
        }
    }
}
