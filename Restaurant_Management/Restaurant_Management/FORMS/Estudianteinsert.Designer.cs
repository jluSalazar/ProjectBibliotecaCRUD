namespace Restaurant_Management
{
    partial class Estudianteinsert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_buscar = new System.Windows.Forms.Button();
            this.text_buscar = new System.Windows.Forms.TextBox();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.lb_nombre_estudiante = new System.Windows.Forms.Label();
            this.lb_apellido_estudiante = new System.Windows.Forms.Label();
            this.lb_celular_estudiante = new System.Windows.Forms.Label();
            this.lb_sector = new System.Windows.Forms.Label();
            this.lb_facultad = new System.Windows.Forms.Label();
            this.bt_insertar = new System.Windows.Forms.Button();
            this.bt_actualizar = new System.Windows.Forms.Button();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.bt_salir = new System.Windows.Forms.Button();
            this.lb_correo_estudiante = new System.Windows.Forms.Label();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.txt_nombre_estudiante = new System.Windows.Forms.TextBox();
            this.txt_apellido_estudiante = new System.Windows.Forms.TextBox();
            this.txt_celular_estudiante = new System.Windows.Forms.TextBox();
            this.txt_sector = new System.Windows.Forms.TextBox();
            this.txt_facultad = new System.Windows.Forms.TextBox();
            this.txt_correo_estudiante = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(905, 399);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Layout += new System.Windows.Forms.LayoutEventHandler(this.dataGridView1_Layout);
            // 
            // bt_buscar
            // 
            this.bt_buscar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_buscar.Location = new System.Drawing.Point(387, 38);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(75, 23);
            this.bt_buscar.TabIndex = 2;
            this.bt_buscar.Text = "Buscar";
            this.bt_buscar.UseVisualStyleBackColor = true;
            this.bt_buscar.Click += new System.EventHandler(this.bt_buscar_Click);
            // 
            // text_buscar
            // 
            this.text_buscar.Location = new System.Drawing.Point(106, 41);
            this.text_buscar.Name = "text_buscar";
            this.text_buscar.Size = new System.Drawing.Size(259, 20);
            this.text_buscar.TabIndex = 3;
            this.text_buscar.TextChanged += new System.EventHandler(this.text_buscar_TextChanged);
            // 
            // lbBuscar
            // 
            this.lbBuscar.AutoSize = true;
            this.lbBuscar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuscar.Location = new System.Drawing.Point(1, 37);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(63, 18);
            this.lbBuscar.TabIndex = 4;
            this.lbBuscar.Text = "Buscar";
            this.lbBuscar.Click += new System.EventHandler(this.lbBuscar_Click);
            // 
            // lb_nombre_estudiante
            // 
            this.lb_nombre_estudiante.AutoSize = true;
            this.lb_nombre_estudiante.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nombre_estudiante.Location = new System.Drawing.Point(957, 38);
            this.lb_nombre_estudiante.Name = "lb_nombre_estudiante";
            this.lb_nombre_estudiante.Size = new System.Drawing.Size(78, 18);
            this.lb_nombre_estudiante.TabIndex = 6;
            this.lb_nombre_estudiante.Text = "Nombre ";
            this.lb_nombre_estudiante.Click += new System.EventHandler(this.lb_nombre_estudiante_Click);
            // 
            // lb_apellido_estudiante
            // 
            this.lb_apellido_estudiante.AutoSize = true;
            this.lb_apellido_estudiante.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_apellido_estudiante.Location = new System.Drawing.Point(957, 97);
            this.lb_apellido_estudiante.Name = "lb_apellido_estudiante";
            this.lb_apellido_estudiante.Size = new System.Drawing.Size(72, 18);
            this.lb_apellido_estudiante.TabIndex = 7;
            this.lb_apellido_estudiante.Text = "Apellido";
            this.lb_apellido_estudiante.Click += new System.EventHandler(this.lb_apellido_estudiante_Click);
            // 
            // lb_celular_estudiante
            // 
            this.lb_celular_estudiante.AutoSize = true;
            this.lb_celular_estudiante.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_celular_estudiante.Location = new System.Drawing.Point(957, 160);
            this.lb_celular_estudiante.Name = "lb_celular_estudiante";
            this.lb_celular_estudiante.Size = new System.Drawing.Size(64, 18);
            this.lb_celular_estudiante.TabIndex = 8;
            this.lb_celular_estudiante.Text = "Celular";
            this.lb_celular_estudiante.Click += new System.EventHandler(this.lb_celular_estudiante_Click);
            // 
            // lb_sector
            // 
            this.lb_sector.AutoSize = true;
            this.lb_sector.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sector.Location = new System.Drawing.Point(960, 232);
            this.lb_sector.Name = "lb_sector";
            this.lb_sector.Size = new System.Drawing.Size(61, 18);
            this.lb_sector.TabIndex = 9;
            this.lb_sector.Text = "Sector";
            this.lb_sector.Click += new System.EventHandler(this.lb_sector_Click);
            // 
            // lb_facultad
            // 
            this.lb_facultad.AutoSize = true;
            this.lb_facultad.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_facultad.Location = new System.Drawing.Point(960, 287);
            this.lb_facultad.Name = "lb_facultad";
            this.lb_facultad.Size = new System.Drawing.Size(77, 18);
            this.lb_facultad.TabIndex = 10;
            this.lb_facultad.Text = "Facultad";
            this.lb_facultad.Click += new System.EventHandler(this.lb_facultad_Click);
            // 
            // bt_insertar
            // 
            this.bt_insertar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_insertar.Location = new System.Drawing.Point(16, 486);
            this.bt_insertar.Name = "bt_insertar";
            this.bt_insertar.Size = new System.Drawing.Size(86, 23);
            this.bt_insertar.TabIndex = 11;
            this.bt_insertar.Text = "Insertar";
            this.bt_insertar.UseVisualStyleBackColor = true;
            this.bt_insertar.Click += new System.EventHandler(this.bt_insertar_Click);
            // 
            // bt_actualizar
            // 
            this.bt_actualizar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_actualizar.Location = new System.Drawing.Point(118, 486);
            this.bt_actualizar.Name = "bt_actualizar";
            this.bt_actualizar.Size = new System.Drawing.Size(100, 23);
            this.bt_actualizar.TabIndex = 12;
            this.bt_actualizar.Text = "Actualizar";
            this.bt_actualizar.UseVisualStyleBackColor = true;
            this.bt_actualizar.Click += new System.EventHandler(this.bt_actualizar_Click);
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_eliminar.Location = new System.Drawing.Point(239, 486);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(83, 23);
            this.bt_eliminar.TabIndex = 13;
            this.bt_eliminar.Text = "Eliminar";
            this.bt_eliminar.UseVisualStyleBackColor = true;
            this.bt_eliminar.Click += new System.EventHandler(this.bt_eliminar_Click);
            // 
            // bt_salir
            // 
            this.bt_salir.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_salir.Location = new System.Drawing.Point(343, 486);
            this.bt_salir.Name = "bt_salir";
            this.bt_salir.Size = new System.Drawing.Size(83, 23);
            this.bt_salir.TabIndex = 14;
            this.bt_salir.Text = "Salir";
            this.bt_salir.UseVisualStyleBackColor = true;
            this.bt_salir.Click += new System.EventHandler(this.bt_salir_Click);
            // 
            // lb_correo_estudiante
            // 
            this.lb_correo_estudiante.AutoSize = true;
            this.lb_correo_estudiante.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_correo_estudiante.Location = new System.Drawing.Point(960, 352);
            this.lb_correo_estudiante.Name = "lb_correo_estudiante";
            this.lb_correo_estudiante.Size = new System.Drawing.Size(63, 18);
            this.lb_correo_estudiante.TabIndex = 15;
            this.lb_correo_estudiante.Text = "Correo";
            this.lb_correo_estudiante.Click += new System.EventHandler(this.lb_correo_estudiante_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar.Location = new System.Drawing.Point(960, 419);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(86, 23);
            this.bt_cancelar.TabIndex = 16;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // bt_guardar
            // 
            this.bt_guardar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_guardar.Location = new System.Drawing.Point(1150, 419);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(91, 23);
            this.bt_guardar.TabIndex = 17;
            this.bt_guardar.Text = "Guardar";
            this.bt_guardar.UseVisualStyleBackColor = true;
            this.bt_guardar.Click += new System.EventHandler(this.bt_guardar_Click);
            // 
            // txt_nombre_estudiante
            // 
            this.txt_nombre_estudiante.Location = new System.Drawing.Point(960, 59);
            this.txt_nombre_estudiante.Name = "txt_nombre_estudiante";
            this.txt_nombre_estudiante.Size = new System.Drawing.Size(237, 20);
            this.txt_nombre_estudiante.TabIndex = 18;
            this.txt_nombre_estudiante.TextChanged += new System.EventHandler(this.txt_nombre_estudiante_TextChanged);
            // 
            // txt_apellido_estudiante
            // 
            this.txt_apellido_estudiante.Location = new System.Drawing.Point(960, 118);
            this.txt_apellido_estudiante.Name = "txt_apellido_estudiante";
            this.txt_apellido_estudiante.Size = new System.Drawing.Size(237, 20);
            this.txt_apellido_estudiante.TabIndex = 19;
            this.txt_apellido_estudiante.TextChanged += new System.EventHandler(this.txt_apellido_estudiante_TextChanged);
            // 
            // txt_celular_estudiante
            // 
            this.txt_celular_estudiante.Location = new System.Drawing.Point(960, 181);
            this.txt_celular_estudiante.Name = "txt_celular_estudiante";
            this.txt_celular_estudiante.Size = new System.Drawing.Size(237, 20);
            this.txt_celular_estudiante.TabIndex = 20;
            this.txt_celular_estudiante.TextChanged += new System.EventHandler(this.txt_celular_estudiante_TextChanged);
            // 
            // txt_sector
            // 
            this.txt_sector.Location = new System.Drawing.Point(960, 253);
            this.txt_sector.Name = "txt_sector";
            this.txt_sector.Size = new System.Drawing.Size(237, 20);
            this.txt_sector.TabIndex = 21;
            this.txt_sector.TextChanged += new System.EventHandler(this.txt_sector_TextChanged);
            // 
            // txt_facultad
            // 
            this.txt_facultad.Location = new System.Drawing.Point(960, 308);
            this.txt_facultad.Name = "txt_facultad";
            this.txt_facultad.Size = new System.Drawing.Size(237, 20);
            this.txt_facultad.TabIndex = 22;
            this.txt_facultad.TextChanged += new System.EventHandler(this.txt_facultad_TextChanged);
            // 
            // txt_correo_estudiante
            // 
            this.txt_correo_estudiante.Location = new System.Drawing.Point(960, 373);
            this.txt_correo_estudiante.Name = "txt_correo_estudiante";
            this.txt_correo_estudiante.Size = new System.Drawing.Size(237, 20);
            this.txt_correo_estudiante.TabIndex = 23;
            this.txt_correo_estudiante.TextChanged += new System.EventHandler(this.txt_correo_estudiante_TextChanged);
            // 
            // Estudianteinsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 552);
            this.Controls.Add(this.txt_correo_estudiante);
            this.Controls.Add(this.txt_facultad);
            this.Controls.Add(this.txt_sector);
            this.Controls.Add(this.txt_celular_estudiante);
            this.Controls.Add(this.txt_apellido_estudiante);
            this.Controls.Add(this.txt_nombre_estudiante);
            this.Controls.Add(this.bt_guardar);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.lb_correo_estudiante);
            this.Controls.Add(this.bt_salir);
            this.Controls.Add(this.bt_eliminar);
            this.Controls.Add(this.bt_actualizar);
            this.Controls.Add(this.bt_insertar);
            this.Controls.Add(this.lb_facultad);
            this.Controls.Add(this.lb_sector);
            this.Controls.Add(this.lb_celular_estudiante);
            this.Controls.Add(this.lb_apellido_estudiante);
            this.Controls.Add(this.lb_nombre_estudiante);
            this.Controls.Add(this.lbBuscar);
            this.Controls.Add(this.text_buscar);
            this.Controls.Add(this.bt_buscar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Estudianteinsert";
            this.Text = "Estudianteinsert";
            this.Load += new System.EventHandler(this.Estudianteinsert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_buscar;
        private System.Windows.Forms.TextBox text_buscar;
        private System.Windows.Forms.Label lbBuscar;
        private System.Windows.Forms.Label lb_nombre_estudiante;
        private System.Windows.Forms.Label lb_apellido_estudiante;
        private System.Windows.Forms.Label lb_celular_estudiante;
        private System.Windows.Forms.Label lb_sector;
        private System.Windows.Forms.Label lb_facultad;
        private System.Windows.Forms.Button bt_insertar;
        private System.Windows.Forms.Button bt_actualizar;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.Button bt_salir;
        private System.Windows.Forms.Label lb_correo_estudiante;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.TextBox txt_nombre_estudiante;
        private System.Windows.Forms.TextBox txt_apellido_estudiante;
        private System.Windows.Forms.TextBox txt_celular_estudiante;
        private System.Windows.Forms.TextBox txt_sector;
        private System.Windows.Forms.TextBox txt_facultad;
        private System.Windows.Forms.TextBox txt_correo_estudiante;
    }
}