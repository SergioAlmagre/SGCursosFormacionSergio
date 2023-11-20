using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

        public int idCurso { get; set; }
        public string nombreCurso { get; set; }
        public int horas { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public string familia { get; set; }
        public string estado { get; set; }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (gestorcursosformacionEntities objDB = new gestorcursosformacionEntities())
            {
                try
                {
                    if (txtNombreCurso.Text == "" || txtHoras.Text == "")
                    {
                        MessageBox.Show("Debe rellenar todos los campos", "Modificar curso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //Creamos el objeto 
                        CURSOS objCat = new CURSOS();

                        objCat.Nombre_Curso = txtNombreCurso.Text;
                        objCat.Horas = Convert.ToInt32(txtHoras.Text);

                        string fechaInicioString = cboFechaInicio.Text;
                        string fechaFinString = cboFechaFin.Text;

                        DateTime fechaInicio, fechaFin;

                        if (DateTime.TryParseExact(fechaInicioString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaInicio))
                        {
                            objCat.Fecha_Inicio = fechaInicio;
                        }
                        else
                        {
                            // La conversión falló, puedes mostrar un mensaje al usuario o tomar medidas adecuadas.
                            MessageBox.Show("Formato de fecha de inicio no válido. Utilice el formato dd/MM/yyyy.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // o realiza alguna otra acción apropiada
                        }

                        if (DateTime.TryParseExact(fechaFinString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaFin))
                        {
                            objCat.Fecha_Fin = fechaFin;
                        }
                        else
                        {
                            // La conversión falló, puedes mostrar un mensaje al usuario o tomar medidas adecuadas.
                            MessageBox.Show("Formato de fecha de fin no válido. Utilice el formato dd/MM/yyyy.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // o realiza alguna otra acción apropiada
                        }



                        //capturar el número correspondiente al estado seleccionado
                        var estadoSeleccionado = cboEstado.Text;

                        // Buscar el estado en la base de datos
                        var estadoEncontrado = objDB.ESTADOS.Where(x => x.Nombre_Estado == estadoSeleccionado).FirstOrDefault();

                        if (estadoEncontrado != null)
                        {
                            // El estado se encontró en la base de datos
                            var idEstado = estadoEncontrado.Id_Estado;
                            objCat.ESTADOS = estadoEncontrado; // Asignar directamente el estado encontrado

                        }
                        else
                        {
                            // El estado no se encontró en la base de datos
                            MessageBox.Show($"El estado '{estadoSeleccionado}' no se encuentra en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // o realiza alguna otra acción apropiada
                        }


                        //capturar el número correspondiente a la familia seleccionada
                        var familiaSeleccionada = cboFamilia.Text;
                        var familiaEncontrada = objDB.FAMILIAS.Where(x => x.Nombre_Familia == familiaSeleccionada).FirstOrDefault();

                        if (familiaEncontrada != null)
                        {
                            // La familia se encontró en la base de datos
                            var idFamilia = familiaEncontrada.Id_Familia;
                            objCat.FAMILIAS = familiaEncontrada; // Asignar directamente la familia encontrada
                        }
                        else
                        {
                            // La familia no se encontró en la base de datos
                            MessageBox.Show($"La familia '{familiaSeleccionada}' no se encuentra en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // o realiza alguna otra acción apropiada
                        }

                        //se añade el objeto a la tabla, para incluirlo como nuevo registro
                        if (idCurso == 0)
                        {
                                
                                objDB.CURSOS.Add(objCat);
                                objDB.SaveChanges();
                                MessageBox.Show("Curso insertado o modificado correctamente");
                        }
                        else
                        {
                            // Buscar el curso por su ID
                            var curso = objDB.CURSOS.FirstOrDefault(x => x.Id_Curso == idCurso);

                            if (curso != null)
                            {
                                curso.Nombre_Curso = objCat.Nombre_Curso;
                                curso.Horas = objCat.Horas;
                                curso.Fecha_Inicio = objCat.Fecha_Inicio;
                                curso.Fecha_Fin = objCat.Fecha_Fin;
                                curso.ESTADOS = objCat.ESTADOS;
                                curso.FAMILIAS = objCat.FAMILIAS;

                                //se guardan los cambios
                                objDB.SaveChanges();
                                MessageBox.Show("Curso insertado o modificado correctamente");
                            }
                        }
                    }
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                {
                    foreach (var entityValidationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in entityValidationErrors.ValidationErrors)
                        {
                            MessageBox.Show($"Error de validación en {validationError.PropertyName}: {validationError.ErrorMessage}", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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

           cargarCombos();
        }

        private void cargarCombos()
        {
            using (gestorcursosformacionEntities objDB = new gestorcursosformacionEntities())
            {
                // Limpiar elementos antiguos antes de agregar nuevos
                cboEstado.Items.Clear();
                cboFamilia.Items.Clear();
                cboFechaInicio.Items.Clear();
                cboFechaFin.Items.Clear();

                var estados = objDB.ESTADOS.ToList();
                var familias = objDB.FAMILIAS.ToList();
                var cursos = objDB.CURSOS.ToList();

                if (idCurso  != 0)
                {
                    txtNombreCurso.Text = nombreCurso;
                    txtHoras.Text = horas.ToString();
                    cboFechaInicio.Text = fechaInicio.ToString("dd/MM/yyyy");
                    cboFechaFin.Text = fechaFin.ToString("dd/MM/yyyy");

                    foreach (var estado in estados.OrderBy(x => x.Nombre_Estado))
                    {
                        cboEstado.Items.Add(estado.Nombre_Estado);
                    }

                    foreach (var familia in familias.OrderBy(x => x.Nombre_Familia))
                    {
                        cboFamilia.Items.Add(familia.Nombre_Familia);
                    }

                    cboFamilia.Text = familia;
                    cboEstado.Text = estado;
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

                        cboFechaInicio.Items.Add(formattedDateInicio); // Agregar la fecha de inicio
                        cboFechaFin.Items.Add(formattedDateFin); // Agregar la fecha de fin
                    }
                }  
            }
        }
    }
}
