namespace ParqueoProyecto
{
    partial class frmVerTiempo
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
            this.linkVerActivos = new MetroFramework.Controls.MetroLink();
            this.btnCargarDatos = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtTiempoTotal = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtHoraEntrada = new MetroFramework.Controls.MetroTextBox();
            this.txtFechaEntrada = new MetroFramework.Controls.MetroTextBox();
            this.txtIngresarPlaca = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // linkVerActivos
            // 
            this.linkVerActivos.BackColor = System.Drawing.Color.Transparent;
            this.linkVerActivos.Location = new System.Drawing.Point(55, 169);
            this.linkVerActivos.Name = "linkVerActivos";
            this.linkVerActivos.Size = new System.Drawing.Size(124, 23);
            this.linkVerActivos.TabIndex = 42;
            this.linkVerActivos.Text = "Ver usuarios activos";
            this.linkVerActivos.UseSelectable = true;
            this.linkVerActivos.Click += new System.EventHandler(this.linkVerActivos_Click);
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Location = new System.Drawing.Point(288, 160);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(112, 32);
            this.btnCargarDatos.TabIndex = 41;
            this.btnCargarDatos.Text = "Calcular Tiempo";
            this.btnCargarDatos.UseSelectable = true;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroLabel3.Location = new System.Drawing.Point(243, 247);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(39, 19);
            this.metroLabel3.TabIndex = 39;
            this.metroLabel3.Text = "Hora";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroLabel8.Location = new System.Drawing.Point(57, 360);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(173, 19);
            this.metroLabel8.TabIndex = 40;
            this.metroLabel8.Text = "TIEMPO TRANSCURRIDO";
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroLabel4.Location = new System.Drawing.Point(57, 228);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(74, 19);
            this.metroLabel4.TabIndex = 38;
            this.metroLabel4.Text = "ENTRADA";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroLabel2.Location = new System.Drawing.Point(57, 247);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(44, 19);
            this.metroLabel2.TabIndex = 37;
            this.metroLabel2.Text = "Fecha";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // txtTiempoTotal
            // 
            this.txtTiempoTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtTiempoTotal.CustomButton.Image = null;
            this.txtTiempoTotal.CustomButton.Location = new System.Drawing.Point(127, 2);
            this.txtTiempoTotal.CustomButton.Name = "";
            this.txtTiempoTotal.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtTiempoTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTiempoTotal.CustomButton.TabIndex = 1;
            this.txtTiempoTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTiempoTotal.CustomButton.UseSelectable = true;
            this.txtTiempoTotal.CustomButton.Visible = false;
            this.txtTiempoTotal.DisplayIcon = true;
            this.txtTiempoTotal.Enabled = false;
            this.txtTiempoTotal.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTiempoTotal.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtTiempoTotal.Lines = new string[0];
            this.txtTiempoTotal.Location = new System.Drawing.Point(61, 382);
            this.txtTiempoTotal.MaxLength = 15;
            this.txtTiempoTotal.Name = "txtTiempoTotal";
            this.txtTiempoTotal.PasswordChar = '\0';
            this.txtTiempoTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTiempoTotal.SelectedText = "";
            this.txtTiempoTotal.SelectionLength = 0;
            this.txtTiempoTotal.SelectionStart = 0;
            this.txtTiempoTotal.ShortcutsEnabled = true;
            this.txtTiempoTotal.ShowClearButton = true;
            this.txtTiempoTotal.Size = new System.Drawing.Size(157, 32);
            this.txtTiempoTotal.TabIndex = 34;
            this.txtTiempoTotal.UseSelectable = true;
            this.txtTiempoTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTiempoTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroLabel1.Location = new System.Drawing.Point(63, 100);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(40, 19);
            this.metroLabel1.TabIndex = 36;
            this.metroLabel1.Text = "Placa";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // txtHoraEntrada
            // 
            this.txtHoraEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtHoraEntrada.CustomButton.Image = null;
            this.txtHoraEntrada.CustomButton.Location = new System.Drawing.Point(127, 2);
            this.txtHoraEntrada.CustomButton.Name = "";
            this.txtHoraEntrada.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtHoraEntrada.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHoraEntrada.CustomButton.TabIndex = 1;
            this.txtHoraEntrada.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHoraEntrada.CustomButton.UseSelectable = true;
            this.txtHoraEntrada.CustomButton.Visible = false;
            this.txtHoraEntrada.DisplayIcon = true;
            this.txtHoraEntrada.Enabled = false;
            this.txtHoraEntrada.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtHoraEntrada.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtHoraEntrada.Lines = new string[0];
            this.txtHoraEntrada.Location = new System.Drawing.Point(243, 269);
            this.txtHoraEntrada.MaxLength = 15;
            this.txtHoraEntrada.Name = "txtHoraEntrada";
            this.txtHoraEntrada.PasswordChar = '\0';
            this.txtHoraEntrada.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHoraEntrada.SelectedText = "";
            this.txtHoraEntrada.SelectionLength = 0;
            this.txtHoraEntrada.SelectionStart = 0;
            this.txtHoraEntrada.ShortcutsEnabled = true;
            this.txtHoraEntrada.ShowClearButton = true;
            this.txtHoraEntrada.Size = new System.Drawing.Size(157, 32);
            this.txtHoraEntrada.TabIndex = 33;
            this.txtHoraEntrada.UseSelectable = true;
            this.txtHoraEntrada.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHoraEntrada.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFechaEntrada
            // 
            this.txtFechaEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtFechaEntrada.CustomButton.Image = null;
            this.txtFechaEntrada.CustomButton.Location = new System.Drawing.Point(127, 2);
            this.txtFechaEntrada.CustomButton.Name = "";
            this.txtFechaEntrada.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtFechaEntrada.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFechaEntrada.CustomButton.TabIndex = 1;
            this.txtFechaEntrada.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFechaEntrada.CustomButton.UseSelectable = true;
            this.txtFechaEntrada.CustomButton.Visible = false;
            this.txtFechaEntrada.DisplayIcon = true;
            this.txtFechaEntrada.Enabled = false;
            this.txtFechaEntrada.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtFechaEntrada.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtFechaEntrada.Lines = new string[0];
            this.txtFechaEntrada.Location = new System.Drawing.Point(61, 269);
            this.txtFechaEntrada.MaxLength = 15;
            this.txtFechaEntrada.Name = "txtFechaEntrada";
            this.txtFechaEntrada.PasswordChar = '\0';
            this.txtFechaEntrada.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFechaEntrada.SelectedText = "";
            this.txtFechaEntrada.SelectionLength = 0;
            this.txtFechaEntrada.SelectionStart = 0;
            this.txtFechaEntrada.ShortcutsEnabled = true;
            this.txtFechaEntrada.ShowClearButton = true;
            this.txtFechaEntrada.Size = new System.Drawing.Size(157, 32);
            this.txtFechaEntrada.TabIndex = 35;
            this.txtFechaEntrada.UseSelectable = true;
            this.txtFechaEntrada.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFechaEntrada.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtIngresarPlaca
            // 
            this.txtIngresarPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtIngresarPlaca.CustomButton.Image = null;
            this.txtIngresarPlaca.CustomButton.Location = new System.Drawing.Point(309, 2);
            this.txtIngresarPlaca.CustomButton.Name = "";
            this.txtIngresarPlaca.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtIngresarPlaca.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIngresarPlaca.CustomButton.TabIndex = 1;
            this.txtIngresarPlaca.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIngresarPlaca.CustomButton.UseSelectable = true;
            this.txtIngresarPlaca.CustomButton.Visible = false;
            this.txtIngresarPlaca.DisplayIcon = true;
            this.txtIngresarPlaca.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtIngresarPlaca.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtIngresarPlaca.Lines = new string[0];
            this.txtIngresarPlaca.Location = new System.Drawing.Point(61, 122);
            this.txtIngresarPlaca.MaxLength = 15;
            this.txtIngresarPlaca.Name = "txtIngresarPlaca";
            this.txtIngresarPlaca.PasswordChar = '\0';
            this.txtIngresarPlaca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIngresarPlaca.SelectedText = "";
            this.txtIngresarPlaca.SelectionLength = 0;
            this.txtIngresarPlaca.SelectionStart = 0;
            this.txtIngresarPlaca.ShortcutsEnabled = true;
            this.txtIngresarPlaca.ShowClearButton = true;
            this.txtIngresarPlaca.Size = new System.Drawing.Size(339, 32);
            this.txtIngresarPlaca.TabIndex = 32;
            this.txtIngresarPlaca.UseSelectable = true;
            this.txtIngresarPlaca.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIngresarPlaca.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmVerTiempo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 535);
            this.Controls.Add(this.linkVerActivos);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtTiempoTotal);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtHoraEntrada);
            this.Controls.Add(this.txtFechaEntrada);
            this.Controls.Add(this.txtIngresarPlaca);
            this.Name = "frmVerTiempo";
            this.Text = "Tiempo transcurrido";
            this.Load += new System.EventHandler(this.frmVerTiempo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink linkVerActivos;
        private MetroFramework.Controls.MetroButton btnCargarDatos;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtTiempoTotal;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtHoraEntrada;
        private MetroFramework.Controls.MetroTextBox txtFechaEntrada;
        private MetroFramework.Controls.MetroTextBox txtIngresarPlaca;
    }
}