﻿namespace FrbaHotel.Registrar_Consumible
{
    partial class FormaDePago
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
            this.label1 = new System.Windows.Forms.Label();
            this.detalles = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.formaPago = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elija la forma de pago y los detalles con que va a abonar su estadía.";
            // 
            // detalles
            // 
            this.detalles.Location = new System.Drawing.Point(160, 208);
            this.detalles.MaxLength = 120;
            this.detalles.Name = "detalles";
            this.detalles.Size = new System.Drawing.Size(336, 71);
            this.detalles.TabIndex = 2;
            this.detalles.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Forma de pago:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Detalles:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(558, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formaPago
            // 
            this.formaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.formaPago.FormattingEnabled = true;
            this.formaPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta de crédito",
            "Tarjeta de débito",
            "Cheque",
            "Pagaré",
            "Cuenta corriente"});
            this.formaPago.Location = new System.Drawing.Point(160, 121);
            this.formaPago.Name = "formaPago";
            this.formaPago.Size = new System.Drawing.Size(201, 21);
            this.formaPago.TabIndex = 6;
            // 
            // FormaDePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 354);
            this.Controls.Add(this.formaPago);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.detalles);
            this.Controls.Add(this.label1);
            this.Name = "FormaDePago";
            this.Text = "FormaDePago";
            this.Load += new System.EventHandler(this.FormaDePago_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox detalles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox formaPago;
    }
}