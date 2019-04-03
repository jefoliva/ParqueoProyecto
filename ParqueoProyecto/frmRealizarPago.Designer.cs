namespace ParqueoProyecto
{
    partial class frmRealizarPago
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
            this.btnGenerarTicket = new MetroFramework.Controls.MetroButton();
            this.btnPagar = new MetroFramework.Controls.MetroButton();
            this.cmbTipoPago = new MetroFramework.Controls.MetroComboBox();
            this.cmbTipoFacturacion = new MetroFramework.Controls.MetroComboBox();
            this.btnCargarDatos = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtTotalPago = new MetroFramework.Controls.MetroTextBox();
            this.txtHoraSalida = new MetroFramework.Controls.MetroTextBox();
            this.txtTiempoTotal = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtFechaSalida = new MetroFramework.Controls.MetroTextBox();
            this.txtHoraEntrada = new MetroFramework.Controls.MetroTextBox();
            this.txtFechaEntrada = new MetroFramework.Controls.MetroTextBox();
            this.txtIngresarPlaca = new MetroFramework.Controls.MetroTextBox();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerarTicket
            // 
            this.btnGenerarTicket.Location = new System.Drawing.Point(355, 614);
            this.btnGenerarTicket.Name = "btnGenerarTicket";
            this.btnGenerarTicket.Size = new System.Drawing.Size(157, 39);
            this.btnGenerarTicket.TabIndex = 30;
            this.btnGenerarTicket.Text = "Generar Ticket";
            this.btnGenerarTicket.UseSelectable = true;
            this.btnGenerarTicket.Click += new System.EventHandler(this.btnGenerarTicket_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(176, 614);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(154, 39);
            this.btnPagar.TabIndex = 29;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseSelectable = true;
            // 
            // cmbTipoPago
            // 
            this.cmbTipoPago.FormattingEnabled = true;
            this.cmbTipoPago.ItemHeight = 23;
            this.cmbTipoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta de Crédito"});
            this.cmbTipoPago.Location = new System.Drawing.Point(352, 477);
            this.cmbTipoPago.Name = "cmbTipoPago";
            this.cmbTipoPago.Size = new System.Drawing.Size(154, 29);
            this.cmbTipoPago.TabIndex = 28;
            this.cmbTipoPago.UseSelectable = true;
            // 
            // cmbTipoFacturacion
            // 
            this.cmbTipoFacturacion.FormattingEnabled = true;
            this.cmbTipoFacturacion.ItemHeight = 23;
            this.cmbTipoFacturacion.Items.AddRange(new object[] {
            "Hora",
            "Diaria",
            "Semanal",
            "Mensual"});
            this.cmbTipoFacturacion.Location = new System.Drawing.Point(173, 477);
            this.cmbTipoFacturacion.Name = "cmbTipoFacturacion";
            this.cmbTipoFacturacion.Size = new System.Drawing.Size(154, 29);
            this.cmbTipoFacturacion.TabIndex = 27;
            this.cmbTipoFacturacion.UseSelectable = true;
            this.cmbTipoFacturacion.SelectedIndexChanged += new System.EventHandler(this.cmbTipoFacturacion_SelectedIndexChanged);
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Location = new System.Drawing.Point(423, 138);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(87, 32);
            this.btnCargarDatos.TabIndex = 26;
            this.btnCargarDatos.Text = "Cargar Datos";
            this.btnCargarDatos.UseSelectable = true;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroLabel7.Location = new System.Drawing.Point(354, 272);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(39, 19);
            this.metroLabel7.TabIndex = 24;
            this.metroLabel7.Text = "Hora";
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroLabel3.Location = new System.Drawing.Point(354, 209);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(39, 19);
            this.metroLabel3.TabIndex = 23;
            this.metroLabel3.Text = "Hora";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroLabel10.Location = new System.Drawing.Point(351, 453);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(99, 19);
            this.metroLabel10.TabIndex = 22;
            this.metroLabel10.Text = "Tipo de pago";
            this.metroLabel10.UseCustomBackColor = true;
            this.metroLabel10.UseCustomForeColor = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroLabel9.Location = new System.Drawing.Point(170, 453);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(103, 19);
            this.metroLabel9.TabIndex = 21;
            this.metroLabel9.Text = "Tipo de Tarifa";
            this.metroLabel9.UseCustomBackColor = true;
            this.metroLabel9.UseCustomForeColor = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroLabel11.Location = new System.Drawing.Point(172, 523);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(99, 19);
            this.metroLabel11.TabIndex = 20;
            this.metroLabel11.Text = "Total a Pagar";
            this.metroLabel11.UseCustomBackColor = true;
            this.metroLabel11.UseCustomForeColor = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroLabel8.Location = new System.Drawing.Point(46, 367);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(109, 19);
            this.metroLabel8.TabIndex = 25;
            this.metroLabel8.Text = "TIEMPO TOTAL";
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.UseCustomForeColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroLabel6.Location = new System.Drawing.Point(91, 307);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(58, 19);
            this.metroLabel6.TabIndex = 19;
            this.metroLabel6.Text = "SALIDA";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroLabel5.Location = new System.Drawing.Point(169, 272);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(44, 19);
            this.metroLabel5.TabIndex = 18;
            this.metroLabel5.Text = "Fecha";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroLabel4.Location = new System.Drawing.Point(78, 237);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(74, 19);
            this.metroLabel4.TabIndex = 17;
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
            this.metroLabel2.Location = new System.Drawing.Point(169, 209);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(44, 19);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "Fecha";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // txtTotalPago
            // 
            this.txtTotalPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtTotalPago.CustomButton.Image = null;
            this.txtTotalPago.CustomButton.Location = new System.Drawing.Point(123, 2);
            this.txtTotalPago.CustomButton.Name = "";
            this.txtTotalPago.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtTotalPago.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalPago.CustomButton.TabIndex = 1;
            this.txtTotalPago.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalPago.CustomButton.UseSelectable = true;
            this.txtTotalPago.CustomButton.Visible = false;
            this.txtTotalPago.DisplayIcon = true;
            this.txtTotalPago.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTotalPago.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtTotalPago.Lines = new string[0];
            this.txtTotalPago.Location = new System.Drawing.Point(174, 547);
            this.txtTotalPago.MaxLength = 15;
            this.txtTotalPago.Name = "txtTotalPago";
            this.txtTotalPago.PasswordChar = '\0';
            this.txtTotalPago.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalPago.SelectedText = "";
            this.txtTotalPago.SelectionLength = 0;
            this.txtTotalPago.SelectionStart = 0;
            this.txtTotalPago.ShortcutsEnabled = true;
            this.txtTotalPago.ShowClearButton = true;
            this.txtTotalPago.Size = new System.Drawing.Size(153, 32);
            this.txtTotalPago.TabIndex = 13;
            this.txtTotalPago.UseSelectable = true;
            this.txtTotalPago.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalPago.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtHoraSalida
            // 
            this.txtHoraSalida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtHoraSalida.CustomButton.Image = null;
            this.txtHoraSalida.CustomButton.Location = new System.Drawing.Point(127, 2);
            this.txtHoraSalida.CustomButton.Name = "";
            this.txtHoraSalida.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtHoraSalida.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHoraSalida.CustomButton.TabIndex = 1;
            this.txtHoraSalida.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHoraSalida.CustomButton.UseSelectable = true;
            this.txtHoraSalida.CustomButton.Visible = false;
            this.txtHoraSalida.DisplayIcon = true;
            this.txtHoraSalida.Enabled = false;
            this.txtHoraSalida.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtHoraSalida.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtHoraSalida.Lines = new string[0];
            this.txtHoraSalida.Location = new System.Drawing.Point(355, 295);
            this.txtHoraSalida.MaxLength = 15;
            this.txtHoraSalida.Name = "txtHoraSalida";
            this.txtHoraSalida.PasswordChar = '\0';
            this.txtHoraSalida.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHoraSalida.SelectedText = "";
            this.txtHoraSalida.SelectionLength = 0;
            this.txtHoraSalida.SelectionStart = 0;
            this.txtHoraSalida.ShortcutsEnabled = true;
            this.txtHoraSalida.ShowClearButton = true;
            this.txtHoraSalida.Size = new System.Drawing.Size(157, 32);
            this.txtHoraSalida.TabIndex = 12;
            this.txtHoraSalida.UseSelectable = true;
            this.txtHoraSalida.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHoraSalida.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTiempoTotal
            // 
            this.txtTiempoTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtTiempoTotal.CustomButton.Image = null;
            this.txtTiempoTotal.CustomButton.Location = new System.Drawing.Point(309, 2);
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
            this.txtTiempoTotal.Location = new System.Drawing.Point(173, 361);
            this.txtTiempoTotal.MaxLength = 15;
            this.txtTiempoTotal.Name = "txtTiempoTotal";
            this.txtTiempoTotal.PasswordChar = '\0';
            this.txtTiempoTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTiempoTotal.SelectedText = "";
            this.txtTiempoTotal.SelectionLength = 0;
            this.txtTiempoTotal.SelectionStart = 0;
            this.txtTiempoTotal.ShortcutsEnabled = true;
            this.txtTiempoTotal.ShowClearButton = true;
            this.txtTiempoTotal.Size = new System.Drawing.Size(339, 32);
            this.txtTiempoTotal.TabIndex = 11;
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
            this.metroLabel1.Location = new System.Drawing.Point(173, 78);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(40, 19);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Placa";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // txtFechaSalida
            // 
            this.txtFechaSalida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtFechaSalida.CustomButton.Image = null;
            this.txtFechaSalida.CustomButton.Location = new System.Drawing.Point(127, 2);
            this.txtFechaSalida.CustomButton.Name = "";
            this.txtFechaSalida.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtFechaSalida.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFechaSalida.CustomButton.TabIndex = 1;
            this.txtFechaSalida.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFechaSalida.CustomButton.UseSelectable = true;
            this.txtFechaSalida.CustomButton.Visible = false;
            this.txtFechaSalida.DisplayIcon = true;
            this.txtFechaSalida.Enabled = false;
            this.txtFechaSalida.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtFechaSalida.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtFechaSalida.Lines = new string[0];
            this.txtFechaSalida.Location = new System.Drawing.Point(173, 296);
            this.txtFechaSalida.MaxLength = 15;
            this.txtFechaSalida.Name = "txtFechaSalida";
            this.txtFechaSalida.PasswordChar = '\0';
            this.txtFechaSalida.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFechaSalida.SelectedText = "";
            this.txtFechaSalida.SelectionLength = 0;
            this.txtFechaSalida.SelectionStart = 0;
            this.txtFechaSalida.ShortcutsEnabled = true;
            this.txtFechaSalida.ShowClearButton = true;
            this.txtFechaSalida.Size = new System.Drawing.Size(157, 32);
            this.txtFechaSalida.TabIndex = 10;
            this.txtFechaSalida.UseSelectable = true;
            this.txtFechaSalida.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFechaSalida.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtHoraEntrada.Location = new System.Drawing.Point(355, 231);
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
            this.txtHoraEntrada.TabIndex = 9;
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
            this.txtFechaEntrada.Location = new System.Drawing.Point(173, 231);
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
            this.txtFechaEntrada.TabIndex = 14;
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
            this.txtIngresarPlaca.Location = new System.Drawing.Point(173, 100);
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
            this.txtIngresarPlaca.TabIndex = 8;
            this.txtIngresarPlaca.UseSelectable = true;
            this.txtIngresarPlaca.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIngresarPlaca.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLink1
            // 
            this.metroLink1.BackColor = System.Drawing.Color.Transparent;
            this.metroLink1.Location = new System.Drawing.Point(172, 147);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(124, 23);
            this.metroLink1.TabIndex = 31;
            this.metroLink1.Text = "Ver usuarios activos";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(46, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(525, 2);
            this.label2.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(46, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 2);
            this.label1.TabIndex = 32;
            // 
            // frmRealizarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 709);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.btnGenerarTicket);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.cmbTipoPago);
            this.Controls.Add(this.cmbTipoFacturacion);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtTotalPago);
            this.Controls.Add(this.txtHoraSalida);
            this.Controls.Add(this.txtTiempoTotal);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtFechaSalida);
            this.Controls.Add(this.txtHoraEntrada);
            this.Controls.Add(this.txtFechaEntrada);
            this.Controls.Add(this.txtIngresarPlaca);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRealizarPago";
            this.Resizable = false;
            this.Text = "Realizar Pago";
            this.Load += new System.EventHandler(this.frmRealizarPago_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnGenerarTicket;
        private MetroFramework.Controls.MetroButton btnPagar;
        private MetroFramework.Controls.MetroComboBox cmbTipoPago;
        private MetroFramework.Controls.MetroComboBox cmbTipoFacturacion;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtTotalPago;
        private MetroFramework.Controls.MetroTextBox txtHoraSalida;
        private MetroFramework.Controls.MetroTextBox txtTiempoTotal;
        private MetroFramework.Controls.MetroTextBox txtFechaSalida;
        private MetroFramework.Controls.MetroTextBox txtHoraEntrada;
        private MetroFramework.Controls.MetroTextBox txtIngresarPlaca;
        private MetroFramework.Controls.MetroTextBox txtFechaEntrada;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnCargarDatos;
        private MetroFramework.Controls.MetroLink metroLink1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}