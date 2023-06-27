
using Proyecto3.Modelo;
using Restaurant_Management.Metodos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management
{
    public partial class Estudianteinsert : Form
    {
        EstudianteQueries datos;
        public Estudianteinsert()
        {
            
            InitializeComponent();
        }

        #region "Variables"
        int codigo_estudiante = 0; //nCodigo_ar = codigoLibro
        int nEstadoguarda = 0;
        private object txt_buscar;
        #endregion

        #region "Métodos"

        //Método para activar o desactivas la edición de las casillas
        private void estadoTexto(bool logicEstado)
        {
           
            txt_nombre_estudiante.ReadOnly = !logicEstado;
            txt_apellido_estudiante.ReadOnly = !logicEstado;
            txt_celular_estudiante.ReadOnly = !logicEstado;
            txt_sector.ReadOnly = !logicEstado;
            txt_facultad.ReadOnly = !logicEstado;
            txt_correo_estudiante.ReadOnly = !logicEstado;
        }


        //Limpia las casillas para ingresar un nuevo libro
        private void LimpiarTexto()
        {
          
            txt_nombre_estudiante.Clear();
            txt_apellido_estudiante.Clear();
            txt_celular_estudiante.Clear();
            txt_sector.Clear();
            txt_facultad.Clear();
            txt_correo_estudiante.Clear();
        }


        //Hace visible los botones cancelar y guardar
        private void estadoBotonesCG(bool logicEstado)
        {
            bt_cancelar.Visible = logicEstado;
            bt_guardar.Visible = logicEstado;

            bt_buscar.Enabled = !logicEstado;
            text_buscar.Enabled = !logicEstado;
            dataGridView1.Enabled = !logicEstado;
        }

        private void estadoBotonesPrincipales(bool logicEstado)
        {
            bt_insertar.Enabled = logicEstado;
            bt_actualizar.Enabled = logicEstado;
            bt_eliminar.Enabled = logicEstado;
            bt_salir.Enabled = logicEstado;
        }



        private void Listado_ar()
        {
            Datos datos = new Datos();
            string sqlsentence = "Select *FROM Estudiante";
            dataGridView1.DataSource = datos.listado(sqlsentence);
        }


        #endregion

        //EVENTO LOAD

        private void Estudianteinsert_Load (object sender, EventArgs e)
        {
            this.Listado_ar();
        }

        //Inicio de busqueda, Label, cuadro de texto y botón de búsqueda

        private void lbBuscar_Click(object sender, EventArgs e)
        {

        }

        private void text_buscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_buscar_Click(object sender, EventArgs e)
        {

        }

        //Fin

        //Botones para las operaciones CRUD

        private void bt_insertar_Click(object sender, EventArgs e)
        {
            //Métodos de interfaz
            nEstadoguarda = 1; //Nuevo Registro
            this.estadoTexto(true);
            this.LimpiarTexto();
            this.estadoBotonesCG(true);
            this.estadoBotonesPrincipales(false);
            txt_nombre_estudiante.Focus();
        }

        private void bt_actualizar_Click(object sender, EventArgs e)
        {
            nEstadoguarda = 2;//Actualizar registro
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {

        }

        private void bt_salir_Click(object sender, EventArgs e)
        {

        }

        //Fin de botones para operaciones CRUD

        //Botones para guardar o cancelar la modificación de datos 
        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.estadoTexto(false);
            this.LimpiarTexto();
            this.estadoBotonesCG(false);
            this.estadoBotonesPrincipales(true);
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            EstudianteQueries datos = new EstudianteQueries();
            String respuesta = "";
            MEstudiante mEstudiante = new MEstudiante();

            mEstudiante.codigo_estudiante = codigo_estudiante;
            mEstudiante.nombre_estudiante = txt_nombre_estudiante.Text.Trim();
            mEstudiante.apellido_estudiante = txt_apellido_estudiante.Text.Trim();
            mEstudiante.celular_estudiante = int.Parse(txt_celular_estudiante.Text.Trim());
            mEstudiante.sector = txt_sector.Text.Trim();
            mEstudiante.facultad = txt_facultad.Text.Trim();
            mEstudiante.correo_estudiante = txt_correo_estudiante.Text.Trim();

           
            respuesta = datos.guardarEstudiantes(nEstadoguarda, mEstudiante);
            if (respuesta.Equals("OK"))
            {
                this.Listado_ar();
                MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(respuesta);
            }

        }


        //Fin de los botones de modificación de datos

        //Inicio de los label que indican que infromación debe llenar el usuario

        private void lb_nombre_estudiante_Click(object sender, EventArgs e)
        {

        }

        private void lb_apellido_estudiante_Click(object sender, EventArgs e)
        {

        }

        private void lb_celular_estudiante_Click(object sender, EventArgs e)
        {

        }

        private void lb_sector_Click(object sender, EventArgs e)
        {

        }

        private void lb_facultad_Click(object sender, EventArgs e)
        {

        }

        private void lb_correo_estudiante_Click(object sender, EventArgs e)
        {

        }

        //Fin de los Label

        //Inicio de los cuadros de texto que albergan la la información ingresada por el usuario
        private void txt_nombre_estudiante_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_apellido_estudiante_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_celular_estudiante_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_sector_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_facultad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_correo_estudiante_TextChanged(object sender, EventArgs e)
        {

        }
        //Fin de los cuadros de texto

        //DATAGRIDVIEB
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
      
        private void dataGridView1_Layout(object sender, LayoutEventArgs e)
        {
            
        }
    }
}
