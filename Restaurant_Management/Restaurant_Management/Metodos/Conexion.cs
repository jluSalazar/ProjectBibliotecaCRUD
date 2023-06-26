using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management
{
    internal class Conexion
    {
        private string baseDatos;
        public static Conexion conexion1 = null;

        private Conexion()
        {
            this.baseDatos = "./Biblioteca.db";
        }

        public SQLiteConnection CrearConexion()
        {
            SQLiteConnection cadena = new SQLiteConnection();

            try
            {
                cadena.ConnectionString = "Data Source=" + this.baseDatos;

            }
            catch (Exception ex)
            {
                cadena = null;
                throw ex;
            }
            return cadena;
        }
        public static Conexion getInstancia()
        {
            if (conexion1 == null)
            {
                conexion1 = new Conexion();
            }
            return conexion1;
        }
    }
}
   
      



