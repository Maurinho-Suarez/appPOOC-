using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Biblioteca
{
    [Serializable]
    public class Prestamo
    {
        
        private Socio SocioDeudor;
        private Libro LibroAdeudado;


        public Prestamo()
        {
            SocioDeudor = null;
            LibroAdeudado = null;
                    }

        public void AgregarSocioDeudor(Socio _socio)
        {
            SocioDeudor = _socio;
                    }
        public void AgregarLibroAdeudado(Libro _libro)
        {
            LibroAdeudado = _libro;
        }



        //Devolver DNI del Deudor
        public string DNI_Deudor
        {
            get
            {
                return SocioDeudor.DNI;
            }
        }
        //Devolver Apellido del Deudor
        public string Apellido_Deudor
        {
            get
            {
                return SocioDeudor.Apellido;
            }
        }
        //Devolver Nombre del Deudor
        public string Nombre_Deudor
        {
            get
            {
                return SocioDeudor.Nombre;
            }
        }
        //Devolver Codigo del Libro Adeudado
        public string Codigo_Adeudado
        {
            get
            {
                return LibroAdeudado.Codigo;
            }
        }
        //Devolver Titulo del Libro Adeudado
        public string Titulo_Adeudado
        {
            get
            {
                return LibroAdeudado.Titulo;
            }
        }
        //Devolver Autor del Libro Adeudado
        public string Autor_Adeudado
        {
            get
            {
                return LibroAdeudado.Autor;
            }
        }
        //Devolver Editorial del Libro Adeudado
        public string Editorial_Adeudado
        {
            get
            {
                return LibroAdeudado.Editorial;
            }
        }








    }
}
