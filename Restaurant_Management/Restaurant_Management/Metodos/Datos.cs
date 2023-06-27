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
        public DataTable listado(string sqlconection)
        {

            SQLiteDataReader resultado;
            DataTable dt = new DataTable();
            SQLiteConnection sqlcon = new SQLiteConnection();

            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                string sql_tarea = sqlconection;
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

        public DataTable ObtenerEstudiantesOrdenadosPorId(string sqlconection2)
        {

            SQLiteDataReader resultado;
            DataTable dt = new DataTable();
            SQLiteConnection sqlcon = new SQLiteConnection();

            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                string sql_tarea = sqlconection2;
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

        public DataTable ObtenerEstudiantesOrdenadosPorNombre(string sqlconection3)
        {

            SQLiteDataReader resultado;
            DataTable dt = new DataTable();
            SQLiteConnection sqlcon = new SQLiteConnection();

            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                string sql_tarea = sqlconection3;
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

        public DataTable BuscarPrestamoPorCodigo(string codigoPrestamo,string sentenciasql)
        {
            SQLiteDataReader resultado;
            DataTable dt = new DataTable();
            SQLiteConnection sqlcon = new SQLiteConnection();

            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                string sql_tarea = sentenciasql;
                SQLiteCommand cmd = new SQLiteCommand(sql_tarea, sqlcon);
                cmd.Parameters.AddWithValue("@codigoPrestamo", codigoPrestamo);
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



        public DataTable BuscarEstudiantePorNombre(string nombre ,string sqlconection )
        {
            SQLiteDataReader resultado;
            DataTable dt = new DataTable();
            SQLiteConnection sqlcon = new SQLiteConnection();

            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                string sql_tarea = sqlconection;
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

        public DataTable ObtenerEstudiantesOrdenadosPorID(string sqlconection)
        {
            DataTable dtEstudiantes = new DataTable();

            using (var connection = Conexion.getInstancia().CrearConexion())
            {
                connection.Open();

                // Obtener todos los estudiantes ordenados por ID
                string query = sqlconection;
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
