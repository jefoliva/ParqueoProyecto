namespace ParqueoProyecto
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.tileFecha = new MetroFramework.Controls.MetroTile();
            this.lblFecha = new System.Windows.Forms.Label();
            this.tileTotalParqueos = new MetroFramework.Controls.MetroTile();
            this.lblTotalParqueos = new System.Windows.Forms.Label();
            this.tileIngresadoHoy = new MetroFramework.Controls.MetroTile();
            this.lblIngresosHoy = new System.Windows.Forms.Label();
            this.tileAcecaDe = new MetroFramework.Controls.MetroTile();
            this.tileHora = new MetroFramework.Controls.MetroTile();
            this.lblHora = new System.Windows.Forms.Label();
            this.tileParqueosDisponibles = new MetroFramework.Controls.MetroTile();
            this.lblParqueosDisponibles = new System.Windows.Forms.Label();
            this.tileParqueosOcupados = new MetroFramework.Controls.MetroTile();
            this.lblParqueosOcupados = new System.Windows.Forms.Label();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.tileAgregarEmpleado = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.tileEliminarEmpleado = new MetroFramework.Controls.MetroTile();
            this.tileVerTiempo = new MetroFramework.Controls.MetroTile();
            this.tileEliminarEspacio = new MetroFramework.Controls.MetroTile();
            this.tileVerActivos = new MetroFramework.Controls.MetroTile();
            this.tileEliminarVehiculo = new MetroFramework.Controls.MetroTile();
            this.tileAgregarEspacio = new MetroFramework.Controls.MetroTile();
            this.tileAgregarVehiculo = new MetroFramework.Controls.MetroTile();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.tileVerTicket = new MetroFramework.Controls.MetroTile();
            this.tileRealizarPago = new MetroFramework.Controls.MetroTile();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTabPage5 = new MetroFramework.Controls.MetroTabPage();
            this.tileTarifas = new MetroFramework.Controls.MetroTile();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mcbColor = new MetroFramework.Controls.MetroComboBox();
            this.mcbTheme = new MetroFramework.Controls.MetroComboBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.tileFecha.SuspendLayout();
            this.tileTotalParqueos.SuspendLayout();
            this.tileIngresadoHoy.SuspendLayout();
            this.tileHora.SuspendLayout();
            this.tileParqueosDisponibles.SuspendLayout();
            this.tileParqueosOcupados.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage4.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.metroTabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.204204F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.7958F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.Controls.Add(this.metroTabControl1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(37, 104);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(802, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage4);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Controls.Add(this.metroTabPage5);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(33, 3);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(686, 444);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.tileFecha);
            this.metroTabPage1.Controls.Add(this.tileTotalParqueos);
            this.metroTabPage1.Controls.Add(this.tileIngresadoHoy);
            this.metroTabPage1.Controls.Add(this.tileAcecaDe);
            this.metroTabPage1.Controls.Add(this.tileHora);
            this.metroTabPage1.Controls.Add(this.tileParqueosDisponibles);
            this.metroTabPage1.Controls.Add(this.tileParqueosOcupados);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(678, 402);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = " Inicio";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // tileFecha
            // 
            this.tileFecha.ActiveControl = null;
            this.tileFecha.Controls.Add(this.lblFecha);
            this.tileFecha.Location = new System.Drawing.Point(387, 145);
            this.tileFecha.Name = "tileFecha";
            this.tileFecha.Size = new System.Drawing.Size(301, 109);
            this.tileFecha.TabIndex = 3;
            this.tileFecha.Text = "Fecha";
            this.tileFecha.UseSelectable = true;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFecha.Location = new System.Drawing.Point(4, 54);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(69, 24);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tileTotalParqueos
            // 
            this.tileTotalParqueos.ActiveControl = null;
            this.tileTotalParqueos.Controls.Add(this.lblTotalParqueos);
            this.tileTotalParqueos.Location = new System.Drawing.Point(22, 28);
            this.tileTotalParqueos.Name = "tileTotalParqueos";
            this.tileTotalParqueos.Size = new System.Drawing.Size(301, 109);
            this.tileTotalParqueos.TabIndex = 3;
            this.tileTotalParqueos.Text = "Total Parqueos";
            this.tileTotalParqueos.TileImage = ((System.Drawing.Image)(resources.GetObject("tileTotalParqueos.TileImage")));
            this.tileTotalParqueos.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tileTotalParqueos.UseSelectable = true;
            this.tileTotalParqueos.UseTileImage = true;
            // 
            // lblTotalParqueos
            // 
            this.lblTotalParqueos.AutoSize = true;
            this.lblTotalParqueos.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalParqueos.Font = new System.Drawing.Font("Arial Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalParqueos.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalParqueos.Location = new System.Drawing.Point(10, 25);
            this.lblTotalParqueos.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotalParqueos.Name = "lblTotalParqueos";
            this.lblTotalParqueos.Size = new System.Drawing.Size(68, 50);
            this.lblTotalParqueos.TabIndex = 0;
            this.lblTotalParqueos.Text = "40";
            // 
            // tileIngresadoHoy
            // 
            this.tileIngresadoHoy.ActiveControl = null;
            this.tileIngresadoHoy.Controls.Add(this.lblIngresosHoy);
            this.tileIngresadoHoy.Location = new System.Drawing.Point(22, 260);
            this.tileIngresadoHoy.Name = "tileIngresadoHoy";
            this.tileIngresadoHoy.Size = new System.Drawing.Size(147, 117);
            this.tileIngresadoHoy.TabIndex = 2;
            this.tileIngresadoHoy.Text = "Ingresos de Hoy";
            this.tileIngresadoHoy.TileImage = ((System.Drawing.Image)(resources.GetObject("tileIngresadoHoy.TileImage")));
            this.tileIngresadoHoy.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tileIngresadoHoy.UseSelectable = true;
            this.tileIngresadoHoy.UseTileImage = true;
            // 
            // lblIngresosHoy
            // 
            this.lblIngresosHoy.BackColor = System.Drawing.Color.Transparent;
            this.lblIngresosHoy.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresosHoy.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIngresosHoy.Location = new System.Drawing.Point(41, 37);
            this.lblIngresosHoy.Name = "lblIngresosHoy";
            this.lblIngresosHoy.Size = new System.Drawing.Size(110, 51);
            this.lblIngresosHoy.TabIndex = 0;
            this.lblIngresosHoy.Text = "400";
            // 
            // tileAcecaDe
            // 
            this.tileAcecaDe.ActiveControl = null;
            this.tileAcecaDe.Location = new System.Drawing.Point(579, 28);
            this.tileAcecaDe.Name = "tileAcecaDe";
            this.tileAcecaDe.Size = new System.Drawing.Size(109, 111);
            this.tileAcecaDe.TabIndex = 2;
            this.tileAcecaDe.Text = "Acerca De";
            this.tileAcecaDe.TileImage = ((System.Drawing.Image)(resources.GetObject("tileAcecaDe.TileImage")));
            this.tileAcecaDe.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileAcecaDe.UseSelectable = true;
            this.tileAcecaDe.UseTileImage = true;
            this.tileAcecaDe.Click += new System.EventHandler(this.tileAcecaDe_Click);
            // 
            // tileHora
            // 
            this.tileHora.ActiveControl = null;
            this.tileHora.Controls.Add(this.lblHora);
            this.tileHora.Location = new System.Drawing.Point(387, 28);
            this.tileHora.Name = "tileHora";
            this.tileHora.Size = new System.Drawing.Size(186, 111);
            this.tileHora.TabIndex = 2;
            this.tileHora.Text = "Hora";
            this.tileHora.UseSelectable = true;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHora.Location = new System.Drawing.Point(3, 59);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(69, 29);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "Hora";
            // 
            // tileParqueosDisponibles
            // 
            this.tileParqueosDisponibles.ActiveControl = null;
            this.tileParqueosDisponibles.Controls.Add(this.lblParqueosDisponibles);
            this.tileParqueosDisponibles.Location = new System.Drawing.Point(176, 143);
            this.tileParqueosDisponibles.Name = "tileParqueosDisponibles";
            this.tileParqueosDisponibles.Size = new System.Drawing.Size(147, 111);
            this.tileParqueosDisponibles.TabIndex = 2;
            this.tileParqueosDisponibles.Text = "Parqueos Disponibles";
            this.tileParqueosDisponibles.TileImage = ((System.Drawing.Image)(resources.GetObject("tileParqueosDisponibles.TileImage")));
            this.tileParqueosDisponibles.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tileParqueosDisponibles.UseSelectable = true;
            this.tileParqueosDisponibles.UseTileImage = true;
            // 
            // lblParqueosDisponibles
            // 
            this.lblParqueosDisponibles.AutoSize = true;
            this.lblParqueosDisponibles.BackColor = System.Drawing.Color.Transparent;
            this.lblParqueosDisponibles.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParqueosDisponibles.ForeColor = System.Drawing.SystemColors.Control;
            this.lblParqueosDisponibles.Location = new System.Drawing.Point(12, 25);
            this.lblParqueosDisponibles.Name = "lblParqueosDisponibles";
            this.lblParqueosDisponibles.Size = new System.Drawing.Size(73, 52);
            this.lblParqueosDisponibles.TabIndex = 0;
            this.lblParqueosDisponibles.Text = "27";
            // 
            // tileParqueosOcupados
            // 
            this.tileParqueosOcupados.ActiveControl = null;
            this.tileParqueosOcupados.Controls.Add(this.lblParqueosOcupados);
            this.tileParqueosOcupados.Location = new System.Drawing.Point(22, 143);
            this.tileParqueosOcupados.Name = "tileParqueosOcupados";
            this.tileParqueosOcupados.Size = new System.Drawing.Size(147, 111);
            this.tileParqueosOcupados.TabIndex = 2;
            this.tileParqueosOcupados.Text = "Parqueos Ocupados";
            this.tileParqueosOcupados.TileImage = ((System.Drawing.Image)(resources.GetObject("tileParqueosOcupados.TileImage")));
            this.tileParqueosOcupados.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tileParqueosOcupados.UseSelectable = true;
            this.tileParqueosOcupados.UseTileImage = true;
            // 
            // lblParqueosOcupados
            // 
            this.lblParqueosOcupados.AutoSize = true;
            this.lblParqueosOcupados.BackColor = System.Drawing.Color.Transparent;
            this.lblParqueosOcupados.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParqueosOcupados.ForeColor = System.Drawing.SystemColors.Control;
            this.lblParqueosOcupados.Location = new System.Drawing.Point(6, 27);
            this.lblParqueosOcupados.Name = "lblParqueosOcupados";
            this.lblParqueosOcupados.Size = new System.Drawing.Size(73, 52);
            this.lblParqueosOcupados.TabIndex = 0;
            this.lblParqueosOcupados.Text = "13";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.tileAgregarEmpleado);
            this.metroTabPage2.Controls.Add(this.metroTile3);
            this.metroTabPage2.Controls.Add(this.tileEliminarEmpleado);
            this.metroTabPage2.Controls.Add(this.tileVerTiempo);
            this.metroTabPage2.Controls.Add(this.tileEliminarEspacio);
            this.metroTabPage2.Controls.Add(this.tileVerActivos);
            this.metroTabPage2.Controls.Add(this.tileEliminarVehiculo);
            this.metroTabPage2.Controls.Add(this.tileAgregarEspacio);
            this.metroTabPage2.Controls.Add(this.tileAgregarVehiculo);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(678, 402);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Gestion de Parqueo";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // tileAgregarEmpleado
            // 
            this.tileAgregarEmpleado.ActiveControl = null;
            this.tileAgregarEmpleado.Location = new System.Drawing.Point(382, 146);
            this.tileAgregarEmpleado.Name = "tileAgregarEmpleado";
            this.tileAgregarEmpleado.Size = new System.Drawing.Size(147, 109);
            this.tileAgregarEmpleado.TabIndex = 9;
            this.tileAgregarEmpleado.Text = "Agregar Empleado";
            this.tileAgregarEmpleado.TileImage = ((System.Drawing.Image)(resources.GetObject("tileAgregarEmpleado.TileImage")));
            this.tileAgregarEmpleado.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileAgregarEmpleado.UseSelectable = true;
            this.tileAgregarEmpleado.UseTileImage = true;
            this.tileAgregarEmpleado.Click += new System.EventHandler(this.tileAgregarEmpleado_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(382, 261);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(300, 110);
            this.metroTile3.TabIndex = 8;
            this.metroTile3.Text = "Seleccionar Empleado Activo";
            this.metroTile3.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile3.TileImage")));
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseTileImage = true;
            // 
            // tileEliminarEmpleado
            // 
            this.tileEliminarEmpleado.ActiveControl = null;
            this.tileEliminarEmpleado.Location = new System.Drawing.Point(535, 145);
            this.tileEliminarEmpleado.Name = "tileEliminarEmpleado";
            this.tileEliminarEmpleado.Size = new System.Drawing.Size(147, 109);
            this.tileEliminarEmpleado.TabIndex = 7;
            this.tileEliminarEmpleado.Text = "Eliminar Empleado";
            this.tileEliminarEmpleado.TileImage = ((System.Drawing.Image)(resources.GetObject("tileEliminarEmpleado.TileImage")));
            this.tileEliminarEmpleado.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileEliminarEmpleado.UseSelectable = true;
            this.tileEliminarEmpleado.UseTileImage = true;
            this.tileEliminarEmpleado.Click += new System.EventHandler(this.tileEliminarEmpleado_Click);
            // 
            // tileVerTiempo
            // 
            this.tileVerTiempo.ActiveControl = null;
            this.tileVerTiempo.Location = new System.Drawing.Point(21, 145);
            this.tileVerTiempo.Name = "tileVerTiempo";
            this.tileVerTiempo.Size = new System.Drawing.Size(301, 109);
            this.tileVerTiempo.TabIndex = 6;
            this.tileVerTiempo.Text = "Ver Tiempo Trancurrido";
            this.tileVerTiempo.TileImage = ((System.Drawing.Image)(resources.GetObject("tileVerTiempo.TileImage")));
            this.tileVerTiempo.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileVerTiempo.UseSelectable = true;
            this.tileVerTiempo.UseTileImage = true;
            this.tileVerTiempo.Click += new System.EventHandler(this.tileVerTiempo_Click);
            // 
            // tileEliminarEspacio
            // 
            this.tileEliminarEspacio.ActiveControl = null;
            this.tileEliminarEspacio.Location = new System.Drawing.Point(535, 28);
            this.tileEliminarEspacio.Name = "tileEliminarEspacio";
            this.tileEliminarEspacio.Size = new System.Drawing.Size(147, 111);
            this.tileEliminarEspacio.TabIndex = 4;
            this.tileEliminarEspacio.Text = "Eliminar Ubicacion";
            this.tileEliminarEspacio.TileImage = ((System.Drawing.Image)(resources.GetObject("tileEliminarEspacio.TileImage")));
            this.tileEliminarEspacio.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileEliminarEspacio.UseSelectable = true;
            this.tileEliminarEspacio.UseTileImage = true;
            this.tileEliminarEspacio.Click += new System.EventHandler(this.tileEliminarEspacio_Click);
            // 
            // tileVerActivos
            // 
            this.tileVerActivos.ActiveControl = null;
            this.tileVerActivos.Location = new System.Drawing.Point(22, 260);
            this.tileVerActivos.Name = "tileVerActivos";
            this.tileVerActivos.Size = new System.Drawing.Size(147, 111);
            this.tileVerActivos.TabIndex = 4;
            this.tileVerActivos.Text = "Ver Activos";
            this.tileVerActivos.TileImage = ((System.Drawing.Image)(resources.GetObject("tileVerActivos.TileImage")));
            this.tileVerActivos.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileVerActivos.UseSelectable = true;
            this.tileVerActivos.UseTileImage = true;
            this.tileVerActivos.Click += new System.EventHandler(this.tileVerActivos_Click);
            // 
            // tileEliminarVehiculo
            // 
            this.tileEliminarVehiculo.ActiveControl = null;
            this.tileEliminarVehiculo.Location = new System.Drawing.Point(175, 28);
            this.tileEliminarVehiculo.Name = "tileEliminarVehiculo";
            this.tileEliminarVehiculo.Size = new System.Drawing.Size(147, 111);
            this.tileEliminarVehiculo.TabIndex = 4;
            this.tileEliminarVehiculo.Text = "Eliminar Vehiculo";
            this.tileEliminarVehiculo.TileImage = ((System.Drawing.Image)(resources.GetObject("tileEliminarVehiculo.TileImage")));
            this.tileEliminarVehiculo.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileEliminarVehiculo.UseSelectable = true;
            this.tileEliminarVehiculo.UseTileImage = true;
            this.tileEliminarVehiculo.Click += new System.EventHandler(this.tileEliminarVehiculo_Click);
            // 
            // tileAgregarEspacio
            // 
            this.tileAgregarEspacio.ActiveControl = null;
            this.tileAgregarEspacio.Location = new System.Drawing.Point(382, 28);
            this.tileAgregarEspacio.Name = "tileAgregarEspacio";
            this.tileAgregarEspacio.Size = new System.Drawing.Size(147, 111);
            this.tileAgregarEspacio.TabIndex = 5;
            this.tileAgregarEspacio.Text = "Agregar Ubicacion";
            this.tileAgregarEspacio.TileImage = ((System.Drawing.Image)(resources.GetObject("tileAgregarEspacio.TileImage")));
            this.tileAgregarEspacio.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileAgregarEspacio.UseSelectable = true;
            this.tileAgregarEspacio.UseTileImage = true;
            this.tileAgregarEspacio.Click += new System.EventHandler(this.tileAgregarEspacio_Click);
            // 
            // tileAgregarVehiculo
            // 
            this.tileAgregarVehiculo.ActiveControl = null;
            this.tileAgregarVehiculo.Location = new System.Drawing.Point(22, 28);
            this.tileAgregarVehiculo.Name = "tileAgregarVehiculo";
            this.tileAgregarVehiculo.Size = new System.Drawing.Size(147, 111);
            this.tileAgregarVehiculo.TabIndex = 5;
            this.tileAgregarVehiculo.Text = "Ingresar Vehiculo";
            this.tileAgregarVehiculo.TileImage = ((System.Drawing.Image)(resources.GetObject("tileAgregarVehiculo.TileImage")));
            this.tileAgregarVehiculo.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileAgregarVehiculo.UseSelectable = true;
            this.tileAgregarVehiculo.UseTileImage = true;
            this.tileAgregarVehiculo.Click += new System.EventHandler(this.metroTile11_Click);
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.Controls.Add(this.tileVerTicket);
            this.metroTabPage4.Controls.Add(this.tileRealizarPago);
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(679, 402);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "Pagos y Tickets";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // tileVerTicket
            // 
            this.tileVerTicket.ActiveControl = null;
            this.tileVerTicket.Location = new System.Drawing.Point(22, 143);
            this.tileVerTicket.Name = "tileVerTicket";
            this.tileVerTicket.Size = new System.Drawing.Size(147, 111);
            this.tileVerTicket.TabIndex = 8;
            this.tileVerTicket.Text = "Ver Ticket";
            this.tileVerTicket.TileImage = ((System.Drawing.Image)(resources.GetObject("tileVerTicket.TileImage")));
            this.tileVerTicket.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileVerTicket.UseSelectable = true;
            this.tileVerTicket.UseTileImage = true;
            this.tileVerTicket.Click += new System.EventHandler(this.tileVerTicket_Click);
            // 
            // tileRealizarPago
            // 
            this.tileRealizarPago.ActiveControl = null;
            this.tileRealizarPago.Location = new System.Drawing.Point(22, 28);
            this.tileRealizarPago.Name = "tileRealizarPago";
            this.tileRealizarPago.Size = new System.Drawing.Size(301, 109);
            this.tileRealizarPago.TabIndex = 7;
            this.tileRealizarPago.Text = "Realizar Pago";
            this.tileRealizarPago.TileImage = ((System.Drawing.Image)(resources.GetObject("tileRealizarPago.TileImage")));
            this.tileRealizarPago.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileRealizarPago.UseSelectable = true;
            this.tileRealizarPago.UseTileImage = true;
            this.tileRealizarPago.Click += new System.EventHandler(this.tileRealizarPago_Click);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.metroTile2);
            this.metroTabPage3.Controls.Add(this.metroTile1);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(679, 402);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Reportes";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(166, 17);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(147, 111);
            this.metroTile2.TabIndex = 9;
            this.metroTile2.Text = "Reporte Mensual";
            this.metroTile2.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile2.TileImage")));
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(13, 17);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(147, 111);
            this.metroTile1.TabIndex = 9;
            this.metroTile1.Text = "Cierre de Caja";
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            // 
            // metroTabPage5
            // 
            this.metroTabPage5.Controls.Add(this.tileTarifas);
            this.metroTabPage5.HorizontalScrollbarBarColor = true;
            this.metroTabPage5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.HorizontalScrollbarSize = 10;
            this.metroTabPage5.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage5.Name = "metroTabPage5";
            this.metroTabPage5.Size = new System.Drawing.Size(679, 402);
            this.metroTabPage5.TabIndex = 4;
            this.metroTabPage5.Text = "Tarifas";
            this.metroTabPage5.VerticalScrollbarBarColor = true;
            this.metroTabPage5.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.VerticalScrollbarSize = 10;
            this.metroTabPage5.Click += new System.EventHandler(this.metroTabPage5_Click);
            // 
            // tileTarifas
            // 
            this.tileTarifas.ActiveControl = null;
            this.tileTarifas.Location = new System.Drawing.Point(22, 28);
            this.tileTarifas.Name = "tileTarifas";
            this.tileTarifas.Size = new System.Drawing.Size(245, 111);
            this.tileTarifas.TabIndex = 2;
            this.tileTarifas.Text = "Modificar Tarifas";
            this.tileTarifas.TileImage = ((System.Drawing.Image)(resources.GetObject("tileTarifas.TileImage")));
            this.tileTarifas.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileTarifas.UseSelectable = true;
            this.tileTarifas.UseTileImage = true;
            this.tileTarifas.Click += new System.EventHandler(this.tileTarifas_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(643, 68);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(42, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Color";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(462, 68);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(42, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Tema";
            // 
            // mcbColor
            // 
            this.mcbColor.FormattingEnabled = true;
            this.mcbColor.ItemHeight = 23;
            this.mcbColor.Items.AddRange(new object[] {
            "Default",
            "Black",
            "White",
            "Silver",
            "Blue",
            "Green",
            "Lime",
            "Teal",
            "Orange",
            "Brown",
            "Pink",
            "Magenta",
            "Purple",
            "Red",
            "Yellow"});
            this.mcbColor.Location = new System.Drawing.Point(700, 63);
            this.mcbColor.Name = "mcbColor";
            this.mcbColor.Size = new System.Drawing.Size(93, 29);
            this.mcbColor.TabIndex = 2;
            this.mcbColor.UseSelectable = true;
            this.mcbColor.SelectedIndexChanged += new System.EventHandler(this.mcbColor_SelectedIndexChanged);
            // 
            // mcbTheme
            // 
            this.mcbTheme.FormattingEnabled = true;
            this.mcbTheme.ItemHeight = 23;
            this.mcbTheme.Items.AddRange(new object[] {
            "Dark",
            "Light"});
            this.mcbTheme.Location = new System.Drawing.Point(519, 63);
            this.mcbTheme.Name = "mcbTheme";
            this.mcbTheme.Size = new System.Drawing.Size(90, 29);
            this.mcbTheme.TabIndex = 3;
            this.mcbTheme.UseSelectable = true;
            this.mcbTheme.SelectedIndexChanged += new System.EventHandler(this.mcbTheme_SelectedIndexChanged);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = ((System.Drawing.Image)(resources.GetObject("$this.BackImage")));
            this.BackImagePadding = new System.Windows.Forms.Padding(75, 35, 10, 10);
            this.BackMaxSize = 250;
            this.ClientSize = new System.Drawing.Size(877, 581);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mcbColor);
            this.Controls.Add(this.mcbTheme);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.tileFecha.ResumeLayout(false);
            this.tileFecha.PerformLayout();
            this.tileTotalParqueos.ResumeLayout(false);
            this.tileTotalParqueos.PerformLayout();
            this.tileIngresadoHoy.ResumeLayout(false);
            this.tileHora.ResumeLayout(false);
            this.tileHora.PerformLayout();
            this.tileParqueosDisponibles.ResumeLayout(false);
            this.tileParqueosDisponibles.PerformLayout();
            this.tileParqueosOcupados.ResumeLayout(false);
            this.tileParqueosOcupados.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage4.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox mcbColor;
        private MetroFramework.Controls.MetroComboBox mcbTheme;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTile tileFecha;
        private System.Windows.Forms.Label lblFecha;
        private MetroFramework.Controls.MetroTile tileTotalParqueos;
        private System.Windows.Forms.Label lblTotalParqueos;
        private MetroFramework.Controls.MetroTile tileIngresadoHoy;
        private MetroFramework.Controls.MetroTile tileAcecaDe;
        private MetroFramework.Controls.MetroTile tileHora;
        private System.Windows.Forms.Label lblHora;
        private MetroFramework.Controls.MetroTile tileParqueosDisponibles;
        private System.Windows.Forms.Label lblParqueosDisponibles;
        private MetroFramework.Controls.MetroTile tileParqueosOcupados;
        private System.Windows.Forms.Label lblParqueosOcupados;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTile tileVerTiempo;
        private MetroFramework.Controls.MetroTile tileEliminarEspacio;
        private MetroFramework.Controls.MetroTile tileVerActivos;
        private MetroFramework.Controls.MetroTile tileEliminarVehiculo;
        private MetroFramework.Controls.MetroTile tileAgregarEspacio;
        private MetroFramework.Controls.MetroTile tileAgregarVehiculo;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private MetroFramework.Controls.MetroTabPage metroTabPage5;
        private MetroFramework.Controls.MetroTile tileTarifas;
        private MetroFramework.Controls.MetroTile tileRealizarPago;
        private MetroFramework.Controls.MetroTile tileVerTicket;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile tileEliminarEmpleado;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile tileAgregarEmpleado;
        private System.Windows.Forms.Label lblIngresosHoy;
    }
}

