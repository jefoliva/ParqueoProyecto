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
    public partial class frmRealizarPago : MetroFramework.Forms.MetroForm
    {
        AccesoDatos comando = new AccesoDatos();
        private int numMinutos = 0;
        private int numHoras = 0;
        private int numDias = 0;
        private int numSemanas = 0;
        private int numMeeses = 0;


        string consulta = "";
        public frmRealizarPago()
        {
            InitializeComponent();
        }

        private void frmRealizarPago_Load(object sender, EventArgs e)
        {
            cmbTipoPago.SelectedIndex = 0;

        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            // Validad que haya un numero de placa para cargar los datos
            // De lo contrario mostrar mensaje
            if(string.IsNullOrEmpty(txtIngresarPlaca.Text))
            {
                MetroMessageBox.Show(this, "Por favor, ingrese un número de placa para cargar los datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, 250);
            }
            else if (txtIngresarPlaca.Text.Length != 7)
            {
                MetroMessageBox.Show(this, "La placa debe tener siete digitos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string placa = txtIngresarPlaca.Text;
      
            // Obtener dia de ingreso
            consulta = "SELECT CONVERT(DATE,FECHA_INGRESO) FROM INGRES_VEHICULO WHERE PLACA= '"+ placa + "'";
            string diaIngreso = comando.DatosNumericos(consulta).Split(' ')[0];


            // Obtener hora de ingreso
            consulta = "SELECT CONVERT(time(0),FECHA_INGRESO) FROM INGRES_VEHICULO WHERE PLACA= '" + placa + "'";
            string horaIngreso = comando.DatosNumericos(consulta);

            // Obtener dia de salida
            consulta = "SELECT CONVERT(DATE,GETDATE())";
            string diaSalida = comando.DatosNumericos(consulta).Split(' ')[0];

            // Obtener hora de salida
            consulta = "SELECT CONVERT(time(0),GETDATE())";
            string horaSalida = comando.DatosNumericos(consulta);

            // Obtener tiempo transcurrido
            consulta = "DECLARE @FECHAINI AS DATETIME ";
            consulta += "DECLARE @FECHAFIN AS DATETIME ";
            consulta += "DECLARE @FECHARES AS DATETIME ";
            consulta += "SET @FECHAINI=(SELECT FECHA_INGRESO FROM INGRES_VEHICULO WHERE PLACA= '" + placa + "') ";
            consulta += "SET @FECHAFIN= GETDATE() ";
            consulta += "SET @FECHARES= @FECHAFIN-@FECHAINI ";
            consulta += "SELECT DATEDIFF( YEAR, '19000101', @FECHARES ) as anio, MONTH( @FECHARES ) -1 as meses, DAY( @FECHARES ) -1 as dia, CAST( @FECHARES AS TIME(0) ) as hora";

            //string tiempoTranscurrido = comando.DatosNumericos(consulta);

            DataTable datosTiempo = comando.Datos(consulta);

            string meses = datosTiempo.Rows[0][1].ToString();
            string dias = datosTiempo.Rows[0][2].ToString();
            string horas = datosTiempo.Rows[0][3].ToString().Split(':')[0];
            string minutos = datosTiempo.Rows[0][3].ToString().Split(':')[1];

            numMinutos = Convert.ToInt32(minutos);
            numHoras = Convert.ToInt32(horas);
            numDias = Convert.ToInt32(dias);
            numSemanas = Convert.ToInt32(dias)/7;
            numMeeses = Convert.ToInt32(meses);

            // Cargar datos obtenidos
            txtFechaEntrada.Text = diaIngreso;
            txtHoraEntrada.Text = horaIngreso;
            txtFechaSalida.Text = diaSalida;
            txtHoraSalida.Text = horaSalida;
            txtTiempoTotal.Text = meses + " meses " + dias + " dias " + horas + " horas" + minutos + " minutos.";


        }

        private void CalcularPago()
        {
            int montoTotal = 0;

            if(cmbTipoFacturacion.SelectedIndex == 0)
            {
               
            }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            var _frmVerActivos = new frmVerActivos();
            _frmVerActivos.StyleManager = this.StyleManager;
            _frmVerActivos.Show();
       
        }

        private void btnGenerarTicket_Click(object sender, EventArgs e)
        {
            var _frmTicket = new frmTicket();
            _frmTicket.StyleManager = this.StyleManager;

            _frmTicket.ShowDialog();
            _frmTicket.Dispose();
        }

        private void cmbTipoFacturacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
              Hora
                Diaria
                Semanal
                Mensual
            */
            if(cmbTipoFacturacion.Items.Contains("Hora"))

            if(cmbTipoFacturacion.SelectedIndex == 0)
                MessageBox.Show("Cobro por hora");
            else if(cmbTipoFacturacion.SelectedIndex == 1)
                MessageBox.Show("Cobro diario");
            else if (cmbTipoFacturacion.SelectedIndex == 2)
                MessageBox.Show("Cobro Semanal");
            else if (cmbTipoFacturacion.SelectedIndex == 3)
                MessageBox.Show("Cobro mensual");

        }
    }
}
