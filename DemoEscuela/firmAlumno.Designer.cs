namespace DemoEscuela
{
    partial class firmAlumno
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
            this.idAlumno = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.ApellidoPaterno = new System.Windows.Forms.Label();
            this.ApellidoMaterno = new System.Windows.Forms.Label();
            this.textBoxIdAlumno = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellidoPaterno = new System.Windows.Forms.TextBox();
            this.textBoxApellidoMaterno = new System.Windows.Forms.TextBox();
            this.pictureBoxFotografia = new System.Windows.Forms.PictureBox();
            this.Examinar = new System.Windows.Forms.Button();
            this.textBoxRutaImagen = new System.Windows.Forms.TextBox();
            this.Fotografia = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotografia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // idAlumno
            // 
            this.idAlumno.AutoSize = true;
            this.idAlumno.Location = new System.Drawing.Point(45, 30);
            this.idAlumno.Name = "idAlumno";
            this.idAlumno.Size = new System.Drawing.Size(53, 13);
            this.idAlumno.TabIndex = 0;
            this.idAlumno.Text = "idAlumno:";
            this.idAlumno.Click += new System.EventHandler(this.idAlumno_Click);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(45, 70);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(47, 13);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Nombre:";
            this.Nombre.Click += new System.EventHandler(this.Nombre_Click);
            // 
            // ApellidoPaterno
            // 
            this.ApellidoPaterno.AutoSize = true;
            this.ApellidoPaterno.Location = new System.Drawing.Point(11, 106);
            this.ApellidoPaterno.Name = "ApellidoPaterno";
            this.ApellidoPaterno.Size = new System.Drawing.Size(87, 13);
            this.ApellidoPaterno.TabIndex = 0;
            this.ApellidoPaterno.Text = "Apellido Paterno:";
            this.ApellidoPaterno.Click += new System.EventHandler(this.label3_Click);
            // 
            // ApellidoMaterno
            // 
            this.ApellidoMaterno.AutoSize = true;
            this.ApellidoMaterno.Location = new System.Drawing.Point(3, 147);
            this.ApellidoMaterno.Name = "ApellidoMaterno";
            this.ApellidoMaterno.Size = new System.Drawing.Size(89, 13);
            this.ApellidoMaterno.TabIndex = 0;
            this.ApellidoMaterno.Text = "Apellido Materno:";
            this.ApellidoMaterno.Click += new System.EventHandler(this.ApellidoMaterno_Click);
            // 
            // textBoxIdAlumno
            // 
            this.textBoxIdAlumno.Location = new System.Drawing.Point(104, 30);
            this.textBoxIdAlumno.Name = "textBoxIdAlumno";
            this.textBoxIdAlumno.Size = new System.Drawing.Size(148, 20);
            this.textBoxIdAlumno.TabIndex = 1;
            this.textBoxIdAlumno.TextChanged += new System.EventHandler(this.textBoxIdAlumno_TextChanged);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(104, 70);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(148, 20);
            this.textBoxNombre.TabIndex = 1;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // textBoxApellidoPaterno
            // 
            this.textBoxApellidoPaterno.Location = new System.Drawing.Point(104, 106);
            this.textBoxApellidoPaterno.Name = "textBoxApellidoPaterno";
            this.textBoxApellidoPaterno.Size = new System.Drawing.Size(148, 20);
            this.textBoxApellidoPaterno.TabIndex = 1;
            this.textBoxApellidoPaterno.TextChanged += new System.EventHandler(this.textBoxApellidoPaterno_TextChanged);
            // 
            // textBoxApellidoMaterno
            // 
            this.textBoxApellidoMaterno.Location = new System.Drawing.Point(104, 147);
            this.textBoxApellidoMaterno.Name = "textBoxApellidoMaterno";
            this.textBoxApellidoMaterno.Size = new System.Drawing.Size(148, 20);
            this.textBoxApellidoMaterno.TabIndex = 1;
            this.textBoxApellidoMaterno.TextChanged += new System.EventHandler(this.textBoxApellidoMaterno_TextChanged);
            // 
            // pictureBoxFotografia
            // 
            this.pictureBoxFotografia.Location = new System.Drawing.Point(275, 32);
            this.pictureBoxFotografia.Name = "pictureBoxFotografia";
            this.pictureBoxFotografia.Size = new System.Drawing.Size(194, 134);
            this.pictureBoxFotografia.TabIndex = 2;
            this.pictureBoxFotografia.TabStop = false;
            // 
            // Examinar
            // 
            this.Examinar.Location = new System.Drawing.Point(273, 183);
            this.Examinar.Name = "Examinar";
            this.Examinar.Size = new System.Drawing.Size(194, 20);
            this.Examinar.TabIndex = 4;
            this.Examinar.Text = "Examinar";
            this.Examinar.UseVisualStyleBackColor = true;
            this.Examinar.Click += new System.EventHandler(this.Examinar_Click);
            // 
            // textBoxRutaImagen
            // 
            this.textBoxRutaImagen.Location = new System.Drawing.Point(104, 183);
            this.textBoxRutaImagen.Name = "textBoxRutaImagen";
            this.textBoxRutaImagen.Size = new System.Drawing.Size(148, 20);
            this.textBoxRutaImagen.TabIndex = 3;
            // 
            // Fotografia
            // 
            this.Fotografia.AutoSize = true;
            this.Fotografia.Location = new System.Drawing.Point(33, 186);
            this.Fotografia.Name = "Fotografia";
            this.Fotografia.Size = new System.Drawing.Size(59, 13);
            this.Fotografia.TabIndex = 5;
            this.Fotografia.Text = "Fotografía:";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(39, 234);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(74, 23);
            this.buttonAgregar.TabIndex = 6;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(120, 234);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(74, 23);
            this.buttonEliminar.TabIndex = 6;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(275, 3);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(192, 23);
            this.buttonBuscar.TabIndex = 6;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(209, 234);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(74, 23);
            this.buttonActualizar.TabIndex = 6;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(5, 286);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(493, 164);
            this.dgvDatos.TabIndex = 7;
            // 
            // firmAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 462);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.Fotografia);
            this.Controls.Add(this.Examinar);
            this.Controls.Add(this.textBoxRutaImagen);
            this.Controls.Add(this.pictureBoxFotografia);
            this.Controls.Add(this.textBoxApellidoMaterno);
            this.Controls.Add(this.textBoxApellidoPaterno);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxIdAlumno);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.ApellidoMaterno);
            this.Controls.Add(this.ApellidoPaterno);
            this.Controls.Add(this.idAlumno);
            this.Name = "firmAlumno";
            this.Text = "Alumno";
            this.Load += new System.EventHandler(this.firmAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotografia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idAlumno;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label ApellidoPaterno;
        private System.Windows.Forms.Label ApellidoMaterno;
        private System.Windows.Forms.TextBox textBoxIdAlumno;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellidoPaterno;
        private System.Windows.Forms.TextBox textBoxApellidoMaterno;
        private System.Windows.Forms.PictureBox pictureBoxFotografia;
        private System.Windows.Forms.Button Examinar;
        private System.Windows.Forms.TextBox textBoxRutaImagen;
        private System.Windows.Forms.Label Fotografia;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.DataGridView dgvDatos;
    }
}

