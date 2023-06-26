using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using Proyecto3.Modelo;


namespace Restaurant_Management.Metodos
{
    internal class EstudianteQueries
    {


        SQLiteConnection connect;
        List<Estudiante_get_set> listaEstudiante;
        string dbcon = @"Data Source=Users.db;";
        public EstudianteQueries()
        {
            connect = Conexion.getInstancia().CrearConexion();

            listaEstudiante = new List<Estudiante_get_set>();
        }

        // Actualizar la lista de estudiantes
        public DataTable Listar(string tableName)
        {
            SQLiteDataReader Resultado;
            DataTable Tabla = new DataTable();
            SQLiteConnection SqlCon = new SQLiteConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                string Sql_tarea = "select * from " + tableName;
                SQLiteCommand Comando = new SQLiteCommand(Sql_tarea, SqlCon);
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
        public List<Estudiante_get_set> GetEstudiantes()
        {
            listaEstudiante.Clear();
            try {
                using (var connection = Conexion.getInstancia().CrearConexion())
                {
                    connection.Open();

                    using (var cmd = new SQLiteCommand("SELECT * FROM Estudiante", connection))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                listaEstudiante.Add(new Estudiante_get_set(reader.GetInt16(0), reader.GetString(1), reader.GetString(2), reader.GetInt16(3), reader.GetString(4), reader.GetString(5), reader.GetString(6)));
                            }
                        }
                    }
                }

