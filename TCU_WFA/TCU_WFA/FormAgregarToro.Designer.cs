﻿namespace TCU_WFA
{
    partial class FormAgregarToro
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
            this.groupBoxAgregarVaca = new System.Windows.Forms.GroupBox();
            this.textBoxCaracteristicas = new System.Windows.Forms.TextBox();
            this.labelCaracteristicas = new System.Windows.Forms.Label();
            this.comboBoxRaza = new System.Windows.Forms.ComboBox();
            this.labelRaza = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNumeroTrazableToro = new System.Windows.Forms.TextBox();
            this.labelNumeroTrazableToro = new System.Windows.Forms.Label();
            this.groupBoxAgregarVaca.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(713, 415);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(75, 23);
            this.botonVolver.TabIndex = 2;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // groupBoxAgregarVaca
            // 
            this.groupBoxAgregarVaca.Controls.Add(this.textBoxCaracteristicas);
            this.groupBoxAgregarVaca.Controls.Add(this.labelCaracteristicas);
            this.groupBoxAgregarVaca.Controls.Add(this.comboBoxRaza);
            this.groupBoxAgregarVaca.Controls.Add(this.labelRaza);
            this.groupBoxAgregarVaca.Controls.Add(this.textBoxNombre);
            this.groupBoxAgregarVaca.Controls.Add(this.labelNombre);
            this.groupBoxAgregarVaca.Controls.Add(this.textBoxNumeroTrazableToro);
            this.groupBoxAgregarVaca.Controls.Add(this.labelNumeroTrazableToro);
            this.groupBoxAgregarVaca.Location = new System.Drawing.Point(228, 12);
            this.groupBoxAgregarVaca.Name = "groupBoxAgregarVaca";
            this.groupBoxAgregarVaca.Size = new System.Drawing.Size(345, 205);
            this.groupBoxAgregarVaca.TabIndex = 3;
            this.groupBoxAgregarVaca.TabStop = false;
            // 
            // textBoxCaracteristicas
            // 
            this.textBoxCaracteristicas.Location = new System.Drawing.Point(100, 145);
            this.textBoxCaracteristicas.MinimumSize = new System.Drawing.Size(236, 50);
            this.textBoxCaracteristicas.Multiline = true;
            this.textBoxCaracteristicas.Name = "textBoxCaracteristicas";
            this.textBoxCaracteristicas.Size = new System.Drawing.Size(236, 50);
            this.textBoxCaracteristicas.TabIndex = 15;
            // 
            // labelCaracteristicas
            // 
            this.labelCaracteristicas.AutoSize = true;
            this.labelCaracteristicas.Location = new System.Drawing.Point(6, 148);
            this.labelCaracteristicas.Name = "labelCaracteristicas";
            this.labelCaracteristicas.Size = new System.Drawing.Size(78, 13);
            this.labelCaracteristicas.TabIndex = 14;
            this.labelCaracteristicas.Text = "Características";
            // 
            // comboBoxRaza
            // 
            this.comboBoxRaza.FormattingEnabled = true;
            this.comboBoxRaza.Location = new System.Drawing.Point(136, 101);
            this.comboBoxRaza.Name = "comboBoxRaza";
            this.comboBoxRaza.Size = new System.Drawing.Size(200, 21);
            this.comboBoxRaza.TabIndex = 5;
            // 
            // labelRaza
            // 
            this.labelRaza.AutoSize = true;
            this.labelRaza.Location = new System.Drawing.Point(6, 104);
            this.labelRaza.Name = "labelRaza";
            this.labelRaza.Size = new System.Drawing.Size(32, 13);
            this.labelRaza.TabIndex = 4;
            this.labelRaza.Text = "Raza";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(136, 58);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(200, 20);
            this.textBoxNombre.TabIndex = 3;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(6, 61);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre";
            // 
            // textBoxNumeroTrazableToro
            // 
            this.textBoxNumeroTrazableToro.Location = new System.Drawing.Point(136, 13);
            this.textBoxNumeroTrazableToro.Name = "textBoxNumeroTrazableToro";
            this.textBoxNumeroTrazableToro.Size = new System.Drawing.Size(200, 20);
            this.textBoxNumeroTrazableToro.TabIndex = 1;
            // 
            // labelNumeroTrazableToro
            // 
            this.labelNumeroTrazableToro.AutoSize = true;
            this.labelNumeroTrazableToro.Location = new System.Drawing.Point(6, 16);
            this.labelNumeroTrazableToro.Name = "labelNumeroTrazableToro";
            this.labelNumeroTrazableToro.Size = new System.Drawing.Size(84, 13);
            this.labelNumeroTrazableToro.TabIndex = 0;
            this.labelNumeroTrazableToro.Text = "Número trazable";
            // 
            // FormAgregarToro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxAgregarVaca);
            this.Controls.Add(this.botonVolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAgregarToro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAgregarToro";
            this.Load += new System.EventHandler(this.FormAgregarToro_Load);
            this.groupBoxAgregarVaca.ResumeLayout(false);
            this.groupBoxAgregarVaca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.GroupBox groupBoxAgregarVaca;
        private System.Windows.Forms.TextBox textBoxCaracteristicas;
        private System.Windows.Forms.Label labelCaracteristicas;
        private System.Windows.Forms.ComboBox comboBoxRaza;
        private System.Windows.Forms.Label labelRaza;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNumeroTrazableToro;
        private System.Windows.Forms.Label labelNumeroTrazableToro;
    }
}