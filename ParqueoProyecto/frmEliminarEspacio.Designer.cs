namespace ParqueoProyecto
{
    partial class frmEliminarEspacio
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
            this.btnEliminarEspacio = new MetroFramework.Controls.MetroButton();
            this.cmbEliminarEspacio = new MetroFramework.Controls.MetroComboBox();
            this.lblEliminarEspacio = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btnEliminarEspacio
            // 
            this.btnEliminarEspacio.Location = new System.Drawing.Point(55, 247);
            this.btnEliminarEspacio.Name = "btnEliminarEspacio";
            this.btnEliminarEspacio.Size = new System.Drawing.Size(113, 34);
            this.btnEliminarEspacio.TabIndex = 6;
            this.btnEliminarEspacio.Text = "Eliminar";
            this.btnEliminarEspacio.UseSelectable = true;
            this.btnEliminarEspacio.Click += new System.EventHandler(this.btnEliminarEspacio_Click);
            // 
            // cmbEliminarEspacio
            // 
            this.cmbEliminarEspacio.FormattingEnabled = true;
            this.cmbEliminarEspacio.ItemHeight = 23;
            this.cmbEliminarEspacio.Location = new System.Drawing.Point(55, 200);
            this.cmbEliminarEspacio.Name = "cmbEliminarEspacio";
            this.cmbEliminarEspacio.Size = new System.Drawing.Size(324, 29);
            this.cmbEliminarEspacio.TabIndex = 5;
            this.cmbEliminarEspacio.UseSelectable = true;
            // 
            // lblEliminarEspacio
            // 
            this.lblEliminarEspacio.AutoSize = true;
            this.lblEliminarEspacio.BackColor = System.Drawing.Color.Transparent;
            this.lblEliminarEspacio.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblEliminarEspacio.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEliminarEspacio.Location = new System.Drawing.Point(55, 178);
            this.lblEliminarEspacio.Name = "lblEliminarEspacio";
            this.lblEliminarEspacio.Size = new System.Drawing.Size(257, 19);
            this.lblEliminarEspacio.TabIndex = 4;
            this.lblEliminarEspacio.Text = "Seleccione Espacio de Parqueo a eliminar";
            this.lblEliminarEspacio.UseCustomBackColor = true;
            this.lblEliminarEspacio.UseCustomForeColor = true;
            // 
            // frmEliminarEspacio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 535);
            this.Controls.Add(this.btnEliminarEspacio);
            this.Controls.Add(this.cmbEliminarEspacio);
            this.Controls.Add(this.lblEliminarEspacio);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEliminarEspacio";
            this.Resizable = false;
            this.Text = "Eliminar Ubicacion";
            this.Load += new System.EventHandler(this.frmEliminarEspacio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnEliminarEspacio;
        private MetroFramework.Controls.MetroComboBox cmbEliminarEspacio;
        private MetroFramework.Controls.MetroLabel lblEliminarEspacio;
    }
}