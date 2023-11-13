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
    public partial class administrarAlumnosForm : Form
    {
        public administrarAlumnosForm()
        {
            InitializeComponent();
        }

        private void aLUMNOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {

                dsDBTableAdapters.ALUMNOSTableAdapter alumnos = new dsDBTableAdapters.ALUMNOSTableAdapter();

                alumnos.FillByDNI(this.dsDB.ALUMNOS, dniTextBox.Text);

                if (this.dsDB.ALUMNOS.Rows.Count > 0)
                {
                    // ESTO NO ES CORRECTO PORQUE NO PODRÍA MODIFICAR UN ALUMNO QUE YA EXISTE
                    MessageBox.Show("El alumno ya existe");
                    return;
                }
                else
                {
                    this.Validate();
                    this.aLUMNOSBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.dsDB);

                    cargarDatos();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
           cargarDatos();
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
                int idAlumno = this.dsDB.ALUMNOS[int.Parse(aLUMNOSBindingNavigator.PositionItem.Text) - 1].Id_Alumno;

                // dsDBTableAdapters.alumnosTableAdapter ata = new dsDBTableAdapters.alumnosTableAdapter();
                dsDBTableAdapters.CURSOSTableAdapter cursoAdapter = new dsDBTableAdapters.CURSOSTableAdapter();
                cursoAdapter.FillByAlumnoId(dsDB.CURSOS, idAlumno);

                dsDBTableAdapters.ALUMNOSTableAdapter alumno = new dsDBTableAdapters.ALUMNOSTableAdapter();


                alumno.FillCursoByIdAlumno(idAlumno);

                if (dsDB.ALUMNOS.Count > 0)
                {
                    MessageBox.Show("El alumno que quieres borrar tiene cursos pendientes, si lo borras la vas a liar parda");
                    rs = MessageBox.Show("¿Estás seguro?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (rs == DialogResult.Yes)
                    {
                        cursoAdapter.DeleteQueryByIdCurso(idAlumno);
                        this.aLUMNOSTableAdapter.DeleteQueryByIdAlumno(idAlumno);
                        this.aLUMNOSTableAdapter.Fill(this.dsDB.ALUMNOS);
                        MessageBox.Show("Alumno borrado");
                        cargarDatos();
                    }
                }
                else
                {
                    this.aLUMNOSTableAdapter.DeleteQueryAlumno(idAlumno);
                    this.aLUMNOSTableAdapter.Fill(this.dsDB.ALUMNOS);
                    MessageBox.Show("Alumno borrado");
                    cargarDatos();
                }
            }

        }
    }
}
