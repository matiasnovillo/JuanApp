﻿namespace JuanApp.Formularios.Salida
{
    partial class ConsultaSalida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaSalida));
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            menuItemMain = new ToolStripMenuItem();
            btnHideShowTable = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            DataGridViewSalida = new DataGridView();
            lblTitulo = new Label();
            btnBuscar = new Button();
            btnGenerarPDF = new Button();
            txtBuscar = new TextBox();
            lblBarraDeBusqueda = new Label();
            dateTimePickerFechaFin = new DateTimePicker();
            lblFechaFin = new Label();
            dateTimePickerFechaInicio = new DateTimePicker();
            lblFechaInicio = new Label();
            btnGenerarExcel = new Button();
            btnAgregar = new Button();
            label1 = new Label();
            lblKilosTotales = new Label();
            txtKilosRealesTotal = new TextBox();
            txtPrecioTotal = new TextBox();
            lblPrecioUnidadTotal = new Label();
            txtSubtotalTotal = new TextBox();
            lblSubtotalTotal = new Label();
            numericUpDownRegistros = new NumericUpDown();
            label2 = new Label();
            pnlSearchBar = new Panel();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewSalida).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRegistros).BeginInit();
            pnlSearchBar.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, btnHideShowTable });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { menuItemMain });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(34, 24);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // menuItemMain
            // 
            menuItemMain.Name = "menuItemMain";
            menuItemMain.Size = new Size(189, 26);
            menuItemMain.Text = "Volver al inicio";
            menuItemMain.Click += menuItemMain_Click;
            // 
            // btnHideShowTable
            // 
            btnHideShowTable.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnHideShowTable.Image = (Image)resources.GetObject("btnHideShowTable.Image");
            btnHideShowTable.ImageTransparentColor = Color.Magenta;
            btnHideShowTable.Name = "btnHideShowTable";
            btnHideShowTable.Size = new Size(48, 24);
            btnHideShowTable.Text = "Tabla";
            btnHideShowTable.Click += btnHideShowTable_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip1.Location = new Point(0, 853);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(92, 20);
            statusLabel.Text = "Información:";
            // 
            // DataGridViewSalida
            // 
            DataGridViewSalida.AllowUserToAddRows = false;
            DataGridViewSalida.AllowUserToDeleteRows = false;
            DataGridViewSalida.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewSalida.Dock = DockStyle.Fill;
            DataGridViewSalida.Location = new Point(0, 27);
            DataGridViewSalida.Name = "DataGridViewSalida";
            DataGridViewSalida.ReadOnly = true;
            DataGridViewSalida.RowHeadersWidth = 51;
            DataGridViewSalida.Size = new Size(800, 826);
            DataGridViewSalida.TabIndex = 2;
            DataGridViewSalida.CellContentClick += DataGridViewSalida_CellContentClick;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(211, 31);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Consulta de salidas";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(700, 360);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(97, 50);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnGenerarPDF
            // 
            btnGenerarPDF.Location = new Point(3, 360);
            btnGenerarPDF.Name = "btnGenerarPDF";
            btnGenerarPDF.Size = new Size(118, 50);
            btnGenerarPDF.TabIndex = 5;
            btnGenerarPDF.Text = "Generar PDF";
            btnGenerarPDF.UseVisualStyleBackColor = true;
            btnGenerarPDF.Click += btnGenerarPDF_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(12, 176);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(532, 27);
            txtBuscar.TabIndex = 16;
            // 
            // lblBarraDeBusqueda
            // 
            lblBarraDeBusqueda.AutoSize = true;
            lblBarraDeBusqueda.Location = new Point(12, 133);
            lblBarraDeBusqueda.Name = "lblBarraDeBusqueda";
            lblBarraDeBusqueda.Size = new Size(447, 20);
            lblBarraDeBusqueda.TabIndex = 15;
            lblBarraDeBusqueda.Text = "Barra de búsqueda (Busque por cód. de cliente, cód. de producto, ";
            // 
            // dateTimePickerFechaFin
            // 
            dateTimePickerFechaFin.Location = new Point(294, 78);
            dateTimePickerFechaFin.Name = "dateTimePickerFechaFin";
            dateTimePickerFechaFin.Size = new Size(250, 27);
            dateTimePickerFechaFin.TabIndex = 14;
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.Location = new Point(294, 55);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(89, 20);
            lblFechaFin.TabIndex = 13;
            lblFechaFin.Text = "Fecha de fin";
            // 
            // dateTimePickerFechaInicio
            // 
            dateTimePickerFechaInicio.Location = new Point(12, 78);
            dateTimePickerFechaInicio.Name = "dateTimePickerFechaInicio";
            dateTimePickerFechaInicio.Size = new Size(250, 27);
            dateTimePickerFechaInicio.TabIndex = 12;
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Location = new Point(12, 55);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(108, 20);
            lblFechaInicio.TabIndex = 11;
            lblFechaInicio.Text = "Fecha de inicio";
            // 
            // btnGenerarExcel
            // 
            btnGenerarExcel.Location = new Point(127, 360);
            btnGenerarExcel.Name = "btnGenerarExcel";
            btnGenerarExcel.Size = new Size(118, 50);
            btnGenerarExcel.TabIndex = 17;
            btnGenerarExcel.Text = "Generar Excel";
            btnGenerarExcel.UseVisualStyleBackColor = true;
            btnGenerarExcel.Click += btnGenerarExcel_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(597, 360);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(97, 50);
            btnAgregar.TabIndex = 18;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 153);
            label1.Name = "label1";
            label1.Size = new Size(290, 20);
            label1.TabIndex = 19;
            label1.Text = "nombre de cliente o nombre de producto)";
            // 
            // lblKilosTotales
            // 
            lblKilosTotales.AutoSize = true;
            lblKilosTotales.Location = new Point(12, 206);
            lblKilosTotales.Name = "lblKilosTotales";
            lblKilosTotales.Size = new Size(148, 20);
            lblKilosTotales.TabIndex = 20;
            lblKilosTotales.Text = "Kilos reales TOTALES:";
            // 
            // txtKilosRealesTotal
            // 
            txtKilosRealesTotal.Location = new Point(12, 229);
            txtKilosRealesTotal.Name = "txtKilosRealesTotal";
            txtKilosRealesTotal.ReadOnly = true;
            txtKilosRealesTotal.Size = new Size(202, 27);
            txtKilosRealesTotal.TabIndex = 21;
            // 
            // txtPrecioTotal
            // 
            txtPrecioTotal.Location = new Point(225, 229);
            txtPrecioTotal.Name = "txtPrecioTotal";
            txtPrecioTotal.ReadOnly = true;
            txtPrecioTotal.Size = new Size(202, 27);
            txtPrecioTotal.TabIndex = 23;
            // 
            // lblPrecioUnidadTotal
            // 
            lblPrecioUnidadTotal.AutoSize = true;
            lblPrecioUnidadTotal.Location = new Point(225, 206);
            lblPrecioUnidadTotal.Name = "lblPrecioUnidadTotal";
            lblPrecioUnidadTotal.Size = new Size(98, 20);
            lblPrecioUnidadTotal.TabIndex = 22;
            lblPrecioUnidadTotal.Text = "Precio TOTAL:";
            // 
            // txtSubtotalTotal
            // 
            txtSubtotalTotal.Location = new Point(435, 229);
            txtSubtotalTotal.Name = "txtSubtotalTotal";
            txtSubtotalTotal.ReadOnly = true;
            txtSubtotalTotal.Size = new Size(202, 27);
            txtSubtotalTotal.TabIndex = 25;
            // 
            // lblSubtotalTotal
            // 
            lblSubtotalTotal.AutoSize = true;
            lblSubtotalTotal.Location = new Point(435, 206);
            lblSubtotalTotal.Name = "lblSubtotalTotal";
            lblSubtotalTotal.Size = new Size(113, 20);
            lblSubtotalTotal.TabIndex = 24;
            lblSubtotalTotal.Text = "Subtotal TOTAL:";
            // 
            // numericUpDownRegistros
            // 
            numericUpDownRegistros.Location = new Point(550, 77);
            numericUpDownRegistros.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numericUpDownRegistros.Minimum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDownRegistros.Name = "numericUpDownRegistros";
            numericUpDownRegistros.Size = new Size(114, 27);
            numericUpDownRegistros.TabIndex = 27;
            numericUpDownRegistros.Value = new decimal(new int[] { 500, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(550, 54);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 28;
            label2.Text = "Registros";
            // 
            // pnlSearchBar
            // 
            pnlSearchBar.Controls.Add(lblTitulo);
            pnlSearchBar.Controls.Add(label2);
            pnlSearchBar.Controls.Add(btnBuscar);
            pnlSearchBar.Controls.Add(numericUpDownRegistros);
            pnlSearchBar.Controls.Add(btnGenerarPDF);
            pnlSearchBar.Controls.Add(txtSubtotalTotal);
            pnlSearchBar.Controls.Add(lblFechaInicio);
            pnlSearchBar.Controls.Add(lblSubtotalTotal);
            pnlSearchBar.Controls.Add(dateTimePickerFechaInicio);
            pnlSearchBar.Controls.Add(txtPrecioTotal);
            pnlSearchBar.Controls.Add(lblFechaFin);
            pnlSearchBar.Controls.Add(lblPrecioUnidadTotal);
            pnlSearchBar.Controls.Add(dateTimePickerFechaFin);
            pnlSearchBar.Controls.Add(txtKilosRealesTotal);
            pnlSearchBar.Controls.Add(lblBarraDeBusqueda);
            pnlSearchBar.Controls.Add(lblKilosTotales);
            pnlSearchBar.Controls.Add(txtBuscar);
            pnlSearchBar.Controls.Add(label1);
            pnlSearchBar.Controls.Add(btnGenerarExcel);
            pnlSearchBar.Controls.Add(btnAgregar);
            pnlSearchBar.Dock = DockStyle.Top;
            pnlSearchBar.Location = new Point(0, 27);
            pnlSearchBar.Name = "pnlSearchBar";
            pnlSearchBar.Size = new Size(800, 419);
            pnlSearchBar.TabIndex = 29;
            // 
            // ConsultaSalida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 879);
            Controls.Add(pnlSearchBar);
            Controls.Add(DataGridViewSalida);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Name = "ConsultaSalida";
            Text = "Consulta de salidas - Clientes";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewSalida).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRegistros).EndInit();
            pnlSearchBar.ResumeLayout(false);
            pnlSearchBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem menuItemMain;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabel;
        private DataGridView DataGridViewSalida;
        private Label lblTitulo;
        private Button btnBuscar;
        private Button btnGenerarPDF;
        private TextBox txtBuscar;
        private Label lblBarraDeBusqueda;
        private DateTimePicker dateTimePickerFechaFin;
        private Label lblFechaFin;
        private DateTimePicker dateTimePickerFechaInicio;
        private Label lblFechaInicio;
        private Button btnGenerarExcel;
        private Button btnAgregar;
        private Label label1;
        private Label lblKilosTotales;
        private TextBox txtKilosRealesTotal;
        private TextBox txtPrecioTotal;
        private Label lblPrecioUnidadTotal;
        private TextBox txtSubtotalTotal;
        private Label lblSubtotalTotal;
        private NumericUpDown numericUpDownRegistros;
        private Label label2;
        private Panel pnlSearchBar;
        private ToolStripButton btnHideShowTable;
    }
}