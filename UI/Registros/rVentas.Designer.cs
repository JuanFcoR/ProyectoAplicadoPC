﻿namespace ProyectoAplicadoPC.UI.Registros
{
    partial class rVentas
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
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.NumeroFacturaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DetallesDataGridView = new System.Windows.Forms.DataGridView();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.RemoverButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.Restaurar_pictureBox = new System.Windows.Forms.PictureBox();
            this.Minimizar_pictureBox = new System.Windows.Forms.PictureBox();
            this.Maximixar_pictureBox = new System.Windows.Forms.PictureBox();
            this.Cerrar_pictureBox = new System.Windows.Forms.PictureBox();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumeroFacturaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximixar_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(199)))), ((int)(((byte)(52)))));
            this.BarraTitulo.Controls.Add(this.Restaurar_pictureBox);
            this.BarraTitulo.Controls.Add(this.label11);
            this.BarraTitulo.Controls.Add(this.Minimizar_pictureBox);
            this.BarraTitulo.Controls.Add(this.Maximixar_pictureBox);
            this.BarraTitulo.Controls.Add(this.Cerrar_pictureBox);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(485, 32);
            this.BarraTitulo.TabIndex = 67;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(90, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 23);
            this.label11.TabIndex = 50;
            this.label11.Text = "Registrar Ventas";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.BackColor = System.Drawing.Color.White;
            this.TotalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalTextBox.ForeColor = System.Drawing.Color.Black;
            this.TotalTextBox.Location = new System.Drawing.Point(109, 125);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(229, 20);
            this.TotalTextBox.TabIndex = 79;
            // 
            // NumeroFacturaNumericUpDown
            // 
            this.NumeroFacturaNumericUpDown.Location = new System.Drawing.Point(109, 55);
            this.NumeroFacturaNumericUpDown.Name = "NumeroFacturaNumericUpDown";
            this.NumeroFacturaNumericUpDown.Size = new System.Drawing.Size(55, 20);
            this.NumeroFacturaNumericUpDown.TabIndex = 78;
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(109, 90);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(86, 20);
            this.FechaDateTimePicker.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(15, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 70;
            this.label3.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 69;
            this.label2.Text = "Factura No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 68;
            this.label1.Text = "Fecha";
            // 
            // DetallesDataGridView
            // 
            this.DetallesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DetallesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DetallesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetallesDataGridView.Location = new System.Drawing.Point(12, 151);
            this.DetallesDataGridView.Name = "DetallesDataGridView";
            this.DetallesDataGridView.Size = new System.Drawing.Size(461, 181);
            this.DetallesDataGridView.TabIndex = 91;
            // 
            // AgregarButton
            // 
            this.AgregarButton.BackColor = System.Drawing.Color.White;
            this.AgregarButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(199)))), ((int)(((byte)(52)))));
            this.AgregarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarButton.Location = new System.Drawing.Point(440, 121);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(33, 24);
            this.AgregarButton.TabIndex = 93;
            this.AgregarButton.Text = "+";
            this.AgregarButton.UseVisualStyleBackColor = false;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // RemoverButton
            // 
            this.RemoverButton.BackColor = System.Drawing.Color.White;
            this.RemoverButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(199)))), ((int)(((byte)(52)))));
            this.RemoverButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoverButton.Image = global::ProyectoAplicadoPC.Properties.Resources.seo_social_web_network_internet_322_icon_icons_com_61532;
            this.RemoverButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoverButton.Location = new System.Drawing.Point(357, 338);
            this.RemoverButton.Name = "RemoverButton";
            this.RemoverButton.Size = new System.Drawing.Size(116, 26);
            this.RemoverButton.TabIndex = 92;
            this.RemoverButton.Text = "Remover Fila";
            this.RemoverButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoverButton.UseVisualStyleBackColor = false;
            this.RemoverButton.Click += new System.EventHandler(this.RemoverButton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.BackColor = System.Drawing.Color.White;
            this.BuscarButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(199)))), ((int)(((byte)(52)))));
            this.BuscarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscarButton.Image = global::ProyectoAplicadoPC.Properties.Resources.preview_search_find_locate_1551;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(185, 45);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(79, 36);
            this.BuscarButton.TabIndex = 89;
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
            this.GuardarButton.Image = global::ProyectoAplicadoPC.Properties.Resources.Save_as_icon;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(35, 338);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(94, 36);
            this.GuardarButton.TabIndex = 84;
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
            this.CancelarButton.Image = global::ProyectoAplicadoPC.Properties.Resources.Remove_icon;
            this.CancelarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelarButton.Location = new System.Drawing.Point(185, 338);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(94, 36);
            this.CancelarButton.TabIndex = 83;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelarButton.UseVisualStyleBackColor = false;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // Restaurar_pictureBox
            // 
            this.Restaurar_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Restaurar_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Restaurar_pictureBox.Image = global::ProyectoAplicadoPC.Properties.Resources.res;
            this.Restaurar_pictureBox.Location = new System.Drawing.Point(434, 3);
            this.Restaurar_pictureBox.Name = "Restaurar_pictureBox";
            this.Restaurar_pictureBox.Size = new System.Drawing.Size(21, 25);
            this.Restaurar_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Restaurar_pictureBox.TabIndex = 9;
            this.Restaurar_pictureBox.TabStop = false;
            this.Restaurar_pictureBox.Visible = false;
            this.Restaurar_pictureBox.Click += new System.EventHandler(this.Restaurar_pictureBox_Click);
            // 
            // Minimizar_pictureBox
            // 
            this.Minimizar_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizar_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimizar_pictureBox.Image = global::ProyectoAplicadoPC.Properties.Resources.minimazar;
            this.Minimizar_pictureBox.Location = new System.Drawing.Point(407, 3);
            this.Minimizar_pictureBox.Name = "Minimizar_pictureBox";
            this.Minimizar_pictureBox.Size = new System.Drawing.Size(21, 25);
            this.Minimizar_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimizar_pictureBox.TabIndex = 8;
            this.Minimizar_pictureBox.TabStop = false;
            this.Minimizar_pictureBox.Click += new System.EventHandler(this.Minimizar_pictureBox_Click);
            // 
            // Maximixar_pictureBox
            // 
            this.Maximixar_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximixar_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Maximixar_pictureBox.Image = global::ProyectoAplicadoPC.Properties.Resources.maxi;
            this.Maximixar_pictureBox.Location = new System.Drawing.Point(434, 4);
            this.Maximixar_pictureBox.Name = "Maximixar_pictureBox";
            this.Maximixar_pictureBox.Size = new System.Drawing.Size(21, 25);
            this.Maximixar_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Maximixar_pictureBox.TabIndex = 7;
            this.Maximixar_pictureBox.TabStop = false;
            this.Maximixar_pictureBox.Click += new System.EventHandler(this.Maximixar_pictureBox_Click);
            // 
            // Cerrar_pictureBox
            // 
            this.Cerrar_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cerrar_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Cerrar_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cerrar_pictureBox.Image = global::ProyectoAplicadoPC.Properties.Resources.cerrar;
            this.Cerrar_pictureBox.Location = new System.Drawing.Point(461, 4);
            this.Cerrar_pictureBox.Name = "Cerrar_pictureBox";
            this.Cerrar_pictureBox.Size = new System.Drawing.Size(21, 25);
            this.Cerrar_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cerrar_pictureBox.TabIndex = 6;
            this.Cerrar_pictureBox.TabStop = false;
            this.Cerrar_pictureBox.Click += new System.EventHandler(this.Cerrar_pictureBox_Click);
            // 
            // rVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 405);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.RemoverButton);
            this.Controls.Add(this.DetallesDataGridView);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.NumeroFacturaNumericUpDown);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rVentas";
            this.Text = "rVentas";
            this.Load += new System.EventHandler(this.RVentas_Load);
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumeroFacturaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximixar_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox Restaurar_pictureBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox Minimizar_pictureBox;
        private System.Windows.Forms.PictureBox Maximixar_pictureBox;
        private System.Windows.Forms.PictureBox Cerrar_pictureBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.NumericUpDown NumeroFacturaNumericUpDown;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RemoverButton;
        private System.Windows.Forms.DataGridView DetallesDataGridView;
        private System.Windows.Forms.Button AgregarButton;
    }
}