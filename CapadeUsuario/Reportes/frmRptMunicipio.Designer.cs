﻿namespace CapadeUsuario.Reportes
{
    partial class frmRptMunicipio
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
            this.cbFiltroEstado = new System.Windows.Forms.ComboBox();
            this.rptVMunicipio = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnPDF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbFiltroEstado
            // 
            this.cbFiltroEstado.FormattingEnabled = true;
            this.cbFiltroEstado.Location = new System.Drawing.Point(179, 13);
            this.cbFiltroEstado.Name = "cbFiltroEstado";
            this.cbFiltroEstado.Size = new System.Drawing.Size(256, 23);
            this.cbFiltroEstado.TabIndex = 0;
            this.cbFiltroEstado.SelectedValueChanged += new System.EventHandler(this.cbFiltroEstado_SelectedValueChanged);
            // 
            // rptVMunicipio
            // 
            this.rptVMunicipio.LocalReport.ReportEmbeddedResource = "CapadeUsuario.Reportes.rptMunicipio.rdlc";
            this.rptVMunicipio.Location = new System.Drawing.Point(12, 42);
            this.rptVMunicipio.Name = "rptVMunicipio";
            this.rptVMunicipio.ServerReport.BearerToken = null;
            this.rptVMunicipio.Size = new System.Drawing.Size(624, 246);
            this.rptVMunicipio.TabIndex = 1;
            // 
            // btnPDF
            // 
            this.btnPDF.Location = new System.Drawing.Point(561, 12);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(75, 23);
            this.btnPDF.TabIndex = 2;
            this.btnPDF.Text = "PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // frmRptMunicipio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 300);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.rptVMunicipio);
            this.Controls.Add(this.cbFiltroEstado);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmRptMunicipio";
            this.Text = "frmRptMunicipio";
            this.Load += new System.EventHandler(this.frmRptMunicipio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFiltroEstado;
        private Microsoft.Reporting.WinForms.ReportViewer rptVMunicipio;
        private System.Windows.Forms.Button btnPDF;
    }
}