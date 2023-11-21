namespace SGCursosFormacionSergio
{
    partial class administrarCursosForm
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
            this.dsDB = new SGCursosFormacionSergio.dsDB();
            this.fAMILIASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fAMILIASTableAdapter = new SGCursosFormacionSergio.dsDBTableAdapters.FAMILIASTableAdapter();
            this.tableAdapterManager = new SGCursosFormacionSergio.dsDBTableAdapters.TableAdapterManager();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.lblFamiliaProfesional = new System.Windows.Forms.Label();
            this.cboFamilia = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fAMILIASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dsDB
            // 
            this.dsDB.DataSetName = "dsDB";
            this.dsDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fAMILIASBindingSource
            // 
            this.fAMILIASBindingSource.DataMember = "FAMILIAS";
            this.fAMILIASBindingSource.DataSource = this.dsDB;
            // 
            // fAMILIASTableAdapter
            // 
            this.fAMILIASTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ALUMNOSTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CURSOSTableAdapter = null;
            this.tableAdapterManager.ESTADOSTableAdapter = null;
            this.tableAdapterManager.FAMILIASTableAdapter = this.fAMILIASTableAdapter;
            this.tableAdapterManager.UpdateOrder = SGCursosFormacionSergio.dsDBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(204, 420);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(137, 37);
            this.btnAñadir.TabIndex = 0;
            this.btnAñadir.Text = "AÑADIR";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(749, 420);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(137, 37);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(460, 420);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(137, 37);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.ColumnHeadersHeight = 29;
            this.dataGrid.Location = new System.Drawing.Point(81, 111);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(889, 274);
            this.dataGrid.TabIndex = 3;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            this.dataGrid.SelectionChanged += new System.EventHandler(this.dataGrid_SelectionChanged);
            // 
            // lblFamiliaProfesional
            // 
            this.lblFamiliaProfesional.AutoSize = true;
            this.lblFamiliaProfesional.Location = new System.Drawing.Point(96, 44);
            this.lblFamiliaProfesional.Name = "lblFamiliaProfesional";
            this.lblFamiliaProfesional.Size = new System.Drawing.Size(122, 16);
            this.lblFamiliaProfesional.TabIndex = 4;
            this.lblFamiliaProfesional.Text = "Familia Profesional";
            // 
            // cboFamilia
            // 
            this.cboFamilia.FormattingEnabled = true;
            this.cboFamilia.Location = new System.Drawing.Point(287, 44);
            this.cboFamilia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboFamilia.Name = "cboFamilia";
            this.cboFamilia.Size = new System.Drawing.Size(683, 24);
            this.cboFamilia.TabIndex = 5;
            this.cboFamilia.SelectedIndexChanged += new System.EventHandler(this.cboFamilia_SelectedIndexChanged);
            // 
            // administrarCursosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 489);
            this.Controls.Add(this.cboFamilia);
            this.Controls.Add(this.lblFamiliaProfesional);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAñadir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "administrarCursosForm";
            this.Text = "administrarCursosForm";
            this.Load += new System.EventHandler(this.administrarCursosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fAMILIASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsDB dsDB;
        private System.Windows.Forms.BindingSource fAMILIASBindingSource;
        private dsDBTableAdapters.FAMILIASTableAdapter fAMILIASTableAdapter;
        private dsDBTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label lblFamiliaProfesional;
        private System.Windows.Forms.ComboBox cboFamilia;
    }
}