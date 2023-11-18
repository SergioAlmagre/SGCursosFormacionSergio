namespace SGCursosFormacionSergio
{
    partial class InformesForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCancelado = new System.Windows.Forms.Button();
            this.btnFamilia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 92);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(644, 282);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnCancelado
            // 
            this.btnCancelado.Location = new System.Drawing.Point(12, 33);
            this.btnCancelado.Name = "btnCancelado";
            this.btnCancelado.Size = new System.Drawing.Size(313, 23);
            this.btnCancelado.TabIndex = 1;
            this.btnCancelado.Text = "Cursos cancelados con mas alumnos";
            this.btnCancelado.UseVisualStyleBackColor = true;
            this.btnCancelado.Click += new System.EventHandler(this.btnCancelado_Click);
            // 
            // btnFamilia
            // 
            this.btnFamilia.Location = new System.Drawing.Point(331, 33);
            this.btnFamilia.Name = "btnFamilia";
            this.btnFamilia.Size = new System.Drawing.Size(325, 23);
            this.btnFamilia.TabIndex = 2;
            this.btnFamilia.Text = "Familia profesional con mas cursos";
            this.btnFamilia.UseVisualStyleBackColor = true;
            this.btnFamilia.Click += new System.EventHandler(this.btnFamilia_Click);
            // 
            // InformesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 386);
            this.Controls.Add(this.btnFamilia);
            this.Controls.Add(this.btnCancelado);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InformesForm";
            this.Text = "InformesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCancelado;
        private System.Windows.Forms.Button btnFamilia;
    }
}