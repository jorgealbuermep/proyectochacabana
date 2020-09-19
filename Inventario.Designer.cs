namespace ConfeccionesLuis
{
    partial class Inventario
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
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hasta = new System.Windows.Forms.DateTimePicker();
            this.desde = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ganancia = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.capital = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.generar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvcompras = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcompras)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.hasta);
            this.panel1.Controls.Add(this.desde);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.generar);
            this.panel1.Location = new System.Drawing.Point(60, 94);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1491, 790);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(47, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(524, 37);
            this.label3.TabIndex = 43;
            this.label3.Text = "Selecciona la fecha para generar Inventario";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(53, 278);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(197, 50);
            this.button4.TabIndex = 42;
            this.button4.Text = "Limpiar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.2F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(85, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 30);
            this.label2.TabIndex = 39;
            this.label2.Text = "Hasta : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.2F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(85, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 30);
            this.label1.TabIndex = 38;
            this.label1.Text = "Desde :";
            // 
            // hasta
            // 
            this.hasta.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.hasta.Location = new System.Drawing.Point(211, 177);
            this.hasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hasta.Name = "hasta";
            this.hasta.Size = new System.Drawing.Size(331, 30);
            this.hasta.TabIndex = 9;
            // 
            // desde
            // 
            this.desde.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.desde.Location = new System.Drawing.Point(211, 121);
            this.desde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.desde.Name = "desde";
            this.desde.Size = new System.Drawing.Size(331, 30);
            this.desde.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.ganancia);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.capital);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(619, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(828, 281);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion Monetaria";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(516, 78);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 66);
            this.button1.TabIndex = 43;
            this.button1.Text = "Exportar a Excel";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.IndianRed;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(516, 160);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(288, 66);
            this.button5.TabIndex = 42;
            this.button5.Text = "Exportar a PDF";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // ganancia
            // 
            this.ganancia.Enabled = false;
            this.ganancia.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.ganancia.Location = new System.Drawing.Point(168, 174);
            this.ganancia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ganancia.Name = "ganancia";
            this.ganancia.Size = new System.Drawing.Size(249, 30);
            this.ganancia.TabIndex = 29;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 13.2F);
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(32, 170);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(111, 30);
            this.label21.TabIndex = 23;
            this.label21.Text = "Ganancia :";
            // 
            // capital
            // 
            this.capital.Enabled = false;
            this.capital.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.capital.Location = new System.Drawing.Point(168, 110);
            this.capital.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.capital.Name = "capital";
            this.capital.Size = new System.Drawing.Size(249, 30);
            this.capital.TabIndex = 17;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 13.2F);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(32, 110);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(96, 30);
            this.label18.TabIndex = 16;
            this.label18.Text = "Capital : ";
            // 
            // generar
            // 
            this.generar.BackColor = System.Drawing.Color.Transparent;
            this.generar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.generar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generar.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generar.ForeColor = System.Drawing.Color.White;
            this.generar.Location = new System.Drawing.Point(303, 278);
            this.generar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generar.Name = "generar";
            this.generar.Size = new System.Drawing.Size(268, 50);
            this.generar.TabIndex = 7;
            this.generar.Text = "Generar Inventario";
            this.generar.UseVisualStyleBackColor = false;
            this.generar.Click += new System.EventHandler(this.editar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1640, 47);
            this.panel2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.8F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(570, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 42);
            this.label4.TabIndex = 15;
            this.label4.Text = "CLQ - Inventario";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvcompras);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(54, 360);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1393, 380);
            this.groupBox4.TabIndex = 44;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Productos Comprados";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // dgvcompras
            // 
            this.dgvcompras.BackgroundColor = System.Drawing.Color.White;
            this.dgvcompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcompras.Location = new System.Drawing.Point(28, 51);
            this.dgvcompras.Name = "dgvcompras";
            this.dgvcompras.RowTemplate.Height = 24;
            this.dgvcompras.Size = new System.Drawing.Size(1341, 296);
            this.dgvcompras.TabIndex = 1;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConfeccionesLuis.Properties.Resources.fondo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1640, 935);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcompras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button generar;
        private System.Windows.Forms.TextBox ganancia;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox capital;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker hasta;
        private System.Windows.Forms.DateTimePicker desde;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvcompras;
    }
}