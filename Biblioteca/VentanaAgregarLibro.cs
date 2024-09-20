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
    public partial class VentanaAgregarLibro : Form
    {
        public VentanaAgregarLibro()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();

        }

        private void buttonAgregarLibro_Click(object sender, EventArgs e)
        {
            //Se crea un objeto de la clase libro
            Libro LibroAgregado = new Libro();

            //Se dan las propiedades al objetos...
            LibroAgregado.DarCodigo(textBoxCodigo.Text);
            LibroAgregado.DarTitulo(textBoxTitulo.Text);
            LibroAgregado.DarAutor(textBoxAutor.Text);
            LibroAgregado.DarEditorial(textBoxEditorial.Text);
            

            //se agrega el objeto a la lista de libros...
            ControladorLibros.AgregarLibroToList(LibroAgregado);




        


            // Se vacian los textbox y se muestra un mensaje que el agregado del libro se realizo correctamente
            MessageBox.Show("El Libro ha sido agregado");
            textBoxAutor.Text = "";
            textBoxEditorial.Text = "";
            textBoxTitulo.Text = "";
            


            //Se cierra la ventana
            this.Owner.Show();

            this.Close();
        }

        private void VentanaAgregarLibro_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
