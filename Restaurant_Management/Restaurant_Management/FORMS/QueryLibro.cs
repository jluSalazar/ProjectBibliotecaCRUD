﻿using Restaurant_Management.Metodos;
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
    public partial class QueryLibro : Form
    {
        private Conexion conexion;
        private ListaE listaestudiante;
        private SQLiteDataAdapter adapter;
        private DataTable dataTable;
        private CRUD crud;
        private string connectionString = "Data Source=./Biblioteca.db";
        private Metodos.Metodos metodos;
       
        public QueryLibro()
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
            string sqlsentence = "Select *FROM Libro";
            dataGLibro.DataSource = datos.listado(sqlsentence);
        }
        private void Estudiante_Load(object sender, EventArgs e)
        {
            Listado_ar();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            string sqlsentence = "SELECT * FROM Libro ORDER BY nombre_libro";
            dataGLibro.DataSource = datos.ObtenerEstudiantesOrdenadosPorNombre(sqlsentence);

        }

        private void button16_Click(object sender, EventArgs e)
        {

            Datos datos = new Datos();
            string sqlsentence = "SELECT * FROM Libro ORDER BY codigo_libro";
            dataGLibro.DataSource = datos.ObtenerEstudiantesOrdenadosPorId(sqlsentence);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = tquerylibro.Text;
            Datos datos = new Datos();
            string sqlsentence = "SELECT * FROM Libro WHERE nombre_libro LIKE '%' || @nombre || '%' COLLATE NOCASE ORDER BY nombre_libro";
            dataGLibro.DataSource = datos.BuscarEstudiantePorNombre(nombre, sqlsentence);


        }

        private void button17_Click(object sender, EventArgs e)
        {
            Metodos.Metodos metodosBusqueda = new Metodos.Metodos();
            int id = Convert.ToInt32(tquerylibro.Text);
            string sqlsentence = "SELECT * FROM libro ORDER BY codigo_libro";
            string convert = "codigo_libro";
            DataRow estudianteEncontrado = metodosBusqueda.Busquedabinaria(id,sqlsentence,convert);

            if (estudianteEncontrado != null)
            {
                DataTable dtEstudiantes = new DataTable();
                dtEstudiantes.Columns.Add("codigo_libro");
                dtEstudiantes.Columns.Add("nombre_libro");
                dtEstudiantes.Columns.Add("fecha_publicacion");
                dtEstudiantes.Columns.Add("edicion");
                dtEstudiantes.Columns.Add("nombre_autor");
                dtEstudiantes.Columns.Add("apellido_autor");
                dtEstudiantes.Columns.Add("categoria");
                dtEstudiantes.Columns.Add("stock");
                dtEstudiantes.Columns.Add("disponibilidad");
                // Agrega las columnas adicionales según la estructura de tu tabla Estudiante
                dtEstudiantes.Rows.Add(
                    estudianteEncontrado["codigo_libro"],
                    estudianteEncontrado["nombre_libro"],
                    estudianteEncontrado["fecha_publicacion"],
                    estudianteEncontrado["edicion"],
                    estudianteEncontrado["nombre_autor"],
                    estudianteEncontrado["apellido_autor"],
                    estudianteEncontrado["categoria"],
                    estudianteEncontrado["stock"],
                    estudianteEncontrado["disponibilidad"]
                );

                dataGLibro.DataSource = dtEstudiantes;
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
                dataGLibro.DataSource = dtEstudiantes;

                // Ajusta el tamaño de las columnas automáticamente
                dataGLibro.AutoResizeColumns();
            }
            else
            {
                MessageBox.Show("No se encontraron estudiantes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void QueryLibro_LocationChanged(object sender, EventArgs e)
        {
            Listado_ar();

        }
    }
}