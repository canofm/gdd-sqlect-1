﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using FrbaHotel.Commons.Database;
using System.Windows.Forms;

namespace FrbaHotel.ABM_de_Hotel
{
    class AltaHotelAppModel : HotelAppModel
    {
        private Conexion connSql = Conexion.Instance;
        public override void doActionHotel(Control nombre, Control email, Control cant_estrellas, Control fecha_creacion, bool all_inclusive, bool all_inclusive_moderado, bool pension_completa, bool media_pension, Control pais, Control ciudad, Control calle, Control nro_calle)
        {
            Conexion cnn = Conexion.Instance;
            System.Data.SqlClient.SqlCommand comando1 = new System.Data.SqlClient.SqlCommand();
            comando1.CommandType = CommandType.StoredProcedure;

            comando1.Parameters.Add("@nombre", SqlDbType.VarChar);
            comando1.Parameters.Add("@email", SqlDbType.VarChar);
            comando1.Parameters.Add("@cant_estrellas", SqlDbType.Int);
            comando1.Parameters.Add("@fecha_creacion", SqlDbType.DateTime);
            comando1.Parameters.Add("@pais", SqlDbType.VarChar);
            comando1.Parameters.Add("@ciudad", SqlDbType.VarChar);
            comando1.Parameters.Add("@calle", SqlDbType.VarChar);
            comando1.Parameters.Add("@nro_calle", SqlDbType.Int);
            comando1.Parameters.Add("@all_inclusive", SqlDbType.Int);
            comando1.Parameters.Add("@all_inclusive_moderado", SqlDbType.Int);
            comando1.Parameters.Add("@pension_completa", SqlDbType.Int);
            comando1.Parameters.Add("@media_pension", SqlDbType.Int);

            comando1.Parameters[0].Value = nombre.Text;
            comando1.Parameters[1].Value = email.Text;
            comando1.Parameters[2].Value = Int32.Parse(cant_estrellas.Text);
            if (fecha_creacion.Text != "") comando1.Parameters[3].Value = DateTime.Parse(fecha_creacion.Text);
            else comando1.Parameters[3].Value = null;
            comando1.Parameters[4].Value = pais.Text;
            comando1.Parameters[5].Value = ciudad.Text;
            comando1.Parameters[6].Value = calle.Text;
            comando1.Parameters[7].Value = Int32.Parse(nro_calle.Text);
            comando1.Parameters[8].Value = (all_inclusive ? 1 : 0);
            comando1.Parameters[9].Value = (all_inclusive_moderado ? 1 : 0);
            comando1.Parameters[10].Value = (pension_completa ? 1 : 0);
            comando1.Parameters[11].Value = (media_pension ? 1 : 0);

            comando1.CommandText = "SQLECT.altaHotel";
            cnn.ejecutarQueryConSP(comando1);

            MessageBox.Show("Alta exitosa", "Alta de Hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}