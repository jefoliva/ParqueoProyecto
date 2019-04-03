namespace ParqueoProyecto
{
    partial class frmEliminarEmpleado
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
            this.btnEliminarEmpleado = new MetroFramework.Controls.MetroButton();
            this.cmbEmpleado = new MetroFramework.Controls.MetroComboBox();
            this.lblTipoVehiculo = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(53, 279);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(113, 34);
            this.btnEliminarEmpleado.TabIndex = 6;
            this.btnEliminarEmpleado.Text = "Eliminar";
            this.btnEliminarEmpleado.UseSelectable = true;
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminarEmpleado_Click);
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.ItemHeight = 23;
            this.cmbEmpleado.Location = new System.Drawing.Point(53, 231);
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
            this.lblTipoVehiculo.Location = new System.Drawing.Point(53, 209);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(198, 19);
            this.lblTipoVehiculo.TabIndex = 4;
            this.lblTipoVehiculo.Text = "Seleccione Empleado a Eliminar";
            this.lblTipoVehiculo.UseCustomBackColor = true;
            this.lblTipoVehiculo.UseCustomForeColor = true;
            // 
            // frmEliminarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 535);
            this.Controls.Add(this.btnEliminarEmpleado);
            this.Controls.Add(this.cmbEmpleado);
            this.Controls.Add(this.lblTipoVehiculo);
            this.Name = "frmEliminarEmpleado";
            this.Text = "Eliminar Empleado";
            this.Load += new System.EventHandler(this.frmEliminarEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnEliminarEmpleado;
        private MetroFramework.Controls.MetroComboBox cmbEmpleado;
        private MetroFramework.Controls.MetroLabel lblTipoVehiculo;
    }
}