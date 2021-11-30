namespace Observer1.UI
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
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.lstUsuarios = new System.Windows.Forms.ListBox();
            this.btnSuscribir = new System.Windows.Forms.Button();
            this.btnDesuscribir = new System.Windows.Forms.Button();
            this.lstNotificaciones = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstProductos
            // 
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.ItemHeight = 16;
            this.lstProductos.Location = new System.Drawing.Point(29, 26);
            this.lstProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(291, 548);
            this.lstProductos.TabIndex = 0;
            this.lstProductos.SelectedValueChanged += new System.EventHandler(this.lstProductos_SelectedValueChanged);
            this.lstProductos.DoubleClick += new System.EventHandler(this.lstProductos_DoubleClick);
            // 
            // lstUsuarios
            // 
            this.lstUsuarios.FormattingEnabled = true;
            this.lstUsuarios.ItemHeight = 16;
            this.lstUsuarios.Location = new System.Drawing.Point(376, 26);
            this.lstUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstUsuarios.Name = "lstUsuarios";
            this.lstUsuarios.Size = new System.Drawing.Size(291, 548);
            this.lstUsuarios.TabIndex = 1;
            this.lstUsuarios.SelectedIndexChanged += new System.EventHandler(this.lstUsuarios_SelectedIndexChanged);
            this.lstUsuarios.SelectedValueChanged += new System.EventHandler(this.lstUsuarios_SelectedValueChanged);
            // 
            // btnSuscribir
            // 
            this.btnSuscribir.Location = new System.Drawing.Point(720, 457);
            this.btnSuscribir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSuscribir.Name = "btnSuscribir";
            this.btnSuscribir.Size = new System.Drawing.Size(172, 55);
            this.btnSuscribir.TabIndex = 3;
            this.btnSuscribir.Text = "Suscribir";
            this.btnSuscribir.UseVisualStyleBackColor = true;
            this.btnSuscribir.Click += new System.EventHandler(this.btnSuscribir_Click);
            // 
            // btnDesuscribir
            // 
            this.btnDesuscribir.Location = new System.Drawing.Point(720, 519);
            this.btnDesuscribir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDesuscribir.Name = "btnDesuscribir";
            this.btnDesuscribir.Size = new System.Drawing.Size(172, 55);
            this.btnDesuscribir.TabIndex = 4;
            this.btnDesuscribir.Text = "Desuscribir";
            this.btnDesuscribir.UseVisualStyleBackColor = true;
            this.btnDesuscribir.Click += new System.EventHandler(this.btnDesuscribir_Click);
            // 
            // lstNotificaciones
            // 
            this.lstNotificaciones.FormattingEnabled = true;
            this.lstNotificaciones.ItemHeight = 16;
            this.lstNotificaciones.Location = new System.Drawing.Point(720, 26);
            this.lstNotificaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstNotificaciones.Name = "lstNotificaciones";
            this.lstNotificaciones.Size = new System.Drawing.Size(547, 420);
            this.lstNotificaciones.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 634);
            this.Controls.Add(this.lstNotificaciones);
            this.Controls.Add(this.btnDesuscribir);
            this.Controls.Add(this.btnSuscribir);
            this.Controls.Add(this.lstUsuarios);
            this.Controls.Add(this.lstProductos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Observer ejemplo 1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstProductos;
        private System.Windows.Forms.ListBox lstUsuarios;
        private System.Windows.Forms.Button btnSuscribir;
        private System.Windows.Forms.Button btnDesuscribir;
        private System.Windows.Forms.ListBox lstNotificaciones;
    }
}

