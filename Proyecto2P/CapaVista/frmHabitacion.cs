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
   
    public partial class frmHabitacion : Form
    {
        Controlador cc = new Controlador();

        public frmHabitacion()
        {
            InitializeComponent();
            llenaTabla();
            vaciarCampos();
        }

        public void llenaTabla()
        {
            DataTable dt = cc.llenarTbl("hapitacion");
            dgvHabitacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHabitacion.DataSource = dt;
        }

        public void vaciarCampos()
        {
            txtidHabitacion.Text = "";

            txttamañoHabitacion.Text = "";
            txtestadoHabitacion.Text = "";
          
        }

        private void frmHabitacion_Load(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string idHabitacion = txtidHabitacion.Text;
            string tamañoHabitacion = txttamañoHabitacion.Text;
            string estadoHabitacion = txtestadoHabitacion.Text;
        

            cc.funInsertarH(idHabitacion, tamañoHabitacion, estadoHabitacion);
            llenaTabla();
            vaciarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string idHabitacion = txtidHabitacion.Text;
            string tamañoHabitacion = txttamañoHabitacion.Text;
            string estadoHabitacion = txtestadoHabitacion.Text;

            cc.funModificarh(idHabitacion, tamañoHabitacion, estadoHabitacion);
            llenaTabla();
            vaciarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string idHabitacion = txtidHabitacion.Text;
            string tamañoHabitacion = txttamañoHabitacion.Text;
            string estadoHabitacion = txtestadoHabitacion.Text;

            cc.funDarBajaHabitacion(idHabitacion);
            llenaTabla();
            vaciarCampos();
        }

        private void dgvHabitacion_SelectionChanged(object sender, EventArgs e)
        {
            //cc.funModificarh(dgvHabitacion,txtidHabitacion, txttamañoHabitacion, txtestadoHabitacion);
            cc.funSeleccionarh(dgvHabitacion, txtidHabitacion, txttamañoHabitacion, txtestadoHabitacion);
        }
    }
}
