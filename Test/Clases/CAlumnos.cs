using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Test.Clases
{
    internal class CAlumnos
    {

        public void MostrarAlumnos(DataGridView tablaAlumnos) {

            CConecxion objectoConexion = new CConecxion();

            try{

                tablaAlumnos.DataSource = null;
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Alumno;", objectoConexion.estableceConexion());

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                tablaAlumnos.DataSource = dt;

                objectoConexion.cerrarConexion();

            }
            catch (Exception ex){
                MessageBox.Show("No se logro mostrar registros, error = "+ ex.ToString());
            
            }
        


        
        }

        public void GuardarAlumnos(TextBox paramDNI,TextBox paramNombres, TextBox paramApellido,TextBox paramEdad )
        {

            CConecxion objectoConexion = new CConecxion();

            try
            {
                string query = "insert into Alumno (dni, nombre, apellido, edad) values ('"+paramDNI.Text+"','"+paramNombres.Text+"','"+paramApellido.Text+"',"+paramEdad.Text +")";
                SqlCommand cmd = new SqlCommand(query, objectoConexion.estableceConexion());
                SqlDataReader myReader;
                myReader = cmd.ExecuteReader();

                MessageBox.Show("Se guardo correctamente");
                
             


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro mostrar registros, error = " + ex.ToString());

            }


        }

        public void SeleccionarAlumno(DataGridView tablaAlumnos,TextBox paramId, TextBox paramDNI , TextBox paramNombres, TextBox paramApellido, TextBox paramEdad)
        {
            try { 
                paramId.Text = tablaAlumnos.CurrentRow.Cells[0].Value.ToString();
                paramDNI.Text = tablaAlumnos.CurrentRow.Cells[1].Value.ToString();
                paramNombres.Text = tablaAlumnos.CurrentRow.Cells[2].Value.ToString();
                paramApellido.Text = tablaAlumnos.CurrentRow.Cells[3].Value.ToString();
                paramEdad.Text = tablaAlumnos.CurrentRow.Cells[4].Value.ToString();
               
            }
            catch (Exception ex) {

                MessageBox.Show("No se logro seleccionar los registros, error ="+ex.ToString());
            }
        
        }

        public void EditarAlumno( TextBox paramId, TextBox paramDNI, TextBox paramNombre, TextBox paramApellido, TextBox paramEdad)
        {
            Clases.CConecxion objectoConexion = new CConecxion();

            try
            {
                string query= "update alumno set dni='"+paramDNI.Text+"',nombre = '"+paramNombre.Text+"',apellido ='"+paramApellido.Text+"', edad="+paramEdad.Text+" where id="+ paramId.Text;
                SqlCommand cmd = new SqlCommand(query, objectoConexion.estableceConexion());
                SqlDataReader myReader;
                myReader = cmd.ExecuteReader();

                

                MessageBox.Show("Se modifico correctamente");

            }
            catch (Exception ex)
            {

                MessageBox.Show("No se logro eliminar los registros, error =" + ex.ToString());
            }

        }

        public void EliminarAlumno(TextBox paramId)
        {
            Clases.CConecxion objectoConexion = new CConecxion();

            try
            {
                string query = "delete from alumno where id =" + paramId.Text;
                SqlCommand cmd = new SqlCommand(query, objectoConexion.estableceConexion());
                SqlDataReader myReader;
                myReader = cmd.ExecuteReader();



                MessageBox.Show("Se elimino correctamente");

            }
            catch (Exception ex)
            {

                MessageBox.Show("No se logro eliminar los registros, error =" + ex.ToString());
            }

        }

    }
}
