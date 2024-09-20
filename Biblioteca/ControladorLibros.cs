using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization.Formatters.Binary;
using System.IO;



namespace Biblioteca
{
    [Serializable]

    public class ControladorLibros
    {



        private static List<Libro> listaLibros; //Lista estatica, en donde se cargará las lista de libros...




        //
        //Método que devuelve listaLibro...
        //
        public static List<Libro> ListaLibros()
        {

            if (listaLibros == null) //Si la lista esta en null, es por que no se ah cargado aún...
            {


                //Se comprueba directorio y se crea uno si no existe
                if (!Directory.Exists(".\\Datos"))
                {
                    Directory.CreateDirectory(".\\Datos");
                }

                //Se carga la lista de socios...
                var serializador = new BinaryFormatter();
                var streamListaLibro = new FileStream(".\\Datos\\ListaLibros.dat", FileMode.OpenOrCreate);
                listaLibros = (List<Libro>)serializador.Deserialize(streamListaLibro);
                streamListaLibro.Close();


            }//Fin if

            return listaLibros;

        }//Termina




        //
        //
        //____________
        //Metodo para agregar un libro a la lista...........
        //___________-
        public static void AgregarLibroToList(Libro _libro)
        {


            ListaLibros().Add(_libro);//Se agrega el libro




            //Crea directorio
            if (!Directory.Exists(".\\Datos"))
            {
                Directory.CreateDirectory(".\\Datos");
            }

            //Se Guarda la lista en un Archivo
            var serializadorguardar = new BinaryFormatter();
            var stream = new FileStream(".\\Datos\\ListaLibros.dat", FileMode.OpenOrCreate);
            serializadorguardar.Serialize(stream, listaLibros);
            stream.Close();

        }

        ////
        //____________



        //
        //
        //__________________________
        //Metodo para solo guardar la lista en el archivo...
        //
        public static void GuardarListaLibro()
        {


            //Crea directorio
            if (!Directory.Exists(".\\Datos"))
            {
                Directory.CreateDirectory(".\\Datos");
            }

            //Se Guarda la lista en un Archivo
            var serializadorguardar = new BinaryFormatter();
            var stream = new FileStream(".\\Datos\\ListaLibros.dat", FileMode.OpenOrCreate);
            serializadorguardar.Serialize(stream, listaLibros);
            stream.Close();

        }






        //
        //_____________________
        //Metodo para borrar Libro
        //

        public static void BorrarLibro(string _codigo)
        {

            int IndiceParaBorrar;

            //Se toma el indice en la lista del libro que coincide con el codigo...
            IndiceParaBorrar = listaLibros.FindIndex((x => x.Codigo.Contains(_codigo)));
            //Se remueve el libro que contiene el indice que se busco...
            listaLibros.RemoveAt(IndiceParaBorrar);


            //Luego se guarda la lista con el socio borrado...
            //Crea directorio
            if (!Directory.Exists(".\\Datos"))
            {
                Directory.CreateDirectory(".\\Datos");
            }

            //Se Guarda la lista en un Archivo
            var serializadorguardar = new BinaryFormatter();
            var stream = new FileStream(".\\Datos\\ListaLibros.dat", FileMode.OpenOrCreate);
            serializadorguardar.Serialize(stream, listaLibros);
            stream.Close();


        }


        //____________________-
        //
        //


        //
        //_____________________
        //Metodo que da un libro
        //
        public static Libro DarLibro(string _codigo)//Se devuelve un objeto libro...
        {
            //Se busca en la lista el indice del libro que coincida con el codigo...
            //
            int IndiceParaBuscar;
            IndiceParaBuscar = listaLibros.FindIndex((x => x.Codigo.Contains(_codigo)));
            //Se obtiene el objeto de la lista...
            Libro LibroParaPrestar = listaLibros[IndiceParaBuscar];
            //y se le da la propiedad false al libro que se encuentra en la lista
            listaLibros[IndiceParaBuscar].HacerDisponibleFalse();


            return LibroParaPrestar;//


        }//Fin 



        //
        //
        //____________________-
        //
        //Metodo que usca un determinado libro en la listo para luego darle la disponibilidad true

        public static void HacerDisponible(string _codigo)
        {
            int IndiceParaBuscar;
            IndiceParaBuscar = listaLibros.FindIndex((x => x.Codigo.Contains(_codigo)));

            listaLibros[IndiceParaBuscar].HacerDisponibleTrue();
        }


        //
        //_________________________-
        //Metodo para las busquedas....
        //
        public static List<Libro> BuscarLibro(string _titulo, string _autor, string _editorial)
        {
            //primero se le pasan los objetos de la lista libros que cumplen con el parametro del titulo
            List<Libro> Resultado = ControladorLibros.ListaLibros().Where((x => x.Titulo.Contains(_titulo))).ToList();
            //luego de la lista resultado, se dejan los objetos que cumplan con el parametro Autor..
            Resultado = Resultado.Where((x => x.Autor.Contains(_autor))).ToList();
            //y por ultimo se filtra por editorial
            Resultado = Resultado.Where((x => x.Editorial.Contains(_editorial))).ToList();


            return Resultado;//Se devuelve el resultado de la busqueda con todos los filtros aplicados...

        }




        //_________________________
        //
        //



    }//Fin de la clase
}
