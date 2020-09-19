namespace ConfeccionesLuis
{
    partial class Pagos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.fechaconfeccion = new System.Windows.Forms.DateTimePicker();
            this.total = new System.Windows.Forms.TextBox();
            this.balancependiente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.totalpagado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guardar = new System.Windows.Forms.Button();
            this.nocuenta = new System.Windows.Forms.TextBox();
            this.editar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.formapago = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.monto = new System.Windows.Forms.TextBox();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.idconfeccion = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(72, 107);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1491, 810);
            this.panel1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(75, 455);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1361, 316);
            this.dataGridView1.TabIndex = 34;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.fechaconfeccion);
            this.groupBox2.Controls.Add(this.total);
            this.groupBox2.Controls.Add(this.balancependiente);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.totalpagado);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.descripcion);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cliente);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(801, 25);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(635, 398);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.2F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(72, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 30);
            this.label9.TabIndex = 33;
            this.label9.Text = "Fecha :";
            // 
            // fechaconfeccion
            // 
            this.fechaconfeccion.Enabled = false;
            this.fechaconfeccion.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.fechaconfeccion.Location = new System.Drawing.Point(293, 169);
            this.fechaconfeccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fechaconfeccion.Name = "fechaconfeccion";
            this.fechaconfeccion.Size = new System.Drawing.Size(291, 30);
            this.fechaconfeccion.TabIndex = 34;
            // 
            // total
            // 
            this.total.Enabled = false;
            this.total.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.total.Location = new System.Drawing.Point(293, 217);
            this.total.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(291, 30);
            this.total.TabIndex = 33;
            // 
            // balancependiente
            // 
            this.balancependiente.Enabled = false;
            this.balancependiente.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.balancependiente.Location = new System.Drawing.Point(293, 308);
            this.balancependiente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.balancependiente.Name = "balancependiente";
            this.balancependiente.Size = new System.Drawing.Size(291, 30);
            this.balancependiente.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.2F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(72, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 30);
            this.label4.TabIndex = 31;
            this.label4.Text = "Descripcion :";
            // 
            // totalpagado
            // 
            this.totalpagado.Enabled = false;
            this.totalpagado.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.totalpagado.Location = new System.Drawing.Point(293, 262);
            this.totalpagado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.totalpagado.Name = "totalpagado";
            this.totalpagado.Size = new System.Drawing.Size(291, 30);
            this.totalpagado.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.2F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(72, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 30);
            this.label5.TabIndex = 29;
            this.label5.Text = "Total Pagado :";
            // 
            // descripcion
            // 
            this.descripcion.Enabled = false;
            this.descripcion.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.descripcion.Location = new System.Drawing.Point(293, 122);
            this.descripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(291, 30);
            this.descripcion.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.2F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(72, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 30);
            this.label6.TabIndex = 25;
            this.label6.Text = "Balance Pendiente :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.2F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(72, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 30);
            this.label7.TabIndex = 18;
            this.label7.Text = "Total :";
            // 
            // cliente
            // 
            this.cliente.Enabled = false;
            this.cliente.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.cliente.Location = new System.Drawing.Point(293, 74);
            this.cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(291, 30);
            this.cliente.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.2F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(72, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 30);
            this.label8.TabIndex = 16;
            this.label8.Text = "Cliente :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.guardar);
            this.groupBox1.Controls.Add(this.nocuenta);
            this.groupBox1.Controls.Add(this.editar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.formapago);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.monto);
            this.groupBox1.Controls.Add(this.fecha);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.idconfeccion);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(75, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(653, 398);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pagos";
            // 
            // guardar
            // 
            this.guardar.BackColor = System.Drawing.Color.Transparent;
            this.guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardar.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar.ForeColor = System.Drawing.Color.White;
            this.guardar.Location = new System.Drawing.Point(260, 295);
            this.guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(149, 71);
            this.guardar.TabIndex = 8;
            this.guardar.Text = "Limpiar";
            this.guardar.UseVisualStyleBackColor = false;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // nocuenta
            // 
            this.nocuenta.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.nocuenta.Location = new System.Drawing.Point(260, 251);
            this.nocuenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nocuenta.Name = "nocuenta";
            this.nocuenta.Size = new System.Drawing.Size(321, 30);
            this.nocuenta.TabIndex = 32;
            this.nocuenta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nocuenta_KeyDown);
            // 
            // editar
            // 
            this.editar.BackColor = System.Drawing.Color.Transparent;
            this.editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editar.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editar.ForeColor = System.Drawing.Color.White;
            this.editar.Location = new System.Drawing.Point(431, 295);
            this.editar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(149, 71);
            this.editar.TabIndex = 7;
            this.editar.Text = "Guardar";
            this.editar.UseVisualStyleBackColor = false;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.2F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(60, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 30);
            this.label3.TabIndex = 31;
            this.label3.Text = "No. Cuenta :";
            // 
            // formapago
            // 
            this.formapago.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.formapago.Location = new System.Drawing.Point(260, 206);
            this.formapago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.formapago.Name = "formapago";
            this.formapago.Size = new System.Drawing.Size(321, 30);
            this.formapago.TabIndex = 30;
            this.formapago.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formapago_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.2F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(60, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 30);
            this.label2.TabIndex = 29;
            this.label2.Text = "Forma de pago :";
            // 
            // monto
            // 
            this.monto.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.monto.Location = new System.Drawing.Point(260, 110);
            this.monto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.monto.Name = "monto";
            this.monto.Size = new System.Drawing.Size(321, 30);
            this.monto.TabIndex = 28;
            this.monto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.monto_KeyDown);
            // 
            // fecha
            // 
            this.fecha.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.fecha.Location = new System.Drawing.Point(260, 158);
            this.fecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(321, 30);
            this.fecha.TabIndex = 27;
            this.fecha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fecha_KeyDown);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 13.2F);
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(60, 154);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(80, 30);
            this.label22.TabIndex = 25;
            this.label22.Text = "Fecha :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 13.2F);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(60, 107);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(89, 30);
            this.label19.TabIndex = 18;
            this.label19.Text = "Monto :";
            // 
            // idconfeccion
            // 
            this.idconfeccion.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.idconfeccion.Location = new System.Drawing.Point(260, 62);
            this.idconfeccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idconfeccion.Name = "idconfeccion";
            this.idconfeccion.Size = new System.Drawing.Size(321, 30);
            this.idconfeccion.TabIndex = 17;
            this.idconfeccion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.idconfeccion_KeyDown);
            this.idconfeccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idconfeccion_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 13.2F);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(60, 59);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(159, 30);
            this.label18.TabIndex = 16;
            this.label18.Text = "ID Confeccion :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1625, 47);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.8F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(706, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 42);
            this.label1.TabIndex = 15;
            this.label1.Text = "CLQ - Pagos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConfeccionesLuis.Properties.Resources.fondo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1625, 951);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Pagos";
            this.Text = "Pagos";
            this.Load += new System.EventHandler(this.Pagos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox idconfeccion;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker fechaconfeccion;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.TextBox balancependiente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox totalpagado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nocuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox formapago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox monto;
    }
}