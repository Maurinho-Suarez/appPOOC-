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
    public class ControladorPrestamo
    {



        private static List<Prestamo> listaPrestamo;  //Lista estatica, en donde se cargará la lista de Prestamos...



        //
        //Método que devuelve listaPrestamo...
        //
        public static List<Prestamo> ListaPrestamo()
        {

            if (listaPrestamo == null)
            {


                //Se comprueba directorio y se crea uno si no existe
                if (!Directory.Exists(".\\Datos"))
                {
                    Directory.CreateDirectory(".\\Datos");
                }

                //Se carga la lista de socios...
                var serializador = new BinaryFormatter();
                var streamListaPrestamo = new FileStream(".\\Datos\\ListaPrestamos.dat", FileMode.OpenOrCreate);
                listaPrestamo = (List<Prestamo>)serializador.Deserialize(streamListaPrestamo);
                streamListaPrestamo.Close();


            }//fin if

            return listaPrestamo;
        }//Fin
        //



        //____________
        //
        //
        //____________
        //Metodo para agregar un prestamo a la lista...........
        //___________-

        public static void AgregarPrestamoToList(Prestamo _prestamo)
        {

            ListaPrestamo().Add(_prestamo);




            //Crea directorio
            if (!Directory.Exists(".\\Datos"))
            {
                Directory.CreateDirectory(".\\Datos");
            }

            //Se Guarda la lista en un Archivo
            var serializadorguardar = new BinaryFormatter();
            var stream = new FileStream(".\\Datos\\ListaPrestamos.dat", FileMode.OpenOrCreate);
            serializadorguardar.Serialize(stream, listaPrestamo);
            stream.Close();

        }





        //
        //
        //_____________________
        //Metodo para borrar Prestamo
        //
        public static string BorrarPrestamo(string _dniSocioDeudor)
        {
        

            int IndiceParaBorrar;
            string codigoLibroDevolver = "";

            //Se busca el indice del prestamo a borrar, 
            IndiceParaBorrar = listaPrestamo.FindIndex((x => x.DNI_Deudor.Contains(_dniSocioDeudor)));
            codigoLibroDevolver = listaPrestamo[IndiceParaBorrar].Codigo_Adeudado;//Se codigo del libro para luego poder usarlo con otro metodo
            listaPrestamo.RemoveAt(IndiceParaBorrar);//Se borra el prestamo

            
            //Luego se guarda la lista con el socio borrado...
            //Crea directorio
            if (!Directory.Exists(".\\Datos"))
            {
                Directory.CreateDirectory(".\\Datos");
            }

            //Se Guarda la lista en un Archivo
            var serializadorguardar = new BinaryFormatter();
            var stream = new FileStream(".\\Datos\\ListaPrestamos.dat", FileMode.OpenOrCreate);
            serializadorguardar.Serialize(stream, listaPrestamo);
            stream.Close();


            return codigoLibroDevolver;//Se devuelve el codigo del libro



        } 


        //____________________-



        //
        //_________________________-
        //Metodo para las busquedas....
        //

        
        public static List<Prestamo> BuscarPrestamo(string _titulo, string _autor, string _editorial, string _dni, string _apellido, string _nombre)
        {
            //Parametros con datos del que se llevo el libro
            List<Prestamo> Resultado = ControladorPrestamo.ListaPrestamo().Where((x => x.DNI_Deudor.Contains(_dni))).ToList();
            Resultado = Resultado.Where((x => x.Apellido_Deudor.Contains(_apellido))).ToList();
            Resultado = Resultado.Where((x => x.Nombre_Deudor.Contains(_nombre))).ToList();
         
            // se le pasan los objetos de la lista libros que cumplen con el parametro del titulo
             Resultado = Resultado.Where((x => x.Titulo_Adeudado.Contains(_titulo))).ToList();
            //luego de la lista resultado, se dejan los objetos que cumplan con el parametro Autor..
            Resultado = Resultado.Where((x => x.Autor_Adeudado.Contains(_autor))).ToList();
            //y por ultimo se filtra por editorial
            Resultado = Resultado.Where((x => x.Editorial_Adeudado.Contains(_editorial))).ToList();


            return Resultado;//Devuelve reesultado de la busqueda con los filtros aplicados

        }

        


        //_________________________




    }
}