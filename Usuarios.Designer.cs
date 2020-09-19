namespace ConfeccionesLuis
{
    partial class Usuarios
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvusuarios = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtidacceso = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chCompra = new System.Windows.Forms.CheckBox();
            this.chparametrizacion = new System.Windows.Forms.CheckBox();
            this.chclientes = new System.Windows.Forms.CheckBox();
            this.chusuarios = new System.Windows.Forms.CheckBox();
            this.chinventario = new System.Windows.Forms.CheckBox();
            this.chconsultas = new System.Windows.Forms.CheckBox();
            this.chpagos = new System.Windows.Forms.CheckBox();
            this.chconfecciones = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1625, 47);
            this.panel2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.8F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(629, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 42);
            this.label4.TabIndex = 15;
            this.label4.Text = "CLQ - Usuarios";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.dgvusuarios);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(79, 102);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1491, 810);
            this.panel1.TabIndex = 9;
            // 
            // dgvusuarios
            // 
            this.dgvusuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvusuarios.Location = new System.Drawing.Point(37, 462);
            this.dgvusuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvusuarios.Name = "dgvusuarios";
            this.dgvusuarios.RowTemplate.Height = 24;
            this.dgvusuarios.Size = new System.Drawing.Size(1421, 315);
            this.dgvusuarios.TabIndex = 1;
            this.dgvusuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvusuarios_CellDoubleClick);
            this.dgvusuarios.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvusuarios_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.Controls.Add(this.txtidacceso);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btneliminar);
            this.groupBox1.Controls.Add(this.btnlimpiar);
            this.groupBox1.Controls.Add(this.btnguardar);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.txtpass);
            this.groupBox1.Controls.Add(this.txtusuario);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(37, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1421, 412);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuentas de Usuarios";
            // 
            // txtidacceso
            // 
            this.txtidacceso.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.txtidacceso.Location = new System.Drawing.Point(547, 319);
            this.txtidacceso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtidacceso.Name = "txtidacceso";
            this.txtidacceso.Size = new System.Drawing.Size(273, 30);
            this.txtidacceso.TabIndex = 41;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(855, 309);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(251, 66);
            this.button4.TabIndex = 40;
            this.button4.Text = "Exportar a Excel";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.IndianRed;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1127, 309);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(251, 66);
            this.button3.TabIndex = 39;
            this.button3.Text = "Exportar a PDF";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.Transparent;
            this.btneliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.Location = new System.Drawing.Point(191, 297);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(155, 66);
            this.btneliminar.TabIndex = 38;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnlimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiar.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.ForeColor = System.Drawing.Color.White;
            this.btnlimpiar.Location = new System.Drawing.Point(19, 297);
            this.btnlimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(155, 66);
            this.btnlimpiar.TabIndex = 37;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.Transparent;
            this.btnguardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.Location = new System.Drawing.Point(361, 297);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(155, 66);
            this.btnguardar.TabIndex = 7;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnombre.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.txtnombre.Location = new System.Drawing.Point(216, 230);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(273, 30);
            this.txtnombre.TabIndex = 32;
            // 
            // txtpass
            // 
            this.txtpass.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpass.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.txtpass.Location = new System.Drawing.Point(216, 182);
            this.txtpass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(273, 30);
            this.txtpass.TabIndex = 31;
            this.txtpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpass_KeyDown);
            // 
            // txtusuario
            // 
            this.txtusuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtusuario.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.txtusuario.Location = new System.Drawing.Point(216, 137);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(273, 30);
            this.txtusuario.TabIndex = 29;
            this.txtusuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtusuario_KeyDown);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chCompra);
            this.groupBox4.Controls.Add(this.chparametrizacion);
            this.groupBox4.Controls.Add(this.chclientes);
            this.groupBox4.Controls.Add(this.chusuarios);
            this.groupBox4.Controls.Add(this.chinventario);
            this.groupBox4.Controls.Add(this.chconsultas);
            this.groupBox4.Controls.Add(this.chpagos);
            this.groupBox4.Controls.Add(this.chconfecciones);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(547, 62);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(831, 214);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Accesos";
            // 
            // chCompra
            // 
            this.chCompra.AutoSize = true;
            this.chCompra.Location = new System.Drawing.Point(599, 121);
            this.chCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chCompra.Name = "chCompra";
            this.chCompra.Size = new System.Drawing.Size(134, 42);
            this.chCompra.TabIndex = 7;
            this.chCompra.Text = "Compra";
            this.chCompra.UseVisualStyleBackColor = true;
            // 
            // chparametrizacion
            // 
            this.chparametrizacion.AutoSize = true;
            this.chparametrizacion.Location = new System.Drawing.Point(599, 62);
            this.chparametrizacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chparametrizacion.Name = "chparametrizacion";
            this.chparametrizacion.Size = new System.Drawing.Size(226, 42);
            this.chparametrizacion.TabIndex = 6;
            this.chparametrizacion.Text = "Parametrizacion";
            this.chparametrizacion.UseVisualStyleBackColor = true;
            // 
            // chclientes
            // 
            this.chclientes.AutoSize = true;
            this.chclientes.Location = new System.Drawing.Point(248, 121);
            this.chclientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chclientes.Name = "chclientes";
            this.chclientes.Size = new System.Drawing.Size(130, 42);
            this.chclientes.TabIndex = 5;
            this.chclientes.Text = "Clientes";
            this.chclientes.UseVisualStyleBackColor = true;
            // 
            // chusuarios
            // 
            this.chusuarios.AutoSize = true;
            this.chusuarios.Location = new System.Drawing.Point(248, 62);
            this.chusuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chusuarios.Name = "chusuarios";
            this.chusuarios.Size = new System.Drawing.Size(139, 42);
            this.chusuarios.TabIndex = 4;
            this.chusuarios.Text = "Usuarios";
            this.chusuarios.UseVisualStyleBackColor = true;
            // 
            // chinventario
            // 
            this.chinventario.AutoSize = true;
            this.chinventario.Location = new System.Drawing.Point(417, 121);
            this.chinventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chinventario.Name = "chinventario";
            this.chinventario.Size = new System.Drawing.Size(155, 42);
            this.chinventario.TabIndex = 3;
            this.chinventario.Text = "Inventario";
            this.chinventario.UseVisualStyleBackColor = true;
            // 
            // chconsultas
            // 
            this.chconsultas.AutoSize = true;
            this.chconsultas.Location = new System.Drawing.Point(417, 62);
            this.chconsultas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chconsultas.Name = "chconsultas";
            this.chconsultas.Size = new System.Drawing.Size(152, 42);
            this.chconsultas.TabIndex = 2;
            this.chconsultas.Text = "Consultas";
            this.chconsultas.UseVisualStyleBackColor = true;
            // 
            // chpagos
            // 
            this.chpagos.AutoSize = true;
            this.chpagos.Location = new System.Drawing.Point(27, 121);
            this.chpagos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chpagos.Name = "chpagos";
            this.chpagos.Size = new System.Drawing.Size(110, 42);
            this.chpagos.TabIndex = 1;
            this.chpagos.Text = "Pagos";
            this.chpagos.UseVisualStyleBackColor = true;
            // 
            // chconfecciones
            // 
            this.chconfecciones.AutoSize = true;
            this.chconfecciones.Location = new System.Drawing.Point(27, 62);
            this.chconfecciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chconfecciones.Name = "chconfecciones";
            this.chconfecciones.Size = new System.Drawing.Size(195, 42);
            this.chconfecciones.TabIndex = 0;
            this.chconfecciones.Text = "Confecciones";
            this.chconfecciones.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 13.2F);
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(65, 226);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(105, 30);
            this.label23.TabIndex = 28;
            this.label23.Text = "Nombre :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 13.2F);
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(65, 178);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(133, 30);
            this.label22.TabIndex = 25;
            this.label22.Text = "Contraseña :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 13.2F);
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(65, 134);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(97, 30);
            this.label21.TabIndex = 23;
            this.label21.Text = "Usuario :";
            // 
            // txtid
            // 
            this.txtid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtid.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.txtid.Location = new System.Drawing.Point(216, 90);
            this.txtid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(273, 30);
            this.txtid.TabIndex = 17;
            this.txtid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtid_KeyDown);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 13.2F);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(65, 90);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 30);
            this.label18.TabIndex = 16;
            this.label18.Text = "ID :";
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConfeccionesLuis.Properties.Resources.fondo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1625, 965);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvusuarios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chparametrizacion;
        private System.Windows.Forms.CheckBox chclientes;
        private System.Windows.Forms.CheckBox chusuarios;
        private System.Windows.Forms.CheckBox chinventario;
        private System.Windows.Forms.CheckBox chconsultas;
        private System.Windows.Forms.CheckBox chpagos;
        private System.Windows.Forms.CheckBox chconfecciones;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtidacceso;
        private System.Windows.Forms.CheckBox chCompra;
    }
}