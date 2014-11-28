﻿namespace FrbaHotel.Generar_Modificar_Reserva
{
    partial class ModificarHabitaciones
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tablaHabitacionesActuales = new System.Windows.Forms.DataGridView();
            this.tablaHabitacionesDisponibles = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericCantHuespedes = new System.Windows.Forms.NumericUpDown();
            this.botonContinuar = new System.Windows.Forms.Button();
            this.textoDelRegimen = new System.Windows.Forms.Label();
            this.botonVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaHabitacionesActuales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaHabitacionesDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantHuespedes)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaHabitacionesActuales
            // 
            this.tablaHabitacionesActuales.AllowUserToAddRows = false;
            this.tablaHabitacionesActuales.AllowUserToDeleteRows = false;
            this.tablaHabitacionesActuales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tablaHabitacionesActuales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaHabitacionesActuales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaHabitacionesActuales.Location = new System.Drawing.Point(12, 44);
            this.tablaHabitacionesActuales.Name = "tablaHabitacionesActuales";
            this.tablaHabitacionesActuales.ReadOnly = true;
            this.tablaHabitacionesActuales.Size = new System.Drawing.Size(472, 112);
            this.tablaHabitacionesActuales.TabIndex = 0;
            // 
            // tablaHabitacionesDisponibles
            // 
            this.tablaHabitacionesDisponibles.AllowUserToAddRows = false;
            this.tablaHabitacionesDisponibles.AllowUserToDeleteRows = false;
            this.tablaHabitacionesDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tablaHabitacionesDisponibles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaHabitacionesDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaHabitacionesDisponibles.Location = new System.Drawing.Point(12, 220);
            this.tablaHabitacionesDisponibles.Name = "tablaHabitacionesDisponibles";
            this.tablaHabitacionesDisponibles.Size = new System.Drawing.Size(515, 164);
            this.tablaHabitacionesDisponibles.TabIndex = 1;
            this.tablaHabitacionesDisponibles.CurrentCellDirtyStateChanged += new System.EventHandler(this.tablaHabitacionesDisponibles_CurrentCellDirtyStateChanged);
            this.tablaHabitacionesDisponibles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaHabitacionesDisponibles_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Habitaciones que dispuso de su última modificación.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(461, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleccione las nuevas habitaciones, incluyendo o no las anteriores, que va a toma" +
                "r.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad de huéspedes";
            // 
            // numericCantHuespedes
            // 
            this.numericCantHuespedes.Location = new System.Drawing.Point(185, 440);
            this.numericCantHuespedes.Name = "numericCantHuespedes";
            this.numericCantHuespedes.Size = new System.Drawing.Size(59, 20);
            this.numericCantHuespedes.TabIndex = 5;
            // 
            // botonContinuar
            // 
            this.botonContinuar.Location = new System.Drawing.Point(861, 483);
            this.botonContinuar.Name = "botonContinuar";
            this.botonContinuar.Size = new System.Drawing.Size(120, 47);
            this.botonContinuar.TabIndex = 6;
            this.botonContinuar.Text = "Realizar modificación";
            this.botonContinuar.UseVisualStyleBackColor = true;
            this.botonContinuar.Click += new System.EventHandler(this.botonContinuar_Click);
            // 
            // textoDelRegimen
            // 
            this.textoDelRegimen.AutoSize = true;
            this.textoDelRegimen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoDelRegimen.Location = new System.Drawing.Point(392, 444);
            this.textoDelRegimen.Name = "textoDelRegimen";
            this.textoDelRegimen.Size = new System.Drawing.Size(135, 16);
            this.textoDelRegimen.TabIndex = 7;
            this.textoDelRegimen.Text = "Tiene como régimen:";
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(12, 483);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(120, 47);
            this.botonVolver.TabIndex = 9;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // ModificarHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 542);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.textoDelRegimen);
            this.Controls.Add(this.botonContinuar);
            this.Controls.Add(this.numericCantHuespedes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaHabitacionesDisponibles);
            this.Controls.Add(this.tablaHabitacionesActuales);
            this.Name = "ModificarHabitaciones";
            this.Text = "Modificacion de Habitaciones";
            this.Load += new System.EventHandler(this.ModificarHabitaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaHabitacionesActuales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaHabitacionesDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantHuespedes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaHabitacionesActuales;
        private System.Windows.Forms.DataGridView tablaHabitacionesDisponibles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericCantHuespedes;
        private System.Windows.Forms.Button botonContinuar;
        private System.Windows.Forms.Label textoDelRegimen;
        private System.Windows.Forms.Button botonVolver;
    }
}