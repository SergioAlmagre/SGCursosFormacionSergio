namespace SGCursosFormacionSergio
{
    partial class ModalInscripcion
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
            System.Windows.Forms.Label nombre_CursoLabel;
            this.dsDB = new SGCursosFormacionSergio.dsDB();
            this.cURSOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cURSOSTableAdapter = new SGCursosFormacionSergio.dsDBTableAdapters.CURSOSTableAdapter();
            this.tableAdapterManager = new SGCursosFormacionSergio.dsDBTableAdapters.TableAdapterManager();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.cURSOSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            nombre_CursoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cURSOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cURSOSBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre_CursoLabel
            // 
            nombre_CursoLabel.AutoSize = true;
            nombre_CursoLabel.Location = new System.Drawing.Point(239, 143);
            nombre_CursoLabel.Name = "nombre_CursoLabel";
            nombre_CursoLabel.Size = new System.Drawing.Size(97, 16);
            nombre_CursoLabel.TabIndex = 1;
            nombre_CursoLabel.Text = "Nombre Curso:";
            // 
            // dsDB
            // 
            this.dsDB.DataSetName = "dsDB";
            this.dsDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cURSOSBindingSource
            // 
            this.cURSOSBindingSource.DataMember = "CURSOS";
            this.cURSOSBindingSource.DataSource = this.dsDB;
            // 
            // cURSOSTableAdapter
            // 
            this.cURSOSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ALUMNOSTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CURSOSTableAdapter = this.cURSOSTableAdapter;
            this.tableAdapterManager.ESTADOSTableAdapter = null;
            this.tableAdapterManager.FAMILIASTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SGCursosFormacionSergio.dsDBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cboCurso
            // 
            this.cboCurso.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cURSOSBindingSource, "Nombre_Curso", true));
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Location = new System.Drawing.Point(342, 140);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(121, 21);
            this.cboCurso.TabIndex = 2;
            // 
            // cURSOSBindingSource1
            // 
            this.cURSOSBindingSource1.DataMember = "CURSOS";
            this.cURSOSBindingSource1.DataSource = this.dsDB;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(242, 223);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 31);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(377, 223);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 31);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // ModalInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 419);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(nombre_CursoLabel);
            this.Controls.Add(this.cboCurso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModalInscripcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "modalInscripcion";
            this.Load += new System.EventHandler(this.modalInscripcion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cURSOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cURSOSBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsDB dsDB;
        private System.Windows.Forms.BindingSource cURSOSBindingSource;
        private dsDBTableAdapters.CURSOSTableAdapter cURSOSTableAdapter;
        private dsDBTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cboCurso;
        private System.Windows.Forms.BindingSource cURSOSBindingSource1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}