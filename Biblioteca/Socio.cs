using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;



namespace Biblioteca
{



    [Serializable]
    public class Socio
    {

 //Propiedades de la clase Socio..............

        private string DNIprop;
        private string NombreProp;
        private string ApellidoProp;
        private string TelefonoProp;
        private string CorreoProp;
        


 //Metodos constructores____________________
        //_---------------------------______________________________-
       
        //Metodo Sin  Parametros..
        public Socio()
        {
            DNIprop = "";
            NombreProp = "";
            ApellidoProp = "";

        }


        //Constructor Con Parametros...
        public Socio(string _nombre, string _apellido, string _DNI)
        {
            NombreProp = _nombre;
            ApellidoProp = _apellido;
            DNIprop = _DNI;

        }

        //__________-------------------------------------------------
        //____________________________________-Metodos para asignar propiedades

        //Método para Darle Nombre
        public void DarNombre(string _nombre)
        {
            NombreProp = _nombre;
        }
        //Para Darle Apellido
        public void DarApellido(string _apellido)
        {
            ApellidoProp = _apellido;
        }

        //Para Darle DNI
        public void DarDNI(string _DNI)
        {
            DNIprop = _DNI;
        }

        //Para Darle Telefono
        public void DarTelefono(string _telefono)
        {
            TelefonoProp = _telefono;
        }

        //Para Darle Correo
        public void DarCorreo(string _correo)
        {
            CorreoProp = _correo;
        }

        

        //____________________________________________________________________--------------

 //Metodos que devuelven propiedades...

        //Método que devuelve el DNI...
        public string DNI
        {
            get
            {
                return DNIprop;
            }
        }

        //Método que devuelve el Apellido...
        public string Apellido
        {
            get
            {
                return ApellidoProp;
            }
        }

        
        //Método que devuelve el Nombre...
        public string Nombre
        {
            get
            {
                return NombreProp;
            }
        }

        
        

        //Para decir telefono
        public string Telefono
        {
            get
            {
                return TelefonoProp;
            }
        }

        ////Para decir correo
        public string Correo
        {
            get
            {
                return CorreoProp;
            }
        }

       



    }//Termina la clase............................................
}
