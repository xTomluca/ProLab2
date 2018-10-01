namespace VistaForm
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
            this.cmbDivisionCurso = new System.Windows.Forms.ComboBox();
            this.cmbDivison = new System.Windows.Forms.ComboBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.nudAnioCurso = new System.Windows.Forms.DomainUpDown();
            this.nudAnio = new System.Windows.Forms.DomainUpDown();
            this.txtNombreProfe = new System.Windows.Forms.TextBox();
            this.txtApellidoProfe = new System.Windows.Forms.TextBox();
            this.txtDocumentoProfe = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.rtbDatos = new System.Windows.Forms.RichTextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblDivision = new System.Windows.Forms.Label();
            this.lblDocumentoProfe = new System.Windows.Forms.Label();
            this.lblApellidoProfe = new System.Windows.Forms.Label();
            this.lblNombreProfe = new System.Windows.Forms.Label();
            this.lblDivisionCurso = new System.Windows.Forms.Label();
            this.lblAnioCurso = new System.Windows.Forms.Label();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.gpbDatosAlumno = new System.Windows.Forms.GroupBox();
            this.gpbDatosCurso = new System.Windows.Forms.GroupBox();
            this.gpbDatosAlumno.SuspendLayout();
            this.gpbDatosCurso.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbDivisionCurso
            // 
            this.cmbDivisionCurso.FormattingEnabled = true;
            this.cmbDivisionCurso.Location = new System.Drawing.Point(64, 84);
            this.cmbDivisionCurso.Name = "cmbDivisionCurso";
            this.cmbDivisionCurso.Size = new System.Drawing.Size(150, 21);
            this.cmbDivisionCurso.TabIndex = 0;
            // 
            // cmbDivison
            // 
            this.cmbDivison.FormattingEnabled = true;
            this.cmbDivison.Location = new System.Drawing.Point(401, 188);
            this.cmbDivison.Name = "cmbDivison";
            this.cmbDivison.Size = new System.Drawing.Size(121, 21);
            this.cmbDivison.TabIndex = 1;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(65, 264);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(97, 36);
            this.btnCrear.TabIndex = 2;
            this.btnCrear.Text = "Crear Curso";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(213, 252);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(87, 36);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(216, 257);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(88, 36);
            this.btnMostrar.TabIndex = 4;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // nudAnioCurso
            // 
            this.nudAnioCurso.Items.Add("1");
            this.nudAnioCurso.Items.Add("2");
            this.nudAnioCurso.Items.Add("3");
            this.nudAnioCurso.Items.Add("4");
            this.nudAnioCurso.Items.Add("5");
            this.nudAnioCurso.Items.Add("6");
            this.nudAnioCurso.Location = new System.Drawing.Point(65, 49);
            this.nudAnioCurso.Name = "nudAnioCurso";
            this.nudAnioCurso.Size = new System.Drawing.Size(149, 20);
            this.nudAnioCurso.TabIndex = 5;
            this.nudAnioCurso.Text = "domainUpDown1";
            // 
            // nudAnio
            // 
            this.nudAnio.Items.Add("1");
            this.nudAnio.Items.Add("2");
            this.nudAnio.Items.Add("3");
            this.nudAnio.Items.Add("4");
            this.nudAnio.Items.Add("5");
            this.nudAnio.Items.Add("6");
            this.nudAnio.Location = new System.Drawing.Point(402, 158);
            this.nudAnio.Name = "nudAnio";
            this.nudAnio.Size = new System.Drawing.Size(120, 20);
            this.nudAnio.TabIndex = 6;
            this.nudAnio.Text = "domainUpDown2";
            // 
            // txtNombreProfe
            // 
            this.txtNombreProfe.Location = new System.Drawing.Point(62, 111);
            this.txtNombreProfe.Name = "txtNombreProfe";
            this.txtNombreProfe.Size = new System.Drawing.Size(243, 20);
            this.txtNombreProfe.TabIndex = 7;
            // 
            // txtApellidoProfe
            // 
            this.txtApellidoProfe.Location = new System.Drawing.Point(64, 159);
            this.txtApellidoProfe.Name = "txtApellidoProfe";
            this.txtApellidoProfe.Size = new System.Drawing.Size(243, 20);
            this.txtApellidoProfe.TabIndex = 8;
            // 
            // txtDocumentoProfe
            // 
            this.txtDocumentoProfe.Location = new System.Drawing.Point(64, 190);
            this.txtDocumentoProfe.Name = "txtDocumentoProfe";
            this.txtDocumentoProfe.Size = new System.Drawing.Size(243, 20);
            this.txtDocumentoProfe.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(402, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(237, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(402, 83);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(237, 20);
            this.txtApellido.TabIndex = 11;
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(402, 122);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(237, 20);
            this.txtLegajo.TabIndex = 12;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Location = new System.Drawing.Point(64, 226);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(243, 20);
            this.dtpFechaIngreso.TabIndex = 16;
            // 
            // rtbDatos
            // 
            this.rtbDatos.Location = new System.Drawing.Point(41, 317);
            this.rtbDatos.Name = "rtbDatos";
            this.rtbDatos.Size = new System.Drawing.Size(554, 146);
            this.rtbDatos.TabIndex = 17;
            this.rtbDatos.Text = "";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(346, 51);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(346, 86);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 19;
            this.lblApellido.Text = "Apellido";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(346, 125);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(39, 13);
            this.lblLegajo.TabIndex = 20;
            this.lblLegajo.Text = "Legajo";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(346, 160);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(26, 13);
            this.lblAnio.TabIndex = 21;
            this.lblAnio.Text = "Año";
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(346, 196);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(42, 13);
            this.lblDivision.TabIndex = 22;
            this.lblDivision.Text = "Divison";
            // 
            // lblDocumentoProfe
            // 
            this.lblDocumentoProfe.AutoSize = true;
            this.lblDocumentoProfe.Location = new System.Drawing.Point(12, 197);
            this.lblDocumentoProfe.Name = "lblDocumentoProfe";
            this.lblDocumentoProfe.Size = new System.Drawing.Size(26, 13);
            this.lblDocumentoProfe.TabIndex = 27;
            this.lblDocumentoProfe.Text = "DNI";
            // 
            // lblApellidoProfe
            // 
            this.lblApellidoProfe.AutoSize = true;
            this.lblApellidoProfe.Location = new System.Drawing.Point(12, 161);
            this.lblApellidoProfe.Name = "lblApellidoProfe";
            this.lblApellidoProfe.Size = new System.Drawing.Size(44, 13);
            this.lblApellidoProfe.TabIndex = 26;
            this.lblApellidoProfe.Text = "Apellido";
            // 
            // lblNombreProfe
            // 
            this.lblNombreProfe.AutoSize = true;
            this.lblNombreProfe.Location = new System.Drawing.Point(12, 126);
            this.lblNombreProfe.Name = "lblNombreProfe";
            this.lblNombreProfe.Size = new System.Drawing.Size(44, 13);
            this.lblNombreProfe.TabIndex = 25;
            this.lblNombreProfe.Text = "Nombre";
            // 
            // lblDivisionCurso
            // 
            this.lblDivisionCurso.AutoSize = true;
            this.lblDivisionCurso.Location = new System.Drawing.Point(12, 87);
            this.lblDivisionCurso.Name = "lblDivisionCurso";
            this.lblDivisionCurso.Size = new System.Drawing.Size(44, 13);
            this.lblDivisionCurso.TabIndex = 24;
            this.lblDivisionCurso.Text = "Division";
            // 
            // lblAnioCurso
            // 
            this.lblAnioCurso.AutoSize = true;
            this.lblAnioCurso.Location = new System.Drawing.Point(12, 52);
            this.lblAnioCurso.Name = "lblAnioCurso";
            this.lblAnioCurso.Size = new System.Drawing.Size(26, 13);
            this.lblAnioCurso.TabIndex = 23;
            this.lblAnioCurso.Text = "Año";
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(12, 233);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(42, 13);
            this.lblFechaIngreso.TabIndex = 28;
            this.lblFechaIngreso.Text = "Ingreso";
            // 
            // gpbDatosAlumno
            // 
            this.gpbDatosAlumno.Controls.Add(this.btnAgregar);
            this.gpbDatosAlumno.Location = new System.Drawing.Point(339, 12);
            this.gpbDatosAlumno.Name = "gpbDatosAlumno";
            this.gpbDatosAlumno.Size = new System.Drawing.Size(309, 299);
            this.gpbDatosAlumno.TabIndex = 29;
            this.gpbDatosAlumno.TabStop = false;
            this.gpbDatosAlumno.Text = "Datos Alumno";
            // 
            // gpbDatosCurso
            // 
            this.gpbDatosCurso.Controls.Add(this.btnMostrar);
            this.gpbDatosCurso.Controls.Add(this.txtNombreProfe);
            this.gpbDatosCurso.Location = new System.Drawing.Point(3, 12);
            this.gpbDatosCurso.Name = "gpbDatosCurso";
            this.gpbDatosCurso.Size = new System.Drawing.Size(318, 299);
            this.gpbDatosCurso.TabIndex = 30;
            this.gpbDatosCurso.TabStop = false;
            this.gpbDatosCurso.Text = "Datos Curso";
            this.gpbDatosCurso.Enter += new System.EventHandler(this.gpbDatosCurso_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 475);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.lblDocumentoProfe);
            this.Controls.Add(this.lblApellidoProfe);
            this.Controls.Add(this.lblNombreProfe);
            this.Controls.Add(this.lblDivisionCurso);
            this.Controls.Add(this.lblAnioCurso);
            this.Controls.Add(this.lblDivision);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.rtbDatos);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDocumentoProfe);
            this.Controls.Add(this.txtApellidoProfe);
            this.Controls.Add(this.nudAnio);
            this.Controls.Add(this.nudAnioCurso);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.cmbDivison);
            this.Controls.Add(this.cmbDivisionCurso);
            this.Controls.Add(this.gpbDatosAlumno);
            this.Controls.Add(this.gpbDatosCurso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbDatosAlumno.ResumeLayout(false);
            this.gpbDatosCurso.ResumeLayout(false);
            this.gpbDatosCurso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDivisionCurso;
        private System.Windows.Forms.ComboBox cmbDivison;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DomainUpDown nudAnioCurso;
        private System.Windows.Forms.DomainUpDown nudAnio;
        private System.Windows.Forms.TextBox txtNombreProfe;
        private System.Windows.Forms.TextBox txtApellidoProfe;
        private System.Windows.Forms.TextBox txtDocumentoProfe;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.RichTextBox rtbDatos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.Label lblDocumentoProfe;
        private System.Windows.Forms.Label lblApellidoProfe;
        private System.Windows.Forms.Label lblNombreProfe;
        private System.Windows.Forms.Label lblDivisionCurso;
        private System.Windows.Forms.Label lblAnioCurso;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.GroupBox gpbDatosAlumno;
        private System.Windows.Forms.GroupBox gpbDatosCurso;
    }
}

