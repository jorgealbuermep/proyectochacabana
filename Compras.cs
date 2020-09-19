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
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
        }
        int id;
        bool editar = false;
        Conexion conexion = new Conexion();
        public void Limpiar()
        {
            nombre.Clear();
            cantidad.Clear();
            precio.Clear();
            descripcion.Clear();
            proveedor.Clear();

        }
        //public bool Existe(string compra)//valida que el proyecto existe
        //{
        //    bool result = false;

        //    try
        //    {
        //        conexion.Conectar();
        //        SqlCommand cmd = new SqlCommand("select * from ViewCompras where Codigo = '" + compra + "'", conexion.getConnection());

        //        cmd.CommandType = CommandType.Text;

        //        SqlDataReader dataReader = cmd.ExecuteReader();
        //        if (dataReader.Read())
        //        {
        //            result = true;
        //        }
        //        dataReader.Close();
        //        conexion.Desconectar();
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //    return result;
        //}
        private void guardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(nombre.Text) || string.IsNullOrEmpty(cantidad.Text) ||
                 string.IsNullOrEmpty(precio.Text) || string.IsNullOrEmpty(descripcion.Text))
            {
                MessageBox.Show("Debe llenar los campos requeridos", "Falta informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                        
                if (editar)
                {
                      ModificaCompra();
                }
                else
                {
                      AgregarCompra();
                }
             
                limpiar();
            }

        }
        public void AgregarCompra()
        {
            conexion.Conectar();
            SqlCommand cmd = new SqlCommand("AgregarCompra", conexion.getConnection());

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", nombre.Text);
            cmd.Parameters.AddWithValue("@cantidad", cantidad.Text);
            cmd.Parameters.AddWithValue("@precio", precio.Text);
            cmd.Parameters.AddWithValue("@proveedor", proveedor.Text);
            cmd.Parameters.AddWithValue("@descripcion", descripcion.Text);
            cmd.Parameters.AddWithValue("@fecha", fecha.Value);
             
            cmd.ExecuteNonQuery();

            MessageBox.Show("Operacion realizada correctamente", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conexion.Desconectar();
            conexion.ActualizarGrid(dataGridView1, "select * from ViewCompras");


        }
        public void ModificaCompra()
        {
            conexion.Conectar();
            SqlCommand cmd = new SqlCommand("ModificaCompra", conexion.getConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nombre", nombre.Text);
            cmd.Parameters.AddWithValue("@cantidad", cantidad.Text);
            cmd.Parameters.AddWithValue("@precio", precio.Text);
            cmd.Parameters.AddWithValue("@proveedor", proveedor.Text);
            cmd.Parameters.AddWithValue("@descripcion", descripcion.Text);
            cmd.Parameters.AddWithValue("@fecha", fecha.Value);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Operacion realizada correctamente", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conexion.Desconectar();
            conexion.ActualizarGrid(dataGridView1, "select * from ViewCompras");

        }
        public void limpiar()
        { 
            nombre.Focus();
            nombre.Clear();
            cantidad.Clear();
            precio.Clear();
            proveedor.Clear();
            descripcion.Clear();
            editar = false;


        }
        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void editar_Click(object sender, EventArgs e)
        {
           
        }

        private void nombre_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                cantidad.Focus();
            }
        }

        private void cantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                precio.Focus();
            }
        }

        private void precio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                proveedor.Focus();
            }
        }

        private void proveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                descripcion.Focus();
            }
        }

        private void descripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fecha.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conexion.ActualizarGrid(dataGridView1, "select * from ViewCompras");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            editar = true;
            id = int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            nombre.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cantidad.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            precio.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            proveedor.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            descripcion.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }

        private void Compras_Load(object sender, EventArgs e)
        {
            nombre.Focus();

        }

        private void fecha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guardar.Focus();

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            conexion.ActualizarGrid(dataGridView1, "select * from ViewCompras");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Mensage = MessageBox.Show("Desea eliminar este registro?", "Se eliminara esta compra", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Mensage == DialogResult.Yes)
            {
                EliminaCompra();

            }
            else
            {
                return;
            }
        }
        public void EliminaCompra()
        {
            id = int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            conexion.Conectar();
            SqlCommand cmd = new SqlCommand("EliminaCompra", conexion.getConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", id); 

            cmd.ExecuteNonQuery();

            MessageBox.Show("Operacion realizada correctamente", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conexion.Desconectar();
            conexion.ActualizarGrid(dataGridView1, "select * from ViewCompras");
        }
    }
}
