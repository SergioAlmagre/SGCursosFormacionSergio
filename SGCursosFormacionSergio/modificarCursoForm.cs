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

                    if (txtNombreCurso.Text == "" || txtHoras.Text == "")
                    {
                        MessageBox.Show("Debe rellenar todos los campos", "Modificar curso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                    //Creamos el objeto 
                    CURSOS objCat = new CURSOS();

                    objCat.Id_Curso = 10;
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
                        objCat.ESTADOS = new ESTADOS();
                        objCat.ESTADOS.Id_Estado = idEstado;
                    }
                    else
                    {
                        // El estado no se encontró en la base de datos
                        MessageBox.Show($"El estado '{estadoSeleccionado}' no se encuentra en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // o realiza alguna otra acción apropiada
                    }



                    //capturar el número correspondiente a la familia seleccionada
                    var familiaSeleccionada = cboFamilia.Text;
                    var idFamilia = objDB.FAMILIAS.Where(x => x.Nombre_Familia == familiaSeleccionada).FirstOrDefault().Id_Familia;
                    objCat.FAMILIAS = new FAMILIAS();
                    objCat.FAMILIAS.Id_Familia = idFamilia;

                    //se añade el objeto a la tabla, para incluirlo como nuevo registro
                    objDB.CURSOS.Add(objCat);

                    //se guardan los cambios
                    objDB.SaveChanges();
                    MessageBox.Show("Curso insertado correctamente");
                }

            }




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
                var estados = objDB.ESTADOS.ToList();
                var familias = objDB.FAMILIAS.ToList();
                var cursos = objDB.CURSOS.ToList(); // Obtener la lista de cursos

                // Limpiar elementos antiguos antes de agregar nuevos
                cboEstado.Items.Clear();
                cboFamilia.Items.Clear();
                cboFechaInicio.Items.Clear();
                cboFechaFin.Items.Clear();

                // Agregar elementos al combo
                foreach (var estado in estados.OrderBy(x => x.Nombre_Estado))
                {
                    cboEstado.Items.Add(estado.Nombre_Estado);
                }

                foreach (var familia in familias.OrderBy(x => x.Nombre_Familia))
                {
                    cboFamilia.Items.Add(familia.Nombre_Familia);
                }

                foreach (var curso in cursos.OrderBy(x => x.Nombre_Curso))
                {
                    cboFechaInicio.Items.Add(curso.Fecha_Inicio); // Agregar la fecha de inicio
                    cboFechaFin.Items.Add(curso.Fecha_Fin); // Agregar la fecha de fin
                }
            }
        }




    }
}
