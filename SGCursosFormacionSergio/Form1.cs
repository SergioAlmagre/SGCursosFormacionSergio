using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGCursosFormacionSergio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();  
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void sMenuAlumnos_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "administrarAlumnosForm")
                {
                    DialogResult rs = MessageBox.Show("¿Seguro que desea salir?, Puedes perder los datos si no has guardado", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();
                        administrarAlumnosForm formulario = new administrarAlumnosForm();
                        formulario.MdiParent = this;
                        formulario.Dock = DockStyle.Fill;
                        formulario.Show();
                    }
                }
            }
            else
            {
                administrarAlumnosForm formulario = new administrarAlumnosForm();
                formulario.MdiParent = this;
                formulario.Dock = DockStyle.Fill;
                formulario.Show();
            }
        }

        private void sMenuCursos_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "administrarCursosForm")
                {
                    DialogResult rs = MessageBox.Show("¿Seguro que desea salir?, Puedes perder los datos si no has guardado", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();
                        administrarCursosForm formulario = new administrarCursosForm();
                        formulario.MdiParent = this;
                        formulario.Dock = DockStyle.Fill;
                        formulario.Show();
                    }
                }
            }
            else
            {
                administrarCursosForm formulario = new administrarCursosForm();
                formulario.MdiParent = this;
                formulario.Dock = DockStyle.Fill;
                formulario.Show();
            }
        }

        private void mnuInscripcion_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "InscripcionForm")
                {
                    DialogResult rs = MessageBox.Show("¿Seguro que desea salir?, Puedes perder los datos si no has guardado", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();
                        InscripcionForm formulario = new InscripcionForm();
                        formulario.MdiParent = this;
                        formulario.Dock = DockStyle.Fill;
                        formulario.Show();
                    }
                }
            }
            else
            {
                InscripcionForm formulario = new InscripcionForm();
                formulario.MdiParent = this;
                formulario.Dock = DockStyle.Fill;
                formulario.Show();
            }
        }

        private void mnuInformes_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "InformesForm")
                {
                    DialogResult rs = MessageBox.Show("¿Seguro que desea salir?, Puedes perder los datos si no has guardado", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();
                        InformesForm formulario = new InformesForm();
                        formulario.MdiParent = this;
                        formulario.Dock = DockStyle.Fill;
                        formulario.Show();
                    }
                }
            }
            else
            { 
                InformesForm formulario = new InformesForm();
                formulario.MdiParent = this;
                formulario.Dock = DockStyle.Fill;
                formulario.Show();
            }

        }
    }
}
