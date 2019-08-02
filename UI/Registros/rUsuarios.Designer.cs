namespace ProyectoAplicadoPC.UI.Registros
{
    partial class rUsuarios
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
            this.Niveles_panel = new System.Windows.Forms.Panel();
            this.Administrador_radioButton = new System.Windows.Forms.RadioButton();
            this.Contador_radioButton = new System.Windows.Forms.RadioButton();
            this.FechaIngreso_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Clave_textBox = new System.Windows.Forms.TextBox();
            this.Usuario_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.UsuarioId_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Confirmar_textBox = new System.Windows.Forms.TextBox();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.Restaurar_pictureBox = new System.Windows.Forms.PictureBox();
            this.Minimizar_pictureBox = new System.Windows.Forms.PictureBox();
            this.Cerrar_pictureBox = new System.Windows.Forms.PictureBox();
            this.Maximixar_pictureBox = new System.Windows.Forms.PictureBox();
            this.SuperErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.BuscarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.Niveles_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioId_numericUpDown)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximixar_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuperErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Niveles_panel
            // 
            this.Niveles_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Niveles_panel.Controls.Add(this.Administrador_radioButton);
            this.Niveles_panel.Controls.Add(this.Contador_radioButton);
            this.Niveles_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Niveles_panel.Location = new System.Drawing.Point(117, 215);
            this.Niveles_panel.Name = "Niveles_panel";
            this.Niveles_panel.Size = new System.Drawing.Size(164, 56);
            this.Niveles_panel.TabIndex = 47;
            // 
            // Administrador_radioButton
            // 
            this.Administrador_radioButton.AutoSize = true;
            this.Administrador_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Administrador_radioButton.Location = new System.Drawing.Point(16, 3);
            this.Administrador_radioButton.Name = "Administrador_radioButton";
            this.Administrador_radioButton.Size = new System.Drawing.Size(109, 20);
            this.Administrador_radioButton.TabIndex = 29;
            this.Administrador_radioButton.TabStop = true;
            this.Administrador_radioButton.Text = "Administrador";
            this.Administrador_radioButton.UseVisualStyleBackColor = true;
            this.Administrador_radioButton.CheckedChanged += new System.EventHandler(this.Administrador_radioButton_CheckedChanged);
            // 
            // Contador_radioButton
            // 
            this.Contador_radioButton.AutoSize = true;
            this.Contador_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contador_radioButton.Location = new System.Drawing.Point(16, 26);
            this.Contador_radioButton.Name = "Contador_radioButton";
            this.Contador_radioButton.Size = new System.Drawing.Size(66, 20);
            this.Contador_radioButton.TabIndex = 29;
            this.Contador_radioButton.TabStop = true;
            this.Contador_radioButton.Text = "Cajero";
            this.Contador_radioButton.UseVisualStyleBackColor = true;
            // 
            // FechaIngreso_dateTimePicker
            // 
            this.FechaIngreso_dateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaIngreso_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.FechaIngreso_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaIngreso_dateTimePicker.Location = new System.Drawing.Point(117, 281);
            this.FechaIngreso_dateTimePicker.Name = "FechaIngreso_dateTimePicker";
            this.FechaIngreso_dateTimePicker.Size = new System.Drawing.Size(164, 23);
            this.FechaIngreso_dateTimePicker.TabIndex = 46;
            // 
            // Clave_textBox
            // 
            this.Clave_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Clave_textBox.Location = new System.Drawing.Point(117, 144);
            this.Clave_textBox.Name = "Clave_textBox";
            this.Clave_textBox.Size = new System.Drawing.Size(164, 23);
            this.Clave_textBox.TabIndex = 45;
            // 
            // Usuario_textBox
            // 
            this.Usuario_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Usuario_textBox.Location = new System.Drawing.Point(117, 106);
            this.Usuario_textBox.Name = "Usuario_textBox";
            this.Usuario_textBox.Size = new System.Drawing.Size(164, 23);
            this.Usuario_textBox.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 10.75F);
            this.label8.Location = new System.Drawing.Point(9, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 19);
            this.label8.TabIndex = 42;
            this.label8.Text = "Fecha Ingreso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.75F);
            this.label4.Location = new System.Drawing.Point(12, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 19);
            this.label4.TabIndex = 40;
            this.label4.Text = "Nivel Usuario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 10.75F);
            this.label7.Location = new System.Drawing.Point(12, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 19);
            this.label7.TabIndex = 39;
            this.label7.Text = "Clave";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 10.75F);
            this.label6.Location = new System.Drawing.Point(12, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 41;
            this.label6.Text = "Usuario";
            // 
            // UsuarioId_numericUpDown
            // 
            this.UsuarioId_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.UsuarioId_numericUpDown.Location = new System.Drawing.Point(117, 45);
            this.UsuarioId_numericUpDown.Name = "UsuarioId_numericUpDown";
            this.UsuarioId_numericUpDown.Size = new System.Drawing.Size(78, 23);
            this.UsuarioId_numericUpDown.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.75F);
            this.label1.Location = new System.Drawing.Point(15, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "UsuarioId";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 10.75F);
            this.label9.Location = new System.Drawing.Point(12, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 19);
            this.label9.TabIndex = 39;
            this.label9.Text = "Confirmar";
            // 
            // Confirmar_textBox
            // 
            this.Confirmar_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Confirmar_textBox.Location = new System.Drawing.Point(117, 181);
            this.Confirmar_textBox.Name = "Confirmar_textBox";
            this.Confirmar_textBox.Size = new System.Drawing.Size(164, 23);
            this.Confirmar_textBox.TabIndex = 45;
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
            this.BarraTitulo.Size = new System.Drawing.Size(312, 32);
            this.BarraTitulo.TabIndex = 78;
            // 
            // Restaurar_pictureBox
            // 
            this.Restaurar_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Restaurar_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Restaurar_pictureBox.Image = global::ProyectoAplicadoPC.Properties.Resources.res;
            this.Restaurar_pictureBox.Location = new System.Drawing.Point(256, 5);
            this.Restaurar_pictureBox.Name = "Restaurar_pictureBox";
            this.Restaurar_pictureBox.Size = new System.Drawing.Size(21, 25);
            this.Restaurar_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Restaurar_pictureBox.TabIndex = 81;
            this.Restaurar_pictureBox.TabStop = false;
            this.Restaurar_pictureBox.Visible = false;
            // 
            // Minimizar_pictureBox
            // 
            this.Minimizar_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizar_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimizar_pictureBox.Image = global::ProyectoAplicadoPC.Properties.Resources.minimazar;
            this.Minimizar_pictureBox.Location = new System.Drawing.Point(229, 5);
            this.Minimizar_pictureBox.Name = "Minimizar_pictureBox";
            this.Minimizar_pictureBox.Size = new System.Drawing.Size(21, 25);
            this.Minimizar_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimizar_pictureBox.TabIndex = 80;
            this.Minimizar_pictureBox.TabStop = false;
            // 
            // Cerrar_pictureBox
            // 
            this.Cerrar_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cerrar_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Cerrar_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cerrar_pictureBox.Image = global::ProyectoAplicadoPC.Properties.Resources.cerrar;
            this.Cerrar_pictureBox.Location = new System.Drawing.Point(283, 5);
            this.Cerrar_pictureBox.Name = "Cerrar_pictureBox";
            this.Cerrar_pictureBox.Size = new System.Drawing.Size(21, 25);
            this.Cerrar_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cerrar_pictureBox.TabIndex = 78;
            this.Cerrar_pictureBox.TabStop = false;
            // 
            // Maximixar_pictureBox
            // 
            this.Maximixar_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximixar_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Maximixar_pictureBox.Image = global::ProyectoAplicadoPC.Properties.Resources.maxi;
            this.Maximixar_pictureBox.Location = new System.Drawing.Point(256, 5);
            this.Maximixar_pictureBox.Name = "Maximixar_pictureBox";
            this.Maximixar_pictureBox.Size = new System.Drawing.Size(21, 25);
            this.Maximixar_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Maximixar_pictureBox.TabIndex = 79;
            this.Maximixar_pictureBox.TabStop = false;
            // 
            // SuperErrorProvider
            // 
            this.SuperErrorProvider.ContainerControl = this;
            // 
            // BuscarButton
            // 
            this.BuscarButton.BackColor = System.Drawing.Color.White;
            this.BuscarButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(199)))), ((int)(((byte)(52)))));
            this.BuscarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarButton.Image = global::ProyectoAplicadoPC.Properties.Resources.preview_search_find_locate_1551;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(201, 38);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(92, 55);
            this.BuscarButton.TabIndex = 79;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = false;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.BackColor = System.Drawing.Color.White;
            this.GuardarButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(199)))), ((int)(((byte)(52)))));
            this.GuardarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Image = global::ProyectoAplicadoPC.Properties.Resources.Save_as_icon;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(161, 326);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(110, 55);
            this.GuardarButton.TabIndex = 81;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = false;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.BackColor = System.Drawing.Color.White;
            this.CancelarButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(199)))), ((int)(((byte)(52)))));
            this.CancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.Image = global::ProyectoAplicadoPC.Properties.Resources.Remove_icon;
            this.CancelarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelarButton.Location = new System.Drawing.Point(36, 326);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(110, 55);
            this.CancelarButton.TabIndex = 80;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelarButton.UseVisualStyleBackColor = false;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // rUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 410);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.Niveles_panel);
            this.Controls.Add(this.FechaIngreso_dateTimePicker);
            this.Controls.Add(this.Confirmar_textBox);
            this.Controls.Add(this.Clave_textBox);
            this.Controls.Add(this.Usuario_textBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.UsuarioId_numericUpDown);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rUsuarios";
            this.Text = "rUsuarios";
            this.Niveles_panel.ResumeLayout(false);
            this.Niveles_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioId_numericUpDown)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximixar_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuperErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Niveles_panel;
        private System.Windows.Forms.RadioButton Administrador_radioButton;
        private System.Windows.Forms.RadioButton Contador_radioButton;
        private System.Windows.Forms.DateTimePicker FechaIngreso_dateTimePicker;
        private System.Windows.Forms.TextBox Clave_textBox;
        private System.Windows.Forms.TextBox Usuario_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown UsuarioId_numericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Confirmar_textBox;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox Restaurar_pictureBox;
        private System.Windows.Forms.PictureBox Minimizar_pictureBox;
        private System.Windows.Forms.PictureBox Cerrar_pictureBox;
        private System.Windows.Forms.PictureBox Maximixar_pictureBox;
        private System.Windows.Forms.ErrorProvider SuperErrorProvider;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button CancelarButton;
    }
}