﻿namespace formularios
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnmostrar = new System.Windows.Forms.Button();
            this.btnocultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(12, 297);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(193, 105);
            this.btnmostrar.TabIndex = 0;
            this.btnmostrar.Text = "Mostrar";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // btnocultar
            // 
            this.btnocultar.Location = new System.Drawing.Point(230, 297);
            this.btnocultar.Name = "btnocultar";
            this.btnocultar.Size = new System.Drawing.Size(193, 105);
            this.btnocultar.TabIndex = 1;
            this.btnocultar.Text = "Ocultar";
            this.btnocultar.UseVisualStyleBackColor = true;
            this.btnocultar.Click += new System.EventHandler(this.btnocultar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 450);
            this.Controls.Add(this.btnocultar);
            this.Controls.Add(this.btnmostrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.Button btnocultar;
    }
}

