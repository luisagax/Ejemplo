namespace CapadeUsuario.Reportes
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
            this.SuspendLayout();
            // 
            // cbFiltroEstado
            // 
            this.cbFiltroEstado.FormattingEnabled = true;
            this.cbFiltroEstado.Location = new System.Drawing.Point(177, 13);
            this.cbFiltroEstado.Name = "cbFiltroEstado";
            this.cbFiltroEstado.Size = new System.Drawing.Size(256, 23);
            this.cbFiltroEstado.TabIndex = 0;
            // 
            // rptVMunicipio
            // 
            this.rptVMunicipio.Location = new System.Drawing.Point(12, 42);
            this.rptVMunicipio.Name = "rptVMunicipio";
            this.rptVMunicipio.ServerReport.BearerToken = null;
            this.rptVMunicipio.Size = new System.Drawing.Size(624, 246);
            this.rptVMunicipio.TabIndex = 1;
            // 
            // frmRptMunicipio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 300);
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
    }
}