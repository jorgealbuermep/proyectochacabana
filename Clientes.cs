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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }
        int id;
        private void label1_Click(object sender, EventArgs e)
        {

        }
        Conexion conn = new Conexion();

        public void guardarCliente()
        {
            conn.Conectar();
            SqlCommand cmd = new SqlCommand("agregarcliente", conn.getConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cedula", txtcedula.Text.Trim());
            cmd.Parameters.AddWithValue("@nombres", txtnombres.Text.Trim());
            cmd.Parameters.AddWithValue("@apellidos", txtapellidos.Text.Trim());
            cmd.Parameters.AddWithValue("@direccion", txtdireccion.Text.Trim());
            cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text.Trim());
            cmd.Parameters.AddWithValue("@celular", txtCelular.Text.Trim());
            cmd.ExecuteNonQuery();

            conn.Desconectar();

            MessageBox.Show("cliente agregado correctamente!");


        }
        public void mostrarclientes()
        {
            conn.Conectar();
            SqlCommand cmd = new SqlCommand("select* from Clientes", conn.getConnection());
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            dgvcliente.DataSource = tbl;

        }

        private void editar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtcedula.Text) || string.IsNullOrEmpty(txtnombres.Text) || string.IsNullOrEmpty(txtapellidos.Text) || string.IsNullOrEmpty(txtdireccion.Text) || string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(txtCelular.Text))
            {
                MessageBox.Show("No se pueden insertar campos vacios!");
            }
            else
            {
                guardarCliente();
                retornarcedulacliente(txtcedula.Text);
               // txtrelacioncliente.Text = txtcedula.Text;
                mostrarclientes();
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            habilitar(false);
            txtcedula.Clear();
            txtnombres.Clear();
            txtapellidos.Clear();
            txtdireccion.Clear();
            txtTelefono.Clear();
            txtCelular.Clear();
            txtnombresdependiente.Clear();
            txtapelidosdependiente.Clear();
            txtdirecciondependiente.Clear();
            txttelefonodependiente.Clear();
            txtcelulardependiente.Clear();
            while (dgvcliente.RowCount > 1 && dgvdependientes.RowCount > 1)
            {

                dgvcliente.Rows.Remove(dgvcliente.CurrentRow);
                dgvdependientes.Rows.Remove(dgvdependientes.CurrentRow);

            }

        }

        private void dgvcliente_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            txtcedula.Text = dgvcliente.CurrentRow.Cells[0].Value.ToString();
            txtnombres.Text = dgvcliente.CurrentRow.Cells[1].Value.ToString();
            txtapellidos.Text = dgvcliente.CurrentRow.Cells[2].Value.ToString();
            txtdireccion.Text = dgvcliente.CurrentRow.Cells[3].Value.ToString();
            txtTelefono.Text = dgvcliente.CurrentRow.Cells[4].Value.ToString();
            txtCelular.Text = dgvcliente.CurrentRow.Cells[5].Value.ToString();

            conexion.ActualizarGrid(dgvdependientes, "select * from dependientes1 where relacioncliente = '"+txtcedula.Text+"'");
        }

        private void txtcedula_TextChanged(object sender, EventArgs e)
        {
            habilitar(true);

        }
        public void habilitar( bool valor)
        {
            txtnombresdependiente.Enabled = valor;
            txtapelidosdependiente.Enabled = valor;
            txtdirecciondependiente.Enabled = valor;
            txttelefonodependiente.Enabled = valor;
            txtcelulardependiente.Enabled = valor;
            eliminardepen.Enabled = valor;
            btnlimpiardepen.Enabled = valor;
            tnguargardependiente.Enabled = valor;

        }
        /* private void dgvcliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
         {
             txtcedula.Text = dgvcliente.CurrentRow.Cells[0].Value.ToString();
             txtnombres.Text = dgvcliente.CurrentRow.Cells[1].Value.ToString();
             txtapellidos.Text = dgvcliente.CurrentRow.Cells[2].Value.ToString();
             txtdireccion.Text = dgvcliente.CurrentRow.Cells[3].Value.ToString();
             txtTelefono.Text = dgvcliente.CurrentRow.Cells[4].Value.ToString();
             txtCelular.Text = dgvcliente.CurrentRow.Cells[5].Value.ToString();
             mostrarconfecciones();
         }*/
        /* public void mostrarconfecciones()
         {
             conn.Conectar();
             SqlCommand cmd = new SqlCommand("select FechaEntrega,MontoInicial,TotalPagado,BalancePendiente,Total,Cantidad,Tela,Descripcion from[Vista_Confeccion] where Cedula='" + txtcedula.Text + "'", conn.getConnection());
             cmd.CommandType = CommandType.Text;
             cmd.ExecuteNonQuery();

             SqlDataAdapter da = new SqlDataAdapter(cmd);
             DataTable tbl = new DataTable();
             da.Fill(tbl);
             dgvconfeccionesCliente.DataSource = tbl;



         }*/


        Conexion conexion = new Conexion();

        private void txtcedula_KeyDown(object sender, KeyEventArgs e)
        {
           /* if (e.KeyCode == Keys.Enter)
            {
                conexion.ActualizarGrid(dgvconfeccionesCliente, "select * from confecciones where cliente = " + txtcedula.Text + "");

            }*/
        }

        private void Clientes_Load(object sender, EventArgs e)/////////load//////////
        {
            mostrarclientes();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public void retornarcedulacliente(string cedula)
        {
            conexion.Conectar();
            SqlCommand cmd = new SqlCommand("select Cedula from Clientes where cedula='" + cedula + "'", conexion.getConnection());
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            txtrelacioncliente.Text = tbl.Rows[0][0].ToString();
            conexion.Desconectar();

        }

        public void guardardependiente()
        {
            conexion.Conectar();
            SqlCommand cmd = new SqlCommand("agregardependiente", conexion.getConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@iddependiente", txtiddependiente.Text);
            cmd.Parameters.AddWithValue("@nombres", txtnombresdependiente.Text);
            cmd.Parameters.AddWithValue("@apellidos", txtapelidosdependiente.Text);
            cmd.Parameters.AddWithValue("@direccion", txtdirecciondependiente.Text);
            cmd.Parameters.AddWithValue("@telefono", txttelefonodependiente.Text);
            cmd.Parameters.AddWithValue("@celular", txtcelulardependiente.Text);
            cmd.Parameters.AddWithValue("@relacioncliente", txtcedula.Text);
            cmd.ExecuteNonQuery();
            conexion.Desconectar();
            MessageBox.Show("Dependiente agregado!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtrelacioncliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tnguargardependiente_Click(object sender, EventArgs e)
        {
            guardardependiente();
            conexion.ActualizarGrid(dgvdependientes, "select * from dependientes1 where relacioncliente = '" + txtcedula.Text + "'");

        }

        private void dgvcliente_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        
        public void EliminarCliente()
        {
            conexion.Conectar();
            SqlCommand cmd = new SqlCommand("Eliminarcliente", conexion.getConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id",id);
            cmd.ExecuteNonQuery();
            conexion.Desconectar();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            id = int.Parse(dgvdependientes.CurrentRow.Cells[0].Value.ToString());
            EliminarCliente();
        }

        private void dgvdependientes_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void dgvdependientes_DoubleClick(object sender, EventArgs e)
        { 
            txtiddependiente.Text = dgvdependientes.CurrentRow.Cells[0].Value.ToString();
            txtnombresdependiente.Text = dgvdependientes.CurrentRow.Cells[1].Value.ToString();
            txtapelidosdependiente.Text = dgvdependientes.CurrentRow.Cells[2].Value.ToString();
            txtdirecciondependiente.Text = dgvdependientes.CurrentRow.Cells[3].Value.ToString();
            txttelefonodependiente.Text = dgvdependientes.CurrentRow.Cells[4].Value.ToString();
            txtcelulardependiente.Text = dgvdependientes.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
