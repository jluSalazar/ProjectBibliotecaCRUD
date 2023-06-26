using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.Metodos
{
    public class Estudiante
    {

        public int CodigoEstudiante { get; set; }
        public string NombreEstudiante { get; set; }
        public string ApellidoEstudiante { get; set; }
        public int CelularEstudiante { get; set; }
        public string Sector { get; set; }
        public string Facultad { get; set; }
        public string CorreoEstudiante { get; set; }

        public Estudiante(int codigoEstudiante, string nombreEstudiante, string apellidoEstudiante, int celularEstudiante, string sector, string facultad, string correoEstudiante)
        {
            CodigoEstudiante = codigoEstudiante;
            NombreEstudiante = nombreEstudiante;
            ApellidoEstudiante = apellidoEstudiante;
            CelularEstudiante = celularEstudiante;
            Sector = sector;
            Facultad = facultad;
            CorreoEstudiante = correoEstudiante;
        }
    }
}
