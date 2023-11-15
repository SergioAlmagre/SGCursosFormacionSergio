using System;
using System.Collections;
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
    public partial class administrarCursosForm : Form
    {
        public administrarCursosForm()
        {
            InitializeComponent();
        }


        private void administrarCursosForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsDB.FAMILIAS' Puede moverla o quitarla según sea necesario.
            this.fAMILIASTableAdapter.Fill(this.dsDB.FAMILIAS);
            cargarComboFamilia();
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;


        }

        public void cargarComboFamilia()
        {
            using (gestorcursosformacionEntities objDB = new gestorcursosformacionEntities())
            {
                cboFamilia.Items.Clear();
                foreach (var fam in objDB.FAMILIAS.OrderBy(x => x.Nombre_Familia))
                {
                    cboFamilia.Items.Add(fam.Nombre_Familia);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //SI EL CURSO ESTA TERMINADO O CANCELADO MUESTRA UN MENSAJE DE AVISO Y  NO PERMITE MODIFICARLO
            using (gestorcursosformacionEntities objDB = new gestorcursosformacionEntities())
            {
                var idCurso = dsDB.CURSOS.Where(x => x.Nombre_Curso == dataGrid.CurrentRow.Cells[0].Value.ToString()).FirstOrDefault().Id_Curso; //OBTENEMOS EL ID DEL CURSO SELECCIONADO

                var estadoCurso = dsDB.CURSOS.Where(x => x.Nombre_Curso == dataGrid.CurrentRow.Cells[0].Value.ToString()).FirstOrDefault().Estado; //OBTENEMOS EL ESTADO DEL CURSO SELECCIONADO
                var alumnosCursando = dsDB.ALUMNOS.Count(x => x.Curso == idCurso); //OBTENEMOS EL NUMERO DE ALUMNOS QUE ESTAN CURSANDO EL CURSO SELECCIONADO

                if (estadoCurso == 3 || estadoCurso == 4) //SI EL ESTADO DEL CURSO ES TERMINADO O CANCELADO MUESTRA UN MENSAJE DE AVISO Y  NO PERMITE MODIFICARLO 3 CANCELADO 4 TERMINADO
                {
                    MessageBox.Show("El curso seleccionado está terminado o cancelado, no se puede modificar", "Modificar curso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    if (alumnosCursando != 0)
                    {
                        DialogResult respuesta = MessageBox.Show("El curso seleccionado tiene alumnos cursandolo", "¿Modificar curso de todos modos?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        modificarCursoForm modificarCurso = new modificarCursoForm();

                        if (modificarCurso.ShowDialog() == DialogResult.Cancel)
                        {

                            dataGrid.CurrentRow.Cells[0].Value = modificarCurso.nombreCurso;
                            dataGrid.CurrentRow.Cells[1].Value = modificarCurso.horas;
                            dataGrid.CurrentRow.Cells[2].Value = modificarCurso.estado;
                            dataGrid.CurrentRow.Cells[3].Value = modificarCurso.fechaInicio;
                            dataGrid.CurrentRow.Cells[4].Value = modificarCurso.fechaFin;
                            cboFamilia.SelectedItem = modificarCurso.familia;
                            
                            cboFamilia_SelectedIndexChanged(sender, e);
                        }
                    }
                    else
                    {
                        modificarCursoForm modificarCurso = new modificarCursoForm();
                        dataGrid.CurrentRow.Cells[0].Value = modificarCurso.nombreCurso;
                        dataGrid.CurrentRow.Cells[1].Value = modificarCurso.horas;
                        dataGrid.CurrentRow.Cells[2].Value = modificarCurso.estado;
                        dataGrid.CurrentRow.Cells[3].Value = modificarCurso.fechaInicio;
                        dataGrid.CurrentRow.Cells[4].Value = modificarCurso.fechaFin;
                        cboFamilia.SelectedItem = modificarCurso.familia;

                        cboFamilia_SelectedIndexChanged(sender, e);
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (gestorcursosformacionEntities objDB = new gestorcursosformacionEntities())
            {
                
                DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea eliminar el curso seleccionado?", "Eliminar curso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    var idCurso = dsDB.CURSOS.Where(x => x.Nombre_Curso == dataGrid.CurrentRow.Cells[0].Value.ToString()).FirstOrDefault().Id_Curso;

                    var alumnosCursando = dsDB.ALUMNOS.Count(x => x.Curso == idCurso);

                    if (alumnosCursando != 0)
                    {
                        DialogResult respuesta2 = MessageBox.Show("El curso seleccionado tiene alumnos cursandolo", "¿Eliminar curso de todos modos?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (respuesta2 == DialogResult.Yes)
                        {
                            var curso = objDB.CURSOS.Where(x => x.Nombre_Curso == dataGrid.CurrentRow.Cells[0].Value.ToString()).FirstOrDefault();
                            objDB.CURSOS.Remove(curso);
                            objDB.SaveChanges();
                            MessageBox.Show("Curso eliminado correctamente", "Eliminar curso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cboFamilia_SelectedIndexChanged(sender, e);

                        }
                    }
                    else
                    {

                        var curso = objDB.CURSOS.Where(x => x.Nombre_Curso == dataGrid.CurrentRow.Cells[0].Value.ToString()).FirstOrDefault();
                        objDB.CURSOS.Remove(curso);
                        objDB.SaveChanges();
                        MessageBox.Show("Curso eliminado correctamente", "Eliminar curso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cboFamilia_SelectedIndexChanged(sender, e);
                    }
                }
            }
        }


        private void btnAñadir_Click(object sender, EventArgs e)
        {

        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboFamilia_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (gestorcursosformacionEntities objDB = new gestorcursosformacionEntities())
            {
                var respuesta = from fam in objDB.FAMILIAS
                                join cur in objDB.CURSOS on fam.Id_Familia equals cur.Familia
                                join est in objDB.ESTADOS on cur.Estado equals est.Id_Estado
                                where fam.Nombre_Familia == cboFamilia.SelectedItem.ToString()
                                orderby cur.Fecha_Inicio descending
                                select new
                                {
                                    Nombre_Curso = cur.Nombre_Curso,
                                    Numero_Horas = cur.Horas,
                                    Estado = est.Nombre_Estado,
                                    Fecha_Inicio = cur.Fecha_Inicio,
                                    Fecha_Fin = cur.Fecha_Fin,
                                };

                dataGrid.DataSource = respuesta.ToList();
                if (respuesta.ToList().Count == 0)
                {
                    btnEliminar.Enabled = false;
                    btnModificar.Enabled = false;
                }
                else
                {
                    btnEliminar.Enabled = true;
                    btnModificar.Enabled = true;
                }
            }



        }
    }
}