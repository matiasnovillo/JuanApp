﻿namespace JuanApp.Formularios.Herramientas
{
    partial class Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            menuItemMain = new ToolStripMenuItem();
            btnShowHideTabla = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            lblTitulo = new Label();
            DataGridViewStock = new DataGridView();
            txtBuscar = new TextBox();
            lblBarraDeBusqueda = new Label();
            btnBuscar = new Button();
            numericUpDownRegistrosPorPagina = new NumericUpDown();
            label1 = new Label();
            pnlSearchBar = new Panel();
            txtNetoTotal = new TextBox();
            lblNeto = new Label();
            label3 = new Label();
            DateTimePickerFechaFin = new DateTimePicker();
            label2 = new Label();
            DateTimePickerFechaInicio = new DateTimePicker();
            btnGenerarExcel = new Button();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRegistrosPorPagina).BeginInit();
            pnlSearchBar.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, btnShowHideTabla });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1028, 27);
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
            // btnShowHideTabla
            // 
            btnShowHideTabla.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnShowHideTabla.Image = (Image)resources.GetObject("btnShowHideTabla.Image");
            btnShowHideTabla.ImageTransparentColor = Color.Magenta;
            btnShowHideTabla.Name = "btnShowHideTabla";
            btnShowHideTabla.Size = new Size(48, 24);
            btnShowHideTabla.Text = "Tabla";
            btnShowHideTabla.Click += btnShowHideTabla_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip1.Location = new Point(0, 1029);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1028, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(92, 20);
            statusLabel.Text = "Información:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.Window;
            lblTitulo.Location = new Point(12, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(502, 81);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Consulta de stock";
            // 
            // DataGridViewStock
            // 
            DataGridViewStock.AllowUserToAddRows = false;
            DataGridViewStock.AllowUserToDeleteRows = false;
            DataGridViewStock.AllowUserToOrderColumns = true;
            DataGridViewStock.BackgroundColor = Color.Black;
            DataGridViewStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewStock.Dock = DockStyle.Bottom;
            DataGridViewStock.Location = new Point(0, 630);
            DataGridViewStock.Name = "DataGridViewStock";
            DataGridViewStock.ReadOnly = true;
            DataGridViewStock.RowHeadersWidth = 51;
            DataGridViewStock.Size = new Size(1028, 399);
            DataGridViewStock.TabIndex = 4;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(12, 226);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(532, 27);
            txtBuscar.TabIndex = 12;
            // 
            // lblBarraDeBusqueda
            // 
            lblBarraDeBusqueda.AutoSize = true;
            lblBarraDeBusqueda.Font = new Font("Segoe UI", 12F);
            lblBarraDeBusqueda.ForeColor = SystemColors.Window;
            lblBarraDeBusqueda.Location = new Point(12, 195);
            lblBarraDeBusqueda.Name = "lblBarraDeBusqueda";
            lblBarraDeBusqueda.Size = new Size(772, 28);
            lblBarraDeBusqueda.TabIndex = 11;
            lblBarraDeBusqueda.Text = "Barra de búsqueda (Busque por Nº de pesaje, nombre de producto o cód. de producto)";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Black;
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = SystemColors.Window;
            btnBuscar.Location = new Point(843, 372);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(173, 82);
            btnBuscar.TabIndex = 13;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // numericUpDownRegistrosPorPagina
            // 
            numericUpDownRegistrosPorPagina.Location = new Point(574, 155);
            numericUpDownRegistrosPorPagina.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numericUpDownRegistrosPorPagina.Minimum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDownRegistrosPorPagina.Name = "numericUpDownRegistrosPorPagina";
            numericUpDownRegistrosPorPagina.Size = new Size(150, 27);
            numericUpDownRegistrosPorPagina.TabIndex = 14;
            numericUpDownRegistrosPorPagina.Value = new decimal(new int[] { 500, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(574, 124);
            label1.Name = "label1";
            label1.Size = new Size(252, 28);
            label1.TabIndex = 15;
            label1.Text = "Cant. de registros a mostrar";
            // 
            // pnlSearchBar
            // 
            pnlSearchBar.BackColor = Color.Black;
            pnlSearchBar.Controls.Add(txtNetoTotal);
            pnlSearchBar.Controls.Add(lblNeto);
            pnlSearchBar.Controls.Add(label3);
            pnlSearchBar.Controls.Add(DateTimePickerFechaFin);
            pnlSearchBar.Controls.Add(label2);
            pnlSearchBar.Controls.Add(DateTimePickerFechaInicio);
            pnlSearchBar.Controls.Add(btnGenerarExcel);
            pnlSearchBar.Controls.Add(lblTitulo);
            pnlSearchBar.Controls.Add(label1);
            pnlSearchBar.Controls.Add(lblBarraDeBusqueda);
            pnlSearchBar.Controls.Add(numericUpDownRegistrosPorPagina);
            pnlSearchBar.Controls.Add(txtBuscar);
            pnlSearchBar.Controls.Add(btnBuscar);
            pnlSearchBar.Dock = DockStyle.Fill;
            pnlSearchBar.Location = new Point(0, 27);
            pnlSearchBar.Name = "pnlSearchBar";
            pnlSearchBar.Size = new Size(1028, 603);
            pnlSearchBar.TabIndex = 16;
            // 
            // txtNetoTotal
            // 
            txtNetoTotal.Location = new Point(12, 301);
            txtNetoTotal.Name = "txtNetoTotal";
            txtNetoTotal.ReadOnly = true;
            txtNetoTotal.Size = new Size(194, 27);
            txtNetoTotal.TabIndex = 23;
            // 
            // lblNeto
            // 
            lblNeto.AutoSize = true;
            lblNeto.Font = new Font("Segoe UI", 12F);
            lblNeto.ForeColor = SystemColors.Window;
            lblNeto.Location = new Point(12, 270);
            lblNeto.Name = "lblNeto";
            lblNeto.Size = new Size(119, 28);
            lblNeto.TabIndex = 22;
            lblNeto.Text = "Neto TOTAL:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(294, 124);
            label3.Name = "label3";
            label3.Size = new Size(120, 28);
            label3.TabIndex = 20;
            label3.Text = "Fecha de fin:";
            // 
            // DateTimePickerFechaFin
            // 
            DateTimePickerFechaFin.Location = new Point(294, 155);
            DateTimePickerFechaFin.Name = "DateTimePickerFechaFin";
            DateTimePickerFechaFin.Size = new Size(250, 27);
            DateTimePickerFechaFin.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(12, 124);
            label2.Name = "label2";
            label2.Size = new Size(145, 28);
            label2.TabIndex = 18;
            label2.Text = "Fecha de inicio:";
            // 
            // DateTimePickerFechaInicio
            // 
            DateTimePickerFechaInicio.Location = new Point(12, 155);
            DateTimePickerFechaInicio.Name = "DateTimePickerFechaInicio";
            DateTimePickerFechaInicio.Size = new Size(250, 27);
            DateTimePickerFechaInicio.TabIndex = 17;
            // 
            // btnGenerarExcel
            // 
            btnGenerarExcel.BackColor = Color.Black;
            btnGenerarExcel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerarExcel.ForeColor = SystemColors.Window;
            btnGenerarExcel.Location = new Point(12, 372);
            btnGenerarExcel.Name = "btnGenerarExcel";
            btnGenerarExcel.Size = new Size(194, 82);
            btnGenerarExcel.TabIndex = 16;
            btnGenerarExcel.Text = "GENERAR EXCEL";
            btnGenerarExcel.UseVisualStyleBackColor = false;
            btnGenerarExcel.Click += btnGenerarExcel_Click;
            // 
            // Stock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 1055);
            Controls.Add(pnlSearchBar);
            Controls.Add(DataGridViewStock);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Name = "Stock";
            Text = "Stock";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRegistrosPorPagina).EndInit();
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
        private Label lblTitulo;
        private DataGridView DataGridViewStock;
        private TextBox txtBuscar;
        private Label lblBarraDeBusqueda;
        private Button btnBuscar;
        private NumericUpDown numericUpDownRegistrosPorPagina;
        private Label label1;
        private Panel pnlSearchBar;
        private ToolStripButton btnShowHideTabla;
        private Button btnGenerarExcel;
        private Label label3;
        private DateTimePicker DateTimePickerFechaFin;
        private Label label2;
        private DateTimePicker DateTimePickerFechaInicio;
        private TextBox txtNetoTotal;
        private Label lblNeto;
    }
}