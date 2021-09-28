using CapaModelo;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaModelor
{
    public class Sentenciascs
    {
        Conexion conexion = new Conexion();

        //Insertar Cliente
        public void funInsertar(string idCliente, string nombreCliente, string telefonoCliente, string correoCliente, string direccionCliente, string estatusCliente)
        {
            String psql = "INSERT INTO cliente(idCliente, nombreCliente, telefonoCliente,correoCliente,direccionCliente,estatusCliente)" +
             " VALUES('" + idCliente + "' , '" + nombreCliente + "' , '" + telefonoCliente + "','" + correoCliente + "' , '" + direccionCliente + "' , '" + estatusCliente + "')";

            OdbcConnection conexionBD = conexion.conexion();

            try
            {
                OdbcCommand insertarCliente = new OdbcCommand(psql, conexionBD);
                insertarCliente.ExecuteNonQuery();
                MessageBox.Show("Datos Ingresados Correctamente");
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al guardar los datos " + ex.Message);
            }
            finally
            {
                conexion.desconexion(conexionBD);
            }
        }
        //funcion para insertar una HaBITACION
        public void funInsertarH(string idHabitacion, string tamañoHabitacion, string estadoHabitacion)
        {
            String psql = "INSERT INTO hapitacion(idHabitacion, tamañoHabitacion, estadoHabitacion)" +
             " VALUES('" + idHabitacion + "' , '" + tamañoHabitacion + "' , '" + estadoHabitacion + "' )";

            OdbcConnection conexionBD = conexion.conexion();

            try
            {
                OdbcCommand insertarCliente = new OdbcCommand(psql, conexionBD);
                insertarCliente.ExecuteNonQuery();
                MessageBox.Show("Datos Ingresados Correctamente");
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al guardar los datos " + ex.Message);
            }
            finally
            {
                conexion.desconexion(conexionBD);
            }
        }

        ///INSERTAR RESERVACION
        public void funInsertarR(string idReservacion, string idCliente, string idHabitacion, string fechaInicio, string fechaFinal,string estatusReservacion)
        {
            String psql = "INSERT INTO reservacion(idReservacion, idCliente, idHabitacion,fechaInicio,fechaFinal,estatusReservacion)" +
             "  VALUES('" + idReservacion + "' , '" + idCliente + "' , '" + idHabitacion + "','" + fechaInicio + "' , '" + fechaFinal + "' , '" + estatusReservacion + "')";

            OdbcConnection conexionBD = conexion.conexion();

            try
            {
                OdbcCommand insertarCliente = new OdbcCommand(psql, conexionBD);
                insertarCliente.ExecuteNonQuery();
                MessageBox.Show("Datos Ingresados Correctamente");
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al guardar los datos " + ex.Message);
            }
            finally
            {
                conexion.desconexion(conexionBD);
            }
        }

        // LLenar tabla
        public OdbcDataAdapter llenarTbl(string tabla)
        {

            string sql = "select * from " + " " + tabla;
            OdbcConnection conexionBD = conexion.conexion();
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conexionBD);
            conexion.desconexion(conexionBD);

            return dataTable;
        }

        // Funcion Modificar Cliente
        public void funModificar(string idCliente, string nombreCliente, string telefonoCliente, string correoCliente, string direccionCliente, string estatusCliente)
        {
            string pSqlModificar = "UPDATE cliente SET nombreCliente='" + nombreCliente + "', telefonoCliente='" +
          telefonoCliente + "',correoCliente='" + correoCliente + "', direccionCliente='" +
          direccionCliente + "',estatusCliente='" +
          estatusCliente + "' WHERE idCliente='" + idCliente + "'";

            //Console.WriteLine(psql);
            OdbcConnection conexionBD = conexion.conexion();

            try
            {
                OdbcCommand modificarPuesto = new OdbcCommand(pSqlModificar, conexionBD);
                modificarPuesto.ExecuteNonQuery();
                MessageBox.Show("Datos Modificados Correctamente");
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al modificar los datos " + ex.Message);
            }
            finally
            {
                conexion.desconexion(conexionBD);
            }

        }

        //funcion modificar una reservacion
        public void funModificarR(string idReservacion, string idCliente, string idHabitacion, string fechaInicio, string fechaFinal, string estatusReservacion)
        {
            string pSqlModificar = "UPDATE reservacion SET idCliente='" + idCliente + "', idHabitacion='" +
          idHabitacion + "',fechaInicio='" + fechaInicio + "', fechaFinal='" +
          fechaFinal + "',estatusReservacion='" +
          estatusReservacion + "' WHERE idReservacion='" + idReservacion + "'";

            //Console.WriteLine(psql);
            OdbcConnection conexionBD = conexion.conexion();

            try
            {
                OdbcCommand modificarPuesto = new OdbcCommand(pSqlModificar, conexionBD);
                modificarPuesto.ExecuteNonQuery();
                MessageBox.Show("Datos Modificados Correctamente");
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al modificar los datos " + ex.Message);
            }
            finally
            {
                conexion.desconexion(conexionBD);
            }

        }

        //modificar habitacion
        public void funModificarh(string idHabitacion, string tamañoHabitacion, string estadoHabitacion)
        {
            string pSqlModificar = "UPDATE hapitacion SET tamañoHabitacion='" + tamañoHabitacion + "', estadoHabitacion='" +
          estadoHabitacion + "' WHERE idHabitacion='" + idHabitacion + "'";

            //Console.WriteLine(psql);
            OdbcConnection conexionBD = conexion.conexion();

            try
            {
                OdbcCommand modificarPuesto = new OdbcCommand(pSqlModificar, conexionBD);
                modificarPuesto.ExecuteNonQuery();
                MessageBox.Show("Datos Modificados Correctamente");
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al modificar los datos " + ex.Message);
            }
            finally
            {
                conexion.desconexion(conexionBD);
            }

        }

        //marcar fila
        public void funSeleccionar(DataGridView data, TextBox idCliente, TextBox nombreCliente, TextBox telefonoCliente, TextBox correoCliente, TextBox direccionCliente, TextBox estatusCliente)
        {
            var filaSeleccionada = data.CurrentRow;
            if (filaSeleccionada != null)
            {
                

                idCliente.Text = data.CurrentRow.Cells[0].Value.ToString();
                nombreCliente.Text = data.CurrentRow.Cells[1].Value.ToString();
                telefonoCliente.Text = data.CurrentRow.Cells[2].Value.ToString();
                correoCliente.Text = data.CurrentRow.Cells[3].Value.ToString();
                direccionCliente.Text = data.CurrentRow.Cells[4].Value.ToString();
                estatusCliente.Text = data.CurrentRow.Cells[5].Value.ToString();
            }
        }

        

        //seleccionar reservacion
        public void funSeleccionarR(DataGridView data, TextBox idReservacion, TextBox idCliente, TextBox idHabitacion, DateTimePicker fechaInicio, DateTimePicker fechaFinal, TextBox estatusReservacion)
        {
            var filaSeleccionada = data.CurrentRow;
            if (filaSeleccionada != null)
            {
                idReservacion.Text = data.CurrentRow.Cells[0].Value.ToString();
                idCliente.Text = data.CurrentRow.Cells[1].Value.ToString();
                idHabitacion.Text = data.CurrentRow.Cells[2].Value.ToString();
                fechaInicio.Text = data.CurrentRow.Cells[3].Value.ToString();
                fechaFinal.Text = data.CurrentRow.Cells[4].Value.ToString();
                estatusReservacion.Text = data.CurrentRow.Cells[5].Value.ToString();

            }
        }

                //marcar fila hotel
                public void funSeleccionarh(DataGridView data, TextBox idHabitacion, TextBox tamañoHabitacion, TextBox estadoHabitacion)
                 {
            var filaSeleccionada = data.CurrentRow;
            if (filaSeleccionada != null)
            {
                idHabitacion.Text = data.CurrentRow.Cells[0].Value.ToString();
                tamañoHabitacion.Text = data.CurrentRow.Cells[1].Value.ToString();
                estadoHabitacion.Text = data.CurrentRow.Cells[2].Value.ToString();
                
            }

                  }

        //fUNCION Dar de baja Cliente
        public void funDarBajaCliente(string id)
        {
            String pSqlModificar = "UPDATE cliente SET estatusCliente='I' WHERE idCliente='" + id + "'";

            OdbcConnection conexionBD = conexion.conexion();

            try
            {
                OdbcCommand modificarDep = new OdbcCommand(pSqlModificar, conexionBD);
                modificarDep.ExecuteNonQuery();
                MessageBox.Show("Estatus modificado Correctamente");
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al modificar los datos " + ex.Message);
            }
            finally
            {
                conexion.desconexion(conexionBD);
            }
        }

        // Dar de baja reservacion
        public void funDarBajaReservacion(string id)
        {
            String pSqlModificar = "UPDATE reservacion SET estatusReservacion='I' WHERE idReservacion='" + id + "'";

            OdbcConnection conexionBD = conexion.conexion();

            try
            {
                OdbcCommand modificarDep = new OdbcCommand(pSqlModificar, conexionBD);
                modificarDep.ExecuteNonQuery();
                MessageBox.Show("Estatus modificado Correctamente");
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al modificar los datos " + ex.Message);
            }
            finally
            {
                conexion.desconexion(conexionBD);
            }
        }

        //dar de bajo una habitacion

        public void funDarBajaHabitacion(string id)
        {
            String pSqlModificar = "UPDATE hapitacion SET estadoHabitacion='I' WHERE idHabitacion='" + id + "'";

            OdbcConnection conexionBD = conexion.conexion();

            try
            {
                OdbcCommand modificarDep = new OdbcCommand(pSqlModificar, conexionBD);
                modificarDep.ExecuteNonQuery();
                MessageBox.Show("Estatus modificado Correctamente");
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al modificar los datos " + ex.Message);
            }
            finally
            {
                conexion.desconexion(conexionBD);
            }
        }

    }


    }






