using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.Metodos
{
    internal class ListaE
    {

        List<Estudiante_get_set> listaE;
        EstudianteQueries queries;

        public ListaE()
        {
            queries = new EstudianteQueries();
            listaE = queries.GetEstudiantes();
            this.Insercion();
        }

        public List<Estudiante_get_set> getListaE()
        {
            return listaE;
        }
        public EstudianteQueries GetQueries()
        {
            return queries;
        }
        public void setQueries(EstudianteQueries queries) { 
         this.queries = queries;
        }

        public void updateListaEstudiantes()
        {
            this.listaE = queries.GetEstudiantes();
            this.Insercion();
        }

        public void deleteEstudiante(int id )
        {
            queries.DeleteEstudiante(id);
            updateListaEstudiantes();
        }

        public void addEstudiante(Estudiante_get_set estudiante)
        {
            queries.SetEstudiante(estudiante);
            updateListaEstudiantes();
        }
        public void ImprimirLista()
        {
            foreach(Estudiante_get_set i in listaE)
            {
                Console.WriteLine(i.ToString());
            }
        }

        public void Insercion()
        {
            for (int i = 0; i < listaE.Count; i++)
            {
                Estudiante_get_set estudainteactual = listaE[i];
                string nombreActual = listaE[i].GetNombreEstudiante();
                int j = i - 1;

                while (j >= 0 && string.Compare(listaE[j].GetNombreEstudiante(), nombreActual) > 0)
                {
                    listaE[j + 1] = listaE[j];
                    j--;
                }

                listaE[j + 1] = estudainteactual;
            }
        }

        public Estudiante_get_set BusquedaLinealID(int id)
        {
            foreach (Estudiante_get_set i in listaE)
            {
                if (i.GetCodigoEstudiante() == id)
                {
                    return i;
                }
            }
            return null;
        }

        public Estudiante_get_set BusquedaBinaria(int id)
        {
            List<Estudiante_get_set> auxiliar = listaE.OrderBy(x => x.GetCodigoEstudiante()).ToList();
            int bajo = 0, alto = auxiliar.Count - 1, centro, valorCentral;

            while (bajo <= alto)
            {
                centro = (bajo + alto) / 2;
                valorCentral = listaE[centro].GetCodigoEstudiante();
                if (auxiliar[centro].GetCodigoEstudiante() == id)
                {
                    return auxiliar[centro];
                }
                else if (id < auxiliar[centro].GetCodigoEstudiante())
                {
                    alto = centro - 1;
                }
                else
                {
                    bajo = centro + 1;
                }
            }
            return null;
        }

        public List<Estudiante_get_set> OrdenarEstudiantesPorId(List<Estudiante_get_set> estudiantes)
        {
            int n = estudiantes.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (estudiantes[j].GetCodigoEstudiante() > estudiantes[j + 1].GetCodigoEstudiante())
                    {
                        Estudiante_get_set temp = estudiantes[j];
                        estudiantes[j] = estudiantes[j + 1];
                        estudiantes[j + 1] = temp;
                    }
                }
            }
            return estudiantes;
        }



        public override String ToString()
        {
            String peliculaString = "";

            foreach (var i in listaE)
            {
                Console.WriteLine(i.ToString());
            }
            return peliculaString;
        }


    }
}
