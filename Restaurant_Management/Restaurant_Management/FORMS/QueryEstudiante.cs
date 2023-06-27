using Restaurant_Management.Metodos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Restaurant_Management
{
    public partial class QueryEstudiante : Form
    {
        private Conexion conexion;
        private ListaE listaestudiante;
        private SQLiteDataAdapter adapter;
        private DataTable dataTable;
        private CRUD crud;
        private string connectionString = "Data Source=./Biblioteca.db";
        private Metodos.Metodos metodos;
       
        public QueryEstudiante()
        {

            InitializeComponent();
            conexion = Conexion.getInstancia();
            metodos = new Metodos.Metodos();

            listaestudiante = new ListaE();
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }


        private void Listado_ar()
        {
            Datos datos = new Datos();
            string sqlsentence= "Select *FROM Estudiante";
            dataGEstudiante.DataSource = datos.listado(sqlsentence);
        }
        private void Estudiante_Load(object sender, EventArgs e)
        {
            Listado_ar();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            string sqlsentence = "SELECT * FROM estudiante ORDER BY nombre_estudiante";
            dataGEstudiante.DataSource = datos.ObtenerEstudiantesOrdenadosPorNombre(sqlsentence);

        }

        private void button16_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            string sqlsentence = "SELECT * FROM estudiante ORDER BY codigo_estudiante";
            dataGEstudiante.DataSource = datos.ObtenerEstudiantesOrdenadosPorId(sqlsentence);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = tquery.Text;
            Datos datos = new Datos();
            string sqlsentence= "SELECT * FROM estudiante WHERE nombre_estudiante COLLATE NOCASE = @nombre ORDER BY nombre_estudiante";
            dataGEstudiante.DataSource = datos.BuscarEstudiantePorNombre(nombre,sqlsentence);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Metodos.Metodos metodosBusqueda = new Metodos.Metodos();
            int id = Convert.ToInt32(tquery.Text);

            DataRow estudianteEncontrado = metodosBusqueda.Busquedabinaria(id);

            if (estudianteEncontrado != null)
            {
                DataTable dtEstudiantes = new DataTable();
                dtEstudiantes.Columns.Add("codigo_estudiante");
                dtEstudiantes.Columns.Add("nombre_estudiante");
                dtEstudiantes.Columns.Add("apellido_estudiante");
                dtEstudiantes.Columns.Add("celular_estudiante");
                dtEstudiantes.Columns.Add("sector");
                dtEstudiantes.Columns.Add("facultad");
                dtEstudiantes.Columns.Add("correo_estudiante");
                // Agrega las columnas adicionales según la estructura de tu tabla Estudiante

                dtEstudiantes.Rows.Add(
                    estudianteEncontrado["codigo_estudiante"],
                    estudianteEncontrado["nombre_estudiante"],
                    estudianteEncontrado["apellido_estudiante"],
                    estudianteEncontrado["celular_estudiante"],
                    estudianteEncontrado["sector"],
                    estudianteEncontrado["facultad"],
                    estudianteEncontrado["correo_estudiante"]
                );
                // Agrega las filas adicionales según la estructura de tu tabla Estudiante

                dataGEstudiante.DataSource = dtEstudiantes;
            }
            else
            {
                MessageBox.Show("Estudiante no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        



        private void button18_Click(object sender, EventArgs e)
        {
            List<Estudiante_get_set> estudiantes = metodos.burbuja(); // Llamada al método para obtener la lista de estudiantes ordenada

            if (estudiantes != null)
            {
                DataTable dtEstudiantes = new DataTable();
                dtEstudiantes.Columns.Add("codigo_estudiante");
                dtEstudiantes.Columns.Add("nombre_estudiante");
                dtEstudiantes.Columns.Add("apellido_estudiante");
                dtEstudiantes.Columns.Add("celular_estudiante");
                dtEstudiantes.Columns.Add("sector");
                dtEstudiantes.Columns.Add("facultad");
                dtEstudiantes.Columns.Add("correo_estudiante");
                // Agrega las columnas adicionales según la estructura de tu tabla Estudiante

                foreach (Estudiante_get_set estudiante in estudiantes)
                {
                    dtEstudiantes.Rows.Add(estudiante.GetCodigoEstudiante(), estudiante.GetNombreEstudiante(), estudiante.GetApellidoEstudiante(), estudiante.GetCelularEstudiante(), estudiante.GetSector(), estudiante.GetFacultad(), estudiante.GetCorreoEstudiante());
                }

                // Vincula la tabla al DataGridView
                dataGEstudiante.DataSource = dtEstudiantes;

                // Ajusta el tamaño de las columnas automáticamente
                dataGEstudiante.AutoResizeColumns();
            }
            else
            {
                MessageBox.Show("No se encontraron estudiantes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGEstudiante_Layout(object sender, LayoutEventArgs e)
        {
            Listado_ar();
        }
    }
}