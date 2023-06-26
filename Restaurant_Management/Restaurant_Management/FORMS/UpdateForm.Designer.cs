namespace Restaurant_Management
{
    partial class UpdateForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Cod_Lib = new System.Windows.Forms.TextBox();
            this.txt_Name_Lib = new System.Windows.Forms.TextBox();
            this.txt_PubDate_Lib = new System.Windows.Forms.TextBox();
            this.t = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_Update_Lib = new System.Windows.Forms.Button();
            this.DGV_Libro = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Cat_Lib = new System.Windows.Forms.TextBox();
            this.txt_Disp_Lib = new System.Windows.Forms.TextBox();
            this.txt_Stock_Lib = new System.Windows.Forms.TextBox();
            this.txt_Ed_Lib = new System.Windows.Forms.TextBox();
            this.txt_LNameAu_Lib = new System.Windows.Forms.TextBox();
            this.txt_NameAutor_Lib = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_Update_Est = new System.Windows.Forms.Button();
            this.DGV_Estudiante = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_Fac_Est = new System.Windows.Forms.TextBox();
            this.txt_Correo_Est = new System.Windows.Forms.TextBox();
            this.txt_LName_Est = new System.Windows.Forms.TextBox();
            this.txt_Sector_Est = new System.Windows.Forms.TextBox();
            this.txt_Cel_Est = new System.Windows.Forms.TextBox();
            this.txt_Cod_Est = new System.Windows.Forms.TextBox();
            this.txt_Name_Est = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_Update_Prest = new System.Windows.Forms.Button();
            this.DGV_Prestamo = new System.Windows.Forms.DataGridView();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txt_FechaInicio_Prest = new System.Windows.Forms.TextBox();
            this.txt_CodEst_Prest = new System.Windows.Forms.TextBox();
            this.txt_FechaFin_Prest = new System.Windows.Forms.TextBox();
            this.txt_Cod_Prest = new System.Windows.Forms.TextBox();
            this.txt_CodLib_Prest = new System.Windows.Forms.TextBox();
            this.bdelete_libro = new System.Windows.Forms.Button();
            this.bdelete = new System.Windows.Forms.Button();
            this.bdeletePrestamo = new System.Windows.Forms.Button();
            this.t.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Libro)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Estudiante)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Prestamo)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Cod_Lib
            // 
            this.txt_Cod_Lib.Enabled = false;
            this.txt_Cod_Lib.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cod_Lib.Location = new System.Drawing.Point(119, 29);
            this.txt_Cod_Lib.Name = "txt_Cod_Lib";
            this.txt_Cod_Lib.Size = new System.Drawing.Size(135, 26);
            this.txt_Cod_Lib.TabIndex = 0;
            // 
            // txt_Name_Lib
            // 
            this.txt_Name_Lib.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name_Lib.Location = new System.Drawing.Point(119, 86);
            this.txt_Name_Lib.Name = "txt_Name_Lib";
            this.txt_Name_Lib.Size = new System.Drawing.Size(135, 26);
            this.txt_Name_Lib.TabIndex = 1;
            // 
            // txt_PubDate_Lib
            // 
            this.txt_PubDate_Lib.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PubDate_Lib.Location = new System.Drawing.Point(119, 150);
            this.txt_PubDate_Lib.Name = "txt_PubDate_Lib";
            this.txt_PubDate_Lib.Size = new System.Drawing.Size(135, 26);
            this.txt_PubDate_Lib.TabIndex = 2;
            // 
            // t
            // 
            this.t.Controls.Add(this.tabPage1);
            this.t.Controls.Add(this.tabPage2);
            this.t.Controls.Add(this.tabPage3);
            this.t.Location = new System.Drawing.Point(0, 0);
            this.t.Name = "t";
            this.t.SelectedIndex = 0;
            this.t.Size = new System.Drawing.Size(868, 555);
            this.t.TabIndex = 3;
            this.t.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bdelete_libro);
            this.tabPage1.Controls.Add(this.btn_Update_Lib);
            this.tabPage1.Controls.Add(this.DGV_Libro);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txt_Cat_Lib);
            this.tabPage1.Controls.Add(this.txt_Disp_Lib);
            this.tabPage1.Controls.Add(this.txt_Stock_Lib);
            this.tabPage1.Controls.Add(this.txt_Ed_Lib);
            this.tabPage1.Controls.Add(this.txt_LNameAu_Lib);
            this.tabPage1.Controls.Add(this.txt_NameAutor_Lib);
            this.tabPage1.Controls.Add(this.txt_Cod_Lib);
            this.tabPage1.Controls.Add(this.txt_PubDate_Lib);
            this.tabPage1.Controls.Add(this.txt_Name_Lib);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(860, 529);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Libro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_Update_Lib
            // 
            this.btn_Update_Lib.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_Lib.Location = new System.Drawing.Point(249, 203);
            this.btn_Update_Lib.Name = "btn_Update_Lib";
            this.btn_Update_Lib.Size = new System.Drawing.Size(131, 31);
            this.btn_Update_Lib.TabIndex = 19;
            this.btn_Update_Lib.Text = "Update";
            this.btn_Update_Lib.UseVisualStyleBackColor = true;
            this.btn_Update_Lib.Click += new System.EventHandler(this.btn_Update_Lib_Click);
            // 
            // DGV_Libro
            // 
            this.DGV_Libro.AllowUserToAddRows = false;
            this.DGV_Libro.AllowUserToDeleteRows = false;
            this.DGV_Libro.AllowUserToOrderColumns = true;
            this.DGV_Libro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Libro.Location = new System.Drawing.Point(9, 240);
            this.DGV_Libro.Name = "DGV_Libro";
            this.DGV_Libro.ReadOnly = true;
            this.DGV_Libro.Size = new System.Drawing.Size(838, 274);
            this.DGV_Libro.TabIndex = 18;
            this.DGV_Libro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Lib_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(521, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Disponibilidad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(602, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Stock:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(557, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "Categoria: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(266, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 38);
            this.label4.TabIndex = 14;
            this.label4.Text = "Apellido \r\ndel Autor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(266, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 38);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nombre \r\ndel Autor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(284, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Edicion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 36);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fecha \r\nPublicacion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Codigo:";
            // 
            // txt_Cat_Lib
            // 
            this.txt_Cat_Lib.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cat_Lib.Location = new System.Drawing.Point(671, 29);
            this.txt_Cat_Lib.Name = "txt_Cat_Lib";
            this.txt_Cat_Lib.Size = new System.Drawing.Size(135, 26);
            this.txt_Cat_Lib.TabIndex = 6;
            // 
            // txt_Disp_Lib
            // 
            this.txt_Disp_Lib.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Disp_Lib.Location = new System.Drawing.Point(671, 150);
            this.txt_Disp_Lib.Name = "txt_Disp_Lib";
            this.txt_Disp_Lib.Size = new System.Drawing.Size(135, 26);
            this.txt_Disp_Lib.TabIndex = 8;
            // 
            // txt_Stock_Lib
            // 
            this.txt_Stock_Lib.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Stock_Lib.Location = new System.Drawing.Point(671, 86);
            this.txt_Stock_Lib.Name = "txt_Stock_Lib";
            this.txt_Stock_Lib.Size = new System.Drawing.Size(135, 26);
            this.txt_Stock_Lib.TabIndex = 7;
            // 
            // txt_Ed_Lib
            // 
            this.txt_Ed_Lib.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ed_Lib.Location = new System.Drawing.Point(371, 29);
            this.txt_Ed_Lib.Name = "txt_Ed_Lib";
            this.txt_Ed_Lib.Size = new System.Drawing.Size(135, 26);
            this.txt_Ed_Lib.TabIndex = 3;
            // 
            // txt_LNameAu_Lib
            // 
            this.txt_LNameAu_Lib.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LNameAu_Lib.Location = new System.Drawing.Point(371, 150);
            this.txt_LNameAu_Lib.Name = "txt_LNameAu_Lib";
            this.txt_LNameAu_Lib.Size = new System.Drawing.Size(135, 26);
            this.txt_LNameAu_Lib.TabIndex = 5;
            // 
            // txt_NameAutor_Lib
            // 
            this.txt_NameAutor_Lib.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NameAutor_Lib.Location = new System.Drawing.Point(371, 90);
            this.txt_NameAutor_Lib.Name = "txt_NameAutor_Lib";
            this.txt_NameAutor_Lib.Size = new System.Drawing.Size(135, 26);
            this.txt_NameAutor_Lib.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bdelete);
            this.tabPage2.Controls.Add(this.btn_Update_Est);
            this.tabPage2.Controls.Add(this.DGV_Estudiante);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.txt_Fac_Est);
            this.tabPage2.Controls.Add(this.txt_Correo_Est);
            this.tabPage2.Controls.Add(this.txt_LName_Est);
            this.tabPage2.Controls.Add(this.txt_Sector_Est);
            this.tabPage2.Controls.Add(this.txt_Cel_Est);
            this.tabPage2.Controls.Add(this.txt_Cod_Est);
            this.tabPage2.Controls.Add(this.txt_Name_Est);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(860, 529);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Estudiante";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_Update_Est
            // 
            this.btn_Update_Est.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_Est.Location = new System.Drawing.Point(274, 187);
            this.btn_Update_Est.Name = "btn_Update_Est";
            this.btn_Update_Est.Size = new System.Drawing.Size(131, 31);
            this.btn_Update_Est.TabIndex = 39;
            this.btn_Update_Est.Text = "Update";
            this.btn_Update_Est.UseVisualStyleBackColor = true;
            this.btn_Update_Est.Click += new System.EventHandler(this.btn_Update_Est_Click);
            // 
            // DGV_Estudiante
            // 
            this.DGV_Estudiante.AllowUserToAddRows = false;
            this.DGV_Estudiante.AllowUserToDeleteRows = false;
            this.DGV_Estudiante.AllowUserToOrderColumns = true;
            this.DGV_Estudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Estudiante.Location = new System.Drawing.Point(13, 233);
            this.DGV_Estudiante.Name = "DGV_Estudiante";
            this.DGV_Estudiante.ReadOnly = true;
            this.DGV_Estudiante.Size = new System.Drawing.Size(838, 274);
            this.DGV_Estudiante.TabIndex = 38;
            this.DGV_Estudiante.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Estudiante_CellClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(561, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 19);
            this.label11.TabIndex = 36;
            this.label11.Text = "Correo:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(543, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 19);
            this.label12.TabIndex = 35;
            this.label12.Text = "Facultad:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(290, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 19);
            this.label13.TabIndex = 34;
            this.label13.Text = "Sector:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(281, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 19);
            this.label14.TabIndex = 33;
            this.label14.Text = "Celular:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(27, 134);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 19);
            this.label15.TabIndex = 32;
            this.label15.Text = "Apellido:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(42, 78);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 19);
            this.label17.TabIndex = 30;
            this.label17.Text = "Nombre:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(42, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 19);
            this.label18.TabIndex = 29;
            this.label18.Text = "Codigo:";
            // 
            // txt_Fac_Est
            // 
            this.txt_Fac_Est.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Fac_Est.Location = new System.Drawing.Point(639, 22);
            this.txt_Fac_Est.Name = "txt_Fac_Est";
            this.txt_Fac_Est.Size = new System.Drawing.Size(135, 26);
            this.txt_Fac_Est.TabIndex = 26;
            // 
            // txt_Correo_Est
            // 
            this.txt_Correo_Est.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Correo_Est.Location = new System.Drawing.Point(639, 75);
            this.txt_Correo_Est.Name = "txt_Correo_Est";
            this.txt_Correo_Est.Size = new System.Drawing.Size(135, 26);
            this.txt_Correo_Est.TabIndex = 27;
            // 
            // txt_LName_Est
            // 
            this.txt_LName_Est.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LName_Est.Location = new System.Drawing.Point(123, 131);
            this.txt_LName_Est.Name = "txt_LName_Est";
            this.txt_LName_Est.Size = new System.Drawing.Size(135, 26);
            this.txt_LName_Est.TabIndex = 23;
            // 
            // txt_Sector_Est
            // 
            this.txt_Sector_Est.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Sector_Est.Location = new System.Drawing.Point(368, 75);
            this.txt_Sector_Est.Name = "txt_Sector_Est";
            this.txt_Sector_Est.Size = new System.Drawing.Size(135, 26);
            this.txt_Sector_Est.TabIndex = 25;
            // 
            // txt_Cel_Est
            // 
            this.txt_Cel_Est.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cel_Est.Location = new System.Drawing.Point(368, 22);
            this.txt_Cel_Est.Name = "txt_Cel_Est";
            this.txt_Cel_Est.Size = new System.Drawing.Size(135, 26);
            this.txt_Cel_Est.TabIndex = 24;
            // 
            // txt_Cod_Est
            // 
            this.txt_Cod_Est.Enabled = false;
            this.txt_Cod_Est.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cod_Est.Location = new System.Drawing.Point(123, 22);
            this.txt_Cod_Est.Name = "txt_Cod_Est";
            this.txt_Cod_Est.Size = new System.Drawing.Size(135, 26);
            this.txt_Cod_Est.TabIndex = 20;
            // 
            // txt_Name_Est
            // 
            this.txt_Name_Est.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name_Est.Location = new System.Drawing.Point(123, 75);
            this.txt_Name_Est.Name = "txt_Name_Est";
            this.txt_Name_Est.Size = new System.Drawing.Size(135, 26);
            this.txt_Name_Est.TabIndex = 21;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.bdeletePrestamo);
            this.tabPage3.Controls.Add(this.btn_Update_Prest);
            this.tabPage3.Controls.Add(this.DGV_Prestamo);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.label23);
            this.tabPage3.Controls.Add(this.label24);
            this.tabPage3.Controls.Add(this.label26);
            this.tabPage3.Controls.Add(this.label27);
            this.tabPage3.Controls.Add(this.txt_FechaInicio_Prest);
            this.tabPage3.Controls.Add(this.txt_CodEst_Prest);
            this.tabPage3.Controls.Add(this.txt_FechaFin_Prest);
            this.tabPage3.Controls.Add(this.txt_Cod_Prest);
            this.tabPage3.Controls.Add(this.txt_CodLib_Prest);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(860, 529);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Prestamo";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_Update_Prest
            // 
            this.btn_Update_Prest.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_Prest.Location = new System.Drawing.Point(286, 185);
            this.btn_Update_Prest.Name = "btn_Update_Prest";
            this.btn_Update_Prest.Size = new System.Drawing.Size(131, 31);
            this.btn_Update_Prest.TabIndex = 39;
            this.btn_Update_Prest.Text = "Update";
            this.btn_Update_Prest.UseVisualStyleBackColor = true;
            this.btn_Update_Prest.Click += new System.EventHandler(this.btn_Update_Prest_Click);
            // 
            // DGV_Prestamo
            // 
            this.DGV_Prestamo.AllowUserToAddRows = false;
            this.DGV_Prestamo.AllowUserToDeleteRows = false;
            this.DGV_Prestamo.AllowUserToOrderColumns = true;
            this.DGV_Prestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Prestamo.Location = new System.Drawing.Point(13, 233);
            this.DGV_Prestamo.Name = "DGV_Prestamo";
            this.DGV_Prestamo.ReadOnly = true;
            this.DGV_Prestamo.Size = new System.Drawing.Size(838, 274);
            this.DGV_Prestamo.TabIndex = 38;
            this.DGV_Prestamo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Prestamo_CellClick);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(611, 86);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(99, 19);
            this.label21.TabIndex = 35;
            this.label21.Text = "Fecha Fin:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(584, 25);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(126, 19);
            this.label23.TabIndex = 33;
            this.label23.Text = "Fecha inicio:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(264, 25);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(153, 19);
            this.label24.TabIndex = 32;
            this.label24.Text = "Cod. Estudiante:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(9, 86);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(108, 19);
            this.label26.TabIndex = 30;
            this.label26.Text = "Cod. Libro:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(42, 25);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(72, 19);
            this.label27.TabIndex = 29;
            this.label27.Text = "Codigo:";
            // 
            // txt_FechaInicio_Prest
            // 
            this.txt_FechaInicio_Prest.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FechaInicio_Prest.Location = new System.Drawing.Point(716, 22);
            this.txt_FechaInicio_Prest.Name = "txt_FechaInicio_Prest";
            this.txt_FechaInicio_Prest.Size = new System.Drawing.Size(135, 26);
            this.txt_FechaInicio_Prest.TabIndex = 26;
            // 
            // txt_CodEst_Prest
            // 
            this.txt_CodEst_Prest.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CodEst_Prest.Location = new System.Drawing.Point(423, 22);
            this.txt_CodEst_Prest.Name = "txt_CodEst_Prest";
            this.txt_CodEst_Prest.Size = new System.Drawing.Size(135, 26);
            this.txt_CodEst_Prest.TabIndex = 23;
            // 
            // txt_FechaFin_Prest
            // 
            this.txt_FechaFin_Prest.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FechaFin_Prest.Location = new System.Drawing.Point(716, 83);
            this.txt_FechaFin_Prest.Name = "txt_FechaFin_Prest";
            this.txt_FechaFin_Prest.Size = new System.Drawing.Size(135, 26);
            this.txt_FechaFin_Prest.TabIndex = 24;
            // 
            // txt_Cod_Prest
            // 
            this.txt_Cod_Prest.Enabled = false;
            this.txt_Cod_Prest.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cod_Prest.Location = new System.Drawing.Point(123, 22);
            this.txt_Cod_Prest.Name = "txt_Cod_Prest";
            this.txt_Cod_Prest.Size = new System.Drawing.Size(135, 26);
            this.txt_Cod_Prest.TabIndex = 20;
            // 
            // txt_CodLib_Prest
            // 
            this.txt_CodLib_Prest.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CodLib_Prest.Location = new System.Drawing.Point(123, 79);
            this.txt_CodLib_Prest.Name = "txt_CodLib_Prest";
            this.txt_CodLib_Prest.Size = new System.Drawing.Size(135, 26);
            this.txt_CodLib_Prest.TabIndex = 21;
            // 
            // bdelete_libro
            // 
            this.bdelete_libro.Location = new System.Drawing.Point(431, 203);
            this.bdelete_libro.Name = "bdelete_libro";
            this.bdelete_libro.Size = new System.Drawing.Size(103, 31);
            this.bdelete_libro.TabIndex = 20;
            this.bdelete_libro.Text = "Delete";
            this.bdelete_libro.UseVisualStyleBackColor = true;
            this.bdelete_libro.Click += new System.EventHandler(this.bdelete_libro_Click);
            // 
            // bdelete
            // 
            this.bdelete.Location = new System.Drawing.Point(435, 188);
            this.bdelete.Name = "bdelete";
            this.bdelete.Size = new System.Drawing.Size(103, 31);
            this.bdelete.TabIndex = 40;
            this.bdelete.Text = "Delete";
            this.bdelete.UseVisualStyleBackColor = true;
            this.bdelete.Click += new System.EventHandler(this.bdelete_Click);
            // 
            // bdeletePrestamo
            // 
            this.bdeletePrestamo.Location = new System.Drawing.Point(455, 186);
            this.bdeletePrestamo.Name = "bdeletePrestamo";
            this.bdeletePrestamo.Size = new System.Drawing.Size(103, 31);
            this.bdeletePrestamo.TabIndex = 40;
            this.bdeletePrestamo.Text = "Delete";
            this.bdeletePrestamo.UseVisualStyleBackColor = true;
            this.bdeletePrestamo.Click += new System.EventHandler(this.bdeletePrestamo_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 567);
            this.Controls.Add(this.t);
            this.Name = "UpdateForm";
            this.Text = "Update";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.t.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Libro)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Estudiante)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Prestamo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Cod_Lib;
        private System.Windows.Forms.TextBox txt_Name_Lib;
        private System.Windows.Forms.TextBox txt_PubDate_Lib;
        private System.Windows.Forms.TabControl t;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Cat_Lib;
        private System.Windows.Forms.TextBox txt_Disp_Lib;
        private System.Windows.Forms.TextBox txt_Stock_Lib;
        private System.Windows.Forms.TextBox txt_Ed_Lib;
        private System.Windows.Forms.TextBox txt_LNameAu_Lib;
        private System.Windows.Forms.TextBox txt_NameAutor_Lib;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGV_Libro;
        private System.Windows.Forms.Button btn_Update_Lib;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_Update_Est;
        private System.Windows.Forms.DataGridView DGV_Estudiante;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_Fac_Est;
        private System.Windows.Forms.TextBox txt_Correo_Est;
        private System.Windows.Forms.TextBox txt_LName_Est;
        private System.Windows.Forms.TextBox txt_Sector_Est;
        private System.Windows.Forms.TextBox txt_Cel_Est;
        private System.Windows.Forms.TextBox txt_Cod_Est;
        private System.Windows.Forms.TextBox txt_Name_Est;
        private System.Windows.Forms.Button btn_Update_Prest;
        private System.Windows.Forms.DataGridView DGV_Prestamo;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txt_FechaInicio_Prest;
        private System.Windows.Forms.TextBox txt_CodEst_Prest;
        private System.Windows.Forms.TextBox txt_FechaFin_Prest;
        private System.Windows.Forms.TextBox txt_Cod_Prest;
        private System.Windows.Forms.TextBox txt_CodLib_Prest;
        private System.Windows.Forms.Button bdelete_libro;
        private System.Windows.Forms.Button bdelete;
        private System.Windows.Forms.Button bdeletePrestamo;
    }
}

