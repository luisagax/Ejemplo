﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapadeUsuario.Catalogos
{
    public partial class frmMunicipio : Form
    {
        SqlDataReader lector;
        static CapadeNegocio.Clases.Conexion x = new CapadeNegocio.Clases.Conexion();
        SqlConnection con = new SqlConnection(x.con());
        string sConexion = x.con();

        public frmMunicipio()
        {
            InitializeComponent();
            cargarestados();
        }
        public frmMunicipio(string sConexion)
        {
            InitializeComponent();
            this.sConexion = sConexion;
            cargarestados();
        }
        private void frmMunicipio_Load(object sender, EventArgs e)
        {
            txtID.Text = "0";
            txtID.Enabled = false;
        }
        void cargarestados()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Estado", sConexion);
            da.Fill(dt);
            cbEstado.DisplayMember = "Nombre";
            cbEstado.ValueMember = "id";
            cbEstado.DataSource = dt;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CapadeNegocio.Clases.Municipio x = new CapadeNegocio.Clases.Municipio(sConexion);
            x.buscar();
            txtID.Text = x.id.ToString();
            txtNombre.Text = x.nombre;
            cbEstado.SelectedValue = x.idEstado;
        }

        private void tsGuardar_Click(object sender, EventArgs e)
        {
            CapadeNegocio.Clases.Municipio x = new CapadeNegocio.Clases.Municipio(sConexion);
            x.id = int.Parse(txtID.Text);
            x.nombre = txtNombre.Text;
            x.idEstado = int.Parse(cbEstado.SelectedValue.ToString());
            MessageBox.Show(x.guardar());
        }

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            CapadeNegocio.Clases.Municipio x = new CapadeNegocio.Clases.Municipio(sConexion);
            x.id = int.Parse(txtID.Text);
            MessageBox.Show(x.eliminar());
        }
    }
}

