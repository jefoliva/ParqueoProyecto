using System;
using System.Data;
using System.Windows.Forms;
using MetroFramework;

namespace ParqueoProyecto
{
    public partial class frmVerTiempo : MetroFramework.Forms.MetroForm
    {
        AccesoDatos Comando = new AccesoDatos();
        public frmVerTiempo()
        {
            InitializeComponent();
        }

        private void frmVerTiempo_Load(object sender, EventArgs e)
        {

        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            string placa = txtIngresarPlaca.Text.ToUpper();

            // Si el campo de placa esta vacio mostrar mensaje
            if (string.IsNullOrEmpty(placa))
            {
                MetroMessageBox.Show(this, "Por favor, ingrese un número de placa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtIngresarPlaca.Text.Length != 7)
            {
                MetroMessageBox.Show(this, "La placa debe tener siete digitos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (placa.Substring(0, 1) != "M" && placa.Substring(0, 1) != "P" && placa.Substring(0, 1) != "C")
            {
                MetroMessageBox.Show(this, "Serie de placa es incorrecto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try
            {
       
                string consulta = "SELECT CONVERT(DATE,FECHA_INGRESO) AS DIA, CONVERT(TIME(0),FECHA_INGRESO) AS ";
                consulta += "HORA, CONCAT (datediff ( HOUR, FECHA_INGRESO , GETDATE() ) ,' ','HORAS') ";
                consulta += "AS TRANS  FROM INGRES_VEHICULO WHERE PLACA='" + placa + "'";

                DataTable datos = Comando.Datos(consulta);

                string fecha = "";
                string hora = "";
                string transcurrido = "";

                string foo = datos.Rows[0][0].ToString();
                fecha = foo.Split(' ')[0];
                hora = datos.Rows[0][1].ToString();
                transcurrido = datos.Rows[0][2].ToString();


                txtFechaEntrada.Text = fecha;
                txtHoraEntrada.Text = hora;
                txtTiempoTotal.Text = transcurrido;
            }
            catch(Exception)
            {
                string msg = "Ocurrio un error al buscar el numero de placa, puede que no exista un vehiculo con esa placa o que haya fallado la conexion";
                MetroMessageBox.Show(this, msg , "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }

        private void linkVerActivos_Click(object sender, EventArgs e)
        {
            var frm = new frmVerActivos();
            frm.StyleManager = this.StyleManager;

            frm.Show();

        }
    }
}
