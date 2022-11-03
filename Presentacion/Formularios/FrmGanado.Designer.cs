namespace Presentacion.Formularios
{
    partial class FrmGanado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxVenta = new System.Windows.Forms.Label();
            this.TxCompra = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxPeso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BoxSexo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BoxRaza = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.ListaGanado = new System.Windows.Forms.DataGridView();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Contador = new System.Windows.Forms.Label();
            this.TxConsultar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BoxMeses = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxPesoVenta = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaGanado)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.TxPesoVenta);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.BoxMeses);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxVenta);
            this.groupBox1.Controls.Add(this.TxCompra);
            this.groupBox1.Controls.Add(this.BtnCancelar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxPeso);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.BoxSexo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BoxRaza);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BtnAgregar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1201, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar de ganados";
            // 
            // TxVenta
            // 
            this.TxVenta.AutoSize = true;
            this.TxVenta.Location = new System.Drawing.Point(894, 52);
            this.TxVenta.Name = "TxVenta";
            this.TxVenta.Size = new System.Drawing.Size(17, 18);
            this.TxVenta.TabIndex = 13;
            this.TxVenta.Text = "0";
            // 
            // TxCompra
            // 
            this.TxCompra.AutoSize = true;
            this.TxCompra.Location = new System.Drawing.Point(735, 53);
            this.TxCompra.Name = "TxCompra";
            this.TxCompra.Size = new System.Drawing.Size(17, 18);
            this.TxCompra.TabIndex = 5;
            this.TxCompra.Text = "0";
            this.TxCompra.Click += new System.EventHandler(this.TxCompra_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(1005, 43);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(90, 36);
            this.BtnCancelar.TabIndex = 12;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(878, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Precio de venta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(735, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Precio de compra:";
            // 
            // TxPeso
            // 
            this.TxPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxPeso.Location = new System.Drawing.Point(263, 50);
            this.TxPeso.Name = "TxPeso";
            this.TxPeso.Size = new System.Drawing.Size(80, 26);
            this.TxPeso.TabIndex = 5;
            this.TxPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxPeso_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Peso: (Kg)";
            // 
            // BoxSexo
            // 
            this.BoxSexo.FormattingEnabled = true;
            this.BoxSexo.Items.AddRange(new object[] {
            "M",
            "H"});
            this.BoxSexo.Location = new System.Drawing.Point(136, 50);
            this.BoxSexo.Name = "BoxSexo";
            this.BoxSexo.Size = new System.Drawing.Size(121, 26);
            this.BoxSexo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sexo:";
            // 
            // BoxRaza
            // 
            this.BoxRaza.FormattingEnabled = true;
            this.BoxRaza.Items.AddRange(new object[] {
            "Brahamman Rojo",
            "Brahamman Blanco",
            "Gyr",
            "Guzera",
            ""});
            this.BoxRaza.Location = new System.Drawing.Point(9, 50);
            this.BoxRaza.Name = "BoxRaza";
            this.BoxRaza.Size = new System.Drawing.Size(121, 26);
            this.BoxRaza.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Raza:";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(1101, 40);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(82, 36);
            this.BtnAgregar.TabIndex = 2;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // ListaGanado
            // 
            this.ListaGanado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListaGanado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListaGanado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ListaGanado.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaGanado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ListaGanado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaGanado.EnableHeadersVisualStyles = false;
            this.ListaGanado.Location = new System.Drawing.Point(6, 57);
            this.ListaGanado.Name = "ListaGanado";
            this.ListaGanado.ReadOnly = true;
            this.ListaGanado.RowHeadersWidth = 15;
            this.ListaGanado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListaGanado.Size = new System.Drawing.Size(1183, 332);
            this.ListaGanado.TabIndex = 1;
            this.ListaGanado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaGanado_CellClick);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminar.Location = new System.Drawing.Point(1113, 507);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(100, 30);
            this.BtnEliminar.TabIndex = 3;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEditar.Location = new System.Drawing.Point(1007, 507);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(100, 30);
            this.BtnEditar.TabIndex = 4;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Contador);
            this.groupBox2.Controls.Add(this.TxConsultar);
            this.groupBox2.Controls.Add(this.ListaGanado);
            this.groupBox2.Location = new System.Drawing.Point(12, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1201, 395);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de registros";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(955, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Consultar:";
            // 
            // Contador
            // 
            this.Contador.AutoSize = true;
            this.Contador.Location = new System.Drawing.Point(6, 33);
            this.Contador.Name = "Contador";
            this.Contador.Size = new System.Drawing.Size(172, 18);
            this.Contador.TabIndex = 3;
            this.Contador.Text = "Ganados registrados: 0";
            // 
            // TxConsultar
            // 
            this.TxConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxConsultar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxConsultar.Location = new System.Drawing.Point(1039, 25);
            this.TxConsultar.Name = "TxConsultar";
            this.TxConsultar.Size = new System.Drawing.Size(150, 26);
            this.TxConsultar.TabIndex = 2;
            this.TxConsultar.TextChanged += new System.EventHandler(this.TxConsultar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Recuperacion(Meses)";
            // 
            // BoxMeses
            // 
            this.BoxMeses.FormattingEnabled = true;
            this.BoxMeses.Items.AddRange(new object[] {
            "2",
            "3",
            "4"});
            this.BoxMeses.Location = new System.Drawing.Point(368, 49);
            this.BoxMeses.Name = "BoxMeses";
            this.BoxMeses.Size = new System.Drawing.Size(121, 26);
            this.BoxMeses.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(553, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Peso venta(Kg)";
            // 
            // TxPesoVenta
            // 
            this.TxPesoVenta.AutoSize = true;
            this.TxPesoVenta.Location = new System.Drawing.Point(562, 56);
            this.TxPesoVenta.Name = "TxPesoVenta";
            this.TxPesoVenta.Size = new System.Drawing.Size(17, 18);
            this.TxPesoVenta.TabIndex = 17;
            this.TxPesoVenta.Text = "0";
            // 
            // FrmGanado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 547);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(890, 586);
            this.Name = "FrmGanado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGanado";
            this.Load += new System.EventHandler(this.FrmGanado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaGanado)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.DataGridView ListaGanado;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Contador;
        private System.Windows.Forms.TextBox TxConsultar;
        private System.Windows.Forms.ComboBox BoxRaza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox BoxSexo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxPeso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label TxVenta;
        private System.Windows.Forms.Label TxCompra;
        private System.Windows.Forms.ComboBox BoxMeses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TxPesoVenta;
        private System.Windows.Forms.Label label8;
    }
}