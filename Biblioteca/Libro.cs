using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;



namespace Biblioteca
{
    [Serializable]
    public class Libro
    {

        //Propiedades de la clase Libro

        private string CodigoProp;
        private string TituloProp;
        private string AutorProp;
        private string EditorialProp;
        
        private bool DisponibleProp;//Indica si esta disponible o no el libro

             



        //Metodos constructores____________________
        //_---------------------------______________________________-
        //Metodo Sin  Parametros..
        public Libro()
        {
            TituloProp = "";
            AutorProp = "";
            EditorialProp = "";
            DisponibleProp = true;
        }


        //Constructor Con Parametros...
        public Libro(string _codigo,string _titulo, string _autor, string _editorial)
        {
            CodigoProp = _codigo;
            TituloProp = _titulo;
            AutorProp = _autor;
            EditorialProp = _editorial;
            DisponibleProp = true;


        }

        //__________-------------------------------------------------
        //____________________________________-Metodos para asignar propiedades


        //Método para Darle Codigo
        public void DarCodigo(string _codigo)
        {
            CodigoProp = _codigo;
        }
        //Método para Darle Titulo
        public void DarTitulo(string _titulo)
        {
            TituloProp = _titulo;
        }
        //Para Darle Autor
        public void DarAutor(string _autor)
        {
            AutorProp = _autor;
        }

        //Para Darle Editorial
        public void DarEditorial(string _editorial)
        {
            EditorialProp = _editorial;
        }
        //Hacer Disponible
        public void HacerDisponible()
        {
            DisponibleProp = true;
        }
        //Hacer Disponible false
        public void HacerDisponibleFalse()
        {
            DisponibleProp = false;
        }
        //Hacer Disponible true
        public void HacerDisponibleTrue()
        {
            DisponibleProp = true;
        }
        

        //____________________________________________________________________--------------

        //Metodos que devuelven propiedades...


        //Método que devuelve el Titulo...
        public string Codigo
        {
            get
            {
                return CodigoProp;
            }
        }


        //Método que devuelve el Titulo...
        public string Titulo
        {
            get
            {
                return TituloProp;
            }
        }

        //Método que devuelve el Autor...
        public string Autor
        {
            get
            {
                return AutorProp;
            }
        }
        //Método que devuelve el Editorial...
        public string Editorial
        {
            get
            {
                return EditorialProp;
            }
        }
        //Método que devuelve Disponibilidad...
        public bool Disponible
        {
            
            get
            {
                return DisponibleProp;            
                
            }

        }
       




    }//Termina la clase............................................
}
