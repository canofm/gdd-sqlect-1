﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Commons.Database;
using FrbaHotel.ABM_de_Usuario;
using FrbaHotel.Generar_Modificar_Reserva;


namespace FrbaHotel.Registrar_Consumible
{
    public partial class RegistrarConsumible : Form
    {
        public RegistrarConsumible(string codigoReserva,string tipoOperacion)
        {
            InitializeComponent();
            this.codigoReservaActual = codigoReserva;
            this.operacionActual = tipoOperacion;
        }

        string codigoReservaActual;
        string operacionActual;
        StringBuilder mensajeValidacion = new StringBuilder();

        AppModel_Consumible funcionesConsumibles = new AppModel_Consumible();
        AppModel_Alta_Usuario funcionesVarias = new AppModel_Alta_Usuario();
        AppModel_Reservas funcionesReservas = new AppModel_Reservas();

        private void RegistrarConsumible_Load(object sender, EventArgs e)
        {
            this.cargarHabitaciones();
           switch (operacionActual)
           {
               case "modificar": botonGenerico.Text = "Modificar Consumible";
                   label4.Text = "Ingrese la cantidad exacta del consumible de la habitación";
                   break;
               case "borrar": botonGenerico.Text = "Eliminar Consumible";
                   label4.Text = "Elija el consumible que desea quitar de una habitación";
                   cantidadConsumible.Enabled = false;
                   break;         
           }

        }

        private void cargarHabitaciones()
        {
            StringBuilder sentence = new StringBuilder().AppendFormat("SELECT DISTINCT h.nro_habitacion FROM SQLECT.Habitaciones h JOIN SQLECT.Habitaciones_Reservas hr ON (hr.fk_habitacion=h.id_habitacion) JOIN SQLECT.Reservas r ON (hr.fk_reserva=r.id_reserva) WHERE r.codigo_reserva='{0}'", this.codigoReservaActual);
            DataTable tabla = Conexion.Instance.ejecutarQuery(sentence.ToString());

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                nroHabitacion.Items.Add(tabla.Rows[i]["nro_habitacion"].ToString());
            }
            nroHabitacion.SelectedIndex = 0;
        }

        private void botonRegistrarConsumible_Click(object sender, EventArgs e)
        {
          /*Validamos campos vacíos*/

            //bool habitacionOk = funcionesVarias.validarNoVacio(nroHabitacion.SelectedItem.ToString(), mensajeValidacion);
            bool comboOk = funcionesVarias.validarComboVacio(comboConsumibles, mensajeValidacion);
            bool cantidadOk = funcionesVarias.validarNoVacio(cantidadConsumible, mensajeValidacion);

            //habitacionOk = funcionesVarias.validarNumerico(nroHabitacion.SelectedItem.ToString(), mensajeValidacion);
            cantidadOk = funcionesVarias.validarNumerico(cantidadConsumible, mensajeValidacion);

            if (comboOk == false)
            {
                mensajeValidacion.AppendLine("Debe elegir un consumible");
            }

            if (operacionActual == "borrar")
            {
                cantidadOk = true;
                if (comboOk)
                    mensajeValidacion.Remove(0, mensajeValidacion.Length);
            
            }

            if (mensajeValidacion.Length > 0 )
                MessageBox.Show(mensajeValidacion.ToString());
            
            else /*Validamos que esa habitacion pertenezca a la reserva*/
            {

                if (funcionesConsumibles.verificarHabitacionDeReserva(codigoReservaActual, Convert.ToInt32(nroHabitacion.SelectedItem.ToString())))
                {

                    switch (operacionActual)
                    {
                        case "agregar":
                            funcionesConsumibles.registrarConsumible(codigoReservaActual, Convert.ToInt32(nroHabitacion.SelectedItem.ToString()), comboConsumibles.SelectedItem.ToString(), Convert.ToInt32(cantidadConsumible.Text.ToString()));
                            this.DialogResult = DialogResult.OK;
                            break;
                        case "modificar":
                            funcionesConsumibles.modificarConsumible(codigoReservaActual, Convert.ToInt32(nroHabitacion.SelectedItem.ToString()), comboConsumibles.SelectedItem.ToString(), Convert.ToInt32(cantidadConsumible.Text.ToString()));
                            this.DialogResult = DialogResult.OK;
                            break;
                        case "borrar":
                            funcionesConsumibles.eliminarConsumible(codigoReservaActual, Convert.ToInt32(nroHabitacion.SelectedItem.ToString()), comboConsumibles.SelectedItem.ToString());
                            this.DialogResult = DialogResult.OK;
                            break;
                    }
                 }
                else
                    MessageBox.Show("El numero de habitación no pertence a la reserva","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            
            }

            mensajeValidacion.Remove(0, mensajeValidacion.Length);
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
