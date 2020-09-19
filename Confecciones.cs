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
    public partial class Confecciones : Form
    {
        Conexion conexion = new Conexion();
        public Confecciones()
        {
            InitializeComponent();
        }

        public bool Existe(int id)//valida que el proyecto existe
        {
            bool result = false;

            try
            {
                conexion.Conectar();
                SqlCommand cmd = new SqlCommand("select * from confecciones where id = '" + id + "'", conexion.getConnection());

                cmd.CommandType = CommandType.Text;

                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                {
                    result = true;
                }
                dataReader.Close();
                conexion.Desconectar();
            }
            catch (Exception e)
            {
                throw e;
            }
            return result;
        }
        public void Limpiar()
        {
            cantidad.Focus();
            id.Clear();
            //cantidad.Clear();
            descripcion.Clear();
            total.Clear();
            inicial.Clear();
            balancependiente.Clear();
            totalpagado.Clear();
            espalda.Clear();
            pecho.Clear();
            cintura.Clear();
            cadera.Clear();
            hombros.Clear();
            cuello.Clear();
            manga.Clear();
            largo.Clear();
            cedula.Clear();
            nombres.Clear();
            apellidos.Clear();
            telefono.Clear();
            direccion.Clear();
            celular.Clear();
            cbDependientes.Enabled = false;
           cbDependientes.DataSource = null;
            cbDependientes.Items.Clear();
            cbDependientes.Text = "Dependientes";


        }
        public void llamardatosp()
        {

            conexion.Conectar();
            SqlCommand cmdLogIn = new SqlCommand("select * from vista_confeccion where [Id Confeccion] = @idC", conexion.getConnection());
            cmdLogIn.CommandType = CommandType.Text;

            cmdLogIn.Parameters.AddWithValue("@idC", id.Text);
            SqlDataReader dr = cmdLogIn.ExecuteReader();

            if (dr.Read())
            { 
                cedula.Text = dr[0].ToString();
                nombres.Text = dr[1].ToString();
                apellidos.Text = dr[2].ToString();
                direccion.Text = dr[3].ToString();
                telefono.Text = dr[4].ToString();
                celular.Text = dr[5].ToString();
                tela.Text = dr[6].ToString();
                fechaEntrega.Text = dr[7].ToString();
                balancependiente.Text = dr[8].ToString();
                totalpagado.Text = dr[9].ToString();
                total.Text = dr[10].ToString();
                estado.Text = dr[11].ToString();
                cantidad.Text = dr[12].ToString();
                descripcion.Text = dr[13].ToString();
                inicial.Text = dr[14].ToString();
                fecha.Text = dr[15].ToString();
                espalda.Text = dr[17].ToString();
                pecho.Text = dr[18].ToString();
                cintura.Text = dr[19].ToString();
                hombros.Text = dr[20].ToString();
                cadera.Text = dr[21].ToString();
                cuello.Text = dr[22].ToString();
                manga.Text = dr[23].ToString();
                largo.Text = dr[24].ToString();
            }
            dr.Close();
            conexion.Desconectar();

        }

        private void textBox9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                llamardatosp();
                inicial.Enabled = false;
                total.Enabled = false;
            }
        }
        public void AgregarCon()//metodo para la llamada a stored procedure agregar que agrega un proyecto nuevo
        {

            conexion.Conectar();
            SqlCommand cmd = new SqlCommand("AgregarConfeccion", conexion.getConnection());

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fecha", fecha.Value);
            cmd.Parameters.AddWithValue("@fechaentrega", fechaEntrega.Value);
            cmd.Parameters.AddWithValue("@montoinicial", inicial.Text);
            cmd.Parameters.AddWithValue("@total", total.Text);
            cmd.Parameters.AddWithValue("@estado", estado.Text);
            cmd.Parameters.AddWithValue("@cantidad", cantidad.Text);
            cmd.Parameters.AddWithValue("@tipotela", tela.Text);
            cmd.Parameters.AddWithValue("@descripcion", descripcion.Text);
            cmd.Parameters.AddWithValue("@cedula", cedula.Text);


            //cmd.Parameters.AddWithValue("@nombre", nombres.Text);
            //cmd.Parameters.AddWithValue("@apellidos ", apellidos.Text);
            //cmd.Parameters.AddWithValue("@direccion", direccion.Text);
            //cmd.Parameters.AddWithValue("@telefono", telefono.Text);
            //cmd.Parameters.AddWithValue("@celular", celular.Text);
            cmd.Parameters.AddWithValue("@espalda", espalda.Text);
            cmd.Parameters.AddWithValue("@pecho", pecho.Text);
            cmd.Parameters.AddWithValue("@cintura", cintura.Text);
            cmd.Parameters.AddWithValue("@cadera", cadera.Text);
            cmd.Parameters.AddWithValue("@hombros", hombros.Text);
            cmd.Parameters.AddWithValue("@cuello", cuello.Text);
            cmd.Parameters.AddWithValue("@manga", manga.Text);
            cmd.Parameters.AddWithValue("@largo", largo.Text);
            cmd.Parameters.AddWithValue("@tipochacabana", cedula.Text);


            cmd.ExecuteNonQuery();

            MessageBox.Show("Operacion realizada correctamente", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            conexion.Desconectar();
           
        }
        public void ModificaConfeccion()
        {
            conexion.Conectar();
            SqlCommand cmd = new SqlCommand("ModificaConfeccion", conexion.getConnection());

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cedula", cedula.Text);
            cmd.Parameters.AddWithValue("@dependiente", cbDependientes.Text);

            cmd.Parameters.AddWithValue("@fecha", fecha.Value);
            cmd.Parameters.AddWithValue("@fechaentrega", fechaEntrega.Value);
            cmd.Parameters.AddWithValue("@montoinicial", inicial.Text); 
            cmd.Parameters.AddWithValue("@estado", estado.Text);
            cmd.Parameters.AddWithValue("@cantidad", cantidad.Text);
            cmd.Parameters.AddWithValue("@tipotela", tela.Text);
            cmd.Parameters.AddWithValue("@descripcion", descripcion.Text);
            cmd.Parameters.AddWithValue("@espalda", espalda.Text);
            cmd.Parameters.AddWithValue("@pecho", pecho.Text);
            cmd.Parameters.AddWithValue("@cintura", cintura.Text);
            cmd.Parameters.AddWithValue("@cadera", cadera.Text);
            cmd.Parameters.AddWithValue("@hombros", hombros.Text);
            cmd.Parameters.AddWithValue("@cuello", cuello.Text);
            cmd.Parameters.AddWithValue("@manga", manga.Text);
            cmd.Parameters.AddWithValue("@largo", largo.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Operacion realizada correctamente", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conexion.Desconectar();
        }
        private void guardar_Click(object sender, EventArgs e)
        {
            id.Enabled = false;
            if (string.IsNullOrEmpty(inicial.Text) || string.IsNullOrEmpty(cedula.Text) || string.IsNullOrEmpty(cantidad.Text) || string.IsNullOrEmpty(tela.Text))
            {
                MessageBox.Show("Debe Llenar todos los campos obligatorios!", "Falta Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                cantidadconfecciones();

                if (string.IsNullOrEmpty(id.Text))
                {
                    AgregarCon();
                    Limpiar();
                }
                else
                {
            if (Existe(int.Parse(id.Text)))
                {
                    ModificaConfeccion();
                    Limpiar();
                }
                else
                {
                    return;
            
                }
                }
                
              
            }
            inicial.Enabled = true;
                total.Enabled = true;
           
            
        }

        private void Confecciones_Load(object sender, EventArgs e)
        {
            cantidad.Focus();
            // TODO: esta línea de código carga datos en la tabla 'cLQDataSet.TipoTela' Puede moverla o quitarla según sea necesario.
            this.tipoTelaTableAdapter.Fill(this.cLQDataSet.TipoTela);
            LlenarTela();
        }
        public void LlenarTela()
        {
            if (tela.Items.Count != 0)
            {
                conexion.Conectar();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select nombre from tipotela", conexion.getConnection());
                da.Fill(ds, "TipoTela");
                tela.DataSource = ds.Tables[0].DefaultView;
                tela.ValueMember = "nombre";
                conexion.Desconectar();
            }
        }

        private void editar_Click(object sender, EventArgs e)
        {
            id.Enabled = true;
            id.Focus();
        }

        private void cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar();
            id.Enabled = false;
            inicial.Enabled = true;
            total.Enabled = true;

        }

        private void cedula_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
           

            }

        private void cantidad_KeyDown(object sender, KeyEventArgs e)
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
                tela.Focus();
            }
        }

        private void fechaEntrega_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                estado.Focus();
            }
        }

        private void estado_KeyDown(object sender, KeyEventArgs e)
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
                total.Focus();
            }
        }

        private void total_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                inicial.Focus();
            }
        }

        private void espalda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pecho.Focus();
            }
        }

        private void inicial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                espalda.Focus();
            }
        }

        private void pecho_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cintura.Focus();
            }
        }

        private void cintura_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cadera.Focus();
            }
        }

        private void cadera_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                hombros.Focus();
            }
        }

        private void hombros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cuello.Focus();
            }
        }

        private void cuello_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                manga.Focus();
            }
        }

        private void manga_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                largo.Focus();
            }
        }

        private void largo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cedula.Focus();
            }
        }

        private void cedula_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               if( MessageBox.Show("Desea realizar una confeccion para un dependiente?", "?", MessageBoxButtons.YesNo) == DialogResult.Yes){
                    if (cbDependientes.Items.Count <= 0)
                    {
                        llenarcomboboxCliente();
                    }

                    cbDependientes.Enabled = true;


                }
                else
                {
                    conexion.Conectar();
                    SqlCommand cmdLogIn = new SqlCommand("select * from Clientes where cedula = @cedula", conexion.getConnection());
                    cmdLogIn.CommandType = CommandType.Text;

                    cmdLogIn.Parameters.AddWithValue("@cedula", cedula.Text);
                    SqlDataReader dr = cmdLogIn.ExecuteReader();

                    if (dr.Read())
                    {
                        nombres.Text = dr[1].ToString();
                        apellidos.Text = dr[2].ToString();
                        direccion.Text = dr[3].ToString();
                        telefono.Text = dr[4].ToString();
                        celular.Text = dr[5].ToString();

                    }
                    dr.Close();
                    conexion.Desconectar();


                }
                
                guardar.Focus();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void llenarcomboboxCliente()  //llenar el combobox de cliente////////////
        {
           // if(cbDependientes.Items.Count<=0)
            //{

                conexion.Conectar();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select a.nombres from dependientes1 as a inner join clientes as b on(a.relacioncliente=  b.Cedula) where b.cedula='" + cedula.Text + "' ", conexion.getConnection());
                da.Fill(ds, " Dependientes1"); // paso el dataset y la vista 
            
                cbDependientes.DataSource = ds.Tables[0].DefaultView;
            if (cbDependientes.Items.Count <= 0)
            {
                MessageBox.Show("este cliente no posee dependientes!");
            }
            cbDependientes.DisplayMember = "nombres";
                cbDependientes.ValueMember = "nombres"; //////  valuemember es el nombre del campo de la vista que quiero mostrar//////
                cbDependientes.Text = "Dependientes";
                conexion.Desconectar();


           // }
           /* else
            {
                conexion.Conectar();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select a.nombres from dependientes1 as a inner join clientes as b on(a.relacioncliente=  b.Cedula) where b.cedula='" + cedula.Text + "' ", conexion.getConnection());
                da.Fill(ds, " Dependientes1"); // paso el dataset y la vista
                cbDependientes.DataSource = ds.Tables[0].DefaultView;
                cbDependientes.ValueMember = "nombres"; //////  valuemember es el nombre del campo de la vista que quiero mostrar//////
                cbDependientes.Text = "Dependientes";
                conexion.Desconectar();
            }*/

        }

       public void obtenerDatosDependiente(string nombre)
        {
            conexion.Conectar();
            SqlCommand cmd = new SqlCommand("select *  from dependientes1 where nombres='" + nombre+"'", conexion.getConnection());
            cmd.CommandType = CommandType.Text;
            // cmd.ExecuteNonQuery();

            /* SqlDataAdapter da = new SqlDataAdapter(cmd);
             DataTable tbl = new DataTable();

             da.Fill(tbl);
             nombres.Text = tbl.Rows[0][1].ToString();
             apellidos.Text = tbl.Rows[0][2].ToString();
             direccion.Text = tbl.Rows[0][3].ToString();
             telefono.Text = tbl.Rows[0][4].ToString();
             celular.Text = tbl.Rows[0][5].ToString();*/
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                nombres.Text = dr[2].ToString();
                apellidos.Text = dr[3].ToString();
                direccion.Text = dr[4].ToString();
                telefono.Text = dr[5].ToString();
                celular.Text = dr[6].ToString();
            }
            dr.Close();
            conexion.Desconectar();
        }

        private void cbDependientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbDependientes_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            obtenerDatosDependiente(cbDependientes.SelectedValue.ToString());

        }

        public void cantidadconfecciones()
        {
            int countcantidad = 0;
             countcantidad = int.Parse(cantidad.Text);
            countcantidad--;
            cantidad.Text = countcantidad.ToString();
            if (countcantidad == 0)
            {
                MessageBox.Show("has completado la cantidad de confecciones a realizar", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
