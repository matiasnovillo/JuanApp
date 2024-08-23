﻿namespace JuanApp.Formularios.Herramientas.Cliente
{
    partial class ConsultaCliente
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
            toolStrip1 = new ToolStrip();
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            DataGridViewCliente = new DataGridView();
            lblTitulo = new Label();
            btnBuscar = new Button();
            lblBarraDeBusqueda = new Label();
            txtBuscar = new TextBox();
            btnAgregar = new Button();
            pnlSearchBar = new Panel();
            btnCargarExcel = new Button();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewCliente).BeginInit();
            pnlSearchBar.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1924, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip1.Location = new Point(0, 1021);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1924, 34);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            statusLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(132, 28);
            statusLabel.Text = "Información:";
            // 
            // DataGridViewCliente
            // 
            DataGridViewCliente.AllowUserToAddRows = false;
            DataGridViewCliente.AllowUserToDeleteRows = false;
            DataGridViewCliente.AllowUserToOrderColumns = true;
            DataGridViewCliente.BackgroundColor = Color.Black;
            DataGridViewCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCliente.Dock = DockStyle.Bottom;
            DataGridViewCliente.Location = new Point(0, 322);
            DataGridViewCliente.Name = "DataGridViewCliente";
            DataGridViewCliente.ReadOnly = true;
            DataGridViewCliente.RowHeadersWidth = 51;
            DataGridViewCliente.Size = new Size(1924, 699);
            DataGridViewCliente.TabIndex = 2;
            DataGridViewCliente.CellClick += DataGridViewCliente_CellClick;
            DataGridViewCliente.CellContentClick += DataGridViewCliente_CellContentClick;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.Window;
            lblTitulo.Location = new Point(12, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(563, 81);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Consulta de clientes";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Black;
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = SystemColors.Window;
            btnBuscar.Location = new Point(1746, 135);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(166, 80);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblBarraDeBusqueda
            // 
            lblBarraDeBusqueda.AutoSize = true;
            lblBarraDeBusqueda.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBarraDeBusqueda.ForeColor = SystemColors.Window;
            lblBarraDeBusqueda.Location = new Point(12, 150);
            lblBarraDeBusqueda.Name = "lblBarraDeBusqueda";
            lblBarraDeBusqueda.Size = new Size(175, 28);
            lblBarraDeBusqueda.TabIndex = 9;
            lblBarraDeBusqueda.Text = "Barra de búsqueda";
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(12, 181);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(532, 34);
            txtBuscar.TabIndex = 10;
            txtBuscar.KeyPress += txtBuscar_KeyPress;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Black;
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = SystemColors.Window;
            btnAgregar.Location = new Point(1557, 132);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(166, 78);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // pnlSearchBar
            // 
            pnlSearchBar.BackColor = Color.Black;
            pnlSearchBar.Controls.Add(btnCargarExcel);
            pnlSearchBar.Controls.Add(lblTitulo);
            pnlSearchBar.Controls.Add(btnAgregar);
            pnlSearchBar.Controls.Add(btnBuscar);
            pnlSearchBar.Controls.Add(txtBuscar);
            pnlSearchBar.Controls.Add(lblBarraDeBusqueda);
            pnlSearchBar.Dock = DockStyle.Fill;
            pnlSearchBar.Location = new Point(0, 25);
            pnlSearchBar.Name = "pnlSearchBar";
            pnlSearchBar.Size = new Size(1924, 297);
            pnlSearchBar.TabIndex = 12;
            // 
            // btnCargarExcel
            // 
            btnCargarExcel.BackColor = Color.Black;
            btnCargarExcel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargarExcel.ForeColor = SystemColors.Window;
            btnCargarExcel.Location = new Point(1365, 132);
            btnCargarExcel.Name = "btnCargarExcel";
            btnCargarExcel.Size = new Size(166, 78);
            btnCargarExcel.TabIndex = 12;
            btnCargarExcel.Text = "CARGAR EXCEL";
            btnCargarExcel.UseVisualStyleBackColor = false;
            btnCargarExcel.Click += btnCargarExcel_Click;
            // 
            // ConsultaCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(pnlSearchBar);
            Controls.Add(DataGridViewCliente);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Name = "ConsultaCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta de Clientes";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewCliente).EndInit();
            pnlSearchBar.ResumeLayout(false);
            pnlSearchBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabel;
        private DataGridView DataGridViewCliente;
        private Label lblTitulo;
        private Button btnBuscar;
        private Label lblBarraDeBusqueda;
        private TextBox txtBuscar;
        private Button btnAgregar;
        private Panel pnlSearchBar;
        private Button btnCargarExcel;
    }
}