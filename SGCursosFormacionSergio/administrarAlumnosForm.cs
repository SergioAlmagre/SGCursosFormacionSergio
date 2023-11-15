using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGCursosFormacionSergio
{
    public partial class administrarAlumnosForm : Form
    {
        public administrarAlumnosForm()
        {
            InitializeComponent();
        }

        private void aLUMNOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            dsDBTableAdapters.ALUMNOSTableAdapter alumnos = new dsDBTableAdapters.ALUMNOSTableAdapter();
            dsDB dsBDDatos = new dsDB();

            alumnos.FillByDNI(dsBDDatos.ALUMNOS, dniTextBox.Text);
            var maxIdBindingNavigator = int.Parse(aLUMNOSBindingNavigator.PositionItem.Text);
            var max = alumnos.MaxAlumnos_idAlumno();
            


            if (dsBDDatos.ALUMNOS.Rows.Count > 0 && max <= maxIdBindingNavigator)
            {
                // ESTO NO ES CORRECTO PORQUE NO PODRÍA MODIFICAR UN ALUMNO QUE YA EXISTE
                MessageBox.Show("DNI ya registrado en la base de datos");
                return;
            }
            else
            {
                this.Validate();
                this.aLUMNOSBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dsDB);

                //cargarDatos();
            }

        }

        private void administrarAlumnosForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsDB1.CURSOS' Puede moverla o quitarla según sea necesario.
            this.cURSOSTableAdapter.Fill(this.dsDB1.CURSOS);
            // TODO: esta línea de código carga datos en la tabla 'gestorcursosformacionDataSet.ALUMNOS' Puede moverla o quitarla según sea necesario.
            this.aLUMNOSTableAdapter.Fill(this.dsDB.ALUMNOS);
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            if (ofdCaratula.ShowDialog() == DialogResult.OK)
            {
                fotoPictureBox.Image = Image.FromFile(ofdCaratula.FileName);
            }
        }

        private void cargarDatos()
        {
            this.aLUMNOSTableAdapter.Fill(this.dsDB.ALUMNOS);
        }


        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("¿Estás seguro?", "Eliminar el alumno", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (rs == DialogResult.Yes)
            {

                dsDBTableAdapters.ALUMNOSTableAdapter alumnoAdapter = new dsDBTableAdapters.ALUMNOSTableAdapter();

                dsDB alumnoConCurso = new dsDB();

                // Check if the alumno has a related curso
                bool alumnoHasCurso = false;
                int idAlumno = this.dsDB.ALUMNOS[int.Parse(aLUMNOSBindingNavigator.PositionItem.Text) - 1].Id_Alumno;
                if (alumnoAdapter.FillCursoByIdAlumno(idAlumno) != null)
                {
                    alumnoHasCurso = true;
                };

                if (alumnoHasCurso)
                {
                    MessageBox.Show("El alumno que quieres borrar tiene cursos pendientes, si lo borras la vas a liar parda");
                    rs = MessageBox.Show("¿Estás seguro?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (rs == DialogResult.Yes)
                    {
                        alumnoAdapter.DeleteByIdAlumno(idAlumno);
                        MessageBox.Show("Alumno borrado");
                        alumnoHasCurso = false;
                        cargarDatos();
                    }
                }
                else
                {
                    alumnoAdapter.DeleteByIdAlumno(idAlumno);
                    MessageBox.Show("Alumno borrado");
                    alumnoHasCurso = false;
                    cargarDatos();
                }
            }

        }

        private void cargarCombo()
        {
            cboCurso.DataSource = dsDB1.CURSOS;
        }

        
    }
    
}
