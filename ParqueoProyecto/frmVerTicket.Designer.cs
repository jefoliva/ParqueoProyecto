namespace ParqueoProyecto
{
    partial class frmVerTicket
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
            this.btnVerTicket = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtIngresarTicket = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // btnVerTicket
            // 
            this.btnVerTicket.Location = new System.Drawing.Point(69, 265);
            this.btnVerTicket.Name = "btnVerTicket";
            this.btnVerTicket.Size = new System.Drawing.Size(113, 34);
            this.btnVerTicket.TabIndex = 9;
            this.btnVerTicket.Text = "Ver Ticket";
            this.btnVerTicket.UseSelectable = true;
            this.btnVerTicket.Click += new System.EventHandler(this.btnVerTicket_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroLabel1.Location = new System.Drawing.Point(69, 191);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(162, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Ingrese numero de ticket";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // txtIngresarTicket
            // 
            this.txtIngresarTicket.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtIngresarTicket.CustomButton.Image = null;
            this.txtIngresarTicket.CustomButton.Location = new System.Drawing.Point(294, 2);
            this.txtIngresarTicket.CustomButton.Name = "";
            this.txtIngresarTicket.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtIngresarTicket.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIngresarTicket.CustomButton.TabIndex = 1;
            this.txtIngresarTicket.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIngresarTicket.CustomButton.UseSelectable = true;
            this.txtIngresarTicket.CustomButton.Visible = false;
            this.txtIngresarTicket.DisplayIcon = true;
            this.txtIngresarTicket.Lines = new string[0];
            this.txtIngresarTicket.Location = new System.Drawing.Point(69, 214);
            this.txtIngresarTicket.MaxLength = 15;
            this.txtIngresarTicket.Name = "txtIngresarTicket";
            this.txtIngresarTicket.PasswordChar = '\0';
            this.txtIngresarTicket.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIngresarTicket.SelectedText = "";
            this.txtIngresarTicket.SelectionLength = 0;
            this.txtIngresarTicket.SelectionStart = 0;
            this.txtIngresarTicket.ShortcutsEnabled = true;
            this.txtIngresarTicket.ShowClearButton = true;
            this.txtIngresarTicket.Size = new System.Drawing.Size(324, 32);
            this.txtIngresarTicket.TabIndex = 7;
            this.txtIngresarTicket.UseSelectable = true;
            this.txtIngresarTicket.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIngresarTicket.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmVerTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 535);
            this.Controls.Add(this.btnVerTicket);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtIngresarTicket);
            this.Name = "frmVerTicket";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmVerTicket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnVerTicket;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtIngresarTicket;
    }
}