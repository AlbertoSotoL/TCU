﻿namespace TCU_WFA
{
    partial class FormRegistroVacas
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
            this.botonVolver = new System.Windows.Forms.Button();
            this.botonAgregarVaca = new System.Windows.Forms.Button();
            this.botonBuscarVaca = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(713, 415);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(75, 23);
            this.botonVolver.TabIndex = 0;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // botonAgregarVaca
            // 
            this.botonAgregarVaca.Location = new System.Drawing.Point(12, 12);
            this.botonAgregarVaca.Name = "botonAgregarVaca";
            this.botonAgregarVaca.Size = new System.Drawing.Size(163, 27);
            this.botonAgregarVaca.TabIndex = 1;
            this.botonAgregarVaca.Text = "Agregar vaca";
            this.botonAgregarVaca.UseVisualStyleBackColor = true;
            // 
            // botonBuscarVaca
            // 
            this.botonBuscarVaca.Location = new System.Drawing.Point(705, 12);
            this.botonBuscarVaca.Name = "botonBuscarVaca";
            this.botonBuscarVaca.Size = new System.Drawing.Size(83, 27);
            this.botonBuscarVaca.TabIndex = 2;
            this.botonBuscarVaca.Text = "Buscar vaca";
            this.botonBuscarVaca.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(541, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 20);
            this.textBox1.TabIndex = 3;
            // 
            // FormRegistroVacas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.botonBuscarVaca);
            this.Controls.Add(this.botonAgregarVaca);
            this.Controls.Add(this.botonVolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormRegistroVacas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro vacas";
            this.Load += new System.EventHandler(this.FormRegistroVacas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button botonAgregarVaca;
        private System.Windows.Forms.Button botonBuscarVaca;
        private System.Windows.Forms.TextBox textBox1;
    }
}