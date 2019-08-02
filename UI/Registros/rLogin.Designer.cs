namespace ProyectoAplicadoPC.UI.Registros
{
    partial class rLogin
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
            this.components = new System.ComponentModel.Container();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.Clave_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Usuario_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Limpiar_button = new System.Windows.Forms.Button();
            this.IniciarSesion_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Restaurar_pictureBox = new System.Windows.Forms.PictureBox();
            this.Minimizar_pictureBox = new System.Windows.Forms.PictureBox();
            this.Maximixar_pictureBox = new System.Windows.Forms.PictureBox();
            this.Cerrar_pictureBox = new System.Windows.Forms.PictureBox();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximixar_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(199)))), ((int)(((byte)(52)))));
            this.BarraTitulo.Controls.Add(this.Restaurar_pictureBox);
            this.BarraTitulo.Controls.Add(this.Minimizar_pictureBox);
            this.BarraTitulo.Controls.Add(this.Cerrar_pictureBox);
            this.BarraTitulo.Controls.Add(this.Maximixar_pictureBox);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(378, 32);
            this.BarraTitulo.TabIndex = 77;
            this.BarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraTitulo_Paint);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(31, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 33);
            this.label11.TabIndex = 76;
            this.label11.Text = "Login";
            // 
            // Clave_textBox
            // 
            this.Clave_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clave_textBox.Location = new System.Drawing.Point(196, 110);
            this.Clave_textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Clave_textBox.Name = "Clave_textBox";
            this.Clave_textBox.PasswordChar = '*';
            this.Clave_textBox.Size = new System.Drawing.Size(167, 26);
            this.Clave_textBox.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 73;
            this.label2.Text = "Clave";
            // 
            // Usuario_textBox
            // 
            this.Usuario_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario_textBox.Location = new System.Drawing.Point(196, 78);
            this.Usuario_textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Usuario_textBox.Name = "Usuario_textBox";
            this.Usuario_textBox.Size = new System.Drawing.Size(167, 26);
            this.Usuario_textBox.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 71;
            this.label1.Text = "Usuario";
            // 
            // Limpiar_button
            // 
            this.Limpiar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpiar_button.Location = new System.Drawing.Point(135, 147);
            this.Limpiar_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Limpiar_button.Name = "Limpiar_button";
            this.Limpiar_button.Size = new System.Drawing.Size(94, 26);
            this.Limpiar_button.TabIndex = 69;
            this.Limpiar_button.Text = "Limpiar";
            this.Limpiar_button.UseVisualStyleBackColor = true;
            this.Limpiar_button.Click += new System.EventHandler(this.Limpiar_button_Click);
            // 
            // IniciarSesion_button
            // 
            this.IniciarSesion_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarSesion_button.Location = new System.Drawing.Point(237, 147);
            this.IniciarSesion_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IniciarSesion_button.Name = "IniciarSesion_button";
            this.IniciarSesion_button.Size = new System.Drawing.Size(126, 26);
            this.IniciarSesion_button.TabIndex = 70;
            this.IniciarSesion_button.Text = "Iniciar Sesión";
            this.IniciarSesion_button.UseVisualStyleBackColor = true;
            this.IniciarSesion_button.Click += new System.EventHandler(this.IniciarSesion_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoAplicadoPC.Properties.Resources.User_icon;
            this.pictureBox1.Location = new System.Drawing.Point(16, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "";
            // 
            // Restaurar_pictureBox
            // 
            this.Restaurar_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Restaurar_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Restaurar_pictureBox.Image = global::ProyectoAplicadoPC.Properties.Resources.res;
            this.Restaurar_pictureBox.Location = new System.Drawing.Point(322, 5);
            this.Restaurar_pictureBox.Name = "Restaurar_pictureBox";
            this.Restaurar_pictureBox.Size = new System.Drawing.Size(21, 25);
            this.Restaurar_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Restaurar_pictureBox.TabIndex = 81;
            this.Restaurar_pictureBox.TabStop = false;
            this.Restaurar_pictureBox.Visible = false;
            this.Restaurar_pictureBox.Click += new System.EventHandler(this.Restaurar_pictureBox_Click);
            // 
            // Minimizar_pictureBox
            // 
            this.Minimizar_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizar_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimizar_pictureBox.Image = global::ProyectoAplicadoPC.Properties.Resources.minimazar;
            this.Minimizar_pictureBox.Location = new System.Drawing.Point(295, 5);
            this.Minimizar_pictureBox.Name = "Minimizar_pictureBox";
            this.Minimizar_pictureBox.Size = new System.Drawing.Size(21, 25);
            this.Minimizar_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimizar_pictureBox.TabIndex = 80;
            this.Minimizar_pictureBox.TabStop = false;
            this.Minimizar_pictureBox.Click += new System.EventHandler(this.Minimizar_pictureBox_Click);
            // 
            // Maximixar_pictureBox
            // 
            this.Maximixar_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximixar_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Maximixar_pictureBox.Image = global::ProyectoAplicadoPC.Properties.Resources.maxi;
            this.Maximixar_pictureBox.Location = new System.Drawing.Point(322, 5);
            this.Maximixar_pictureBox.Name = "Maximixar_pictureBox";
            this.Maximixar_pictureBox.Size = new System.Drawing.Size(21, 25);
            this.Maximixar_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Maximixar_pictureBox.TabIndex = 79;
            this.Maximixar_pictureBox.TabStop = false;
            this.Maximixar_pictureBox.Click += new System.EventHandler(this.Maximixar_pictureBox_Click);
            // 
            // Cerrar_pictureBox
            // 
            this.Cerrar_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cerrar_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Cerrar_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cerrar_pictureBox.Image = global::ProyectoAplicadoPC.Properties.Resources.cerrar;
            this.Cerrar_pictureBox.Location = new System.Drawing.Point(349, 5);
            this.Cerrar_pictureBox.Name = "Cerrar_pictureBox";
            this.Cerrar_pictureBox.Size = new System.Drawing.Size(21, 25);
            this.Cerrar_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cerrar_pictureBox.TabIndex = 78;
            this.Cerrar_pictureBox.TabStop = false;
            this.Cerrar_pictureBox.Click += new System.EventHandler(this.Cerrar_pictureBox_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // rLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 191);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Clave_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Usuario_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Limpiar_button);
            this.Controls.Add(this.IniciarSesion_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rLogin";
            this.Text = "rLogin";
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximixar_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Clave_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Usuario_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Limpiar_button;
        private System.Windows.Forms.Button IniciarSesion_button;
        private System.Windows.Forms.PictureBox Restaurar_pictureBox;
        private System.Windows.Forms.PictureBox Minimizar_pictureBox;
        private System.Windows.Forms.PictureBox Maximixar_pictureBox;
        private System.Windows.Forms.PictureBox Cerrar_pictureBox;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}