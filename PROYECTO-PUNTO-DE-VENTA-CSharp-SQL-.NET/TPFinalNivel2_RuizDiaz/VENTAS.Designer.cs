namespace TPFinalNivel2_RuizDiaz
{
    partial class Venta_Por_Venta
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
            this.DgvVentas = new System.Windows.Forms.DataGridView();
            this.DtpFiltro = new System.Windows.Forms.DateTimePicker();
            this.BtnFiltrarFecha = new System.Windows.Forms.Button();
            this.BtnBorrarVenta = new System.Windows.Forms.Button();
            this.BtnVolverVenta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.DtpHoraFin = new System.Windows.Forms.DateTimePicker();
            this.FiltroRango = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DGVVentas_Agrupadas = new System.Windows.Forms.DataGridView();
            this.Buscar_Articulo = new System.Windows.Forms.Button();
            this.lblRecaudacionTotal = new System.Windows.Forms.Label();
            this.BtnFrmFiados = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblFiadosHoy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVentas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVentas_Agrupadas)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvVentas
            // 
            this.DgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVentas.Location = new System.Drawing.Point(30, 352);
            this.DgvVentas.Name = "DgvVentas";
            this.DgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvVentas.Size = new System.Drawing.Size(639, 365);
            this.DgvVentas.TabIndex = 0;
            this.DgvVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVentas_CellClick);
            this.DgvVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVentas_CellContentClick);
            // 
            // DtpFiltro
            // 
            this.DtpFiltro.Location = new System.Drawing.Point(16, 46);
            this.DtpFiltro.Name = "DtpFiltro";
            this.DtpFiltro.Size = new System.Drawing.Size(233, 20);
            this.DtpFiltro.TabIndex = 2;
            // 
            // BtnFiltrarFecha
            // 
            this.BtnFiltrarFecha.Location = new System.Drawing.Point(287, 43);
            this.BtnFiltrarFecha.Name = "BtnFiltrarFecha";
            this.BtnFiltrarFecha.Size = new System.Drawing.Size(87, 23);
            this.BtnFiltrarFecha.TabIndex = 3;
            this.BtnFiltrarFecha.Text = "FILTRAR";
            this.BtnFiltrarFecha.UseVisualStyleBackColor = true;
            this.BtnFiltrarFecha.Click += new System.EventHandler(this.BtnFiltrarFecha_Click);
            // 
            // BtnBorrarVenta
            // 
            this.BtnBorrarVenta.Location = new System.Drawing.Point(740, 306);
            this.BtnBorrarVenta.Name = "BtnBorrarVenta";
            this.BtnBorrarVenta.Size = new System.Drawing.Size(87, 23);
            this.BtnBorrarVenta.TabIndex = 6;
            this.BtnBorrarVenta.Text = "BORRAR";
            this.BtnBorrarVenta.UseVisualStyleBackColor = true;
            this.BtnBorrarVenta.Click += new System.EventHandler(this.BtnBorrarVenta_Click);
            // 
            // BtnVolverVenta
            // 
            this.BtnVolverVenta.Location = new System.Drawing.Point(605, 306);
            this.BtnVolverVenta.Name = "BtnVolverVenta";
            this.BtnVolverVenta.Size = new System.Drawing.Size(87, 23);
            this.BtnVolverVenta.TabIndex = 8;
            this.BtnVolverVenta.Text = "VOLVER";
            this.BtnVolverVenta.UseVisualStyleBackColor = true;
            this.BtnVolverVenta.Click += new System.EventHandler(this.BtnVolverVenta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(597, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "VENTAS UNITARIAS";
            // 
            // DtpHoraInicio
            // 
            this.DtpHoraInicio.CustomFormat = "HH:mm";
            this.DtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpHoraInicio.Location = new System.Drawing.Point(76, 28);
            this.DtpHoraInicio.Name = "DtpHoraInicio";
            this.DtpHoraInicio.ShowUpDown = true;
            this.DtpHoraInicio.Size = new System.Drawing.Size(233, 20);
            this.DtpHoraInicio.TabIndex = 13;
            this.DtpHoraInicio.ValueChanged += new System.EventHandler(this.DtpHoraInicio_ValueChanged);
            // 
            // DtpHoraFin
            // 
            this.DtpHoraFin.CustomFormat = "HH:mm";
            this.DtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpHoraFin.Location = new System.Drawing.Point(422, 28);
            this.DtpHoraFin.Name = "DtpHoraFin";
            this.DtpHoraFin.ShowUpDown = true;
            this.DtpHoraFin.Size = new System.Drawing.Size(233, 20);
            this.DtpHoraFin.TabIndex = 14;
            // 
            // FiltroRango
            // 
            this.FiltroRango.Location = new System.Drawing.Point(254, 69);
            this.FiltroRango.Name = "FiltroRango";
            this.FiltroRango.Size = new System.Drawing.Size(149, 23);
            this.FiltroRango.TabIndex = 15;
            this.FiltroRango.Text = "FILTRAR RANGO";
            this.FiltroRango.UseVisualStyleBackColor = true;
            this.FiltroRango.Click += new System.EventHandler(this.FiltroRango_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "DESDE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "HASTA";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.DtpFiltro);
            this.groupBox1.Controls.Add(this.BtnFiltrarFecha);
            this.groupBox1.Location = new System.Drawing.Point(363, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 90);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FECHA";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.FiltroRango);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.DtpHoraFin);
            this.groupBox2.Controls.Add(this.DtpHoraInicio);
            this.groupBox2.Location = new System.Drawing.Point(363, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(694, 117);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RANGO HORARIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(661, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "HS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "HS";
            // 
            // DGVVentas_Agrupadas
            // 
            this.DGVVentas_Agrupadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVVentas_Agrupadas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVVentas_Agrupadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVVentas_Agrupadas.Location = new System.Drawing.Point(779, 352);
            this.DGVVentas_Agrupadas.Name = "DGVVentas_Agrupadas";
            this.DGVVentas_Agrupadas.Size = new System.Drawing.Size(639, 365);
            this.DGVVentas_Agrupadas.TabIndex = 22;
            // 
            // Buscar_Articulo
            // 
            this.Buscar_Articulo.Location = new System.Drawing.Point(1133, 51);
            this.Buscar_Articulo.Name = "Buscar_Articulo";
            this.Buscar_Articulo.Size = new System.Drawing.Size(222, 39);
            this.Buscar_Articulo.TabIndex = 23;
            this.Buscar_Articulo.Text = "BUSCAR POR ARTICULO";
            this.Buscar_Articulo.UseVisualStyleBackColor = true;
            this.Buscar_Articulo.Click += new System.EventHandler(this.Buscar_Articulo_Click);
            // 
            // lblRecaudacionTotal
            // 
            this.lblRecaudacionTotal.AutoSize = true;
            this.lblRecaudacionTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecaudacionTotal.Location = new System.Drawing.Point(27, 306);
            this.lblRecaudacionTotal.Name = "lblRecaudacionTotal";
            this.lblRecaudacionTotal.Size = new System.Drawing.Size(0, 20);
            this.lblRecaudacionTotal.TabIndex = 25;
            // 
            // BtnFrmFiados
            // 
            this.BtnFrmFiados.Location = new System.Drawing.Point(1133, 145);
            this.BtnFrmFiados.Name = "BtnFrmFiados";
            this.BtnFrmFiados.Size = new System.Drawing.Size(219, 39);
            this.BtnFrmFiados.TabIndex = 26;
            this.BtnFrmFiados.Text = "LISTA FIADOS";
            this.BtnFrmFiados.UseVisualStyleBackColor = true;
            this.BtnFrmFiados.Click += new System.EventHandler(this.BtnFrmFiados_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1133, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 39);
            this.button1.TabIndex = 27;
            this.button1.Text = "INFORME DE VENTAS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblFiadosHoy
            // 
            this.lblFiadosHoy.AutoSize = true;
            this.lblFiadosHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiadosHoy.Location = new System.Drawing.Point(27, 280);
            this.lblFiadosHoy.Name = "lblFiadosHoy";
            this.lblFiadosHoy.Size = new System.Drawing.Size(0, 20);
            this.lblFiadosHoy.TabIndex = 28;
            // 
            // Venta_Por_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.lblFiadosHoy);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnFrmFiados);
            this.Controls.Add(this.lblRecaudacionTotal);
            this.Controls.Add(this.Buscar_Articulo);
            this.Controls.Add(this.DGVVentas_Agrupadas);
            this.Controls.Add(this.BtnVolverVenta);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnBorrarVenta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvVentas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Venta_Por_Venta";
            this.Text = "TOTAL VENTA POR VENTA";
            this.Load += new System.EventHandler(this.VENTAS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvVentas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVentas_Agrupadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvVentas;
        private System.Windows.Forms.DateTimePicker DtpFiltro;
        private System.Windows.Forms.Button BtnFiltrarFecha;
        private System.Windows.Forms.Button BtnBorrarVenta;
        private System.Windows.Forms.Button BtnVolverVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpHoraInicio;
        private System.Windows.Forms.DateTimePicker DtpHoraFin;
        private System.Windows.Forms.Button FiltroRango;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DGVVentas_Agrupadas;
        private System.Windows.Forms.Button Buscar_Articulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRecaudacionTotal;
        private System.Windows.Forms.Button BtnFrmFiados;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblFiadosHoy;
    }
}