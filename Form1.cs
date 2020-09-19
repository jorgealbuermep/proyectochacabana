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
    public partial class Form1 : Form
    {
        Conexion conn = new Conexion();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)//// btn entrar
        {
            if (validarlogIn())
            {
                Principal principal = new Principal();
            principal.Show();  //Visible= true;
            this.Visible = false;
                if (InfoSistema.confecciones != "1")
                {
                    principal.confecciones.Enabled = false;
                }

                if (InfoSistema.pagos != "1")
                {
                    principal.pagos.Enabled = false;
                }

                if (InfoSistema.consulta != "1")
                {
                    principal.consultas.Enabled = false;
                }

                if (InfoSistema.cliente != "1")
                {
                    principal.clientes.Enabled = false;
                }

                if (InfoSistema.compra != "1")
                {
                    principal.compras.Enabled = false;
                }

                if (InfoSistema.inventario != "1")
                {
                    principal.inventario.Enabled = false;
                }

                if (InfoSistema.usuarios != "1")
                {
                    principal.usuarios.Enabled = false;
                }

                if (InfoSistema.parametrizacion != "1")
                {
                    principal.parametrizacion.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

            private void Form1_Load(object sender, EventArgs e)
        {

           
            

            }


            public bool validarlogIn()    /////////////////////////////validarlogin
            {


                //string consulta;
                //this.codigo = txtuserlogin.Text;
                //Infosistema.nombreUsuario = txtuserlogin.Text;


                bool resultado = false;
                try
                {


                    conn.Conectar();
                    Principal fp = new Principal();
                   
                    SqlCommand cmdLogIn = new SqlCommand("select * from Usuarios  as a inner join Accesos as b on(a.IdAcceso= b.Id) where Usuario= @user and  Pass=@pass", conn.getConnection());
                    cmdLogIn.CommandType = CommandType.Text;

                    cmdLogIn.Parameters.AddWithValue("@user", txtUsuarioLogIn.Text);
                    cmdLogIn.Parameters.AddWithValue("@pass", txtPassUser.Text);
                    SqlDataReader dr = cmdLogIn.ExecuteReader();



                    if (dr.Read())
                    {
                       
                        resultado = true;
                    InfoSistema.confecciones = dr[6].ToString();
                    InfoSistema.pagos = dr[7].ToString();
                    InfoSistema.consulta = dr[8].ToString();
                    InfoSistema.cliente = dr[9].ToString();
                    InfoSistema.compra = dr[10].ToString();
                    InfoSistema.inventario = dr[11].ToString();
                    InfoSistema.usuarios= dr[12].ToString();
                    InfoSistema.parametrizacion = dr[13].ToString();

                }
                    dr.Close();
                    conn.Desconectar();
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            return resultado;
        }

        private void txtUsuarioLogIn_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
            {
                txtPassUser.Focus();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
    
