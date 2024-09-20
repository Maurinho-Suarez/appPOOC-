using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Biblioteca
{
    [Serializable]
    static class VariablesGlobales
    {
        static public List<Socio> ListaSociosTemp = new List<Socio>();
        static public List<Libro> ListaLibrosTemp = new List<Libro>();
        static public List<Prestamo> ListaPrestamosTemp = new List<Prestamo>();

        


    }
}
