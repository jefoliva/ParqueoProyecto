using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace ParqueoProyecto
{

    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
      
        Timer hora = new Timer();
        AccesoDatos Comando = new AccesoDatos();
        string consulta;

        public frmMain()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;

            hora.Tick += new EventHandler(Actualizar_Hora);

            hora.Interval = (1000) * 1;
            hora.Enabled = true;
            hora.Start();

            lblFecha.Text = string.Empty;
            lblFecha.Text = DateTime.Now.ToLongDateString();

      

            //tileAcecaDe.Style = (MetroColorStyle) 14;
            //tileHora.Style = (MetroColorStyle) 13;
            //tileFecha.Style = (MetroColorStyle) 5;    
        }

        private void Actualizar_Hora(object sender, EventArgs e)
        {
            lblHora.Text = String.Empty;
            lblHora.AutoSize = true;
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mcbColor.SelectedIndex = 13;
            mcbTheme.SelectedIndex = 1;

            SQLDatosInicio();
        }

        public void SQLDatosInicio()
        {
            string result;
            // Total de Parqueos
            consulta = "select COUNT(ID_UBICACION) FROM UBICACION";
            result = Comando.DatosNumericos(consulta);
            lblTotalParqueos.Text = result.ToString();

            // Parqueos ocupados
            consulta = "SELECT COUNT(T0.ID_UBICACION) FROM UBICACION T0 INNER JOIN INGRES_VEHICULO T1 ON T0.ID_UBICACION = T1.ID_UBICACION WHERE T1.OCUPACION = 'ACTIVO'";
            result = Comando.DatosNumericos(consulta);
            lblParqueosOcupados.Text = result.ToString();

            // Parqueos Disponible
            consulta = "DECLARE @OCUPADO INT SET @OCUPADO = (SELECT COUNT(T0.ID_UBICACION) FROM UBICACION T0 INNER JOIN INGRES_VEHICULO T1 ON T0.ID_UBICACION = T1.ID_UBICACION WHERE T1.OCUPACION = 'ACTIVO' )";
            consulta += "DECLARE @TOTAL INT SET @TOTAL = (select COUNT(ID_UBICACION) FROM UBICACION) SELECT @TOTAL - @OCUPADO  AS ESPACIOS_LIBRES";
            result = Comando.DatosNumericos(consulta);
            lblParqueosDisponibles.Text = result.ToString();

            // Ingresos Hoy
            consulta = "DECLARE @FECHA DATE ";
            consulta += "SET @FECHA = (SELECT CONVERT(DATE,GETDATE())) ";
            consulta += "SELECT CASE WHEN SUM(TOTAL_FACTURA) IS NULL THEN '0' ELSE SUM(TOTAL_FACTURA) END AS TOTAL FROM FACTURA WHERE CONVERT(DATE,FECHA_SALIDA) = @FECHA ";
            result = Comando.DatosNumericos(consulta);
            lblIngresosHoy.Text = result; 

        }

        private void mcbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (mcbTheme.SelectedIndex)
            {
                case 0:
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                    break;
                case 1:
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
                    break;
            }
        }

        private void mcbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroStyleManager1.Style = (MetroColorStyle)Convert.ToInt32(mcbColor.SelectedIndex);
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {
           
        }

        private void metroTile11_Click(object sender, EventArgs e)
        {
            var frmAgregar = new frmAgregarVehiculo();
            frmAgregar.StyleManager = this.StyleManager;

            
            frmAgregar.ShowDialog();
            frmAgregar.Dispose();
        }

        private void tileAgregarVehiculo_Click(object sender, EventArgs e)
        {
            var frmAgregar = new frmAgregarVehiculo();
            frmAgregar.StyleManager = this.StyleManager;
            frmAgregar.ShowDialog();
            frmAgregar.Dispose();
        }

        private void tileAcecaDe_Click(object sender, EventArgs e)
        {
            var _frmAcercaDe = new frmAcercaDe();
            _frmAcercaDe.StyleManager = this.StyleManager;
            _frmAcercaDe.ShowDialog();
            _frmAcercaDe.Dispose();
        }

        private void tileEliminarVehiculo_Click(object sender, EventArgs e)
        {
            var _frmEliminarVehiculo = new frmEliminarVehiculo();

            _frmEliminarVehiculo.StyleManager = this.StyleManager;
            _frmEliminarVehiculo.ShowDialog();
            _frmEliminarVehiculo.Dispose();
        }

        private void tileVerActivos_Click(object sender, EventArgs e)
        {
            var _frmVerActivos = new frmVerActivos();
            _frmVerActivos.StyleManager = this.StyleManager;

            _frmVerActivos.ShowDialog();
            _frmVerActivos.Dispose();
        }

        private void tileAgregarEspacio_Click(object sender, EventArgs e)
        {
            var _frmAgregarEspacio = new frmAgregarEspacio();
            _frmAgregarEspacio.StyleManager = this.StyleManager;

            _frmAgregarEspacio.ShowDialog();
            _frmAgregarEspacio.Dispose();
        }

        private void tileEliminarEspacio_Click(object sender, EventArgs e)
        {
            var _frmEliminarEspacio = new frmEliminarEspacio();
            _frmEliminarEspacio.StyleManager = this.StyleManager;

            _frmEliminarEspacio.ShowDialog();
            _frmEliminarEspacio.Dispose();
        }

        private void metroTabPage5_Click(object sender, EventArgs e)
        {

        }

        private void tileTarifas_Click(object sender, EventArgs e)
        {
            var _frmTarifas = new frmTarifas();
            _frmTarifas.StyleManager = this.StyleManager;
            _frmTarifas.ShowDialog();
            _frmTarifas.Dispose();
        }

        private void tileRealizarPago_Click(object sender, EventArgs e)
        {
            var _frmRealizarPago = new frmRealizarPago();
            _frmRealizarPago.StyleManager = this.StyleManager;
            _frmRealizarPago.ShowDialog();
            _frmRealizarPago.Dispose();
        }

        private void tileVerTicket_Click(object sender, EventArgs e)
        {
            var _frmVerTicket = new frmVerTicket();
            _frmVerTicket.StyleManager = this.StyleManager;
            _frmVerTicket.ShowDialog();
            _frmVerTicket.Dispose();
        }

        private void tileVerTiempo_Click(object sender, EventArgs e)
        {
            var _frmVerTiempo = new frmVerTiempo();
            _frmVerTiempo.StyleManager = this.StyleManager;
            _frmVerTiempo.ShowDialog();
            _frmVerTiempo.Dispose();
        }

        private void tileAgregarEmpleado_Click(object sender, EventArgs e)
        {
            var _frmAgregarEmpleado = new frmAgregarEmpleado();
            _frmAgregarEmpleado.StyleManager = this.StyleManager;
            _frmAgregarEmpleado.ShowDialog();
            _frmAgregarEmpleado.Dispose();
        }

        private void tileEliminarEmpleado_Click(object sender, EventArgs e)
        {
            var _frmEliminarEmpleado = new frmEliminarEmpleado();
            _frmEliminarEmpleado.StyleManager = this.StyleManager;
            _frmEliminarEmpleado.ShowDialog();
            _frmEliminarEmpleado.Dispose();
        }
    }
}
