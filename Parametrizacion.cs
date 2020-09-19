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
    public partial class Parametrizacion : Form
    {
        public Parametrizacion()
        {
            InitializeComponent();
        }
         
        Conexion conexion = new Conexion();
        //int id;
        bool editar = false;

        public void LimpiarTT()
        {
            idTT.Clear();
            nombreTT.Clear();
            nombreTT.Focus();
            editar = false;
        }
        public void LimpiarTP()
        {
            idTP.Clear();
            nombreTP.Clear();
            nombreTP.Focus();
            editar = false;
        }
        private void guardar_Click(object sender, EventArgs e)
        {
            if (editar)
            {
                ModificaTT();

            }
            else
            {
                AgregaTT();
            } 
        }
        public void AgregaTT()
        {
            conexion.Conectar();
            SqlCommand cmd = new SqlCommand("AgregaTT", conexion.getConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nombre", nombreTT.Text); 

            cmd.ExecuteNonQuery();

            MessageBox.Show("Operacion realizada correctamente", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conexion.Desconectar();
            conexion.ActualizarGrid(dgvTT, "select * from TipoTela");
            LimpiarTT();

        }
        public void ModificaTT()
        {
            conexion.Conectar();
            SqlCommand cmd = new SqlCommand("ModificaTT", conexion.getConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", idTT.Text);
            cmd.Parameters.AddWithValue("@nombre", nombreTT.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Operacion realizada correctamente", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conexion.Desconectar();
            conexion.ActualizarGrid(dgvTT, "select * from TipoTela");

        }

        public void AgregaTP()
        {
            conexion.Conectar();
            SqlCommand cmd = new SqlCommand("AgregaTP", conexion.getConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nombre", nombreTP.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Operacion realizada correctamente", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conexion.Desconectar();
            conexion.ActualizarGrid(dgvTP, "select * from TipoPagos");

        }
        public void ModificaTP()
        {
            conexion.Conectar();
            SqlCommand cmd = new SqlCommand("ModificaTP", conexion.getConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", idTT.Text);
            cmd.Parameters.AddWithValue("@nombre", nombreTT.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Operacion realizada correctamente", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conexion.Desconectar();
            conexion.ActualizarGrid(dgvTP, "select * from TipoPagos");
            LimpiarTP();

        }
        public void EliminaTT()
        {
            conexion.Conectar();
            SqlCommand cmd = new SqlCommand("EliminaTT", conexion.getConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", idTT.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Operacion realizada correctamente", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conexion.Desconectar();
            conexion.ActualizarGrid(dgvTT, "select * from TipoTela");
            LimpiarTT();

        }

        public void EliminaTP()
        {
            conexion.Conectar();
            SqlCommand cmd = new SqlCommand("EliminaTP", conexion.getConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", idTP.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Operacion realizada correctamente", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conexion.Desconectar();
            conexion.ActualizarGrid(dgvTP, "select * from TipoPagos");
            LimpiarTP();
        }


        private void dgvTT_DoubleClick(object sender, EventArgs e)
        {
            idTT.Text =  this.dgvTT.CurrentRow.Cells[0].Value.ToString();
            nombreTT.Text = this.dgvTT.CurrentRow.Cells[1].Value.ToString();
            editar = true;
        }

        private void dgvTP_DoubleClick(object sender, EventArgs e)
        {
            idTP.Text = this.dgvTP.CurrentRow.Cells[0].Value.ToString();
            nombreTP.Text = this.dgvTP.CurrentRow.Cells[1].Value.ToString();
            editar = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (editar)
            {
                ModificaTP();

            }
            else
            {
                AgregaTP();
            }
        }

        private void Parametrizacion_Load(object sender, EventArgs e)
        {
            conexion.ActualizarGrid(dgvTT, "select * from TipoTela");
            conexion.ActualizarGrid(dgvTP, "select * from TipoPagos");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EliminaTT();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EliminaTP();
        }
    }
}
