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
    public partial class Form1Ingreso : Form
    {
        public Form1Ingreso()
        {
            InitializeComponent();
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                VentanaPrincipal Principal = new VentanaPrincipal();
                this.Hide();
                Principal.Show(this);
            }
            else
            { MessageBox.Show("Datos Incorrectos");
            }
           

            

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(".\\Datos\\APBiblioteca.chm");
        }    

        

    }
}
