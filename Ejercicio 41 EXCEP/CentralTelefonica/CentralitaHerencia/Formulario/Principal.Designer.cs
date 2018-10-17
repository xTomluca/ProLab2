namespace Formulario
{
    partial class Principal
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
            this.buttonGenerarLlamada = new System.Windows.Forms.Button();
            this.buttonFcTotal = new System.Windows.Forms.Button();
            this.buttonFcLocal = new System.Windows.Forms.Button();
            this.buttonFcProvincial = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGenerarLlamada
            // 
            this.buttonGenerarLlamada.Location = new System.Drawing.Point(59, 41);
            this.buttonGenerarLlamada.Name = "buttonGenerarLlamada";
            this.buttonGenerarLlamada.Size = new System.Drawing.Size(236, 38);
            this.buttonGenerarLlamada.TabIndex = 0;
            this.buttonGenerarLlamada.Text = "Generar Llamada";
            this.buttonGenerarLlamada.UseVisualStyleBackColor = true;
            this.buttonGenerarLlamada.Click += new System.EventHandler(this.buttonGenerarLlamada_Click);
            // 
            // buttonFcTotal
            // 
            this.buttonFcTotal.Location = new System.Drawing.Point(59, 114);
            this.buttonFcTotal.Name = "buttonFcTotal";
            this.buttonFcTotal.Size = new System.Drawing.Size(236, 38);
            this.buttonFcTotal.TabIndex = 1;
            this.buttonFcTotal.Text = "Facturacion Total";
            this.buttonFcTotal.UseVisualStyleBackColor = true;
            this.buttonFcTotal.Click += new System.EventHandler(this.buttonFcTotal_Click);
            // 
            // buttonFcLocal
            // 
            this.buttonFcLocal.Location = new System.Drawing.Point(59, 193);
            this.buttonFcLocal.Name = "buttonFcLocal";
            this.buttonFcLocal.Size = new System.Drawing.Size(236, 38);
            this.buttonFcLocal.TabIndex = 2;
            this.buttonFcLocal.Text = "Facturacion Local";
            this.buttonFcLocal.UseVisualStyleBackColor = true;
            this.buttonFcLocal.Click += new System.EventHandler(this.buttonFcLocal_Click);
            // 
            // buttonFcProvincial
            // 
            this.buttonFcProvincial.Location = new System.Drawing.Point(59, 266);
            this.buttonFcProvincial.Name = "buttonFcProvincial";
            this.buttonFcProvincial.Size = new System.Drawing.Size(236, 38);
            this.buttonFcProvincial.TabIndex = 3;
            this.buttonFcProvincial.Text = "Facturacion Provincial";
            this.buttonFcProvincial.UseVisualStyleBackColor = true;
            this.buttonFcProvincial.Click += new System.EventHandler(this.buttonFcProvincial_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(59, 338);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(236, 38);
            this.buttonSalir.TabIndex = 4;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.button5_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 450);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonFcProvincial);
            this.Controls.Add(this.buttonFcLocal);
            this.Controls.Add(this.buttonFcTotal);
            this.Controls.Add(this.buttonGenerarLlamada);
            this.Name = "Principal";
            this.Text = "Central Telefonica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerarLlamada;
        private System.Windows.Forms.Button buttonFcTotal;
        private System.Windows.Forms.Button buttonFcLocal;
        private System.Windows.Forms.Button buttonFcProvincial;
        private System.Windows.Forms.Button buttonSalir;
    }
}

