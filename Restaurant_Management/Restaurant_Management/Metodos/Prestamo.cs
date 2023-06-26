using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management
{
    public class Prestamo
    {
        public int CodigoPrestamo { get; set; }
        public int CodigoLibro { get; set; }
        public int CodigoEstudiante { get; set; }
        public string FechaPrestamo { get; set; }
        public string FechaDevolucion { get; set; }

        public Prestamo(int codigoPrestamo, int codigoLibro, int codigoEstudiante, string fechaPrestamo, string fechaDevolucion)
        {
            CodigoPrestamo = codigoPrestamo;
            CodigoLibro = codigoLibro;
            CodigoEstudiante = codigoEstudiante;
            FechaPrestamo = fechaPrestamo;
            FechaDevolucion = fechaDevolucion;
        }
    }

}
