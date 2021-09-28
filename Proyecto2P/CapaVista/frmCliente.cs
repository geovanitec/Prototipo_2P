using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class frmCliente : Form
    {
        Controlador cc = new Controlador();
        public frmCliente()
        {
            InitializeComponent();
            llenaTabla();
            vaciarCampos();

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string idCliente = txtidCliente.Text;
            string nombreCliente  = txtnombreCliente.Text;
            string telefonoCliente=  txtdireccionCliente.Text;
            string correoCliente = txtcorreoCliente.Text;
            string direccionCliente = txttelefonoCliente.Text;
            string estatusCliente = txtestatusCliente.Text;

            cc.funInsertar(idCliente, nombreCliente, telefonoCliente, correoCliente, direccionCliente, estatusCliente);
            llenaTabla();
            vaciarCampos();
            
        }

        private void dgvCliente_SelectionChanged(object sender, EventArgs e)
        {
         cc.funSeleccionar(dgvCliente, txtidCliente, txtnombreCliente, txttelefonoCliente, txtcorreoCliente, txtdireccionCliente, txtestatusCliente);
           
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {

        }


        public void llenaTabla()
        {
            DataTable dt = cc.llenarTbl("cliente");
            dgvCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCliente.DataSource = dt;
        }

        public void vaciarCampos()
        {
            txtidCliente.Text = "";
           
           txtnombreCliente.Text = "";
            txttelefonoCliente.Text = "";
            txtcorreoCliente.Text = "";
            txtdireccionCliente.Text = "";
            txtestatusCliente.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string idCliente = txtidCliente.Text;
            string nombreCliente = txtnombreCliente.Text;
            string telefonoCliente = txtdireccionCliente.Text;
            string correoCliente = txtcorreoCliente.Text;
            string direccionCliente = txttelefonoCliente.Text;
            string estatusCliente = txtestatusCliente.Text;

            //cc.funInsertar(idCliente, nombreCliente, telefonoCliente, correoCliente, direccionCliente, estatusCliente);
            cc.funModificar(idCliente, nombreCliente, telefonoCliente, correoCliente, direccionCliente, estatusCliente);
            llenaTabla();
            vaciarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string idCliente = txtidCliente.Text;
            string nombreCliente = txtnombreCliente.Text;
            string telefonoCliente = txtdireccionCliente.Text;
            string correoCliente = txtcorreoCliente.Text;
            string direccionCliente = txttelefonoCliente.Text;
            string estatusCliente = txtestatusCliente.Text;

            
            cc.funDarBajaCliente(idCliente);
            vaciarCampos();
            llenaTabla();
            

        }
    }
}
