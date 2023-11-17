namespace SGCursosFormacionSergio
{
    partial class modificarCursoForm
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
            this.components = new System.ComponentModel.Container();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblNombreCurso = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblFamilia = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.cboFamilia = new System.Windows.Forms.ComboBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.cboFechaInicio = new System.Windows.Forms.ComboBox();
            this.cboFechaFin = new System.Windows.Forms.ComboBox();
            this.dsDB = new SGCursosFormacionSergio.dsDB();
            this.dsDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eSTADOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eSTADOSTableAdapter = new SGCursosFormacionSergio.dsDBTableAdapters.ESTADOSTableAdapter();
            this.eSTADOSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cURSOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cURSOSTableAdapter = new SGCursosFormacionSergio.dsDBTableAdapters.CURSOSTableAdapter();
            this.cURSOSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fAMILIASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fAMILIASTableAdapter = new SGCursosFormacionSergio.dsDBTableAdapters.FAMILIASTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTADOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTADOSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cURSOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cURSOSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fAMILIASBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(218, 317);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 38);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(457, 317);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 38);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblNombreCurso
            // 
            this.lblNombreCurso.AutoSize = true;
            this.lblNombreCurso.Location = new System.Drawing.Point(84, 47);
            this.lblNombreCurso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreCurso.Name = "lblNombreCurso";
            this.lblNombreCurso.Size = new System.Drawing.Size(93, 13);
            this.lblNombreCurso.TabIndex = 2;
            this.lblNombreCurso.Text = "Nombre del curso:";
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(84, 89);
            this.lblHoras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(38, 13);
            this.lblHoras.TabIndex = 3;
            this.lblHoras.Text = "Horas:";
            // 
            // lblFamilia
            // 
            this.lblFamilia.AutoSize = true;
            this.lblFamilia.Location = new System.Drawing.Point(84, 132);
            this.lblFamilia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFamilia.Name = "lblFamilia";
            this.lblFamilia.Size = new System.Drawing.Size(42, 13);
            this.lblFamilia.TabIndex = 4;
            this.lblFamilia.Text = "Familia:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(84, 180);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 5;
            this.lblEstado.Text = "Estado:";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(84, 222);
            this.lblFechaInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(82, 13);
            this.lblFechaInicio.TabIndex = 6;
            this.lblFechaInicio.Text = "Fecha de inicio:";
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Location = new System.Drawing.Point(84, 270);
            this.lblFechaFinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(62, 13);
            this.lblFechaFinal.TabIndex = 7;
            this.lblFechaFinal.Text = "Fecha final:";
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.Location = new System.Drawing.Point(218, 45);
            this.txtNombreCurso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(332, 20);
            this.txtNombreCurso.TabIndex = 8;
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(218, 89);
            this.txtHoras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(332, 20);
            this.txtHoras.TabIndex = 9;
            // 
            // cboFamilia
            // 
            this.cboFamilia.FormattingEnabled = true;
            this.cboFamilia.Location = new System.Drawing.Point(218, 132);
            this.cboFamilia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboFamilia.Name = "cboFamilia";
            this.cboFamilia.Size = new System.Drawing.Size(332, 21);
            this.cboFamilia.TabIndex = 10;
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(218, 177);
            this.cboEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(332, 21);
            this.cboEstado.TabIndex = 11;
            // 
            // cboFechaInicio
            // 
            this.cboFechaInicio.FormattingEnabled = true;
            this.cboFechaInicio.Location = new System.Drawing.Point(218, 219);
            this.cboFechaInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboFechaInicio.Name = "cboFechaInicio";
            this.cboFechaInicio.Size = new System.Drawing.Size(332, 21);
            this.cboFechaInicio.TabIndex = 12;
            // 
            // cboFechaFin
            // 
            this.cboFechaFin.FormattingEnabled = true;
            this.cboFechaFin.Location = new System.Drawing.Point(218, 267);
            this.cboFechaFin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboFechaFin.Name = "cboFechaFin";
            this.cboFechaFin.Size = new System.Drawing.Size(332, 21);
            this.cboFechaFin.TabIndex = 13;
            // 
            // dsDB
            // 
            this.dsDB.DataSetName = "dsDB";
            this.dsDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsDBBindingSource
            // 
            this.dsDBBindingSource.DataSource = this.dsDB;
            this.dsDBBindingSource.Position = 0;
            // 
            // eSTADOSBindingSource
            // 
            this.eSTADOSBindingSource.DataMember = "ESTADOS";
            this.eSTADOSBindingSource.DataSource = this.dsDBBindingSource;
            // 
            // eSTADOSTableAdapter
            // 
            this.eSTADOSTableAdapter.ClearBeforeFill = true;
            // 
            // eSTADOSBindingSource1
            // 
            this.eSTADOSBindingSource1.DataMember = "ESTADOS";
            this.eSTADOSBindingSource1.DataSource = this.dsDBBindingSource;
            // 
            // cURSOSBindingSource
            // 
            this.cURSOSBindingSource.DataMember = "CURSOS";
            this.cURSOSBindingSource.DataSource = this.dsDBBindingSource;
            // 
            // cURSOSTableAdapter
            // 
            this.cURSOSTableAdapter.ClearBeforeFill = true;
            // 
            // cURSOSBindingSource1
            // 
            this.cURSOSBindingSource1.DataMember = "CURSOS";
            this.cURSOSBindingSource1.DataSource = this.dsDBBindingSource;
            // 
            // fAMILIASBindingSource
            // 
            this.fAMILIASBindingSource.DataMember = "FAMILIAS";
            this.fAMILIASBindingSource.DataSource = this.dsDBBindingSource;
            // 
            // fAMILIASTableAdapter
            // 
            this.fAMILIASTableAdapter.ClearBeforeFill = true;
            // 
            // modificarCursoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 415);
            this.Controls.Add(this.cboFechaFin);
            this.Controls.Add(this.cboFechaInicio);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.cboFamilia);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.txtNombreCurso);
            this.Controls.Add(this.lblFechaFinal);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblFamilia);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.lblNombreCurso);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "modificarCursoForm";
            this.Text = "modificarCursoForm";
            this.Load += new System.EventHandler(this.modificarCursoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTADOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTADOSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cURSOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cURSOSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fAMILIASBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblNombreCurso;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblFamilia;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.ComboBox cboFamilia;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.ComboBox cboFechaInicio;
        private System.Windows.Forms.ComboBox cboFechaFin;
        private System.Windows.Forms.BindingSource dsDBBindingSource;
        private dsDB dsDB;
        private System.Windows.Forms.BindingSource eSTADOSBindingSource;
        private dsDBTableAdapters.ESTADOSTableAdapter eSTADOSTableAdapter;
        private System.Windows.Forms.BindingSource eSTADOSBindingSource1;
        private System.Windows.Forms.BindingSource cURSOSBindingSource;
        private dsDBTableAdapters.CURSOSTableAdapter cURSOSTableAdapter;
        private System.Windows.Forms.BindingSource cURSOSBindingSource1;
        private System.Windows.Forms.BindingSource fAMILIASBindingSource;
        private dsDBTableAdapters.FAMILIASTableAdapter fAMILIASTableAdapter;
    }
}