using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ConfeccionesLuis
{
    public partial class Usuarios : Form
    {
        int idacceso;
        //bool editar = false;
        Conexion conn = new Conexion();
        public Usuarios()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Usuarios_Load(object sender, EventArgs e)/////////// load////
        {
            mostrarUsuarios();
        }
        public void agregaraccesos()
        {
            // editar = true;
            conn.Conectar();
            SqlCommand cmd = new SqlCommand("agregaracceso", conn.getConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", txtidacceso.Text);
            cmd.Parameters.AddWithValue("@pconfeccion", chconfecciones.Checked);
            cmd.Parameters.AddWithValue("@ppagos", chpagos.Checked);
            cmd.Parameters.AddWithValue("@pconsulta", chconsultas.Checked);
            cmd.Parameters.AddWithValue("@pinventario", chinventario.Checked);
            cmd.Parameters.AddWithValue("@pusuarios", chusuarios.Checked);
            cmd.Parameters.AddWithValue("@pclientes", chclientes.Checked);
            cmd.Parameters.AddWithValue("@pparametrizacion", chparametrizacion.Checked);
            cmd.Parameters.AddWithValue("@pcompra", chCompra.Checked);
            cmd.ExecuteNonQuery();

            /*SqlDataAdapter da = new SqlDataAdapter(cmd);
             DataTable tbl = new DataTable();
             da.Fill(tbl);
             InfoSistema.idacceso = tbl.Rows[0][0].ToString();
             txtidacceso.Text = InfoSistema.idacceso.ToString();*/
            conn.Desconectar();

        }

        public void agregarUsuarios()
        {
            // editar = true;
            conn.Conectar();
            SqlCommand cmd = new SqlCommand("agregarUsuarios", conn.getConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", txtid.Text);
            cmd.Parameters.AddWithValue("@usuario", txtusuario.Text);
            cmd.Parameters.AddWithValue("@pass", txtpass.Text);
            cmd.Parameters.AddWithValue("@nombre", txtnombre.Text);
            cmd.Parameters.AddWithValue("@idAcceso", retornaridacceso());
            cmd.ExecuteNonQuery();
            conn.Desconectar();
            MessageBox.Show("usuario agregado correctamente!");

        }

        public void mostrarUsuarios()
        {
            conn.Conectar();
            SqlCommand cmd = new SqlCommand("select * from Usuarios as a inner join Accesos as b on(a.IdAcceso= b.Id)", conn.getConnection());
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            dgvusuarios.DataSource = tbl;
            conn.Desconectar();
        }

        public int retornaridacceso()
        {
            SqlCommand cmd = new SqlCommand("select max(Id) from Accesos", conn.getConnection());
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            idacceso = int.Parse(tbl.Rows[0][0].ToString());
            return idacceso;

        }

        private void cantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtid.Text) || string.IsNullOrEmpty(txtusuario.Text) || string.IsNullOrEmpty(txtpass.Text) || string.IsNullOrEmpty(txtnombre.Text))
            {
                MessageBox.Show("Hay campos vacios");
          
            }
            else
            {
                agregaraccesos();
                agregarUsuarios();
                mostrarUsuarios();
            }

            
        }

        private void dgvusuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgvusuarios.CurrentRow.Cells[0].Value.ToString();
            txtusuario.Text = dgvusuarios.CurrentRow.Cells[1].Value.ToString();
            txtpass.Text = dgvusuarios.CurrentRow.Cells[2].Value.ToString();
            txtnombre.Text = dgvusuarios.CurrentRow.Cells[3].Value.ToString();

                if(dgvusuarios.CurrentRow.Cells[6].Value.ToString() == "1")
            {
                chconfecciones.Checked = true;
            }
            else
            {
                chconfecciones.Checked = false;
            }

            if (dgvusuarios.CurrentRow.Cells[7].Value.ToString() == "1")
            {
                chpagos.Checked = true;
            }
            else
            {
                chpagos.Checked = false;
            }

            if (dgvusuarios.CurrentRow.Cells[8].Value.ToString() == "1")
            {
                chconsultas.Checked = true;
            }
            else
            {
                chconsultas.Checked = false;
            }

            if (dgvusuarios.CurrentRow.Cells[9].Value.ToString() == "1")
            {
                chinventario.Checked = true;
            }
            else
            {
                chinventario.Checked = false;
            }

            if (dgvusuarios.CurrentRow.Cells[10].Value.ToString() == "1")
            {
                chusuarios.Checked = true;
            }
            else
            {
                chusuarios.Checked = false;
            }

            if (dgvusuarios.CurrentRow.Cells[11].Value.ToString() == "1")
            {
                chclientes.Checked = true;
            }
            else
            {
                chclientes.Checked = false;
            }

            if (dgvusuarios.CurrentRow.Cells[12].Value.ToString() == "1")
            {
                chparametrizacion.Checked = true;
            }
            else
            {
                chparametrizacion.Checked = false;
            }

            if (dgvusuarios.CurrentRow.Cells[13].Value.ToString() == "1")
            {
                chCompra.Checked = true;
            }
            else
            {
                chCompra.Checked = false;
            }
        }

        private void txtid_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
            {
                txtusuario.Focus();
            }
        }

        private void txtusuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtpass.Focus();
            }
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtnombre.Focus();
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtusuario.Clear();
            txtpass.Clear();
            txtnombre.Clear();

            chconfecciones.Checked = false;
            chpagos.Checked = false;
            chclientes.Checked = false;
            chconsultas.Checked = false;
            chinventario.Checked = false;
            chCompra.Checked = false;
            chusuarios.Checked = false;
            chparametrizacion.Checked = false;
        }

        private void dgvusuarios_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
