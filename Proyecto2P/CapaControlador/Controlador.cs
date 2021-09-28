using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModelor;

namespace CapaControlador
{

    public class Controlador
    {

        Sentenciascs cp = new Sentenciascs();
        public void funInsertar(string idCliente, string nombreCliente, string telefonoCliente, string correoCliente, string direccionCliente, string estatusCliente)
        {
            cp.funInsertar(idCliente, nombreCliente, telefonoCliente, correoCliente, direccionCliente, estatusCliente);
        }

        //insertar una reservacion
        public void funInsertarR(string idReservacion, string idCliente, string idHabitacion, string fechaInicio, string fechaFinal, string estatusReservacion)
        {
            cp.funInsertarR(idReservacion, idCliente, idHabitacion, fechaInicio, fechaFinal, estatusReservacion);
        }


        //insertar hotel
        public void funInsertarH(string idHabitacion, string tamañoHabitacion, string estadoHabitacion)
        {
            cp.funInsertarH(idHabitacion, tamañoHabitacion, estadoHabitacion);
        }

        //MODIFICAR CLIENTE
        public void funModificar(string idCliente, string nombreCliente, string telefonoCliente, string correoCliente, string direccionCliente, string estatusCliente)
        {
            cp.funModificar(idCliente, nombreCliente, telefonoCliente, correoCliente, direccionCliente, estatusCliente);
        }

        //modificar una reservacion
        public void funModificarR(string idReservacion, string idCliente, string idHabitacion, string fechaInicio, string fechaFinal, string estatusReservacion)
        {
            cp.funModificarR(idReservacion, idCliente, idHabitacion, fechaInicio, fechaFinal, estatusReservacion);
        }

        //modificar hotel

        public void funModificarh(string idHabitacion, string tamañoHabitacion, string estadoHabitacion)
        {
            cp.funModificarh(idHabitacion, tamañoHabitacion, estadoHabitacion);
        }

        // llenado de tabla

        public DataTable llenarTbl(string tablaDB)
        {
            OdbcDataAdapter dt = cp.llenarTbl(tablaDB);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //Seleccionar Registro

        public void funSeleccionar(DataGridView data, TextBox idCliente, TextBox nombreCliente, TextBox telefonoCliente, TextBox correoCliente, TextBox direccionCliente, TextBox estatusCliente)
        {
            cp.funSeleccionar(data, idCliente, nombreCliente, telefonoCliente, correoCliente, direccionCliente, estatusCliente);
        }

        //seleccionar registro reservacion
        public void funSeleccionarR(DataGridView data, TextBox idReservacion, TextBox idCliente, TextBox idHabitacion, DateTimePicker fechaInicio, DateTimePicker fechaFinal, TextBox estatusReservacion)
        {
            cp.funSeleccionarR(data, idReservacion, idCliente,  idHabitacion, fechaInicio,  fechaFinal, estatusReservacion);
        }
        //seleccionar registro hotel
        public void funSeleccionarh(DataGridView data, TextBox idHabitacion, TextBox tamañoHabitacion, TextBox estadoHabitacion)
        {
            cp.funSeleccionarh(data, idHabitacion, tamañoHabitacion, estadoHabitacion);
        }

        //dar de baja cliente
        public void funDarBajaCliente(string id)
        {

            cp.funDarBajaCliente(id);
        }

        // dar de bajo un hotel

        public void funDarBajaHabitacion(string id)
        {
            cp.funDarBajaHabitacion(id);
        }

        public void funDarBajaReservacion(string id)
        {
            cp.funDarBajaReservacion(id);
        }

    }
}
