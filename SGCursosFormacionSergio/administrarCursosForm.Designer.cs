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
            ((System.ComponentModel.ISupportInitialize)(this.dsDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fAMILIASBindingSource)).BeginInit();
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
            // administrarCursosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "administrarCursosForm";
            this.Text = "administrarCursosForm";
            this.Load += new System.EventHandler(this.administrarCursosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fAMILIASBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private dsDB dsDB;
        private System.Windows.Forms.BindingSource fAMILIASBindingSource;
        private dsDBTableAdapters.FAMILIASTableAdapter fAMILIASTableAdapter;
        private dsDBTableAdapters.TableAdapterManager tableAdapterManager;
    }
}