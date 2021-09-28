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
    public partial class Contenedor : Form
    {
        public Contenedor()
        {
            InitializeComponent();
        }

        private void hABITACIONToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmHabitacion habitacion = new frmHabitacion();
            habitacion.MdiParent = this;
            habitacion.Show();

        }

        private void cLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente CLIENTE = new frmCliente();
            CLIENTE.MdiParent = this;
            CLIENTE.Show();
        }

        private void rESERVACIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReservacion reservacion = new frmReservacion();
            reservacion.MdiParent = this;
            reservacion.Show();
        }
    }
}
