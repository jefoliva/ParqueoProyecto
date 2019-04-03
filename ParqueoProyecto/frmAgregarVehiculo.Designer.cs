namespace ParqueoProyecto
{
    partial class frmAgregarVehiculo
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
            this.txtIngresarPlaca = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmbTipoVehiculo = new MetroFramework.Controls.MetroComboBox();
            this.lblTipoVehiculo = new MetroFramework.Controls.MetroLabel();
            this.lblIngresarUbicacion = new MetroFramework.Controls.MetroLabel();
            this.mcbIngresarUbicacion = new MetroFramework.Controls.MetroComboBox();
            this.btnIngresarVehiculo = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtIngresarPlaca
            // 
            this.txtIngresarPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtIngresarPlaca.CustomButton.Image = null;
            this.txtIngresarPlaca.CustomButton.Location = new System.Drawing.Point(294, 2);
            this.txtIngresarPlaca.CustomButton.Name = "";
            this.txtIngresarPlaca.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtIngresarPlaca.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIngresarPlaca.CustomButton.TabIndex = 1;
            this.txtIngresarPlaca.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIngresarPlaca.CustomButton.UseSelectable = true;
            this.txtIngresarPlaca.CustomButton.Visible = false;
            this.txtIngresarPlaca.DisplayIcon = true;
            this.txtIngresarPlaca.Lines = new string[0];
            this.txtIngresarPlaca.Location = new System.Drawing.Point(61, 326);
            this.txtIngresarPlaca.MaxLength = 15;
            this.txtIngresarPlaca.Name = "txtIngresarPlaca";
            this.txtIngresarPlaca.PasswordChar = '\0';
            this.txtIngresarPlaca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIngresarPlaca.SelectedText = "";
            this.txtIngresarPlaca.SelectionLength = 0;
            this.txtIngresarPlaca.SelectionStart = 0;
            this.txtIngresarPlaca.ShortcutsEnabled = true;
            this.txtIngresarPlaca.ShowClearButton = true;
            this.txtIngresarPlaca.Size = new System.Drawing.Size(324, 32);
            this.txtIngresarPlaca.TabIndex = 0;
            this.txtIngresarPlaca.UseSelectable = true;
            this.txtIngresarPlaca.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIngresarPlaca.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtIngresarPlaca.Click += new System.EventHandler(this.metroTextBox1_Click_1);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroLabel1.Location = new System.Drawing.Point(61, 304);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(40, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Placa";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // cmbTipoVehiculo
            // 
            this.cmbTipoVehiculo.FormattingEnabled = true;
            this.cmbTipoVehiculo.ItemHeight = 23;
            this.cmbTipoVehiculo.Items.AddRange(new object[] {
            "Vehiculo",
            "Motocicleta",
            "Camion"});
            this.cmbTipoVehiculo.Location = new System.Drawing.Point(61, 134);
            this.cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            this.cmbTipoVehiculo.Size = new System.Drawing.Size(324, 29);
            this.cmbTipoVehiculo.TabIndex = 2;
            this.cmbTipoVehiculo.UseSelectable = true;
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoVehiculo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTipoVehiculo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTipoVehiculo.Location = new System.Drawing.Point(61, 112);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(175, 19);
            this.lblTipoVehiculo.TabIndex = 1;
            this.lblTipoVehiculo.Text = "Seleccione Tipo de Vehiculo";
            this.lblTipoVehiculo.UseCustomBackColor = true;
            this.lblTipoVehiculo.UseCustomForeColor = true;
            // 
            // lblIngresarUbicacion
            // 
            this.lblIngresarUbicacion.AutoSize = true;
            this.lblIngresarUbicacion.BackColor = System.Drawing.Color.Transparent;
            this.lblIngresarUbicacion.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblIngresarUbicacion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblIngresarUbicacion.Location = new System.Drawing.Point(61, 208);
            this.lblIngresarUbicacion.Name = "lblIngresarUbicacion";
            this.lblIngresarUbicacion.Size = new System.Drawing.Size(68, 19);
            this.lblIngresarUbicacion.TabIndex = 1;
            this.lblIngresarUbicacion.Text = "Ubicacion";
            this.lblIngresarUbicacion.UseCustomBackColor = true;
            this.lblIngresarUbicacion.UseCustomForeColor = true;
            // 
            // mcbIngresarUbicacion
            // 
            this.mcbIngresarUbicacion.FormattingEnabled = true;
            this.mcbIngresarUbicacion.ItemHeight = 23;
            this.mcbIngresarUbicacion.Location = new System.Drawing.Point(61, 230);
            this.mcbIngresarUbicacion.Name = "mcbIngresarUbicacion";
            this.mcbIngresarUbicacion.Size = new System.Drawing.Size(324, 29);
            this.mcbIngresarUbicacion.TabIndex = 2;
            this.mcbIngresarUbicacion.UseSelectable = true;
            // 
            // btnIngresarVehiculo
            // 
            this.btnIngresarVehiculo.Location = new System.Drawing.Point(61, 396);
            this.btnIngresarVehiculo.Name = "btnIngresarVehiculo";
            this.btnIngresarVehiculo.Size = new System.Drawing.Size(113, 34);
            this.btnIngresarVehiculo.TabIndex = 3;
            this.btnIngresarVehiculo.Text = "Agregar";
            this.btnIngresarVehiculo.UseSelectable = true;
            this.btnIngresarVehiculo.Click += new System.EventHandler(this.btnIngresarVehiculo_Click);
            // 
            // frmAgregarVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 535);
            this.Controls.Add(this.btnIngresarVehiculo);
            this.Controls.Add(this.mcbIngresarUbicacion);
            this.Controls.Add(this.cmbTipoVehiculo);
            this.Controls.Add(this.lblIngresarUbicacion);
            this.Controls.Add(this.lblTipoVehiculo);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtIngresarPlaca);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarVehiculo";
            this.Resizable = false;
            this.Text = "Ingresar Nuevo Vehiculo";
            this.Load += new System.EventHandler(this.frmAgregarVehiculo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtIngresarPlaca;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmbTipoVehiculo;
        private MetroFramework.Controls.MetroLabel lblTipoVehiculo;
        private MetroFramework.Controls.MetroLabel lblIngresarUbicacion;
        private MetroFramework.Controls.MetroComboBox mcbIngresarUbicacion;
        private MetroFramework.Controls.MetroButton btnIngresarVehiculo;
    }
}