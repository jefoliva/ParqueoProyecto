namespace ParqueoProyecto
{
    partial class frmEliminarVehiculo
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
            this.lblEliminarVehiculo = new MetroFramework.Controls.MetroLabel();
            this.btnEliminarVehiculo = new MetroFramework.Controls.MetroButton();
            this.cmbEliminarVehiculo = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // lblEliminarVehiculo
            // 
            this.lblEliminarVehiculo.AutoSize = true;
            this.lblEliminarVehiculo.BackColor = System.Drawing.Color.Transparent;
            this.lblEliminarVehiculo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEliminarVehiculo.Location = new System.Drawing.Point(65, 171);
            this.lblEliminarVehiculo.Name = "lblEliminarVehiculo";
            this.lblEliminarVehiculo.Size = new System.Drawing.Size(183, 19);
            this.lblEliminarVehiculo.TabIndex = 2;
            this.lblEliminarVehiculo.Text = "Seleccione vehiculo a eliminar";
            this.lblEliminarVehiculo.UseCustomBackColor = true;
            this.lblEliminarVehiculo.UseCustomForeColor = true;
            this.lblEliminarVehiculo.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // btnEliminarVehiculo
            // 
            this.btnEliminarVehiculo.Location = new System.Drawing.Point(65, 266);
            this.btnEliminarVehiculo.Name = "btnEliminarVehiculo";
            this.btnEliminarVehiculo.Size = new System.Drawing.Size(113, 34);
            this.btnEliminarVehiculo.TabIndex = 3;
            this.btnEliminarVehiculo.Text = "Eliminar";
            this.btnEliminarVehiculo.UseSelectable = true;
            // 
            // cmbEliminarVehiculo
            // 
            this.cmbEliminarVehiculo.FormattingEnabled = true;
            this.cmbEliminarVehiculo.ItemHeight = 23;
            this.cmbEliminarVehiculo.Items.AddRange(new object[] {
            "P123412",
            "M234234",
            "C232323"});
            this.cmbEliminarVehiculo.Location = new System.Drawing.Point(65, 193);
            this.cmbEliminarVehiculo.Name = "cmbEliminarVehiculo";
            this.cmbEliminarVehiculo.Size = new System.Drawing.Size(324, 29);
            this.cmbEliminarVehiculo.TabIndex = 4;
            this.cmbEliminarVehiculo.UseSelectable = true;
            // 
            // frmEliminarVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 535);
            this.Controls.Add(this.cmbEliminarVehiculo);
            this.Controls.Add(this.btnEliminarVehiculo);
            this.Controls.Add(this.lblEliminarVehiculo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEliminarVehiculo";
            this.Resizable = false;
            this.Text = "Eliminar Vehiculo";
            this.Load += new System.EventHandler(this.frmEliminarVehiculo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lblEliminarVehiculo;
        private MetroFramework.Controls.MetroButton btnEliminarVehiculo;
        private MetroFramework.Controls.MetroComboBox cmbEliminarVehiculo;
    }
}