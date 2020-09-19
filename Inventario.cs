using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfeccionesLuis
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }
        Conexion conexion = new Conexion();

        public void GenerarInventario()
        {

        }
        private void editar_Click(object sender, EventArgs e)
        {
                  conexion.ActualizarGrid(dgvcompras, " select * from viewCompras where [FECHA] BETWEEN '" + desde.Value + "' AND '" + hasta.Value+"'");

            //conexion.ActualizarGrid(dgvventas, "SET DATEFORMAT YMD select * from Vista_Confeccion where [Fecha] BETWEEN '" + desde.Value.ToShortDateString() + "' AND '" + hasta.Value.ToShortDateString() + "';");
            //Ganancia();
            //Capital();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {

        }
        public void Ganancia()
        {
            
            conexion.Conectar();
            SqlCommand cmdLogIn = new SqlCommand("SET DATEFORMAT YMD select sum(total) from viewcompras where fecha between @desde and @hasta ");
            cmdLogIn.CommandType = CommandType.Text;

            cmdLogIn.Parameters.AddWithValue("@desde", desde.Value.ToShortDateString());
            cmdLogIn.Parameters.AddWithValue("@hasta", hasta.Value.ToShortDateString());
            SqlDataReader dr = cmdLogIn.ExecuteReader();

            if (dr.Read())
            {
                ganancia.Text = dr[0].ToString();
                
            }
            dr.Close();
            conexion.Desconectar();
        }
        public void Capital()
        {
            
            conexion.Conectar();
            SqlCommand cmdLogIn = new SqlCommand("select sum(total) from Vista_Confeccion fecha between @desde and @hasta ");
            cmdLogIn.CommandType = CommandType.Text;

            cmdLogIn.Parameters.AddWithValue("@desde", desde.Value);
            cmdLogIn.Parameters.AddWithValue("@hasta", hasta.Value);
            SqlDataReader dr = cmdLogIn.ExecuteReader();

            if (dr.Read())
            {
                capital.Text = dr[0].ToString();

            }
            dr.Close();
            conexion.Desconectar();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
