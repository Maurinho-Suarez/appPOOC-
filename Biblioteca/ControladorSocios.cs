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
    public class ControladorSocios
    
    {


        private static List<Socio> listaSocios;// //Lista estatica, en donde se cargará las lista de socios...


        //
        //Para
        //Devolver la lista de socios
        //
        public static List<Socio> ListaSocios() {
            
                if (listaSocios == null) {
                    
                    
                    //Se comprueba directorio y se crea uno si no existe
                    if (!Directory.Exists(".\\Datos"))
                    {
                        Directory.CreateDirectory(".\\Datos");
                    }

                    //Se carga la lista de socios...
                    var serializador = new BinaryFormatter();
                    var streamListaSocio = new FileStream(".\\Datos\\ListaSocios.dat", FileMode.OpenOrCreate);
                    listaSocios = (List<Socio>)serializador.Deserialize(streamListaSocio);
                    streamListaSocio.Close();

                    
                }

                return listaSocios;     //Retorna socios       
        }




        //
        //____________
        //
        //____________
        //Metodo para agregar un socio a la lista...........

        public static void AgregarSocioToList(Socio _socio) { 
        
        ListaSocios().Add(_socio);


        //Crea directorio
        if (!Directory.Exists(".\\Datos"))
        {
            Directory.CreateDirectory(".\\Datos");
        }

        //Se Guarda la lista en un Archivo
        var serializadorguardar = new BinaryFormatter();
        var stream = new FileStream(".\\Datos\\ListaSocios.dat", FileMode.OpenOrCreate);
        serializadorguardar.Serialize(stream, listaSocios);
        stream.Close();
        
        }








        //_____________________
        //Metodo para borrar socio
        public static void BorrarSocio(string _DNI)
        {

            int IndiceParaBorrar;
            
            IndiceParaBorrar =  listaSocios.FindIndex((x => x.DNI.Contains(_DNI)));
            
            listaSocios.RemoveAt(IndiceParaBorrar);

           
            //Luego se guarda la lista con el socio borrado...
            //Crea directorio
            if (!Directory.Exists(".\\Datos"))
            {
                Directory.CreateDirectory(".\\Datos");
            }

            //Se Guarda la lista en un Archivo
            var serializadorguardar = new BinaryFormatter();
            var stream = new FileStream(".\\Datos\\ListaSocios.dat", FileMode.OpenOrCreate);
            serializadorguardar.Serialize(stream, listaSocios);
            stream.Close();


        }


        //____________________-
        //



        //_____________________
        //Metodo para retornar socio...

        public static Socio DarSocio(string _DNI)
        {

            int IndiceParaBuscar;

            IndiceParaBuscar = listaSocios.FindIndex((x => x.DNI.Contains(_DNI)));

            Socio SocioParaDevolver = listaSocios[IndiceParaBuscar];

            return SocioParaDevolver;


        }


        //____________________-





        //
        //_____________________________________________________________
        //Metodo Buscar socios...
        public static List<Socio> BuscarSocio(string _dni, string _apellido, string _nombre)
        {
            List<Socio> Resultado = ControladorSocios.ListaSocios().Where((x => x.DNI.Contains(_dni))).ToList();
            Resultado = Resultado.Where((x => x.Apellido.Contains(_apellido))).ToList();
            Resultado = Resultado.Where((x => x.Nombre.Contains(_nombre))).ToList();

            return Resultado;
                    }



        //
        //___________________________________________
        //


    }
}
