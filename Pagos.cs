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
    public partial class Pagos : Form
    {
        public Pagos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void editar_Click(object sender, EventArgs e)
        {
            AgregarPago();
            InfoPago();
            Limpiar();

        }
        Conexion conexion = new Conexion();
        public void AgregarPago()
        {
            conexion.Conectar();
            SqlCommand cmd = new SqlCommand("AgregarPago", conexion.getConnection());

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idConfeccion", idconfeccion.Text);
            cmd.Parameters.AddWithValue("@monto", monto.Text);
            cmd.Parameters.AddWithValue("@fecha", fecha.Value);
            cmd.Parameters.AddWithValue("@formadepago", formapago.Text);
            cmd.Parameters.AddWithValue("@idusuario", 1);
            cmd.Parameters.AddWithValue("@numcuenta", nocuenta.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Operacion realizada correctamente", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conexion.Desconectar();
            conexion.ActualizarGrid(dataGridView1, "select * from pagos where confeccion = " + idconfeccion.Text + "");

        }

        private void Pagos_Load(object sender, EventArgs e)
        {
            idconfeccion.Focus();
        }

        private void idconfeccion_KeyPress(object sender, KeyPressEventArgs e)
        {




        }

        public void Limpiar()
        {
            idconfeccion.Clear();
            monto.Clear();
            idconfeccion.Clear();
            monto.Clear();
            formapago.Clear();
            nocuenta.Clear();
        }
        private void guardar_Click(object sender, EventArgs e)
        {

        }

        private void idconfeccion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                monto.Focus();
                InfoPago();
            }
        }
        public void InfoPago()
        {
            conexion.ActualizarGrid(dataGridView1, "select * from pagos where confeccion = " + idconfeccion.Text + "");


            conexion.Conectar();
            SqlCommand cmdLogIn = new SqlCommand("select * from InfoPago where Id = @confeccion", conexion.getConnection());
            cmdLogIn.CommandType = CommandType.Text;

            cmdLogIn.Parameters.AddWithValue("@confeccion", idconfeccion.Text);
            SqlDataReader dr = cmdLogIn.ExecuteReader();

            if (dr.Read())
            {
                cliente.Text = dr[1].ToString();
                descripcion.Text = dr[2].ToString();
                fecha.Text = dr[3].ToString();
                total.Text = dr[4].ToString();
                totalpagado.Text = dr[5].ToString();
                balancependiente.Text = dr[6].ToString();

            }
            dr.Close();
            conexion.Desconectar();
        }

        private void monto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fecha.Focus();
            }
        }

        private void fecha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                formapago.Focus();
            }
        }

        private void formapago_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nocuenta.Focus();
            }
        }

        private void nocuenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guardar.Focus();
            }
        }
    }
}
