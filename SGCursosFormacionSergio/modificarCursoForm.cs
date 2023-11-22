using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGCursosFormacionSergio
{
    public partial class modificarCursoForm : Form
    {
        private CURSOS cursoSeleccionado;
        public modificarCursoForm(CURSOS cursoSeleccionado)
        {
            InitializeComponent();
            this.cursoSeleccionado = cursoSeleccionado;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (gestorcursosformacionEntities objDB = new gestorcursosformacionEntities())
            {
                try
                {
                    // Validar que los campos nombre y horas no estén vacios
                    if (string.IsNullOrWhiteSpace(txtNombreCurso.Text) || string.IsNullOrWhiteSpace(txtHoras.Text))
                    {
                        MessageBox.Show("Debe rellenar todos los campos", "Modificar curso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Validar que las horas sean solo números
                    if (!EsNumero(txtHoras.Text))
                    {
                        MessageBox.Show("Las horas deben ser un número válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    CURSOS nuevoCurso = new CURSOS();

                    // Asignar valores comunes
                    nuevoCurso.Nombre_Curso = txtNombreCurso.Text;
                    nuevoCurso.Horas = Convert.ToInt32(txtHoras.Text);
                    nuevoCurso.Fecha_Inicio = dtpFechaInicio.Value;
                    nuevoCurso.Fecha_Fin = dtpFechaFin.Value;


                    // Asignar estado
                    var estadoSeleccionado = cboEstado.Text;
                    var estadoEncontrado = objDB.ESTADOS.FirstOrDefault(x => x.Nombre_Estado == estadoSeleccionado);

                    if (estadoEncontrado == null)
                    {
                        MessageBox.Show($"El estado '{estadoSeleccionado}' no se encuentra en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    nuevoCurso.ESTADOS = estadoEncontrado;

                    // Asignar familia
                    var familiaSeleccionada = cboFamilia.Text;
                    var familiaEncontrada = objDB.FAMILIAS.FirstOrDefault(x => x.Nombre_Familia == familiaSeleccionada);

                    if (familiaEncontrada == null)
                    {
                        MessageBox.Show($"La familia '{familiaSeleccionada}' no se encuentra en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    nuevoCurso.FAMILIAS = familiaEncontrada;

                    if(cursoSeleccionado == null)
                    {
                        objDB.CURSOS.Add(nuevoCurso);
                        // Guardar cambios
                        objDB.SaveChanges();
                        MessageBox.Show("Curso insertado correctamente");
                    }
                    else
                    {
                        // Buscar el curso existente por su ID
                        CURSOS cursoExistente = objDB.CURSOS.Find(cursoSeleccionado.Id_Curso);

                        // Actualizar propiedades del curso existente con los valores del nuevo objeto
                        cursoExistente.Nombre_Curso = txtNombreCurso.Text;
                        cursoExistente.Horas = Convert.ToInt32(txtHoras.Text);
                        cursoExistente.Fecha_Inicio = dtpFechaInicio.Value;
                        cursoExistente.Fecha_Fin = dtpFechaFin.Value;
                        cursoExistente.ESTADOS = estadoEncontrado;
                        cursoExistente.FAMILIAS = familiaEncontrada;

                        // Guardar cambios
                        objDB.SaveChanges();
                        MessageBox.Show("Curso modificado correctamente");
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void modificarCursoForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsDB.FAMILIAS' Puede moverla o quitarla según sea necesario.
            this.fAMILIASTableAdapter.Fill(this.dsDB.FAMILIAS);
            // TODO: esta línea de código carga datos en la tabla 'dsDB.CURSOS' Puede moverla o quitarla según sea necesario.
            this.cURSOSTableAdapter.Fill(this.dsDB.CURSOS);
            // TODO: esta línea de código carga datos en la tabla 'dsDB.ESTADOS' Puede moverla o quitarla según sea necesario.
            this.eSTADOSTableAdapter.Fill(this.dsDB.ESTADOS);

           cargarTextos();
        }

        public void cargarTextos()
        {
            using (gestorcursosformacionEntities objDB = new gestorcursosformacionEntities())
            {
                var estados = objDB.ESTADOS.ToList();
                var familias = objDB.FAMILIAS.ToList();
                var cursos = objDB.CURSOS.ToList();

                if (cursoSeleccionado != null)
                {
                    foreach (var estado in estados.OrderBy(x => x.Nombre_Estado))
                    {
                        cboEstado.Items.Add(estado.Nombre_Estado);
                    }

                    foreach (var familia in familias.OrderBy(x => x.Nombre_Familia))
                    {
                        cboFamilia.Items.Add(familia.Nombre_Familia);
                    }

                    txtNombreCurso.Text = cursoSeleccionado.Nombre_Curso;
                    txtHoras.Text = cursoSeleccionado.Horas.ToString();
                    dtpFechaInicio.Value = cursoSeleccionado.Fecha_Inicio;
                    dtpFechaFin.Value = cursoSeleccionado.Fecha_Fin;


                    var nombreFamiliaSeleccionada = objDB.FAMILIAS.Where(x => x.Id_Familia == cursoSeleccionado.Familia).FirstOrDefault().Nombre_Familia.ToString();
                    cboFamilia.Text = nombreFamiliaSeleccionada;
                    var nombreEstadoSeleccionado = objDB.ESTADOS.Where(x => x.Id_Estado == cursoSeleccionado.Estado).FirstOrDefault().Nombre_Estado.ToString();
                    cboEstado.Text = nombreEstadoSeleccionado;
                }
                else
                {
                    // Agregar elemento requerido por ejercicio cuando el curso es nuevo
                    var estadoInscripcion = objDB.ESTADOS.Where(x => x.Nombre_Estado == "Inscripción").FirstOrDefault();
                    cboEstado.Items.Add(estadoInscripcion.Nombre_Estado);

                    foreach (var familia in familias.OrderBy(x => x.Nombre_Familia))
                    {
                        cboFamilia.Items.Add(familia.Nombre_Familia);
                    }

                    foreach (var curso in cursos.OrderBy(x => x.Nombre_Curso))
                    {
                        // Formato personalizado para mostrar la fecha
                        string formattedDateInicio = curso.Fecha_Inicio.ToString("dddd, d 'de' MMMM 'de' yyyy");
                        string formattedDateFin = curso.Fecha_Fin.ToString("dddd, d 'de' MMMM 'de' yyyy");

                        formattedDateInicio = dtpFechaInicio.Text; // Agregar la fecha de inicio
                        formattedDateFin = dtpFechaFin.Text; // Agregar la fecha de fin
                    }
                }
            }
        }


        // Función para verificar si una cadena es un número
        private bool EsNumero(string input)
        {
            return Regex.IsMatch(input, @"^\d+$");
        }


    }
}
