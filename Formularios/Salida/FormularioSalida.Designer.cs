﻿namespace JuanApp.Formularios.Salida
{
    partial class FormularioSalida
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioSalida));
            lblTitulo = new Label();
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            dropDownButton = new ToolStripDropDownButton();
            menuItemMain = new ToolStripMenuItem();
            btnGuardar = new Button();
            lblCodigoDeCliente = new Label();
            txtCodigoDeCliente = new TextBox();
            txtNombreDeCliente = new TextBox();
            lblNombreDeCliente = new Label();
            txtCodigoDeProducto = new TextBox();
            lblCodigoDeProducto = new Label();
            txtNombreProducto = new TextBox();
            lblNombreProducto = new Label();
            lblKilosTotales = new Label();
            textBox1 = new TextBox();
            lblCodigoDeBarraDeProducto = new Label();
            numericUpDownKilosTotales = new NumericUpDown();
            lblPrecio = new Label();
            numericUpDownPrecio = new NumericUpDown();
            lblSubtotal = new Label();
            numericUpDownSubtotal = new NumericUpDown();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKilosTotales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSubtotal).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 27);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(232, 31);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Formulario de salidas";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip1.Location = new Point(0, 421);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(546, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(92, 20);
            statusLabel.Text = "Información:";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { dropDownButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(546, 27);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // dropDownButton
            // 
            dropDownButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            dropDownButton.DropDownItems.AddRange(new ToolStripItem[] { menuItemMain });
            dropDownButton.Image = (Image)resources.GetObject("dropDownButton.Image");
            dropDownButton.ImageTransparentColor = Color.Magenta;
            dropDownButton.Name = "dropDownButton";
            dropDownButton.Size = new Size(34, 24);
            dropDownButton.Text = "toolStripDropDownButton1";
            // 
            // menuItemMain
            // 
            menuItemMain.Name = "menuItemMain";
            menuItemMain.Size = new Size(189, 26);
            menuItemMain.Text = "Volver al inicio";
            menuItemMain.Click += menuItemMain_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(408, 368);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(126, 43);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // lblCodigoDeCliente
            // 
            lblCodigoDeCliente.AutoSize = true;
            lblCodigoDeCliente.Location = new Point(12, 70);
            lblCodigoDeCliente.Name = "lblCodigoDeCliente";
            lblCodigoDeCliente.Size = new Size(127, 20);
            lblCodigoDeCliente.TabIndex = 6;
            lblCodigoDeCliente.Text = "Código de cliente";
            // 
            // txtCodigoDeCliente
            // 
            txtCodigoDeCliente.Location = new Point(12, 93);
            txtCodigoDeCliente.Name = "txtCodigoDeCliente";
            txtCodigoDeCliente.Size = new Size(232, 27);
            txtCodigoDeCliente.TabIndex = 12;
            // 
            // txtNombreDeCliente
            // 
            txtNombreDeCliente.Location = new Point(12, 162);
            txtNombreDeCliente.Name = "txtNombreDeCliente";
            txtNombreDeCliente.Size = new Size(232, 27);
            txtNombreDeCliente.TabIndex = 14;
            // 
            // lblNombreDeCliente
            // 
            lblNombreDeCliente.AutoSize = true;
            lblNombreDeCliente.Location = new Point(12, 139);
            lblNombreDeCliente.Name = "lblNombreDeCliente";
            lblNombreDeCliente.Size = new Size(133, 20);
            lblNombreDeCliente.TabIndex = 13;
            lblNombreDeCliente.Text = "Nombre de cliente";
            // 
            // txtCodigoDeProducto
            // 
            txtCodigoDeProducto.Location = new Point(12, 299);
            txtCodigoDeProducto.Name = "txtCodigoDeProducto";
            txtCodigoDeProducto.Size = new Size(232, 27);
            txtCodigoDeProducto.TabIndex = 16;
            // 
            // lblCodigoDeProducto
            // 
            lblCodigoDeProducto.AutoSize = true;
            lblCodigoDeProducto.Location = new Point(12, 276);
            lblCodigoDeProducto.Name = "lblCodigoDeProducto";
            lblCodigoDeProducto.Size = new Size(144, 20);
            lblCodigoDeProducto.TabIndex = 15;
            lblCodigoDeProducto.Text = "Código de producto";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(12, 371);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(232, 27);
            txtNombreProducto.TabIndex = 18;
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Location = new Point(12, 348);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(150, 20);
            lblNombreProducto.TabIndex = 17;
            lblNombreProducto.Text = "Nombre de producto";
            // 
            // lblKilosTotales
            // 
            lblKilosTotales.AutoSize = true;
            lblKilosTotales.Location = new Point(284, 70);
            lblKilosTotales.Name = "lblKilosTotales";
            lblKilosTotales.Size = new Size(90, 20);
            lblKilosTotales.TabIndex = 19;
            lblKilosTotales.Text = "Kilos totales";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 232);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 27);
            textBox1.TabIndex = 21;
            // 
            // lblCodigoDeBarraDeProducto
            // 
            lblCodigoDeBarraDeProducto.AutoSize = true;
            lblCodigoDeBarraDeProducto.Location = new Point(12, 209);
            lblCodigoDeBarraDeProducto.Name = "lblCodigoDeBarraDeProducto";
            lblCodigoDeBarraDeProducto.Size = new Size(208, 20);
            lblCodigoDeBarraDeProducto.TabIndex = 20;
            lblCodigoDeBarraDeProducto.Text = "Código de barra del producto";
            // 
            // numericUpDownKilosTotales
            // 
            numericUpDownKilosTotales.Location = new Point(284, 94);
            numericUpDownKilosTotales.Name = "numericUpDownKilosTotales";
            numericUpDownKilosTotales.Size = new Size(150, 27);
            numericUpDownKilosTotales.TabIndex = 22;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(284, 139);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(50, 20);
            lblPrecio.TabIndex = 23;
            lblPrecio.Text = "Precio";
            // 
            // numericUpDownPrecio
            // 
            numericUpDownPrecio.Location = new Point(284, 163);
            numericUpDownPrecio.Name = "numericUpDownPrecio";
            numericUpDownPrecio.Size = new Size(150, 27);
            numericUpDownPrecio.TabIndex = 24;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(284, 209);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(65, 20);
            lblSubtotal.TabIndex = 25;
            lblSubtotal.Text = "Subtotal";
            // 
            // numericUpDownSubtotal
            // 
            numericUpDownSubtotal.Location = new Point(284, 233);
            numericUpDownSubtotal.Name = "numericUpDownSubtotal";
            numericUpDownSubtotal.Size = new Size(150, 27);
            numericUpDownSubtotal.TabIndex = 26;
            // 
            // FormularioSalida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 447);
            Controls.Add(numericUpDownSubtotal);
            Controls.Add(lblSubtotal);
            Controls.Add(numericUpDownPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(numericUpDownKilosTotales);
            Controls.Add(textBox1);
            Controls.Add(lblCodigoDeBarraDeProducto);
            Controls.Add(lblKilosTotales);
            Controls.Add(txtNombreProducto);
            Controls.Add(lblNombreProducto);
            Controls.Add(txtCodigoDeProducto);
            Controls.Add(lblCodigoDeProducto);
            Controls.Add(txtNombreDeCliente);
            Controls.Add(lblNombreDeCliente);
            Controls.Add(txtCodigoDeCliente);
            Controls.Add(btnGuardar);
            Controls.Add(lblCodigoDeCliente);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(lblTitulo);
            Name = "FormularioSalida";
            Text = "Formulario de salidas";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKilosTotales).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSubtotal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabel;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton dropDownButton;
        private Button btnGuardar;
        private ToolStripMenuItem menuItemMain;
        private Label lblCodigoDeCliente;
        private TextBox txtCodigoDeCliente;
        private TextBox txtNombreDeCliente;
        private Label lblNombreDeCliente;
        private TextBox txtCodigoDeProducto;
        private Label lblCodigoDeProducto;
        private TextBox txtNombreProducto;
        private Label lblNombreProducto;
        private Label lblKilosTotales;
        private TextBox textBox1;
        private Label lblCodigoDeBarraDeProducto;
        private NumericUpDown numericUpDownKilosTotales;
        private Label lblPrecio;
        private NumericUpDown numericUpDownPrecio;
        private Label lblSubtotal;
        private NumericUpDown numericUpDownSubtotal;
    }
}
