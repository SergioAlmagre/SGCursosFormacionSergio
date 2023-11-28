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
    public partial class ModalInscripcion : Form
    {
        public int idAlumno { get; set; }
        public ModalInscripcion()
        {
            InitializeComponent();
        }

        private void cURSOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cURSOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsDB);
        }

        private void modalInscripcion_Load(object sender, EventArgs e)
        {
            gestorcursosformacionEntities objDB = new gestorcursosformacionEntities();
            var alumnoSeleccionado = objDB.ALUMNOS.FirstOrDefault(x => x.Id_Alumno == idAlumno);
           
            cargarCombo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            gestorcursosformacionEntities objDB = new gestorcursosformacionEntities();
            var nombreCurso = cboCurso.SelectedItem.ToString();
            var idCurso = objDB.CURSOS.FirstOrDefault(x => x.Nombre_Curso == nombreCurso).Id_Curso;
            var alumnoSeleccionado = objDB.ALUMNOS.FirstOrDefault(x => x.Id_Alumno == idAlumno);

            alumnoSeleccionado.Curso = idCurso;

            objDB.SaveChanges();
            MessageBox.Show("Inscripción realizada correctamente", "Inscripción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void cargarCombo()
        {
            gestorcursosformacionEntities dsDB = new gestorcursosformacionEntities();

            var cursosInscripcion = from cur in dsDB.CURSOS
                                    join est in dsDB.ESTADOS on cur.Estado equals est.Id_Estado
                                    where est.Nombre_Estado == "Inscripción"
                                    select new
                                    {
                                        cur.Nombre_Curso
                                    };

            foreach (var curso in cursosInscripcion)
            {
                cboCurso.Items.Add(curso.Nombre_Curso);
            }
        }
    }
}
