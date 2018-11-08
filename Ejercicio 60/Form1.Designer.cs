namespace Ejercicio_60
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
            this.iniciarSql = new System.Windows.Forms.Button();
            this.ricardoElTexto = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // iniciarSql
            // 
            this.iniciarSql.Location = new System.Drawing.Point(38, 21);
            this.iniciarSql.Name = "iniciarSql";
            this.iniciarSql.Size = new System.Drawing.Size(75, 23);
            this.iniciarSql.TabIndex = 0;
            this.iniciarSql.Text = "Iniciar SQL";
            this.iniciarSql.UseVisualStyleBackColor = true;
            this.iniciarSql.Click += new System.EventHandler(this.button1_Click);
            // 
            // ricardoElTexto
            // 
            this.ricardoElTexto.Location = new System.Drawing.Point(38, 67);
            this.ricardoElTexto.Name = "ricardoElTexto";
            this.ricardoElTexto.Size = new System.Drawing.Size(714, 355);
            this.ricardoElTexto.TabIndex = 1;
            this.ricardoElTexto.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ricardoElTexto);
            this.Controls.Add(this.iniciarSql);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button iniciarSql;
        private System.Windows.Forms.RichTextBox ricardoElTexto;
    }
}

