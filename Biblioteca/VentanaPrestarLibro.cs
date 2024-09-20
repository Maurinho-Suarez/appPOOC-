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
    public partial class VentanaPrestarLibro : Form
    {

        string DNI = "";
        string CodigoLibro = "";
        bool libroDisponible = false;


        public VentanaPrestarLibro()
        {
            InitializeComponent();
        }

        private void VentanaPrestarLibro_Load(object sender, EventArgs e)
        {
            dataGridSocio.DataSource = ControladorSocios.ListaSocios();
            dataGridLibro.DataSource = ControladorLibros.ListaLibros();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridSocio.DataSource = ControladorSocios.BuscarSocio(textBoxDNI.Text, textBoxApellido.Text, textBoxNombre.Text);
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            dataGridLibro.DataSource = ControladorLibros.BuscarLibro(textBoxTitulo.Text, textBoxAutor.Text, textBoxEditorial.Text);

        }

        private void dataGridSocio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            List<Socio> ListaPrueba = (List<Socio>)dataGridSocio.DataSource;
            
            Socio SocioPrueba = ListaPrueba[e.RowIndex];
            //Se muestra un mensaje notificando la seleccion
            MessageBox.Show("El socio:\r\n\r\n\tDNI: " + SocioPrueba.DNI + "\r\n\tApellido: " + SocioPrueba.Apellido + "\r\n\tNombre: " + SocioPrueba.Nombre + "\r\n\r\nEsta Seleccionado.");

            //Se toma el valor del dni del socio, para luego poder usarlo en caso de que se lo quiera borrar...
            DNI = SocioPrueba.DNI;
        }

        private void dataGridLibro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Libro> ListaPrueba = (List<Libro>)dataGridLibro.DataSource;
            Libro LibroPrueba = ListaPrueba[e.RowIndex];
            MessageBox.Show("El Libro:\r\n\r\n\t" + LibroPrueba.Codigo + "\r\n\tTitulo: " + LibroPrueba.Titulo + "\r\n\tAutor: " + LibroPrueba.Autor + "\r\n\tEditorial: " + LibroPrueba.Editorial + "\r\n\r\nEsta seleccionado");
            CodigoLibro = LibroPrueba.Codigo;
            libroDisponible = LibroPrueba.Disponible;

        }

        private void buttonPrestar_Click(object sender, EventArgs e)
        {
            if ((DNI != "") && (CodigoLibro != "") && (libroDisponible != false))
            {
                Prestamo NuevoPrestamo = new Prestamo();
                
                Socio SocioPrestamista = ControladorSocios.DarSocio(DNI);
                Libro LibroPrestamista = ControladorLibros.DarLibro(CodigoLibro);


                NuevoPrestamo.AgregarSocioDeudor(SocioPrestamista);
                NuevoPrestamo.AgregarLibroAdeudado(LibroPrestamista);
                ControladorPrestamo.AgregarPrestamoToList(NuevoPrestamo);
                ControladorLibros.GuardarListaLibro();
                dataGridLibro.DataSource = null;
                dataGridLibro.DataSource = ControladorLibros.ListaLibros();


                MessageBox.Show("Prestamo Realizado");


            }


            else { MessageBox.Show("Falta Seleccionar o El Libro No esta Disponible"); }
        
        
        }
    }
}
