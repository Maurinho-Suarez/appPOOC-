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
    public partial class VentanaListaLibro : Form
    {
        string CodigoBorrar = "";//Se utiliza como parametro para borrar el libro
            

        public VentanaListaLibro()
        {
            InitializeComponent();
         }


        //Boton, para volver hacia la ventana anterior...
        private void button1_Click(object sender, EventArgs e)
        {
         
            this.Owner.Show();//Muestra la ventana anterior
            this.Close();//Cierra esta ventana
          
        }






        //
        //__________________________________________________________________________
        //AL Cargar La Ventana...


        //
        //_________________________-
        //
        private void VentanaListaLibro_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = ControladorLibros.ListaLibros();

        }

        //
        //_________________________________________________________________________
        //



        //____________________________________________________________________-
        //
        //
        //Este boton muestra la lista de todos los libros en el list view, al igual que cuando se carga la ventana...
        private void buttonVerListaLibros_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ControladorLibros.ListaLibros();

        }
        //
        //_________________
        //
        //



        
        //______________
        //EL Boton que abre la ventana de donde se crean los nuevos socios...


        private void buttonAgregarLibro_Click(object sender, EventArgs e)
        {
            //Se crea la ventana para agregar socios
            VentanaAgregarLibro VentanaAgregarLibro = new VentanaAgregarLibro();

            //Se muestra la ventana para agregar socios
            VentanaAgregarLibro.Show(this);

            //Se oculta la ventana actual
            this.Hide();

        }


        //___________________
        //



        

        //
        //_________________________________________________________________________
        //Boton de Busqueda
        //_______
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
         //Por parametros se pasan los textos de los textbox al metodo que devuelve la lista
            //con los resultados de la busqueda
            //
         dataGridView1.DataSource = ControladorLibros.BuscarLibro(textBoxTitulo.Text, textBoxAutor.Text, textBoxEditorial.Text);

        }
        //
        //___________________
        //

       
        //
            //__________________________
        //Al Cliquear una celda...
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Libro> ListaPrueba = (List<Libro>)dataGridView1.DataSource;
            Libro LibroPrueba = ListaPrueba[e.RowIndex];
            MessageBox.Show("El Libro:\r\n\r\n\t" + LibroPrueba.Codigo + "\r\n\tTitulo: " + LibroPrueba.Titulo + "\r\n\tAutor: " +LibroPrueba.Autor+ "\r\n\tEditorial: " + LibroPrueba.Editorial + "\r\n\r\nEsta seleccionado");
            CodigoBorrar = LibroPrueba.Codigo;
        }

        //
        //________________
        //

        //
        //_____________________________________________-
        //
        //
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (CodigoBorrar != "")
            {
                ControladorLibros.BorrarLibro(CodigoBorrar);
                MessageBox.Show("Libro Borrado");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ControladorLibros.ListaLibros();

            }
        }
        //
        //____________________________________________________________________________________________-
        //











    }//VentanaListaLibro
}
