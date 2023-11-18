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
    public partial class InformesForm : Form
    {
        public InformesForm()
        {
            InitializeComponent();
        }

        private void btnCancelado_Click(object sender, EventArgs e)
        {
            //nombre de curso o cursos en estado "Cancelado" con mayor número de laumnos matriculados
            gestorcursosformacionEntities objDB = new gestorcursosformacionEntities();
            var cursosCancelados = from est in objDB.ESTADOS
                                   join cur in objDB.CURSOS on est.Id_Estado equals cur.Estado
                                   where est.Nombre_Estado == "Cancelado"
                                   select cur;

            var alumnosPorCurso = objDB.ALUMNOS.ToList();
            var cursos = objDB.CURSOS.ToList();
            var cursosCanceladosConAlumnos = new List<CURSOS>();
            foreach (var curso in cursosCancelados)
            {
                var alumnosPorCursoCancelado = alumnosPorCurso.Where(x => x.Curso == curso.Id_Curso).ToList();
                if (alumnosPorCursoCancelado.Count > 0)
                {
                    cursosCanceladosConAlumnos.Add(curso);
                }
            }
            var cursosCanceladosConAlumnosOrdenados = cursosCanceladosConAlumnos.OrderByDescending(x => x.ALUMNOS.Count).ToList();
            var cursoMasAlumnos = cursosCanceladosConAlumnosOrdenados.FirstOrDefault();
            var nombreCursoMasAlumnos = cursoMasAlumnos.Nombre_Curso;

            dataGridView1.DataSource = cursosCanceladosConAlumnosOrdenados;
            ocultarColumnas();
        }

        private void btnFamilia_Click(object sender, EventArgs e)
        {
            // nombre de la familia profesional que mas cursos creados tenga
            gestorcursosformacionEntities objDB = new gestorcursosformacionEntities();
            var cursos = objDB.CURSOS.ToList();
            var familias = objDB.FAMILIAS.ToList();
            var cursosPorFamilia = new List<CURSOS>();
            foreach (var familia in familias)
            {
                var cursosPorFamiliaActual = cursos.Where(x => x.Familia == familia.Id_Familia).ToList();
                if (cursosPorFamiliaActual.Count > 0)
                {
                    cursosPorFamilia.AddRange(cursosPorFamiliaActual);
                }
            }
            var cursosPorFamiliaOrdenados = cursosPorFamilia.OrderByDescending(x => x.Familia).ToList();
            var familiaMasCursos = cursosPorFamiliaOrdenados.Take(1).ToList();
            
            dataGridView1.DataSource = familiaMasCursos;
            ocultarColumnas();
                
        }
        private void ocultarColumnas()
        {
            dataGridView1.Columns["ALUMNOS"].Visible = false;
            dataGridView1.Columns["ESTADOS"].Visible = false;
            dataGridView1.Columns["Id_Curso"].Visible = false;
            dataGridView1.Columns["Estado"].Visible = false;
            dataGridView1.Columns["Familias"].Visible = false;
            dataGridView1.Columns["Nombre_Curso"].HeaderText = "Nombre del curso";
        }
    }
}
