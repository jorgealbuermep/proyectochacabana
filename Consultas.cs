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
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }
        Conexion conexion = new Conexion();
        //public void ActualizarGrid(string query)
        //{
        //    conexion.ActualizarGrid(dataGridView2, query);
        //}

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rcodigo.Checked)
            {
                idcon.Enabled = true;
                desde.Enabled = false;
                hasta.Enabled = false;
                cedula.Enabled = false;
                btnbuscar.Enabled = true;
                idcon.Focus();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (rcodigo.Checked)
            {
                if (string.IsNullOrEmpty(idcon.Text)){
                    MessageBox.Show("Introduzca el codigo de la confeccion", "Campo Vacio!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    conexion.ActualizarGrid(dataGridView2, "select * from confecciones where id = " + idcon.Text + "");
                    conexion.ActualizarGrid(dataGridView1, "select * from pagos inner join Confecciones  on Confecciones.id = pagos.Confeccion " +
                        "where confecciones.id = '" + idcon.Text + "'");

                }
            }
            else if (rfecha.Checked)
            {
                if (string.IsNullOrEmpty(idcon.Text)){
                    MessageBox.Show("Selecicone las fechas de la confeccion", "Campo Vacio!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    conexion.ActualizarGrid(dataGridView2, "select * from confecciones where fecha between '" + desde.Value + "' and '" + hasta.Value + "'");
                    conexion.ActualizarGrid(dataGridView1, "select * from pagos inner join Confecciones on Confecciones.id = pagos.Confeccion " +
                        "where fecha between '" + desde.Value + "' and '" + hasta.Value + "'");
                }

            }   
            else if(rcliente.Checked) {
                if (string.IsNullOrEmpty(idcon.Text)){
                    MessageBox.Show("Introduzca la cedula del cliente", "Campo Vacio!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    conexion.ActualizarGrid(dataGridView2, "select * from confecciones where cliente = '" + cedula.Text + "'");
                    conexion.ActualizarGrid(dataGridView1, "select * from pagos inner join Confecciones on Confecciones.id = pagos.Confeccion " +
                                            "where Cliente = '" + cedula.Text + "'");
                }

            }
            else
            {
                MessageBox.Show("Debe llenar el campo requerido", "No hay informacion brindada", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void rfecha_CheckedChanged(object sender, EventArgs e)
        {
            idcon.Enabled = false;
            desde.Enabled = true;
            hasta.Enabled = true;
            cedula.Enabled = false;
            btnbuscar.Enabled = true;

        }

        private void rcliente_CheckedChanged(object sender, EventArgs e)
        {
            idcon.Enabled = false;
            desde.Enabled = false;
            hasta.Enabled = false;
            cedula.Enabled = true;
            btnbuscar.Enabled = true;
            cedula.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rcliente.Checked = false;
            rcodigo.Checked = false;
            rfecha.Checked = false;
            idcon.Enabled = false;
            desde.Enabled = false;
            hasta.Enabled = false;
            cedula.Enabled = false;
            btnbuscar.Enabled = false;
            cedula.Clear();
            idcon.Clear();
        }

        private void idcon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnbuscar.Focus();
            }
        }

        private void cedula_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnbuscar.Focus();
            }
        }

        private void Consultas_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
       
    }
}
