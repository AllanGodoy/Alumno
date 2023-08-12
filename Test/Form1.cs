using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Clases.CAlumnos objetoAlumno = new Clases.CAlumnos();
            objetoAlumno.MostrarAlumnos(dgvAlumnos);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //private void btnGuardarRegistroEmpleado_Click(object sender, EventArgs e)
        //{
        //    txtNombre.Text = "Allan";
        //}

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            Clases.CAlumnos objetoAlumno = new Clases.CAlumnos();
            objetoAlumno.GuardarAlumnos(txtDNI, textNombre, txtApellido, txtEdad);
            objetoAlumno.MostrarAlumnos(dgvAlumnos);

            txtId.Text = "";
            txtDNI.Text = "";
            textNombre.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "";

        }

        private void dgvAlumnos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Clases.CAlumnos objetoalumno = new Clases.CAlumnos();
            objetoalumno.SeleccionarAlumno(dgvAlumnos, txtId, txtDNI, textNombre, txtApellido, txtEdad);

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Clases.CAlumnos objetoAlumno = new Clases.CAlumnos();
            objetoAlumno.EditarAlumno(txtId, txtDNI, textNombre, txtApellido, txtEdad);
            objetoAlumno.MostrarAlumnos(dgvAlumnos);
            txtId.Text = "";
            txtDNI.Text = "";
            textNombre.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Clases.CAlumnos objetoalumno = new Clases.CAlumnos();
            objetoalumno.EliminarAlumno(txtId);
            objetoalumno.MostrarAlumnos(dgvAlumnos);
           
            txtId.Text = "";
            txtDNI.Text = "";
            textNombre.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "";
        }

        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}