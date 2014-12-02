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

namespace FrbaHotel.Registrar_Consumible
{
    public partial class FormaDePago : Form
    {
        public FormaDePago(string codigoReserva)
        {
            InitializeComponent();
            this.codigoReservaActual = codigoReserva;
        }

        string codigoReservaActual;
        AppModel_Facturacion funcionesFacturacion = new AppModel_Facturacion();
        AppModel_Alta_Usuario funcionesValidacion = new AppModel_Alta_Usuario();
        StringBuilder mensaje = new StringBuilder();
        private void FormaDePago_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool formaDePagoOk = funcionesValidacion.validarNoVacio(formaPago, mensaje);
            bool detallesDePagoOk = funcionesValidacion.validarNoVacio(detalles, mensaje);

            if (formaDePagoOk & detallesDePagoOk)
            {
                funcionesFacturacion.registrarFormaDePago(codigoReservaActual, formaPago.Text, detalles.Text);
                FrbaHotel.Registrar_Consumible.Agradecimiento formFinal = new Agradecimiento();
                formFinal.Show();


            }
            else
                MessageBox.Show(mensaje.ToString());

            mensaje.Remove(0, mensaje.Length);
            



        }
    }
}
