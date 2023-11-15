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
    public partial class modificarCursoForm : Form
    {
        public modificarCursoForm()
        {
            InitializeComponent();
        }

        public string nombreCurso { get; set; }
        public string horas { get; set; }
        public string fechaInicio { get; set; }
        public string fechaFin { get; set; }
        public string familia { get; set; }
        public string estado { get; set; }


        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
