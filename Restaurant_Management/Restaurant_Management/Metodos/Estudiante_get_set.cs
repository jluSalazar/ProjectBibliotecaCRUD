using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.Metodos
{
    internal class Estudiante_get_set
    {


        private int codigoEstudiante;
        private string nombreEstudiante;
        private string apellidoEstudiante;
        private int celularEstudiante;
        private string sector;
        private string facultad;
        private string correoEstudiante;

        public Estudiante_get_set()
        {
            
        }

        // Constructor para obtener estudiantes de SQLite
        public Estudiante_get_set(int codigoEstudiante, string nombreEstudiante, string apellidoEstudiante, int celularEstudiante, string sector, string facultad, string correoEstudiante)
        {
            this.codigoEstudiante = codigoEstudiante;
            this.nombreEstudiante = nombreEstudiante;
            this.apellidoEstudiante = apellidoEstudiante;
            this.celularEstudiante = celularEstudiante;
            this.sector = sector;
            this.facultad = facultad;
            this.correoEstudiante = correoEstudiante;
        }

        // Constructor para insertar estudiantes en SQLite
        public Estudiante_get_set(string nombreEstudiante, string apellidoEstudiante, int celularEstudiante, string sector, string facultad, string correoEstudiante)
        {
            
            this.nombreEstudiante = nombreEstudiante;
            this.apellidoEstudiante = apellidoEstudiante;
            this.celularEstudiante = celularEstudiante;
            this.sector = sector;
            this.facultad = facultad;
            this.correoEstudiante = correoEstudiante;
        }

        public int GetCodigoEstudiante()
        {
            return this.codigoEstudiante;
        }

        public string GetNombreEstudiante()
        {
            return this.nombreEstudiante;
        }

        public string GetApellidoEstudiante()
        {
            return this.apellidoEstudiante;
        }

        public int GetCelularEstudiante()
        {
            return this.celularEstudiante;
        }

        public string GetSector()
        {
            return this.sector;
        }

        public string GetFacultad()
        {
            return this.facultad;
        }

        public string GetCorreoEstudiante()
        {
            return this.correoEstudiante;
        }

        public override string ToString()
        {
            return "Código: " + this.codigoEstudiante + ", Nombre: " + this.nombreEstudiante + ", Apellido: " + this.apellidoEstudiante + ", Celular: " + this.celularEstudiante + ", Sector: " + this.sector + ", Facultad: " + this.facultad + ", Correo: " + this.correoEstudiante;
        }
    }

}

