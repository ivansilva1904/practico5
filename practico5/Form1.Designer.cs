namespace practico5
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TXB_FOTO = new System.Windows.Forms.TextBox();
            this.BUT_FOTO = new System.Windows.Forms.Button();
            this.BUT_GUARDAR = new System.Windows.Forms.Button();
            this.TXB_SALDO = new System.Windows.Forms.TextBox();
            this.RBUT_MUJER = new System.Windows.Forms.RadioButton();
            this.RBUT_HOMBRE = new System.Windows.Forms.RadioButton();
            this.DATEPICK_FECNAC = new System.Windows.Forms.DateTimePicker();
            this.TXB_APELLIDO = new System.Windows.Forms.TextBox();
            this.TXB_NOMBRE = new System.Windows.Forms.TextBox();
            this.LAB_SALDO = new System.Windows.Forms.Label();
            this.LAB_SEXO = new System.Windows.Forms.Label();
            this.LAB_FECNAC = new System.Windows.Forms.Label();
            this.LAB_APELLIDO = new System.Windows.Forms.Label();
            this.LAB_NOMBRE = new System.Windows.Forms.Label();
            this.PICBOX_FOTO = new System.Windows.Forms.PictureBox();
            this.DGV_EMPLEADO = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.OPFD_FOTO = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICBOX_FOTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_EMPLEADO)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImage = global::practico5.Properties.Resources._455056;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.TXB_FOTO);
            this.panel1.Controls.Add(this.BUT_FOTO);
            this.panel1.Controls.Add(this.BUT_GUARDAR);
            this.panel1.Controls.Add(this.TXB_SALDO);
            this.panel1.Controls.Add(this.RBUT_MUJER);
            this.panel1.Controls.Add(this.RBUT_HOMBRE);
            this.panel1.Controls.Add(this.DATEPICK_FECNAC);
            this.panel1.Controls.Add(this.TXB_APELLIDO);
            this.panel1.Controls.Add(this.TXB_NOMBRE);
            this.panel1.Controls.Add(this.LAB_SALDO);
            this.panel1.Controls.Add(this.LAB_SEXO);
            this.panel1.Controls.Add(this.LAB_FECNAC);
            this.panel1.Controls.Add(this.LAB_APELLIDO);
            this.panel1.Controls.Add(this.LAB_NOMBRE);
            this.panel1.Location = new System.Drawing.Point(34, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 307);
            this.panel1.TabIndex = 0;
            // 
            // TXB_FOTO
            // 
            this.TXB_FOTO.Location = new System.Drawing.Point(32, 254);
            this.TXB_FOTO.Name = "TXB_FOTO";
            this.TXB_FOTO.ReadOnly = true;
            this.TXB_FOTO.Size = new System.Drawing.Size(176, 22);
            this.TXB_FOTO.TabIndex = 13;
            // 
            // BUT_FOTO
            // 
            this.BUT_FOTO.BackColor = System.Drawing.SystemColors.Control;
            this.BUT_FOTO.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BUT_FOTO.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUT_FOTO.Location = new System.Drawing.Point(86, 227);
            this.BUT_FOTO.Name = "BUT_FOTO";
            this.BUT_FOTO.Size = new System.Drawing.Size(69, 22);
            this.BUT_FOTO.TabIndex = 12;
            this.BUT_FOTO.Text = "Foto";
            this.BUT_FOTO.UseVisualStyleBackColor = false;
            this.BUT_FOTO.Click += new System.EventHandler(this.BUT_FOTO_Click);
            // 
            // BUT_GUARDAR
            // 
            this.BUT_GUARDAR.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUT_GUARDAR.Image = global::practico5.Properties.Resources.guardar2;
            this.BUT_GUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BUT_GUARDAR.Location = new System.Drawing.Point(240, 227);
            this.BUT_GUARDAR.Name = "BUT_GUARDAR";
            this.BUT_GUARDAR.Size = new System.Drawing.Size(100, 50);
            this.BUT_GUARDAR.TabIndex = 11;
            this.BUT_GUARDAR.Text = "Guardar";
            this.BUT_GUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BUT_GUARDAR.UseVisualStyleBackColor = true;
            this.BUT_GUARDAR.Click += new System.EventHandler(this.BUT_GUARDAR_Click);
            // 
            // TXB_SALDO
            // 
            this.TXB_SALDO.Location = new System.Drawing.Point(168, 171);
            this.TXB_SALDO.Name = "TXB_SALDO";
            this.TXB_SALDO.Size = new System.Drawing.Size(172, 22);
            this.TXB_SALDO.TabIndex = 10;
            this.TXB_SALDO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXB_SALDO_KeyPress);
            // 
            // RBUT_MUJER
            // 
            this.RBUT_MUJER.AutoSize = true;
            this.RBUT_MUJER.BackColor = System.Drawing.Color.Transparent;
            this.RBUT_MUJER.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBUT_MUJER.Location = new System.Drawing.Point(286, 140);
            this.RBUT_MUJER.Name = "RBUT_MUJER";
            this.RBUT_MUJER.Size = new System.Drawing.Size(54, 17);
            this.RBUT_MUJER.TabIndex = 9;
            this.RBUT_MUJER.TabStop = true;
            this.RBUT_MUJER.Text = "Mujer";
            this.RBUT_MUJER.UseVisualStyleBackColor = false;
            // 
            // RBUT_HOMBRE
            // 
            this.RBUT_HOMBRE.AutoSize = true;
            this.RBUT_HOMBRE.BackColor = System.Drawing.Color.Transparent;
            this.RBUT_HOMBRE.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBUT_HOMBRE.Location = new System.Drawing.Point(168, 140);
            this.RBUT_HOMBRE.Name = "RBUT_HOMBRE";
            this.RBUT_HOMBRE.Size = new System.Drawing.Size(64, 17);
            this.RBUT_HOMBRE.TabIndex = 8;
            this.RBUT_HOMBRE.TabStop = true;
            this.RBUT_HOMBRE.Text = "Hombre";
            this.RBUT_HOMBRE.UseVisualStyleBackColor = false;
            // 
            // DATEPICK_FECNAC
            // 
            this.DATEPICK_FECNAC.CalendarFont = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DATEPICK_FECNAC.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DATEPICK_FECNAC.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DATEPICK_FECNAC.Location = new System.Drawing.Point(265, 98);
            this.DATEPICK_FECNAC.Name = "DATEPICK_FECNAC";
            this.DATEPICK_FECNAC.Size = new System.Drawing.Size(75, 22);
            this.DATEPICK_FECNAC.TabIndex = 7;
            // 
            // TXB_APELLIDO
            // 
            this.TXB_APELLIDO.Location = new System.Drawing.Point(168, 58);
            this.TXB_APELLIDO.Name = "TXB_APELLIDO";
            this.TXB_APELLIDO.Size = new System.Drawing.Size(172, 22);
            this.TXB_APELLIDO.TabIndex = 6;
            this.TXB_APELLIDO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXB_APELLIDO_KeyPress);
            // 
            // TXB_NOMBRE
            // 
            this.TXB_NOMBRE.Location = new System.Drawing.Point(168, 21);
            this.TXB_NOMBRE.Name = "TXB_NOMBRE";
            this.TXB_NOMBRE.Size = new System.Drawing.Size(172, 22);
            this.TXB_NOMBRE.TabIndex = 5;
            this.TXB_NOMBRE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXB_NOMBRE_KeyPress);
            // 
            // LAB_SALDO
            // 
            this.LAB_SALDO.AutoSize = true;
            this.LAB_SALDO.BackColor = System.Drawing.Color.Transparent;
            this.LAB_SALDO.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB_SALDO.Location = new System.Drawing.Point(27, 163);
            this.LAB_SALDO.Name = "LAB_SALDO";
            this.LAB_SALDO.Size = new System.Drawing.Size(64, 30);
            this.LAB_SALDO.TabIndex = 4;
            this.LAB_SALDO.Text = "Saldo";
            // 
            // LAB_SEXO
            // 
            this.LAB_SEXO.AutoSize = true;
            this.LAB_SEXO.BackColor = System.Drawing.Color.Transparent;
            this.LAB_SEXO.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB_SEXO.Location = new System.Drawing.Point(27, 127);
            this.LAB_SEXO.Name = "LAB_SEXO";
            this.LAB_SEXO.Size = new System.Drawing.Size(57, 30);
            this.LAB_SEXO.TabIndex = 3;
            this.LAB_SEXO.Text = "Sexo";
            // 
            // LAB_FECNAC
            // 
            this.LAB_FECNAC.AutoSize = true;
            this.LAB_FECNAC.BackColor = System.Drawing.Color.Transparent;
            this.LAB_FECNAC.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB_FECNAC.Location = new System.Drawing.Point(27, 91);
            this.LAB_FECNAC.Name = "LAB_FECNAC";
            this.LAB_FECNAC.Size = new System.Drawing.Size(204, 30);
            this.LAB_FECNAC.TabIndex = 2;
            this.LAB_FECNAC.Text = "Fecha de nacimiento";
            // 
            // LAB_APELLIDO
            // 
            this.LAB_APELLIDO.AutoSize = true;
            this.LAB_APELLIDO.BackColor = System.Drawing.Color.Transparent;
            this.LAB_APELLIDO.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB_APELLIDO.Location = new System.Drawing.Point(27, 50);
            this.LAB_APELLIDO.Name = "LAB_APELLIDO";
            this.LAB_APELLIDO.Size = new System.Drawing.Size(89, 30);
            this.LAB_APELLIDO.TabIndex = 1;
            this.LAB_APELLIDO.Text = "Apellido";
            // 
            // LAB_NOMBRE
            // 
            this.LAB_NOMBRE.AutoSize = true;
            this.LAB_NOMBRE.BackColor = System.Drawing.Color.Transparent;
            this.LAB_NOMBRE.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB_NOMBRE.Location = new System.Drawing.Point(27, 13);
            this.LAB_NOMBRE.Name = "LAB_NOMBRE";
            this.LAB_NOMBRE.Size = new System.Drawing.Size(89, 30);
            this.LAB_NOMBRE.TabIndex = 0;
            this.LAB_NOMBRE.Text = "Nombre";
            // 
            // PICBOX_FOTO
            // 
            this.PICBOX_FOTO.BackColor = System.Drawing.Color.Transparent;
            this.PICBOX_FOTO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PICBOX_FOTO.BackgroundImage")));
            this.PICBOX_FOTO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PICBOX_FOTO.Location = new System.Drawing.Point(475, 32);
            this.PICBOX_FOTO.Name = "PICBOX_FOTO";
            this.PICBOX_FOTO.Size = new System.Drawing.Size(380, 307);
            this.PICBOX_FOTO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PICBOX_FOTO.TabIndex = 1;
            this.PICBOX_FOTO.TabStop = false;
            // 
            // DGV_EMPLEADO
            // 
            this.DGV_EMPLEADO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_EMPLEADO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.Fecha_nacimiento,
            this.sexo,
            this.saldo,
            this.foto,
            this.ruta,
            this.eliminar});
            this.DGV_EMPLEADO.Location = new System.Drawing.Point(22, 371);
            this.DGV_EMPLEADO.Name = "DGV_EMPLEADO";
            this.DGV_EMPLEADO.Size = new System.Drawing.Size(843, 155);
            this.DGV_EMPLEADO.TabIndex = 2;
            this.DGV_EMPLEADO.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_EMPLEADO_CellClick);
            this.DGV_EMPLEADO.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_EMPLEADO_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Fecha_nacimiento
            // 
            this.Fecha_nacimiento.HeaderText = "Fecha nacimiento";
            this.Fecha_nacimiento.Name = "Fecha_nacimiento";
            this.Fecha_nacimiento.ReadOnly = true;
            // 
            // sexo
            // 
            this.sexo.HeaderText = "Sexo";
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            // 
            // saldo
            // 
            this.saldo.HeaderText = "Saldo";
            this.saldo.Name = "saldo";
            this.saldo.ReadOnly = true;
            // 
            // foto
            // 
            this.foto.HeaderText = "Foto";
            this.foto.Name = "foto";
            this.foto.ReadOnly = true;
            this.foto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.foto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ruta
            // 
            this.ruta.HeaderText = "Ruta";
            this.ruta.Name = "ruta";
            this.ruta.ReadOnly = true;
            // 
            // eliminar
            // 
            this.eliminar.HeaderText = "Eliminar";
            this.eliminar.Name = "eliminar";
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseColumnTextForButtonValue = true;
            // 
            // OPFD_FOTO
            // 
            this.OPFD_FOTO.FileOk += new System.ComponentModel.CancelEventHandler(this.OPFD_FOTO_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::practico5.Properties.Resources._10734569;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.DGV_EMPLEADO);
            this.Controls.Add(this.PICBOX_FOTO);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario con Datagrid";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICBOX_FOTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_EMPLEADO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LAB_SALDO;
        private System.Windows.Forms.Label LAB_SEXO;
        private System.Windows.Forms.Label LAB_FECNAC;
        private System.Windows.Forms.Label LAB_APELLIDO;
        private System.Windows.Forms.Label LAB_NOMBRE;
        private System.Windows.Forms.TextBox TXB_NOMBRE;
        private System.Windows.Forms.DateTimePicker DATEPICK_FECNAC;
        private System.Windows.Forms.TextBox TXB_APELLIDO;
        private System.Windows.Forms.RadioButton RBUT_MUJER;
        private System.Windows.Forms.RadioButton RBUT_HOMBRE;
        private System.Windows.Forms.TextBox TXB_SALDO;
        private System.Windows.Forms.Button BUT_GUARDAR;
        private System.Windows.Forms.Button BUT_FOTO;
        private System.Windows.Forms.PictureBox PICBOX_FOTO;
        private System.Windows.Forms.DataGridView DGV_EMPLEADO;
        private System.Windows.Forms.TextBox TXB_FOTO;
        private System.Windows.Forms.OpenFileDialog OPFD_FOTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo;
        private System.Windows.Forms.DataGridViewImageColumn foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruta;
        private System.Windows.Forms.DataGridViewButtonColumn eliminar;
    }
}

