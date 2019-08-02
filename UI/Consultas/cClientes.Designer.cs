namespace ProyectoAplicadoPC.UI.Consultas
{
    partial class cClientes
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
            this.CerrarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.EditarButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.FiltrarComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ConsultaDataGridView = new System.Windows.Forms.DataGridView();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.Restaurar_pictureBox = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Minimizar_pictureBox = new System.Windows.Forms.PictureBox();
            this.Maximixar_pictureBox = new System.Windows.Forms.PictureBox();
            this.Cerrar_pictureBox = new System.Windows.Forms.PictureBox();
            this.ConsultaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDataGridView)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximixar_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CerrarButton
            // 
            this.CerrarButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(199)))), ((int)(((byte)(52)))));
            this.CerrarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CerrarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CerrarButton.Location = new System.Drawing.Point(631, 298);
            this.CerrarButton.Margin = new System.Windows.Forms.Padding(2);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.Size = new System.Drawing.Size(83, 68);
            this.CerrarButton.TabIndex = 64;
            this.CerrarButton.Text = "Cerrar";
            this.CerrarButton.UseVisualStyleBackColor = true;
            this.CerrarButton.Click += new System.EventHandler(this.CerrarButton_Click_1);
            // 
            // NuevoButton
            // 
            this.NuevoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(199)))), ((int)(((byte)(52)))));
            this.NuevoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevoButton.Location = new System.Drawing.Point(631, 217);
            this.NuevoButton.Margin = new System.Windows.Forms.Padding(2);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(83, 57);
            this.NuevoButton.TabIndex = 63;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click_1);
            // 
            // EditarButton
            // 
            this.EditarButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(199)))), ((int)(((byte)(52)))));
            this.EditarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditarButton.Location = new System.Drawing.Point(631, 133);
            this.EditarButton.Margin = new System.Windows.Forms.Padding(2);
            this.EditarButton.Name = "EditarButton";
            this.EditarButton.Size = new System.Drawing.Size(83, 56);
            this.EditarButton.TabIndex = 62;
            this.EditarButton.Text = "Editar";
            this.EditarButton.UseVisualStyleBackColor = true;
            this.EditarButton.Click += new System.EventHandler(this.EditarButton_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Hasta";
            // 
            // HastaDateTimePicker
            // 
            this.HastaDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.HastaDateTimePicker.Location = new System.Drawing.Point(103, 50);
            this.HastaDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.HastaDateTimePicker.Name = "HastaDateTimePicker";
            this.HastaDateTimePicker.Size = new System.Drawing.Size(77, 20);
            this.HastaDateTimePicker.TabIndex = 59;
            // 
            // DesdeDateTimePicker
            // 
            this.DesdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DesdeDateTimePicker.Location = new System.Drawing.Point(14, 52);
            this.DesdeDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.DesdeDateTimePicker.Name = "DesdeDateTimePicker";
            this.DesdeDateTimePicker.Size = new System.Drawing.Size(75, 20);
            this.DesdeDateTimePicker.TabIndex = 58;
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CriterioTextBox.Location = new System.Drawing.Point(289, 52);
            this.CriterioTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(323, 20);
            this.CriterioTextBox.TabIndex = 56;
            // 
            // FiltrarComboBox
            // 
            this.FiltrarComboBox.FormattingEnabled = true;
            this.FiltrarComboBox.Items.AddRange(new object[] {
            "Todo",
            "ID",
            "Nombre",
            "Cedula",
            "Telefono",
            "Direccion"});
            this.FiltrarComboBox.Location = new System.Drawing.Point(193, 52);
            this.FiltrarComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.FiltrarComboBox.Name = "FiltrarComboBox";
            this.FiltrarComboBox.Size = new System.Drawing.Size(92, 21);
            this.FiltrarComboBox.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Criterio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Filtro";
            // 
            // ConsultaDataGridView
            // 
            this.ConsultaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsultaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaDataGridView.Location = new System.Drawing.Point(17, 83);
            this.ConsultaDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.ConsultaDataGridView.Name = "ConsultaDataGridView";
            this.ConsultaDataGridView.RowTemplate.Height = 24;
            this.ConsultaDataGridView.Size = new System.Drawing.Size(595, 319);
            this.ConsultaDataGridView.TabIndex = 52;
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
            this.BarraTitulo.Size = new System.Drawing.Size(730, 32);
            this.BarraTitulo.TabIndex = 65;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // Restaurar_pictureBox
            // 
            this.Restaurar_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Restaurar_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Restaurar_pictureBox.Image = global::ProyectoAplicadoPC.Properties.Resources.res;
            this.Restaurar_pictureBox.Location = new System.Drawing.Point(679, 4);
            this.Restaurar_pictureBox.Name = "Restaurar_pictureBox";
            this.Restaurar_pictureBox.Size = new System.Drawing.Size(21, 25);
            this.Restaurar_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Restaurar_pictureBox.TabIndex = 9;
            this.Restaurar_pictureBox.TabStop = false;
            this.Restaurar_pictureBox.Visible = false;
            this.Restaurar_pictureBox.Click += new System.EventHandler(this.Restaurar_pictureBox_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(90, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 23);
            this.label11.TabIndex = 50;
            this.label11.Text = "Registrar Clientes";
            // 
            // Minimizar_pictureBox
            // 
            this.Minimizar_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizar_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimizar_pictureBox.Image = global::ProyectoAplicadoPC.Properties.Resources.minimazar;
            this.Minimizar_pictureBox.Location = new System.Drawing.Point(652, 3);
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
            this.Maximixar_pictureBox.Location = new System.Drawing.Point(679, 4);
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
            this.Cerrar_pictureBox.Location = new System.Drawing.Point(706, 4);
            this.Cerrar_pictureBox.Name = "Cerrar_pictureBox";
            this.Cerrar_pictureBox.Size = new System.Drawing.Size(21, 25);
            this.Cerrar_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cerrar_pictureBox.TabIndex = 6;
            this.Cerrar_pictureBox.TabStop = false;
            this.Cerrar_pictureBox.Click += new System.EventHandler(this.Cerrar_pictureBox_Click);
            // 
            // ConsultaButton
            // 
            this.ConsultaButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(199)))), ((int)(((byte)(52)))));
            this.ConsultaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultaButton.Image = global::ProyectoAplicadoPC.Properties.Resources.seo_social_web_network_internet_340_icon_icons1;
            this.ConsultaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConsultaButton.Location = new System.Drawing.Point(627, 50);
            this.ConsultaButton.Margin = new System.Windows.Forms.Padding(2);
            this.ConsultaButton.Name = "ConsultaButton";
            this.ConsultaButton.Size = new System.Drawing.Size(87, 53);
            this.ConsultaButton.TabIndex = 57;
            this.ConsultaButton.Text = "Consultar";
            this.ConsultaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ConsultaButton.UseVisualStyleBackColor = true;
            this.ConsultaButton.Click += new System.EventHandler(this.ConsultaButton_Click_1);
            // 
            // cClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(730, 413);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.CerrarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.EditarButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HastaDateTimePicker);
            this.Controls.Add(this.DesdeDateTimePicker);
            this.Controls.Add(this.ConsultaButton);
            this.Controls.Add(this.CriterioTextBox);
            this.Controls.Add(this.FiltrarComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConsultaDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cClientes";
            this.Text = "cClientes";
            this.Load += new System.EventHandler(this.CClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDataGridView)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximixar_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CerrarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button EditarButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker HastaDateTimePicker;
        private System.Windows.Forms.DateTimePicker DesdeDateTimePicker;
        private System.Windows.Forms.Button ConsultaButton;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.ComboBox FiltrarComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ConsultaDataGridView;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox Restaurar_pictureBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox Minimizar_pictureBox;
        private System.Windows.Forms.PictureBox Maximixar_pictureBox;
        private System.Windows.Forms.PictureBox Cerrar_pictureBox;
    }
}