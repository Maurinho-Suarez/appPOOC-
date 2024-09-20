using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Biblioteca
{
    public partial class VentanaAgregarSocio : Form
    {
        public VentanaAgregarSocio()
        {
            InitializeComponent();
        }

        private void buttonAgregarSocio_Click(object sender, EventArgs e)
        {
            //Se instancia un objeto socio;

            Socio SocioAgregado = new Socio();

            //se agregan las propiedades de los textbox en el objeto;

            SocioAgregado.DarNombre(textBoxNombre.Text);
            SocioAgregado.DarApellido(textBoxApellido.Text);
            SocioAgregado.DarDNI(textBoxDNI.Text);
            SocioAgregado.DarTelefono(textBoxTelefono.Text);
            SocioAgregado.DarCorreo(textBoxEmail.Text);
            
            
            //Se pasa el objeto a la lista...
            ControladorSocios.AgregarSocioToList(SocioAgregado);


            // Se muestra un mensaje
            MessageBox.Show("El socio ha Sido Agregado");

            //Se borran los text box
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            textBoxDNI.Text = "";
            textBoxTelefono.Text = "";
            textBoxEmail.Text = "";
            

           
            //Muestra la ventana principal nuevamente
            this.Owner.Show();
            //Cierra esta ventana
            this.Close();




        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            
            //Muestra la ventana principal nuevamente
            this.Owner.Show();
            //Cierra esta ventana
            this.Close();
        }

        private void VentanaAgregarSocio_Load(object sender, EventArgs e)
        {

        }
    }
}
