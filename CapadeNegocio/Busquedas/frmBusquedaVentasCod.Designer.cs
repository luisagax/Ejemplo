namespace CapadeNegocio.Busquedas
{
    partial class frmBusquedaVentasCod
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dgVentasDetCod = new System.Windows.Forms.DataGridView();
            this.dgVentasCod = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgVentasDetCod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVentasCod)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(521, 277);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 31);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(416, 277);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(82, 31);
            this.btnAceptar.TabIndex = 18;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dgVentasDetCod
            // 
            this.dgVentasDetCod.AllowUserToAddRows = false;
            this.dgVentasDetCod.AllowUserToDeleteRows = false;
            this.dgVentasDetCod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVentasDetCod.Location = new System.Drawing.Point(24, 155);
            this.dgVentasDetCod.Name = "dgVentasDetCod";
            this.dgVentasDetCod.ReadOnly = true;
            this.dgVentasDetCod.Size = new System.Drawing.Size(579, 116);
            this.dgVentasDetCod.TabIndex = 17;
            // 
            // dgVentasCod
            // 
            this.dgVentasCod.AllowUserToAddRows = false;
            this.dgVentasCod.AllowUserToDeleteRows = false;
            this.dgVentasCod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVentasCod.Location = new System.Drawing.Point(24, 33);
            this.dgVentasCod.Name = "dgVentasCod";
            this.dgVentasCod.ReadOnly = true;
            this.dgVentasCod.Size = new System.Drawing.Size(579, 116);
            this.dgVentasCod.TabIndex = 16;
            this.dgVentasCod.SelectionChanged += new System.EventHandler(this.dgVentasCod_SelectionChanged);
            // 
            // frmBusquedaVentasCod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 321);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgVentasDetCod);
            this.Controls.Add(this.dgVentasCod);
            this.Font = new System.Drawing.Font("Georgia", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBusquedaVentasCod";
            this.Text = "frmBusquedaVentasCod";
            this.Load += new System.EventHandler(this.frmBusquedaVentasCod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVentasDetCod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVentasCod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.DataGridView dgVentasDetCod;
        public System.Windows.Forms.DataGridView dgVentasCod;
    }
}