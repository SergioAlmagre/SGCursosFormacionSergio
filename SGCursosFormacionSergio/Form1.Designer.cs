namespace SGCursosFormacionSergio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuAdministrar = new System.Windows.Forms.ToolStripMenuItem();
            this.sMenuAlumnos = new System.Windows.Forms.ToolStripMenuItem();
            this.sMenuCursos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInscripcion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInformes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdministrar,
            this.mnuInscripcion,
            this.mnuInformes,
            this.mnuSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuAdministrar
            // 
            this.mnuAdministrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sMenuAlumnos,
            this.sMenuCursos});
            this.mnuAdministrar.Name = "mnuAdministrar";
            this.mnuAdministrar.Size = new System.Drawing.Size(100, 24);
            this.mnuAdministrar.Text = "Administrar";
            // 
            // sMenuAlumnos
            // 
            this.sMenuAlumnos.Name = "sMenuAlumnos";
            this.sMenuAlumnos.Size = new System.Drawing.Size(150, 26);
            this.sMenuAlumnos.Text = "Alumnos";
            this.sMenuAlumnos.Click += new System.EventHandler(this.sMenuAlumnos_Click);
            // 
            // sMenuCursos
            // 
            this.sMenuCursos.Name = "sMenuCursos";
            this.sMenuCursos.Size = new System.Drawing.Size(150, 26);
            this.sMenuCursos.Text = "Cursos";
            this.sMenuCursos.Click += new System.EventHandler(this.sMenuCursos_Click);
            // 
            // mnuInscripcion
            // 
            this.mnuInscripcion.Name = "mnuInscripcion";
            this.mnuInscripcion.Size = new System.Drawing.Size(94, 24);
            this.mnuInscripcion.Text = "Inscripcion";
            this.mnuInscripcion.Click += new System.EventHandler(this.mnuInscripcion_Click);
            // 
            // mnuInformes
            // 
            this.mnuInformes.Name = "mnuInformes";
            this.mnuInformes.Size = new System.Drawing.Size(81, 24);
            this.mnuInformes.Text = "Informes";
            this.mnuInformes.Click += new System.EventHandler(this.mnuInformes_Click);
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(52, 24);
            this.mnuSalir.Text = "Salir";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 574);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuAdministrar;
        private System.Windows.Forms.ToolStripMenuItem sMenuAlumnos;
        private System.Windows.Forms.ToolStripMenuItem mnuInscripcion;
        private System.Windows.Forms.ToolStripMenuItem sMenuCursos;
        private System.Windows.Forms.ToolStripMenuItem mnuInformes;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
    }
}

