namespace ParqueoProyecto
{
    partial class frmSeleccionarEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnActivarEmpleado = new MetroFramework.Controls.MetroButton();
            this.cmbEmpleado = new MetroFramework.Controls.MetroComboBox();
            this.lblTipoVehiculo = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btnActivarEmpleado
            // 
            this.btnActivarEmpleado.Location = new System.Drawing.Point(65, 290);
            this.btnActivarEmpleado.Name = "btnActivarEmpleado";
            this.btnActivarEmpleado.Size = new System.Drawing.Size(113, 34);
            this.btnActivarEmpleado.TabIndex = 6;
            this.btnActivarEmpleado.Text = "Activar";
            this.btnActivarEmpleado.UseSelectable = true;
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.ItemHeight = 23;
            this.cmbEmpleado.Location = new System.Drawing.Point(65, 235);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(324, 29);
            this.cmbEmpleado.TabIndex = 5;
            this.cmbEmpleado.UseSelectable = true;
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoVehiculo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTipoVehiculo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTipoVehiculo.Location = new System.Drawing.Point(65, 213);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(176, 19);
            this.lblTipoVehiculo.TabIndex = 4;
            this.lblTipoVehiculo.Text = "Seleccione Tipo de Vehiculo";
            this.lblTipoVehiculo.UseCustomBackColor = true;
            this.lblTipoVehiculo.UseCustomForeColor = true;
            // 
            // frmSeleccionarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 535);
            this.Controls.Add(this.btnActivarEmpleado);
            this.Controls.Add(this.cmbEmpleado);
            this.Controls.Add(this.lblTipoVehiculo);
            this.Name = "frmSeleccionarEmpleado";
            this.Text = "Seleccionar Empleado Activo";
            this.Load += new System.EventHandler(this.frmSeleccionarEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnActivarEmpleado;
        private MetroFramework.Controls.MetroComboBox cmbEmpleado;
        private MetroFramework.Controls.MetroLabel lblTipoVehiculo;
    }
}