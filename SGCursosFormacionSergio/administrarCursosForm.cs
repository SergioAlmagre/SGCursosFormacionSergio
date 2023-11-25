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
        public int idCurso = 0;
        public CURSOS curso = null;
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
                if(dataGrid.CurrentRow == null)
                {
                    MessageBox.Show("No hay ningún curso seleccionado", "Modificar curso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    var estadoCurso = dataGrid.CurrentRow.Cells[3].Value.ToString(); //OBTENEMOS EL ESTADO DEL CURSO SELECCIONADO
                    var alumnosCursando = objDB.ALUMNOS.Count(x => x.Curso == idCurso); //OBTENEMOS EL NUMERO DE ALUMNOS QUE ESTAN CURSANDO EL CURSO SELECCIONADO

                    if (estadoCurso == "Terminado" || estadoCurso == "Cancelado") //SI EL ESTADO DEL CURSO ES TERMINADO O CANCELADO MUESTRA UN MENSAJE DE AVISO Y  NO PERMITE MODIFICARLO 3 CANCELADO 4 TERMINADO
                    {
                        MessageBox.Show("El curso seleccionado está terminado o cancelado, no se puede modificar", "Modificar curso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        var cursoSeleccionado = objDB.CURSOS.Where(x => x.Id_Curso == idCurso).FirstOrDefault();
                        modificarCursoForm modificarCurso = new modificarCursoForm(cursoSeleccionado);

                        if (alumnosCursando != 0)
                        {
                            DialogResult respuesta = MessageBox.Show("El curso seleccionado tiene alumnos cursandolo", "¿Modificar curso de todos modos?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if(respuesta == DialogResult.Yes)
                            {
                                if (modificarCurso.ShowDialog() == DialogResult.Cancel)
                                {
                                    cboFamilia_SelectedIndexChanged(sender, e);
                                }
                            }
                            
                        }
                        else
                        {
                            if (modificarCurso.ShowDialog() == DialogResult.Cancel)
                            {
                                cboFamilia_SelectedIndexChanged(sender, e);
                            }
                        }
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
                    var idCurso = (int)dataGrid.CurrentRow.Cells[0].Value;

                    var alumnosCursando = from alu in objDB.ALUMNOS
                                          join cur in objDB.CURSOS on alu.Curso equals cur.Id_Curso
                                          where cur.Id_Curso == idCurso
                                          select alu;

                    var cantidadAlumnos = alumnosCursando.Count();

                    if (cantidadAlumnos > 0)
                    {
                        DialogResult respuesta2 = MessageBox.Show("El curso seleccionado tiene alumnos cursandolo", "¿Eliminar curso de todos modos?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (respuesta2 == DialogResult.Yes)
                        {
                            foreach (var alumno in alumnosCursando)
                            {
                               alumno.Curso = null;
                            }

                            var curso = objDB.CURSOS.Where(x => x.Id_Curso == idCurso).FirstOrDefault();
                            objDB.CURSOS.Remove(curso);
                            objDB.SaveChanges();
                            MessageBox.Show("Curso eliminado correctamente", "Curso eliminado también de alumnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cboFamilia_SelectedIndexChanged(sender, e);
                        }
                    }
                    else
                    {

                        // Instanciar el curso por su ID
                        var curso = objDB.CURSOS.Where(x => x.Id_Curso == idCurso).FirstOrDefault();

                        if (curso != null)
                        {
                            objDB.CURSOS.Remove(curso);
                            objDB.SaveChanges();
                            cboFamilia_SelectedIndexChanged(sender, e);
                            MessageBox.Show("Curso eliminado correctamente", "Eliminar curso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("El curso no se encuentra en la base de datos", "Eliminar curso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }


        private void btnAñadir_Click(object sender, EventArgs e)
        {
            // No mostramos un mensaje, simplemente abrimos el formulario modal

            modificarCursoForm modificarCurso = new modificarCursoForm(null);

            // Si el usuario hace clic en Cancelar en el formulario modal
            if (modificarCurso.ShowDialog() == DialogResult.Cancel)
            {

                // Realizar otras acciones si es necesario
                cboFamilia_SelectedIndexChanged(sender, e);
            }
        }


        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboFamilia_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (gestorcursosformacionEntities objDB = new gestorcursosformacionEntities())
            {
                string nombreFamiliaSeleccionada = cboFamilia.SelectedItem?.ToString();
                 
                if (nombreFamiliaSeleccionada != null)
                {
                    // Convertir el nombre de la familia antes de la consulta LINQ
                    var respuesta = from fam in objDB.FAMILIAS
                                    join cur in objDB.CURSOS on fam.Id_Familia equals cur.Familia
                                    join est in objDB.ESTADOS on cur.Estado equals est.Id_Estado
                                    orderby cur.Fecha_Inicio descending
                                    where fam.Nombre_Familia == nombreFamiliaSeleccionada
                                    select new
                                    {
                                        idCurso = cur.Id_Curso,
                                        Nombre_Curso = cur.Nombre_Curso,
                                        Numero_Horas = cur.Horas,
                                        Estado = est.Nombre_Estado,
                                        Fecha_Inicio = cur.Fecha_Inicio,
                                        Fecha_Fin = cur.Fecha_Fin,
                                    };

                    dataGrid.DataSource = respuesta.ToList();
                    dataGrid.Columns[0].Visible = false;
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

        private void dataGrid_SelectionChanged(object sender, EventArgs e)
        {
            using (gestorcursosformacionEntities objDB = new gestorcursosformacionEntities())
            {
                try
                {
                    // Verificar si hay una fila seleccionada
                    if (dataGrid.CurrentRow != null)
                    {
                        // Obtener el ID del curso
                        idCurso = (int)dataGrid.CurrentRow.Cells[0].Value;

                        // Instanciar el curso por su ID
                        curso = objDB.CURSOS.FirstOrDefault(x => x.Id_Curso == idCurso);
                    }
                    else
                    {
                        // No hay una fila seleccionada, puedes manejar este caso según sea necesario
                        MessageBox.Show("Ningún curso seleccionado");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al seleccionar el curso: " + ex.Message);
                }
            }

        }


    }
}