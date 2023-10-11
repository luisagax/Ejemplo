namespace CapadeUsuario.Catalogos
{
    partial class frmMunicipio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMunicipio));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.barrademenu = new System.Windows.Forms.ToolStrip();
            this.tsGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsEliminar = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.barrademenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(226, 41);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(44, 35);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(120, 90);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(338, 26);
            this.txtNombre.TabIndex = 10;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(120, 46);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 26);
            this.txtID.TabIndex = 9;
            this.txtID.Tag = "";
            this.txtID.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // barrademenu
            // 
            this.barrademenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.barrademenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsGuardar,
            this.tsEliminar});
            this.barrademenu.Location = new System.Drawing.Point(0, 0);
            this.barrademenu.Name = "barrademenu";
            this.barrademenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.barrademenu.Size = new System.Drawing.Size(502, 31);
            this.barrademenu.Stretch = true;
            this.barrademenu.TabIndex = 6;
            this.barrademenu.Text = "toolStrip1";
            // 
            // tsGuardar
            // 
            this.tsGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsGuardar.Image")));
            this.tsGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsGuardar.Name = "tsGuardar";
            this.tsGuardar.Size = new System.Drawing.Size(28, 28);
            this.tsGuardar.Tag = "Guardar";
            this.tsGuardar.Text = "Guardar";
            this.tsGuardar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsGuardar.Click += new System.EventHandler(this.tsGuardar_Click);
            // 
            // tsEliminar
            // 
            this.tsEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsEliminar.Image")));
            this.tsEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEliminar.Name = "tsEliminar";
            this.tsEliminar.Size = new System.Drawing.Size(28, 28);
            this.tsEliminar.Text = "toolStripButton2";
            this.tsEliminar.Click += new System.EventHandler(this.tsEliminar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Estado";
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(120, 133);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(338, 26);
            this.cbEstado.TabIndex = 13;
            // 
            // frmMunicipio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 186);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barrademenu);
            this.Font = new System.Drawing.Font("Georgia", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMunicipio";
            this.Text = "Municipio";
            this.Load += new System.EventHandler(this.frmMunicipio_Load);
            this.barrademenu.ResumeLayout(false);
            this.barrademenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip barrademenu;
        private System.Windows.Forms.ToolStripButton tsGuardar;
        private System.Windows.Forms.ToolStripButton tsEliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbEstado;
    }
}