using ConfeccionesLuis.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfeccionesLuis
{
    class Conexion
    {
        public static string ObtenerString()
        {
            return Settings.Default.ConfeccionesLuisConnectionString;
        }
        SqlConnection conexion; //creando una variable tipo sqlconection

        //metodo para conectar con la base de datos sql
        public void Conectar()
        {
            conexion = new SqlConnection(ObtenerString());
            conexion.Open();
        }
        //obtener cadena de conexion
        public SqlConnection getConnection()
        {
            return conexion;

        }
        public void Desconectar() //metodo para desconectarse de la base de datos
        {
            conexion.Close();

        }
        public void ejecutarSql(string consulta) //metodo para ejecutar en sql las consultas realizadas 
        {
            SqlCommand com = new SqlCommand(consulta, conexion);

            int FilasAfectadas = com.ExecuteNonQuery();

            if (FilasAfectadas > 0)
            {
                MessageBox.Show("Operacion realizada correctamente", "La base de datos a sido modificada", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("No se a conectado a la base de datos", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }
        public void ActualizarGrid(DataGridView dg, string consulta) //metodo para actualizar el datagridview
        {
            this.Conectar();
            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(consulta, conexion);

            da.Fill(ds, "confecciones");
            dg.DataSource = ds;
            dg.DataMember = "confecciones";

            this.Desconectar();



        }
    }
}
