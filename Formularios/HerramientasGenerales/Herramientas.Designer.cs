﻿namespace JuanApp.Formularios.HerramientasGenerales
{
    partial class Herramientas
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
            btnResetearStock = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnResetearStock
            // 
            btnResetearStock.BackColor = Color.Black;
            btnResetearStock.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResetearStock.ForeColor = SystemColors.Window;
            btnResetearStock.Location = new Point(41, 131);
            btnResetearStock.Name = "btnResetearStock";
            btnResetearStock.Size = new Size(161, 77);
            btnResetearStock.TabIndex = 4;
            btnResetearStock.Text = "RESETEAR STOCK";
            btnResetearStock.UseVisualStyleBackColor = false;
            btnResetearStock.Click += btnResetearStock_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(41, 75);
            label3.Name = "label3";
            label3.Size = new Size(770, 28);
            label3.TabIndex = 13;
            label3.Text = "Usar estas herramientas implica validaciones. Haga los backups correspondientes antes.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(41, 25);
            label4.Name = "label4";
            label4.Size = new Size(651, 50);
            label4.TabIndex = 12;
            label4.Text = "OPERACIONES CRÍTICAS DEL SISTEMA";
            // 
            // Herramientas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(848, 350);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(btnResetearStock);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Herramientas";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Herramientas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnResetearStock;
        private Label label3;
        private Label label4;
    }
}