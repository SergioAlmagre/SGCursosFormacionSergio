using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGCursosFormacionSergio
{
    public partial class InscripcionForm : Form
    {
        public int idAlumno { get; set; }   
        public InscripcionForm()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarTodo();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (gestorcursosformacionEntities objDB = new gestorcursosformacionEntities())
            {

                var resultado = from alu in objDB.ALUMNOS
                                select new
                                {
                                    alu.Id_Alumno,
                                    DNI = alu.Dni,
                                    Nombre = alu.Nombre,
                                    Apellidos = alu.Apellidos,
                                    Email = alu.Email,
                                };


                if (!string.IsNullOrEmpty(txtDni.Text))
                {
                    resultado = from res in resultado
                                where res.DNI.ToUpper().StartsWith(txtDni.Text.Trim().ToUpper())
                                select (res);
                }

                if (!string.IsNullOrEmpty(txtNombre.Text))
                {
                    resultado = from res in resultado
                                where res.Nombre.ToUpper().StartsWith(txtNombre.Text.Trim().ToUpper())
                                select (res);
                }

                if (!string.IsNullOrEmpty(txtApellidos.Text))
                {
                    resultado = from res in resultado
                                where res.Apellidos.ToUpper().StartsWith(txtApellidos.Text.Trim().ToUpper())
                                select (res);

                }

                if (!string.IsNullOrEmpty(txtEmail.Text))
                {
                    resultado = from res in resultado
                                where res.Email.ToUpper().StartsWith(txtEmail.Text.Trim().ToUpper())
                                select (res);
                }

                dataGridInscripcion.DataSource = resultado.ToList();

                ////Si quieres ocultar algunas columnas
                dataGridInscripcion.Columns[0].Visible = false;


                ////Si quieres cambiar el nombre de las columnas que se muestran
                //dataGridView1.Columns[1].HeaderText = "Título de pelicula";
                //dataGridView1.Columns[2].HeaderText = "Año";
                //dataGridView1.Columns[3].HeaderText = "Director";
                //dataGridView1.Columns[4].HeaderText = "Estilo";
                //dataGridView1.Columns[5].HeaderText = "Fecha de alquiler";
                //dataGridView1.Columns[6].HeaderText = "Apellido del socio";
                //dataGridView1.Columns[7].HeaderText = "Nombre del socio";
                //dataGridView1.Columns[8].HeaderText = "Categoría";

            }


        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            if (idAlumno != 0)
            {
                using (gestorcursosformacionEntities objDB = new gestorcursosformacionEntities())
                {
                    var alumnoSeleccionado = from alu in objDB.ALUMNOS
                                             where alu.Id_Alumno == idAlumno
                                             select alu;

                    var cursoEnDesarrollo = from cur in objDB.CURSOS
                                            join est in objDB.ESTADOS on cur.Estado equals est.Id_Estado
                                            join alu in objDB.ALUMNOS on cur.Id_Curso equals alu.Curso
                                            where est.Nombre_Estado == "En desarrollo" && alu.Id_Alumno == idAlumno
                                            select cur;

                    if (cursoEnDesarrollo.ToList().Count == 0)
                    {
                        ModalInscripcion modalInscripcion = new ModalInscripcion();
                        modalInscripcion.idAlumno = idAlumno;
                        if (modalInscripcion.ShowDialog() == DialogResult.Cancel)
                        {
                            // Realizar otras acciones si es necesario
                            dataGridInscripcion_SelectionChanged(sender, e);
                        }

                    }
                    else
                    {
                        MessageBox.Show("El alumno tiene algún curso en desarrollo y no puede inscribirse");
                        return;
                    }

                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún alumno");
            }


        }

            
        private void limpiarTodo()
        {
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtDni.Text = "";
            txtEmail.Text = "";
            dataGridInscripcion.DataSource = null;
            txtNombre.Focus();
        }

        private void dataGridInscripcion_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridInscripcion.CurrentRow != null)
            {
                idAlumno = Convert.ToInt32(dataGridInscripcion.CurrentRow.Cells[0].Value);
            }
            
        }
    }
}
