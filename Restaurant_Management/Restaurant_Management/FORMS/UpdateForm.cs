

using Restaurant_Management.Metodos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            this.ListarDGV();
        }

        private void ListarDGV()
        {
            EstudianteQueries Datos = new EstudianteQueries();
            string tabName = this.t.SelectedTab.Text;
            //DGV_Libro.DataSource = 
            //return Datos.Listar(tabName);
            switch (t.SelectedIndex)
            {
                case 0:
                    DGV_Libro.DataSource = Datos.Listar(tabName);
                    break;
                case 1:
                    DGV_Estudiante.DataSource = Datos.Listar(tabName);
                    break;
                case 2:
                    DGV_Prestamo.DataSource = Datos.Listar(tabName);
                    break;
            }
        }

        private void btn_Update_Lib_Click(object sender, EventArgs e)
        {
            Libro libro = new Libro(int.Parse(txt_Cod_Lib.Text),
                txt_Name_Lib.Text, txt_PubDate_Lib.Text, txt_Ed_Lib.Text, 
                txt_NameAutor_Lib.Text, txt_LNameAu_Lib.Text,txt_Cat_Lib.Text, 
                int.Parse(txt_Stock_Lib.Text), int.Parse(txt_Disp_Lib.Text));

            EstudianteQueries Datos = new EstudianteQueries();
            string tabName = this.t.SelectedTab.Text;
            Datos.ActualizarRegistro(tabName, libro,null,null);
            this.ListarDGV();
        }

        private void DGV_Lib_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGV_Libro.Rows[e.RowIndex];

                // Obtener los valores de las columnas del registro seleccionado
                int codigoLibro = Convert.ToInt32(row.Cells["codigo_libro"].Value);
                string nombreLibro = row.Cells["nombre_libro"].Value.ToString();
                string fechaPublicacion = row.Cells["fecha_publicacion"].Value.ToString();
                string edicion = row.Cells["edicion"].Value.ToString();
                string nombreAutor = row.Cells["nombre_autor"].Value.ToString();
                string apellidoAutor = row.Cells["apellido_autor"].Value.ToString();
                string categoria = row.Cells["categoria"].Value.ToString();
                int stock = Convert.ToInt32(row.Cells["stock"].Value);
                int disponibilidad = Convert.ToInt32(row.Cells["disponibilidad"].Value);

                // Establecer los valores en los cuadros de texto
                txt_Cod_Lib.Text = codigoLibro.ToString();
                txt_Name_Lib.Text = nombreLibro;
                txt_PubDate_Lib.Text = fechaPublicacion;
                txt_Ed_Lib.Text = edicion;
                txt_NameAutor_Lib.Text = nombreAutor;
                txt_LNameAu_Lib.Text = apellidoAutor;
                txt_Cat_Lib.Text = categoria;
                txt_Stock_Lib.Text = stock.ToString();
                txt_Disp_Lib.Text = disponibilidad.ToString();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ListarDGV();
        }

        private void DGV_Estudiante_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGV_Estudiante.Rows[e.RowIndex];

                // Obtener los valores de las columnas del registro seleccionado
                int codigoEstudiante = Convert.ToInt32(row.Cells["codigo_estudiante"].Value);
                string nombreEstudiante = row.Cells["nombre_estudiante"].Value.ToString();
                string apellidoEstudiante = row.Cells["apellido_estudiante"].Value.ToString();
                int celularEstudiante = Convert.ToInt32(row.Cells["celular_estudiante"].Value);
                string sector = row.Cells["sector"].Value.ToString();
                string facultad = row.Cells["facultad"].Value.ToString();
                string correoEstudiante = row.Cells["correo_estudiante"].Value.ToString();

                // Establecer los valores en los cuadros de texto
                txt_Cod_Est.Text = codigoEstudiante.ToString();
                txt_Name_Est.Text = nombreEstudiante;
                txt_LName_Est.Text = apellidoEstudiante;
                txt_Cel_Est.Text = celularEstudiante.ToString();
                txt_Sector_Est.Text = sector;
                txt_Fac_Est.Text = facultad;
                txt_Correo_Est.Text = correoEstudiante;
            }
        }

        private void btn_Update_Est_Click(object sender, EventArgs e)
        {
           Estudiante estudiante = new Estudiante(int.Parse(txt_Cod_Est.Text),
                txt_Name_Est.Text,txt_LName_Est.Text,int.Parse(txt_Cel_Est.Text),
                txt_Sector_Est.Text,txt_Fac_Est.Text,txt_Correo_Est.Text);

            EstudianteQueries Datos = new EstudianteQueries();
            string tabName = this.t.SelectedTab.Text;
            Datos.ActualizarRegistro(tabName, null,estudiante,null);
            this.ListarDGV();
        }

        private void btn_Update_Prest_Click(object sender, EventArgs e)
        {
            Prestamo prestamo = new Prestamo(int.Parse(txt_Cod_Prest.Text), 
                int.Parse(txt_CodLib_Prest.Text), int.Parse(txt_CodEst_Prest.Text),
                txt_FechaInicio_Prest.Text,txt_FechaFin_Prest.Text);

            EstudianteQueries Datos = new EstudianteQueries();
            string tabName = this.t.SelectedTab.Text;
            Datos.ActualizarRegistro(tabName, null, null,prestamo);
            this.ListarDGV();
        }

        private void DGV_Prestamo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGV_Prestamo.Rows[e.RowIndex];

                // Obtener los valores de las columnas del registro seleccionado
                int codigoPrestamo = Convert.ToInt32(row.Cells["codigo_prestamo"].Value);
                int codigoLibro = Convert.ToInt32(row.Cells["codigo_libro"].Value);
                int codigoEstudiante = Convert.ToInt32(row.Cells["codigo_estudiante"].Value);
                string fechaPrestamo = row.Cells["fecha_prestamo"].Value.ToString();
                string fechaDevolucion = row.Cells["fecha_devolucion"].Value.ToString();

                // Por ejemplo, establecer los valores en los cuadros de texto
                txt_Cod_Prest.Text = codigoPrestamo.ToString();
                txt_CodLib_Prest.Text = codigoLibro.ToString();
                txt_CodEst_Prest.Text = codigoEstudiante.ToString();
                txt_FechaInicio_Prest.Text = fechaPrestamo;
                txt_FechaFin_Prest.Text = fechaDevolucion;
            }

        }
        private void LimpiarTextBox(TabPage tabPage)
        {
            foreach (Control control in tabPage.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
            }
        }

        private void bdelete_libro_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Libro libro = new Libro(int.Parse(txt_Cod_Lib.Text),
              txt_Name_Lib.Text, txt_PubDate_Lib.Text, txt_Ed_Lib.Text,
              txt_NameAutor_Lib.Text, txt_LNameAu_Lib.Text, txt_Cat_Lib.Text,
              int.Parse(txt_Stock_Lib.Text), int.Parse(txt_Disp_Lib.Text));

                EstudianteQueries Datos = new EstudianteQueries();
                string tabName = this.t.SelectedTab.Text;
                Datos.EliminarRegistro(tabName, libro, null, null);
                this.ListarDGV();

                LimpiarTextBox(tabPage1);
            }
                
        }

        private void bdelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Estudiante estudiante = new Estudiante(int.Parse(txt_Cod_Est.Text),
               txt_Name_Est.Text, txt_LName_Est.Text, int.Parse(txt_Cel_Est.Text),
               txt_Sector_Est.Text, txt_Fac_Est.Text, txt_Correo_Est.Text);

                EstudianteQueries Datos = new EstudianteQueries();
                string tabName = this.t.SelectedTab.Text;
                Datos.EliminarRegistro(tabName, null, estudiante, null);
                this.ListarDGV();

                LimpiarTextBox(tabPage2);
            }
                
        }

        private void bdeletePrestamo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Prestamo prestamo = new Prestamo(int.Parse(txt_Cod_Prest.Text),
               int.Parse(txt_CodLib_Prest.Text), int.Parse(txt_CodEst_Prest.Text),
               txt_FechaInicio_Prest.Text, txt_FechaFin_Prest.Text);

                EstudianteQueries Datos = new EstudianteQueries();
                string tabName = this.t.SelectedTab.Text;
                Datos.EliminarRegistro(tabName, null, null, prestamo);
                this.ListarDGV();


                LimpiarTextBox(tabPage3);
            }
        }
    }
}
