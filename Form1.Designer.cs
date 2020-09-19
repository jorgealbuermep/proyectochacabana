namespace ConfeccionesLuis
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsuarioLogIn = new System.Windows.Forms.TextBox();
            this.txtPassUser = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 30F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(605, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Confecciones Luis Quezada";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(114, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(114, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña :";
            // 
            // txtUsuarioLogIn
            // 
            this.txtUsuarioLogIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuarioLogIn.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioLogIn.Location = new System.Drawing.Point(302, 141);
            this.txtUsuarioLogIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuarioLogIn.Name = "txtUsuarioLogIn";
            this.txtUsuarioLogIn.Size = new System.Drawing.Size(297, 34);
            this.txtUsuarioLogIn.TabIndex = 3;
            this.txtUsuarioLogIn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuarioLogIn_KeyDown);
            // 
            // txtPassUser
            // 
            this.txtPassUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassUser.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassUser.Location = new System.Drawing.Point(302, 215);
            this.txtPassUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassUser.Name = "txtPassUser";
            this.txtPassUser.PasswordChar = '*';
            this.txtPassUser.Size = new System.Drawing.Size(297, 34);
            this.txtPassUser.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(183, 304);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(151, 84);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.Transparent;
            this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(414, 304);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(151, 84);
            this.btnEntrar.TabIndex = 6;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(726, 442);
            this.ControlBox = false;
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtPassUser);
            this.Controls.Add(this.txtUsuarioLogIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsuarioLogIn;
        private System.Windows.Forms.TextBox txtPassUser;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEntrar;
    }
}

