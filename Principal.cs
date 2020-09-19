using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfeccionesLuis
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var mensaje = MessageBox.Show("Desea Salir del Sistema?", "Seguro que desea salir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mensaje == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        public void AddFormInPanel<MiForm>() where MiForm : Form, new() //metodo para desplegar un formulario dentro de un panel
        {
            Form formulario;
            formulario = panel2.Controls.OfType<MiForm>().FirstOrDefault(); //busca en la coleccion el formulario

            //si la instancia del form no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                mostrar.Controls.Add(formulario);
                mostrar.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();


            }
            else
            {
                formulario.BringToFront();

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddFormInPanel<Compras>();
            Colores();
            compras.BackColor = Color.Gray;
        }
        public void Colores()
        {
            pagos.BackColor = Color.Transparent;
            consultas.BackColor = Color.Transparent;
            clientes.BackColor = Color.Transparent;
            usuarios.BackColor = Color.Transparent;
            parametrizacion.BackColor = Color.Transparent;
            inventario.BackColor = Color.Transparent;
            compras.BackColor = Color.Transparent;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AddFormInPanel<Pagos>();
            Colores();
            pagos.BackColor = Color.Gray;


        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddFormInPanel<Consultas>();
            Colores();
            consultas.BackColor = Color.Gray;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddFormInPanel<Clientes>();
            Colores();
            clientes.BackColor = Color.Gray;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddFormInPanel<Inventario>();
            Colores();
            inventario.BackColor = Color.Gray;
        }

        private void Principal_Load(object sender, EventArgs e)  //////////Load//////////////
        {

             this.Size = Screen.PrimaryScreen.WorkingArea.Size;
             this.Location = Screen.PrimaryScreen.WorkingArea.Location;

           /* this.Location = new Point(0, 0); //sobra si tienes la posición en el diseño
            this.Size = new Size(this.Width, Screen.PrimaryScreen.WorkingArea.Size.Height);*/
        
    }

        private void button5_Click(object sender, EventArgs e)
        {
            AddFormInPanel<Usuarios>();
            Colores();
            usuarios.BackColor = Color.Gray;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddFormInPanel<Parametrizacion>();
            Colores();
            parametrizacion.BackColor = Color.Gray;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mensaje = MessageBox.Show("Desea cerrar Sesion?", "Seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mensaje == DialogResult.Yes)
            {
                this.Hide();
                Form1 login = new Form1();
                login.ShowDialog();
            }
            else
            {
                return;
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            AddFormInPanel<Confecciones>();
            Colores();
            confecciones.BackColor = Color.Gray;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mostrar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
