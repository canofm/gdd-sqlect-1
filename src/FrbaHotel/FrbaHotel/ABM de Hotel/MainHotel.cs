﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FrbaHotel.Commons.Database;

namespace FrbaHotel.ABM_de_Hotel
{
    public partial class MainHotel : Form
    {
        public MainHotel(int idUsuario)
        {
            InitializeComponent();
            Text = "Gestor de hoteles";
            this.idUsuarioActual = idUsuario;
            cmbPais.Items.Add("");
            cargarPaises();
        }
        
        private int idUsuarioActual;
        private StringBuilder paisSeleccionado = new StringBuilder();
        private StringBuilder ciudadSeleccionado = new StringBuilder();
        private StringBuilder calleSeleccionado = new StringBuilder();
        private StringBuilder nombreSeleccionado = new StringBuilder();
        private Int32 nro_calleSeleccionado = new Int32();

        private void MainHotel_Load(object sender, EventArgs e)
        {
            lstHoteles.AllowUserToAddRows = false;
        }

        private void cargarPaises()
        {
            StringBuilder sentence = new StringBuilder().AppendFormat("SELECT nombrePais FROM SQLECT.Paises");
            DataTable tabla = Conexion.Instance.ejecutarQuery(sentence.ToString());

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                cmbPais.Items.Add(tabla.Rows[i]["nombrePais"].ToString());
            }
            cmbPais.SelectedIndex = 0;
        }

        public static StringBuilder getAllInstances()
        {
            StringBuilder sentence = new StringBuilder().Append("SELECT h.nombre 'Nombre', p.nombrePais 'Pais', h.ciudad 'Ciudad', h.calle 'Calle', h.nro_calle 'Nro Calle', h.cant_estrellas 'Cantidad de estrellas'");
            sentence.Append("FROM SQLECT.Hoteles h, SQLECT.Paises p WHERE h.fk_pais=p.id_pais");
            return sentence;
        }

        public static DataTable cargar_lista(StringBuilder sentence)
        {
            DataTable tabla = Conexion.Instance.ejecutarQuery(sentence.ToString());

            return tabla;
        }

        private void cerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            Alta_Hotel formAlta = new Alta_Hotel(this.lstHoteles,this.paisSeleccionado,this.ciudadSeleccionado,this.calleSeleccionado,this.nro_calleSeleccionado);
            formAlta.ShowDialog(this);
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            Alta_Hotel formAlta = new Alta_Hotel(this.lstHoteles,this.idUsuarioActual);
            formAlta.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nombre.ResetText();
            CantidadEstrellas.ResetText();
            Ciudad.ResetText();
            cmbPais.ResetText();
            lstHoteles.DataSource = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sentence = new StringBuilder();
            sentence = getAllInstances();

            if ((Nombre.Text != "") || (CantidadEstrellas.Text != "") || (Ciudad.Text != "") || (cmbPais.SelectedItem.ToString() != ""))
            {
                sentence.Append(" AND ");
                if (Nombre.Text != "") sentence.AppendFormat(" (nombre LIKE '%{0}%') AND ", Nombre.Text);
                if (CantidadEstrellas.Text != "")
                {
                    try
                    {
                        int numero = Convert.ToInt32(CantidadEstrellas.Text);
                        sentence.AppendFormat(" (cant_estrellas = '{0}') AND ", numero);
                    }
                    catch
                    {
                        MessageBox.Show("El filtro de cantidad estrellas debe ser numerico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (Ciudad.Text != "") sentence.AppendFormat(" (ciudad LIKE '%{0}%') AND ", Ciudad.Text);
                if (cmbPais.SelectedItem.ToString() != "") sentence.AppendFormat(" (nombrePais LIKE '%{0}%') AND ", cmbPais.SelectedItem.ToString());
                StringBuilder sentenceFiltro = new StringBuilder().AppendFormat(sentence.ToString().Substring(0, sentence.Length - 5));
                lstHoteles.DataSource = cargar_lista(sentenceFiltro).DefaultView;
                lstHoteles.AllowUserToAddRows = false;
            }
            else
            {
                lstHoteles.DataSource = cargar_lista(sentence).DefaultView;
                lstHoteles.AllowUserToAddRows = false;
            }
        }

        private void baja_Click(object sender, EventArgs e)
        {
            Baja_Hotel formBaja = new Baja_Hotel(this.nombreSeleccionado, this.paisSeleccionado, this.ciudadSeleccionado, this.calleSeleccionado, this.nro_calleSeleccionado);
            formBaja.ShowDialog(this);
        }

        private void lstHoteles_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow celda_actual = lstHoteles.CurrentRow;
            paisSeleccionado.Remove(0, paisSeleccionado.Length);
            ciudadSeleccionado.Remove(0, ciudadSeleccionado.Length);
            calleSeleccionado.Remove(0, calleSeleccionado.Length);
            nombreSeleccionado.Remove(0, nombreSeleccionado.Length);
            nro_calleSeleccionado = 0;

            if (celda_actual != null)
            {
                nombreSeleccionado.AppendFormat("{0}", celda_actual.Cells[0].Value.ToString());
                paisSeleccionado.AppendFormat("{0}", celda_actual.Cells[1].Value.ToString());
                ciudadSeleccionado.AppendFormat("{0}", celda_actual.Cells[2].Value.ToString());
                calleSeleccionado.AppendFormat("{0}", celda_actual.Cells[3].Value.ToString());
                nro_calleSeleccionado = Int32.Parse(celda_actual.Cells[4].Value.ToString());

                modificar.Enabled = true;
                baja.Enabled = true;
            }
        }
    }
}