                return listaEstudiante;
            } catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connect.State == ConnectionState.Open) connect.Close();
            }
        }

        public void SetEstudiante(Estudiante_get_set nuevoEstudiante)
        {
            using (var cmd = new SQLiteCommand("INSERT INTO Estudiante (codigo_estudiante, nombre_estudiante, apellido_estudiante, celular_estudiante, sector, facultad, correo_estudiante) VALUES (@codigo_estudiante, @nombre_estudiante, @apellido_estudiante, @celular_estudiante, @sector, @facultad, @correo_estudiante)", connect))
            {
                cmd.Parameters.AddWithValue("codigo_estudiante", nuevoEstudiante.GetCodigoEstudiante());
                cmd.Parameters.AddWithValue("nombre_estudiante", nuevoEstudiante.GetNombreEstudiante());
                cmd.Parameters.AddWithValue("apellido_estudiante", nuevoEstudiante.GetApellidoEstudiante());
                cmd.Parameters.AddWithValue("celular_estudiante", nuevoEstudiante.GetCelularEstudiante());
                cmd.Parameters.AddWithValue("sector", nuevoEstudiante.GetSector());
                cmd.Parameters.AddWithValue("facultad", nuevoEstudiante.GetFacultad());
                cmd.Parameters.AddWithValue("correo_estudiante", nuevoEstudiante.GetCorreoEstudiante());
                cmd.ExecuteNonQuery();
            }
        }

        public string guardarEstudiantes(int nOpcion, MEstudiante mEstudiante) //L_Articulos = guardarLibros
        {

            String respuesta = "";
            string Sql_tarea = "";
            /*
            SQLiteDataReader resultado;
            DataTable tabla = new DataTable();
            */
            SQLiteConnection SqlCon = new SQLiteConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();


                if (nOpcion == 1) //Nuevo registro
                {
                    Sql_tarea = "INSERT INTO Estudiante (nombre_estudiante, apellido_estudiante, celular_estudiante, sector, facultad, correo_estudiante) " +
                        "VALUES ('" + mEstudiante.nombre_estudiante + "', '" + mEstudiante.apellido_estudiante + "', " + mEstudiante.celular_estudiante + ", '" + mEstudiante.sector + "', '" + mEstudiante.facultad + "', '" + mEstudiante.correo_estudiante + "' )";
                }

                else //Actualizar registro
                {
                    Sql_tarea = "";
                }

                SQLiteCommand comando = new SQLiteCommand(Sql_tarea, SqlCon);
                SqlCon.Open();
                respuesta = comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo completar el proceso de registro";

                return respuesta;

            }
            catch (Exception e)
            {
                return respuesta = e.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
        public void ActualizarRegistro(string tableName, Libro libro = null, Estudiante estudiante = null, Prestamo prestamo = null)
        {
            SQLiteConnection SqlCon = new SQLiteConnection();
            string sqlActualizar;
            SQLiteCommand Comando = null;
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                switch (tableName)
                {
                    case "Libro":
                        sqlActualizar = "UPDATE " + tableName + " SET nombre_libro = @NombreLibro, fecha_publicacion = @Fecha, edicion = @Edicion, nombre_autor = @AutorNombre, apellido_autor = @AutorApellido, categoria = @Categoria, stock = @Stock, disponibilidad = @Disponibilidad WHERE codigo_libro = @CodigoLibro";
                        Comando = new SQLiteCommand(sqlActualizar, SqlCon);

                        // Agregar parámetros a la consulta
                        Comando.Parameters.AddWithValue("@NombreLibro", libro.NombreLibro);
                        Comando.Parameters.AddWithValue("@Fecha", libro.FechaPublicacion);
                        Comando.Parameters.AddWithValue("@Edicion", libro.Edicion);
                        Comando.Parameters.AddWithValue("@AutorNombre", libro.NombreAutor);
                        Comando.Parameters.AddWithValue("@AutorApellido", libro.ApellidoAutor);
                        Comando.Parameters.AddWithValue("@Categoria", libro.Categoria);
                        Comando.Parameters.AddWithValue("@Stock", libro.Stock);
                        Comando.Parameters.AddWithValue("@Disponibilidad", libro.Disponibilidad);
                        Comando.Parameters.AddWithValue("@CodigoLibro", libro.CodigoLibro);

                        break;
                    case "Estudiante":
                        sqlActualizar = "UPDATE " + tableName + " SET nombre_estudiante = @NombreEstudiante, apellido_estudiante = @ApellidoEstudiante, celular_estudiante = @CelularEstudiante, sector = @Sector, facultad = @Facultad, correo_estudiante = @CorreoEstudiante WHERE codigo_estudiante = @CodigoEstudiante";
                        Comando = new SQLiteCommand(sqlActualizar, SqlCon);

                        // Agregar parámetros a la consulta
                        Comando.Parameters.AddWithValue("@NombreEstudiante", estudiante.CodigoEstudiante);
                        Comando.Parameters.AddWithValue("@ApellidoEstudiante", estudiante.ApellidoEstudiante);
                        Comando.Parameters.AddWithValue("@CelularEstudiante", estudiante.CelularEstudiante);
                        Comando.Parameters.AddWithValue("@Sector", estudiante.Sector);
                        Comando.Parameters.AddWithValue("@Facultad", estudiante.Facultad);
                        Comando.Parameters.AddWithValue("@CorreoEstudiante", estudiante.CorreoEstudiante);
                        Comando.Parameters.AddWithValue("@CodigoEstudiante", estudiante.CodigoEstudiante);

                        break;
                    case "Prestamo":
                        sqlActualizar = "UPDATE " + tableName + " SET codigo_libro = @CodigoLibro, codigo_estudiante = @CodigoEstudiante, fecha_prestamo = @FechaPrestamo, fecha_devolucion = @FechaDevolucion WHERE codigo_prestamo = @CodigoPrestamo";
                        Comando = new SQLiteCommand(sqlActualizar, SqlCon);

                        // Agregar parámetros a la consulta
                        Comando.Parameters.AddWithValue("@CodigoLibro", prestamo.CodigoLibro);
                        Comando.Parameters.AddWithValue("@CodigoEstudiante", prestamo.CodigoEstudiante);
                        Comando.Parameters.AddWithValue("@FechaPrestamo", prestamo.FechaPrestamo);
                        Comando.Parameters.AddWithValue("@FechaDevolucion", prestamo.FechaDevolucion);
                        Comando.Parameters.AddWithValue("@CodigoPrestamo", prestamo.CodigoPrestamo);

                        break;
                }

                SqlCon.Open();
                Comando.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public void EliminarRegistro(string tableName, Libro libro = null, Estudiante estudiante = null, Prestamo prestamo = null)
        {
            SQLiteConnection SqlCon = new SQLiteConnection();
            string sqlEliminar;
            SQLiteCommand Comando = null;
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                switch (tableName)
                {
                    case "Libro":
                        sqlEliminar = "DELETE FROM " + tableName + " WHERE codigo_libro = @CodigoLibro";
                        Comando = new SQLiteCommand(sqlEliminar, SqlCon);

                        // Agregar parámetro a la consulta
                        Comando.Parameters.AddWithValue("@CodigoLibro", libro.CodigoLibro);

                        break;
                    case "Estudiante":
                        sqlEliminar = "DELETE FROM " + tableName + " WHERE codigo_estudiante = @CodigoEstudiante";
                        Comando = new SQLiteCommand(sqlEliminar, SqlCon);

                        Comando.Parameters.AddWithValue("@CodigoEstudiante", estudiante.CodigoEstudiante);

                        break;
                    case "Prestamo":
                        sqlEliminar = "DELETE FROM " + tableName + " WHERE codigo_prestamo = @CodigoPrestamo";
                        Comando = new SQLiteCommand(sqlEliminar, SqlCon);

                        Comando.Parameters.AddWithValue("@CodigoPrestamo", prestamo.CodigoPrestamo);

                        break;
                }

                SqlCon.Open();
                Comando.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
        public void DeleteEstudiante(int codigoEstudiante)
        {
            using (var cmd = new SQLiteCommand("DELETE FROM Estudiante WHERE codigo_estudiante = @codigo_estudiante", connect))
            {
                cmd.Parameters.AddWithValue("codigo_estudiante", codigoEstudiante);
                cmd.ExecuteNonQuery();
            }
        }

        public Estudiante_get_set BuscarEstudiantePorCodigo(int codigoEstudiante)
        {
            Estudiante_get_set estudianteABuscar = null;

            using (var cmd = new SQLiteCommand("SELECT * FROM Estudiante WHERE codigo_estudiante = @codigo_estudiante", connect))
            {
                cmd.Parameters.AddWithValue("codigo_estudiante", codigoEstudiante);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        estudianteABuscar = new Estudiante_get_set(reader.GetInt16(0), reader.GetString(1), reader.GetString(2), reader.GetInt16(3), reader.GetString(4), reader.GetString(5), reader.GetString(6));
                    }
                }
            }
            return estudianteABuscar;
        }
        public Estudiante_get_set BuscarEstudiantePorNombre(string nombre)
        {
            Estudiante_get_set estudianteABuscar = null;

            using (var connection = Conexion.getInstancia().CrearConexion())
            {
                connection.Open();

                string query = "SELECT * FROM Estudiante WHERE nombre_estudiante = @nombre_estudiante";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombre_estudiante", nombre);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {


                            estudianteABuscar = new Estudiante_get_set(reader.GetInt16(0), reader.GetString(1), reader.GetString(2), reader.GetInt16(3), reader.GetString(4), reader.GetString(5), reader.GetString(6));
                        }
                    }
                }

                connection.Close();
            }

            return estudianteABuscar;
        }


        /*
        public List<Estudiante_get_set> BuscarEstudiantesPorGenero(string genero)
        {
            List<Estudiante_get_set> estudiantesPorGenero = new List<Estudiante_get_set>();

            using (var cmd = new SQLiteCommand("SELECT * FROM Estudiante WHERE genero_estudiante = @genero", Estudiante))
            {
                cmd.Parameters.AddWithValue("genero", genero);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        estudiantesPorGenero.Add(new Estudiante_get_set(reader.GetInt16(0), reader.GetString(1), reader.GetString(2), reader.GetInt16(3), reader.GetString(4), reader.GetString(5), reader.GetString(6)));
                    }
                }
            }
            return estudiantesPorGenero;
        }
        */
    }
}
        
 

