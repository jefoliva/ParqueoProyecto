namespace ParqueoProyecto
{
    partial class frmAgregarEspacio
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
            this.btnAgregarEstacionamiento = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtNuevoEstacionamiento = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // btnAgregarEstacionamiento
            // 
            this.btnAgregarEstacionamiento.Location = new System.Drawing.Point(57, 255);
            this.btnAgregarEstacionamiento.Name = "btnAgregarEstacionamiento";
            this.btnAgregarEstacionamiento.Size = new System.Drawing.Size(113, 34);
            this.btnAgregarEstacionamiento.TabIndex = 6;
            this.btnAgregarEstacionamiento.Text = "Agregar";
            this.btnAgregarEstacionamiento.UseSelectable = true;
            this.btnAgregarEstacionamiento.Click += new System.EventHandler(this.btnAgregarEstacionamiento_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroLabel1.Location = new System.Drawing.Point(57, 181);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(180, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Nombre de nueva ubicacion";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // txtNuevoEstacionamiento
            // 
            this.txtNuevoEstacionamiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtNuevoEstacionamiento.CustomButton.Image = null;
            this.txtNuevoEstacionamiento.CustomButton.Location = new System.Drawing.Point(294, 2);
            this.txtNuevoEstacionamiento.CustomButton.Name = "";
            this.txtNuevoEstacionamiento.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtNuevoEstacionamiento.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNuevoEstacionamiento.CustomButton.TabIndex = 1;
            this.txtNuevoEstacionamiento.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNuevoEstacionamiento.CustomButton.UseSelectable = true;
            this.txtNuevoEstacionamiento.CustomButton.Visible = false;
            this.txtNuevoEstacionamiento.DisplayIcon = true;
            this.txtNuevoEstacionamiento.Lines = new string[0];
            this.txtNuevoEstacionamiento.Location = new System.Drawing.Point(57, 204);
            this.txtNuevoEstacionamiento.MaxLength = 15;
            this.txtNuevoEstacionamiento.Name = "txtNuevoEstacionamiento";
            this.txtNuevoEstacionamiento.PasswordChar = '\0';
            this.txtNuevoEstacionamiento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNuevoEstacionamiento.SelectedText = "";
            this.txtNuevoEstacionamiento.SelectionLength = 0;
            this.txtNuevoEstacionamiento.SelectionStart = 0;
            this.txtNuevoEstacionamiento.ShortcutsEnabled = true;
            this.txtNuevoEstacionamiento.ShowClearButton = true;
            this.txtNuevoEstacionamiento.Size = new System.Drawing.Size(324, 32);
            this.txtNuevoEstacionamiento.TabIndex = 4;
            this.txtNuevoEstacionamiento.UseSelectable = true;
            this.txtNuevoEstacionamiento.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNuevoEstacionamiento.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmAgregarEspacio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 535);
            this.Controls.Add(this.btnAgregarEstacionamiento);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtNuevoEstacionamiento);
            this.Name = "frmAgregarEspacio";
            this.Text = "Agregar Ubicacion de Parqueo";
            this.Load += new System.EventHandler(this.frmAgregarEspacio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnAgregarEstacionamiento;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtNuevoEstacionamiento;
    }
}