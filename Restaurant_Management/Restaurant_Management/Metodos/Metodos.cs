using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.Metodos
{
    internal class Metodos
    {
        private Datos datos;
        private Estudiante_get_set Estudiante;
        private List<Estudiante_get_set> EstudianteList;
        private EstudianteQueries queries;

        public Metodos()
        {
            queries = new EstudianteQueries();
            EstudianteList= queries.GetEstudiantes();

        }
        public DataRow Busquedabinaria(int id)
        {
            datos = new Datos();
            DataTable dtEstudiantes = datos.ObtenerEstudiantesOrdenadosPorID();

            // Aplicar búsqueda binaria para encontrar el estudiante por ID
            int inicio = 0;
            int fin = dtEstudiantes.Rows.Count - 1;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;
                DataRow estudiante = dtEstudiantes.Rows[medio];

                int estudianteID = Convert.ToInt32(estudiante["codigo_estudiante"]);

                if (estudianteID == id)
                {
                    return estudiante;
                }
                else if (estudianteID < id)
                {
                    inicio = medio + 1;
                }
                else
                {
                    fin = medio - 1;
                }
            }

            return null; // Estudiante no encontrado
        }
        
        public List<Estudiante_get_set> burbuja()
        {
            // Realizar una copia de la lista de estudiantes para no modificar la lista original
            List<Estudiante_get_set> listaAux = EstudianteList;

            Estudiante_get_set estudaux;
            for (int i = 0; i < listaAux.Count; i++)
            {
                for (int j = 0; j < listaAux.Count - 1; j++)
                {
                    if (listaAux[j].GetCodigoEstudiante() > listaAux[j + 1].GetCodigoEstudiante())
                    {
                        estudaux = listaAux[j];
                        listaAux[j] = listaAux[j + 1];
                        listaAux[j + 1] = estudaux;
                    }
                }
            }
            return listaAux;
        }

        /// lineal
        public Estudiante_get_set BuscarEstudiantePorID(List<Estudiante_get_set> estudiantes, int id)
        {
            foreach (Estudiante_get_set estudiante in estudiantes)
            {
                if (estudiante.GetCodigoEstudiante() == id)
                {
                    return estudiante;
                }
            }

            return null; // Estudiante no encontrado
        }

       




    }



}


    

