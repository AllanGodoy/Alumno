﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Test.Clases
{
    internal class CConecxion
    {
        SqlConnection conex = new SqlConnection();

        static String Servidor = "192.168.1.50";
        static String bd = "Test";
        static String usuario = "sa";
        static String contrasenia = "Taller+2023";
        static String puerto = "1433";

        String cadenaConexion ="Data Source="+Servidor+","+puerto+";"+"user id="+usuario+";"+"password="+contrasenia+";"+"Initial Catalog="+bd+";"+"Persist Security info=true";

        public SqlConnection estableceConexion() {
            try {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
               // MessageBox.Show("Se conecto correctamente");
            } catch (Exception ex){
                MessageBox.Show("No se conecto correctamente a la Base de Datos, error ="+ex.ToString());

            }

            return conex;
        }

        public void cerrarConexion() {
            conex.Close();
        }
    }
}
