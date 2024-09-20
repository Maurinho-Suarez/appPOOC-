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
    public partial class VentanaListaSocio : Form
    {


        string DNI = "";//se usa como parametro para borrar al socio...


        public VentanaListaSocio()
        {
            InitializeComponent();
        }


        //
       //Boton para abrir la ventana en donde se agregan los socios...
        private void buttonAgregarSocio_Click(object sender, EventArgs e)
        {
            VentanaAgregarSocio VentanaAgregarSocio = new VentanaAgregarSocio();
            VentanaAgregarSocio.Show(this);
            this.Hide();
            
        }
        //
        //____________________________
        //

        //
        //_________________________________________
                //Boton para volver a la ventana anterior..
        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
        //
        //_:_____________
        //


        //
        //________________________________________________________________
        //Boton para mostrar la lista de Socios en el DataGridView

        private void buttonVerListaSocios_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;//Se borra el actual datagrid para poder actualizarlo

            dataGridView1.DataSource = ControladorSocios.ListaSocios();//Se cargan los datos de la lista en el dataGrid-..
            
        }
        //
        //__________
        //


        //
        //_________________________________________
        //Cuando se carga la ventana, se carga la lista al DataGrid

        private void VentanaListaSocio_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = ControladorSocios.ListaSocios();
            
        }

        //
        //__________________________________
        //


        //
        //___________________________________________
        //
        //Muestra los resultados de la busqueda que se realice entre los libros...
        //
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ControladorSocios.BuscarSocio(textBoxDNI.Text, textBoxApellido.Text, textBoxNombre.Text);
           
        }
        //
        //_____________________________
        //

        //Al cliquear en una celda....
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

           //Se crea una lista y se le pasan los datos que se encuentra en el dataGrid
           List<Socio> ListaPrueba = (List<Socio>)dataGridView1.DataSource;
            //Se crea un objeto Socio y se le da los valores del Socio que pertenece a la celda en que se realizo click
           Socio SocioPrueba = ListaPrueba[e.RowIndex];
            //Se muestra un mensaje notificando la seleccion
           MessageBox.Show("El socio:\r\n\r\n\tDNI: " + SocioPrueba.DNI + "\r\n\tApellido: " + SocioPrueba.Apellido + "\r\n\tNombre: " + SocioPrueba.Nombre +"\r\n\r\nEsta Seleccionado.");
          
            //Se toma el valor del dni del socio, para luego poder usarlo en caso de que se lo quiera borrar...
            DNI = SocioPrueba.DNI;

            
        }


        //Boton para eliminar socios
        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            if (DNI != "")//El DNI tiene que ser diferente a vacio, para asegurarse que se haya elegido un socio, y no se borre cualquiera..
            {
                ControladorSocios.BorrarSocio(DNI);
                MessageBox.Show("Socio Borrado");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ControladorSocios.ListaSocios();

            }


        }//Se termina el boton para eliminar socios...





    }
}