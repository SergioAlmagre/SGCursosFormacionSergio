namespace SGCursosFormacionSergio
{
    partial class administrarAlumnosForm
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
            System.Windows.Forms.Label dniLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label cursoLabel;
            System.Windows.Forms.Label fotoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(administrarAlumnosForm));
            this.aLUMNOSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.aLUMNOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDB = new SGCursosFormacionSergio.dsDB();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.aLUMNOSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dniTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.cURSOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDB1 = new SGCursosFormacionSergio.dsDB();
            this.cURSOSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.aLUMNOSTableAdapter = new SGCursosFormacionSergio.dsDBTableAdapters.ALUMNOSTableAdapter();
            this.tableAdapterManager = new SGCursosFormacionSergio.dsDBTableAdapters.TableAdapterManager();
            this.cURSOSTableAdapter = new SGCursosFormacionSergio.dsDBTableAdapters.CURSOSTableAdapter();
            this.ofdCaratula = new System.Windows.Forms.OpenFileDialog();
            this.alumnosfkcurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumnosfkcurBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            dniLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            cursoLabel = new System.Windows.Forms.Label();
            fotoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aLUMNOSBindingNavigator)).BeginInit();
            this.aLUMNOSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aLUMNOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cURSOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cURSOSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosfkcurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosfkcurBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dniLabel
            // 
            dniLabel.AutoSize = true;
            dniLabel.Location = new System.Drawing.Point(36, 94);
            dniLabel.Name = "dniLabel";
            dniLabel.Size = new System.Drawing.Size(30, 16);
            dniLabel.TabIndex = 3;
            dniLabel.Text = "Dni:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(36, 122);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(59, 16);
            nombreLabel.TabIndex = 5;
            nombreLabel.Text = "Nombre:";
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Location = new System.Drawing.Point(36, 150);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(67, 16);
            apellidosLabel.TabIndex = 7;
            apellidosLabel.Text = "Apellidos:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(36, 178);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(44, 16);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "Email:";
            // 
            // cursoLabel
            // 
            cursoLabel.AutoSize = true;
            cursoLabel.Location = new System.Drawing.Point(36, 206);
            cursoLabel.Name = "cursoLabel";
            cursoLabel.Size = new System.Drawing.Size(45, 16);
            cursoLabel.TabIndex = 11;
            cursoLabel.Text = "Curso:";
            // 
            // fotoLabel
            // 
            fotoLabel.AutoSize = true;
            fotoLabel.Location = new System.Drawing.Point(355, 54);
            fotoLabel.Name = "fotoLabel";
            fotoLabel.Size = new System.Drawing.Size(37, 16);
            fotoLabel.TabIndex = 13;
            fotoLabel.Text = "Foto:";
            // 
            // aLUMNOSBindingNavigator
            // 
            this.aLUMNOSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.aLUMNOSBindingNavigator.BindingSource = this.aLUMNOSBindingSource;
            this.aLUMNOSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.aLUMNOSBindingNavigator.DeleteItem = null;
            this.aLUMNOSBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.aLUMNOSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.aLUMNOSBindingNavigatorSaveItem});
            this.aLUMNOSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.aLUMNOSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.aLUMNOSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.aLUMNOSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.aLUMNOSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.aLUMNOSBindingNavigator.Name = "aLUMNOSBindingNavigator";
            this.aLUMNOSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.aLUMNOSBindingNavigator.Size = new System.Drawing.Size(575, 27);
            this.aLUMNOSBindingNavigator.TabIndex = 0;
            this.aLUMNOSBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // aLUMNOSBindingSource
            // 
            this.aLUMNOSBindingSource.DataMember = "ALUMNOS";
            this.aLUMNOSBindingSource.DataSource = this.dsDB;
            // 
            // dsDB
            // 
            this.dsDB.DataSetName = "gestorcursosformacionDataSet";
            this.dsDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // aLUMNOSBindingNavigatorSaveItem
            // 
            this.aLUMNOSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aLUMNOSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aLUMNOSBindingNavigatorSaveItem.Image")));
            this.aLUMNOSBindingNavigatorSaveItem.Name = "aLUMNOSBindingNavigatorSaveItem";
            this.aLUMNOSBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.aLUMNOSBindingNavigatorSaveItem.Text = "Guardar datos";
            this.aLUMNOSBindingNavigatorSaveItem.Click += new System.EventHandler(this.aLUMNOSBindingNavigatorSaveItem_Click);
            // 
            // dniTextBox
            // 
            this.dniTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLUMNOSBindingSource, "Dni", true));
            this.dniTextBox.Location = new System.Drawing.Point(111, 91);
            this.dniTextBox.Name = "dniTextBox";
            this.dniTextBox.Size = new System.Drawing.Size(207, 22);
            this.dniTextBox.TabIndex = 4;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLUMNOSBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(111, 119);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(207, 22);
            this.nombreTextBox.TabIndex = 6;
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLUMNOSBindingSource, "Apellidos", true));
            this.apellidosTextBox.Location = new System.Drawing.Point(111, 147);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(207, 22);
            this.apellidosTextBox.TabIndex = 8;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLUMNOSBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(111, 175);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(207, 22);
            this.emailTextBox.TabIndex = 10;
            // 
            // cboCurso
            // 
            this.cboCurso.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.aLUMNOSBindingSource, "Curso", true));
            this.cboCurso.DataSource = this.cURSOSBindingSource;
            this.cboCurso.DisplayMember = "Nombre_Curso";
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Location = new System.Drawing.Point(111, 203);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(207, 24);
            this.cboCurso.TabIndex = 12;
            this.cboCurso.ValueMember = "Id_Curso";
            // 
            // cURSOSBindingSource
            // 
            this.cURSOSBindingSource.DataMember = "CURSOS";
            this.cURSOSBindingSource.DataSource = this.dsDB1;
            // 
            // dsDB1
            // 
            this.dsDB1.DataSetName = "dsDB";
            this.dsDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cURSOSBindingSource1
            // 
            this.cURSOSBindingSource1.DataMember = "CURSOS";
            this.cURSOSBindingSource1.DataSource = this.dsDB1;
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.aLUMNOSBindingSource, "Foto", true));
            this.fotoPictureBox.Location = new System.Drawing.Point(338, 106);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(217, 301);
            this.fotoPictureBox.TabIndex = 14;
            this.fotoPictureBox.TabStop = false;
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(338, 77);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(75, 23);
            this.btnCambiar.TabIndex = 16;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // aLUMNOSTableAdapter
            // 
            this.aLUMNOSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ALUMNOSTableAdapter = this.aLUMNOSTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CURSOSTableAdapter = null;
            this.tableAdapterManager.ESTADOSTableAdapter = null;
            this.tableAdapterManager.FAMILIASTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SGCursosFormacionSergio.dsDBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cURSOSTableAdapter
            // 
            this.cURSOSTableAdapter.ClearBeforeFill = true;
            // 
            // ofdCaratula
            // 
            this.ofdCaratula.FileName = "openFileDialog1";
            // 
            // alumnosfkcurBindingSource
            // 
            this.alumnosfkcurBindingSource.DataMember = "alumnos_fk_cur";
            this.alumnosfkcurBindingSource.DataSource = this.cURSOSBindingSource;
            // 
            // alumnosfkcurBindingSource1
            // 
            this.alumnosfkcurBindingSource1.DataMember = "alumnos_fk_cur";
            this.alumnosfkcurBindingSource1.DataSource = this.cURSOSBindingSource;
            // 
            // administrarAlumnosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 427);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(dniLabel);
            this.Controls.Add(this.dniTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(apellidosLabel);
            this.Controls.Add(this.apellidosTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(cursoLabel);
            this.Controls.Add(this.cboCurso);
            this.Controls.Add(fotoLabel);
            this.Controls.Add(this.fotoPictureBox);
            this.Controls.Add(this.aLUMNOSBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "administrarAlumnosForm";
            this.Text = "administrarAlumnosForm";
            this.Load += new System.EventHandler(this.administrarAlumnosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aLUMNOSBindingNavigator)).EndInit();
            this.aLUMNOSBindingNavigator.ResumeLayout(false);
            this.aLUMNOSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aLUMNOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cURSOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cURSOSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosfkcurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosfkcurBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsDB dsDB;
        private System.Windows.Forms.BindingSource aLUMNOSBindingSource;
        private dsDBTableAdapters.ALUMNOSTableAdapter aLUMNOSTableAdapter;
        private dsDBTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator aLUMNOSBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton aLUMNOSBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox dniTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ComboBox cboCurso;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.Button btnCambiar;
        private dsDB dsDB1;
        private System.Windows.Forms.BindingSource cURSOSBindingSource;
        private dsDBTableAdapters.CURSOSTableAdapter cURSOSTableAdapter;
        private System.Windows.Forms.BindingSource cURSOSBindingSource1;
        private System.Windows.Forms.OpenFileDialog ofdCaratula;
        private System.Windows.Forms.BindingSource alumnosfkcurBindingSource;
        private System.Windows.Forms.BindingSource alumnosfkcurBindingSource1;
    }
}