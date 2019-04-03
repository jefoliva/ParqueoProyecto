namespace ParqueoProyecto
{
    partial class frmAgregarEmpleado
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
            this.btnIngresarVehiculo = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtNombreEmpleado = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // btnIngresarVehiculo
            // 
            this.btnIngresarVehiculo.Location = new System.Drawing.Point(64, 321);
            this.btnIngresarVehiculo.Name = "btnIngresarVehiculo";
            this.btnIngresarVehiculo.Size = new System.Drawing.Size(113, 34);
            this.btnIngresarVehiculo.TabIndex = 6;
            this.btnIngresarVehiculo.Text = "Agregar";
            this.btnIngresarVehiculo.UseSelectable = true;
            this.btnIngresarVehiculo.Click += new System.EventHandler(this.btnIngresarVehiculo_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroLabel1.Location = new System.Drawing.Point(64, 229);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(142, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Nombre de Empleado";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtNombreEmpleado.CustomButton.Image = null;
            this.txtNombreEmpleado.CustomButton.Location = new System.Drawing.Point(294, 2);
            this.txtNombreEmpleado.CustomButton.Name = "";
            this.txtNombreEmpleado.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtNombreEmpleado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombreEmpleado.CustomButton.TabIndex = 1;
            this.txtNombreEmpleado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombreEmpleado.CustomButton.UseSelectable = true;
            this.txtNombreEmpleado.CustomButton.Visible = false;
            this.txtNombreEmpleado.DisplayIcon = true;
            this.txtNombreEmpleado.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNombreEmpleado.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtNombreEmpleado.Lines = new string[0];
            this.txtNombreEmpleado.Location = new System.Drawing.Point(64, 251);
            this.txtNombreEmpleado.MaxLength = 15;
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.PasswordChar = '\0';
            this.txtNombreEmpleado.PromptText = "Ingrese nombre y apellido";
            this.txtNombreEmpleado.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombreEmpleado.SelectedText = "";
            this.txtNombreEmpleado.SelectionLength = 0;
            this.txtNombreEmpleado.SelectionStart = 0;
            this.txtNombreEmpleado.ShortcutsEnabled = true;
            this.txtNombreEmpleado.ShowClearButton = true;
            this.txtNombreEmpleado.Size = new System.Drawing.Size(324, 32);
            this.txtNombreEmpleado.TabIndex = 4;
            this.txtNombreEmpleado.UseSelectable = true;
            this.txtNombreEmpleado.WaterMark = "Ingrese nombre y apellido";
            this.txtNombreEmpleado.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombreEmpleado.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmAgregarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 535);
            this.Controls.Add(this.btnIngresarVehiculo);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Name = "frmAgregarEmpleado";
            this.Text = "Agregar Empleado";
            this.Load += new System.EventHandler(this.frmAgregarEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnIngresarVehiculo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtNombreEmpleado;
    }
}