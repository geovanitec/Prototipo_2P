using CapaControlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class frmReservacion : Form
    {
        Controlador cc = new Controlador();
        public frmReservacion()
        {
            InitializeComponent();
            llenaTabla();
            vaciarCampos();
        }

        public void llenaTabla()
        {
            DataTable dt = cc.llenarTbl("reservacion");
            dgvReservacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReservacion.DataSource = dt;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            
            string idReservacion = txtidReservacion.Text;
            string idCliente = txtIdCliente.Text;
            string idHabitacion = txtIdHabitacion.Text;
            string fechaI = txtfechaFinal.Value.ToString("yyyy-MM-dd");
            string fechaF = txtfechaFinal.Value.ToString("yyyy-MM-dd");
            string estatusReservacion = txtestatus.Text;

            cc.funInsertarR(idReservacion, idCliente, idHabitacion, fechaI, fechaF, estatusReservacion);
            llenaTabla();
            vaciarCampos();
        }

        private void frmReservacion_Load(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string idReservacion = txtidReservacion.Text;
            string idCliente = txtIdCliente.Text;
            string idHabitacion = txtIdHabitacion.Text;
            string fechaI = txtfechaInicio.Value.ToString("yyyy-MM-dd");
            string fechaF = txtfechaFinal.Value.ToString("yyyy-MM-dd");
            string estatusReservacion = txtestatus.Text;

            cc.funModificarR(idReservacion, idCliente, idHabitacion, fechaI, fechaF, estatusReservacion);
            llenaTabla();
            vaciarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string idReservacion = txtidReservacion.Text;
            string idCliente = txtIdCliente.Text;
            string idHabitacion = txtIdHabitacion.Text;
            string fechaI = txtfechaInicio.Value.ToString("yyyy-MM-dd");
            string fechaF = txtfechaFinal.Value.ToString("yyyy-MM-dd");
            string estatusReservacion = txtestatus.Text;

            cc.funDarBajaReservacion(idReservacion);
            llenaTabla();
            vaciarCampos();
        }

        public void vaciarCampos()
        {
            txtidReservacion.Text = "";
            txtestatus.Text = "";
            txtIdCliente.Text = "";
            txtIdHabitacion.Text = "";

        }

        private void dgvReservacion_SelectionChanged(object sender, EventArgs e)

        {
            //cc.funSeleccionarh(dgvHabitacion, txtidHabitacion, txttamañoHabitacion, txtestadoHabitacion);
            cc.funSeleccionarR(dgvReservacion, txtidReservacion, txtIdCliente, txtIdHabitacion, txtfechaInicio, txtfechaFinal, txtestatus);
        }
    }
}
