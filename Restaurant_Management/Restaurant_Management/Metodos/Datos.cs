using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Restaurant_Management.Metodos
{
    public class Datos
    {
        private CRUD crud;
        private Estudiante_get_set Estudiante;
        public DataTable listado()
        {

            SQLiteDataReader resultado;
            DataTable dt = new DataTable();
            SQLiteConnection sqlcon = new SQLiteConnection();

            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                string sql_tarea = "Select *FROM Estudiante";
                SQLiteCommand cmd = new SQLiteCommand(sql_tarea,sqlcon);
                sqlcon.Open();
                resultado= cmd.ExecuteReader();
                dt.Load(resultado);
                return dt;

            }
            catch(Exception ex) {

                throw ex;
            }
            finally
            {
                if (sqlcon.State==ConnectionState.Open) sqlcon.Close();
            }
            

        }

        public DataTable ObtenerEstudiantesOrdenadosPorId()
        {

            SQLiteDataReader resultado;
            DataTable dt = new DataTable();
            SQLiteConnection sqlcon = new SQLiteConnection();

            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                string sql_tarea = "SELECT * FROM estudiante ORDER BY codigo_estudiante";
                SQLiteCommand cmd = new SQLiteCommand(sql_tarea, sqlcon);
                sqlcon.Open();
                resultado = cmd.ExecuteReader();
                dt.Load(resultado);
                return dt;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
        }

        public DataTable ObtenerEstudiantesOrdenadosPorNombre()
        {

            SQLiteDataReader resultado;
            DataTable dt = new DataTable();
            SQLiteConnection sqlcon = new SQLiteConnection();

            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                string sql_tarea = "SELECT * FROM estudiante ORDER BY nombre_estudiante";
                SQLiteCommand cmd = new SQLiteCommand(sql_tarea, sqlcon);
                sqlcon.Open();
                resultado = cmd.ExecuteReader();
                dt.Load(resultado);
                return dt;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
        }

        public DataTable BuscarEstudiantePorNombre(string nombre)
        {
            SQLiteDataReader resultado;
            DataTable dt = new DataTable();
            SQLiteConnection sqlcon = new SQLiteConnection();

            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                string sql_tarea = "SELECT * FROM estudiante WHERE nombre_estudiante COLLATE NOCASE = @nombre ORDER BY nombre_estudiante";
                SQLiteCommand cmd = new SQLiteCommand(sql_tarea, sqlcon);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                sqlcon.Open();
                resultado = cmd.ExecuteReader();
                dt.Load(resultado);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                    sqlcon.Close();
            }
        }

        public DataTable ObtenerEstudiantesOrdenadosPorID()
        {
            DataTable dtEstudiantes = new DataTable();

            using (var connection = Conexion.getInstancia().CrearConexion())
            {
                connection.Open();

                // Obtener todos los estudiantes ordenados por ID
                string query = "SELECT * FROM estudiante ORDER BY codigo_estudiante";
                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var adapter = new SQLiteDataAdapter(command))
                    {
                        adapter.Fill(dtEstudiantes);
                    }
                }
            }

            return dtEstudiantes;

        }

       



    }
}
