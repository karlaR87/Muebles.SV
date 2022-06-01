
namespace proyectoLogin1
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
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.btningresar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btMostrar = new System.Windows.Forms.PictureBox();
            this.ptOcultar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptOcultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtusuario
            // 
            this.txtusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(217)))), ((int)(((byte)(206)))));
            this.txtusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.ForeColor = System.Drawing.Color.Gray;
            this.txtusuario.Location = new System.Drawing.Point(333, 183);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtusuario.Multiline = true;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(206, 28);
            this.txtusuario.TabIndex = 2;
            this.txtusuario.Text = "Usuario";
            this.txtusuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtusuario.Enter += new System.EventHandler(this.txtusuario_Enter);
            this.txtusuario.Leave += new System.EventHandler(this.txtusuario_Leave);
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(217)))), ((int)(((byte)(206)))));
            this.txtcontraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontraseña.ForeColor = System.Drawing.Color.Gray;
            this.txtcontraseña.Location = new System.Drawing.Point(333, 244);
            this.txtcontraseña.Margin = new System.Windows.Forms.Padding(2);
            this.txtcontraseña.Multiline = true;
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(206, 30);
            this.txtcontraseña.TabIndex = 4;
            this.txtcontraseña.Text = "Contraseña";
            this.txtcontraseña.Enter += new System.EventHandler(this.txtcontraseña_Enter);
            this.txtcontraseña.Leave += new System.EventHandler(this.txtcontraseña_Leave);
            // 
            // btningresar
            // 
            this.btningresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(159)))), ((int)(((byte)(123)))));
            this.btningresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btningresar.Font = new System.Drawing.Font("Tw Cen MT Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btningresar.Location = new System.Drawing.Point(366, 331);
            this.btningresar.Margin = new System.Windows.Forms.Padding(2);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(154, 36);
            this.btningresar.TabIndex = 5;
            this.btningresar.Text = "INICIAR SECCIÓN";
            this.btningresar.UseVisualStyleBackColor = false;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Tan;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.minimizar);
            this.panel2.Location = new System.Drawing.Point(0, -7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(614, 45);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(159)))), ((int)(((byte)(123)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 357);
            this.panel1.TabIndex = 9;
            // 
            // btMostrar
            // 
            this.btMostrar.Image = global::proyectoLogin1.Properties.Resources.ojo1;
            this.btMostrar.Location = new System.Drawing.Point(545, 244);
            this.btMostrar.Name = "btMostrar";
            this.btMostrar.Size = new System.Drawing.Size(38, 30);
            this.btMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btMostrar.TabIndex = 11;
            this.btMostrar.TabStop = false;
            this.btMostrar.Click += new System.EventHandler(this.btMostrar_Click);
            // 
            // ptOcultar
            // 
            this.ptOcultar.Image = global::proyectoLogin1.Properties.Resources.ojo2;
            this.ptOcultar.Location = new System.Drawing.Point(545, 244);
            this.ptOcultar.Name = "ptOcultar";
            this.ptOcultar.Size = new System.Drawing.Size(38, 30);
            this.ptOcultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptOcultar.TabIndex = 10;
            this.ptOcultar.TabStop = false;
            this.ptOcultar.Click += new System.EventHandler(this.pictureBox4_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proyectoLogin1.Properties.Resources.muebles_sv2;
            this.pictureBox1.Location = new System.Drawing.Point(33, 122);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::proyectoLogin1.Properties.Resources.usuario2;
            this.pictureBox2.Location = new System.Drawing.Point(378, 53);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(114, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::proyectoLogin1.Properties.Resources.esquisde;
            this.pictureBox3.Location = new System.Drawing.Point(576, 15);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // minimizar
            // 
            this.minimizar.Image = global::proyectoLogin1.Properties.Resources.minimizar;
            this.minimizar.Location = new System.Drawing.Point(545, 15);
            this.minimizar.Margin = new System.Windows.Forms.Padding(2);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(38, 26);
            this.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizar.TabIndex = 7;
            this.minimizar.TabStop = false;
            this.minimizar.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(217)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(614, 393);
            this.Controls.Add(this.btMostrar);
            this.Controls.Add(this.ptOcultar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptOcultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptOcultar;
        private System.Windows.Forms.PictureBox btMostrar;
    }
}

