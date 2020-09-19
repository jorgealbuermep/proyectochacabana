namespace ConfeccionesLuis
{
    partial class Compras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compras));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.proveedor = new System.Windows.Forms.TextBox();
            this.guardar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.precio = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(72, 107);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1491, 749);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1101, 635);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 87);
            this.button3.TabIndex = 35;
            this.button3.Text = "Refrescar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 18.2F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(564, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 42);
            this.label3.TabIndex = 34;
            this.label3.Text = "Compras Realizadas ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1285, 635);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 87);
            this.button2.TabIndex = 34;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 13.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(571, 121);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 13.2F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(889, 474);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.descripcion);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.proveedor);
            this.groupBox1.Controls.Add(this.guardar);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cantidad);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.precio);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.fecha);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(45, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(507, 551);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles Producto";
            // 
            // descripcion
            // 
            this.descripcion.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.descripcion.Location = new System.Drawing.Point(195, 281);
            this.descripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(275, 30);
            this.descripcion.TabIndex = 29;
            this.descripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.descripcion_KeyDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(131, 420);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 87);
            this.button1.TabIndex = 33;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.2F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 30);
            this.label2.TabIndex = 28;
            this.label2.Text = "Descripcion :";
            // 
            // proveedor
            // 
            this.proveedor.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.proveedor.Location = new System.Drawing.Point(195, 234);
            this.proveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.proveedor.Name = "proveedor";
            this.proveedor.Size = new System.Drawing.Size(275, 30);
            this.proveedor.TabIndex = 26;
            this.proveedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.proveedor_KeyDown);
            // 
            // guardar
            // 
            this.guardar.BackColor = System.Drawing.Color.Transparent;
            this.guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardar.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar.ForeColor = System.Drawing.Color.White;
            this.guardar.Location = new System.Drawing.Point(315, 420);
            this.guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(155, 87);
            this.guardar.TabIndex = 8;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = false;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 13.2F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(29, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 30);
            this.label11.TabIndex = 25;
            this.label11.Text = "Proveedor :";
            // 
            // cantidad
            // 
            this.cantidad.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.cantidad.Location = new System.Drawing.Point(195, 143);
            this.cantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(275, 30);
            this.cantidad.TabIndex = 24;
            this.cantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cantidad_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13.2F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(29, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 30);
            this.label10.TabIndex = 23;
            this.label10.Text = "Cantidad :";
            // 
            // precio
            // 
            this.precio.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.precio.Location = new System.Drawing.Point(195, 190);
            this.precio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(275, 30);
            this.precio.TabIndex = 22;
            this.precio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.precio_KeyDown);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 13.2F);
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(29, 186);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(84, 30);
            this.label20.TabIndex = 21;
            this.label20.Text = "Precio :";
            // 
            // fecha
            // 
            this.fecha.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.fecha.Location = new System.Drawing.Point(195, 330);
            this.fecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(275, 30);
            this.fecha.TabIndex = 20;
            this.fecha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fecha_KeyDown);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 13.2F);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(29, 330);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 30);
            this.label19.TabIndex = 18;
            this.label19.Text = "Fecha :";
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.nombre.Location = new System.Drawing.Point(195, 100);
            this.nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(275, 30);
            this.nombre.TabIndex = 17;
            this.nombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nombre_KeyDown);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 13.2F);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(29, 97);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(105, 30);
            this.label18.TabIndex = 16;
            this.label18.Text = "Nombre :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1669, 47);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.8F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(581, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 42);
            this.label1.TabIndex = 15;
            this.label1.Text = "CLQ - Compras";
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1669, 907);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Compras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.Compras_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox proveedor;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
    }
}