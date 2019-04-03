using System;
using System.Windows.Forms;
using MetroFramework;

namespace ParqueoProyecto
{

    public partial class frmAgregarVehiculo : MetroFramework.Forms.MetroForm
    {

        AccesoDatos Comando = new AccesoDatos();

        public frmAgregarVehiculo()
        {
            InitializeComponent();
        }

        private void frmAgregarVehiculo_Load(object sender, EventArgs e)
        {
            // Cargar ubicaciones disponibles al combo box
            string consulta = "SELECT T0.NIVEL FROM UBICACION T0 WHERE ID_UBICACION NOT IN (SELECT ID_UBICACION FROM INGRES_VEHICULO WHERE OCUPACION='ACTIVO')";
            Comando.DatosComboBox(mcbIngresarUbicacion, consulta);
            cmbTipoVehiculo.SelectedIndex = 0;
        }

        private void validarPlacaVehiculo()
        {
            // Si el campo de placa esta vacio mostrar mensaje
            if( string.IsNullOrEmpty(txtIngresarPlaca.Text) )
            {
                MetroMessageBox.Show(this, "Por favor, ingrese un número de placa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } 
            else if( txtIngresarPlaca.Text.Length != 7)
            {
                MetroMessageBox.Show(this, "La placa debe tener siete digitos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string indiceSeleccionado = cmbTipoVehiculo.SelectedItem.ToString();
            string letraPlaca = txtIngresarPlaca.Text.Substring(0, 1).ToUpper();
            string mensaje = "El tipo de Vehiculo y la Serie de la placa no coinciden.";

            if (indiceSeleccionado == "Motocicleta" && letraPlaca != "M")
            {

                MetroMessageBox.Show(this, mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (indiceSeleccionado == "Vehiculo" && letraPlaca != "P")
            {
                MetroMessageBox.Show(this, mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (indiceSeleccionado == "Camion" && letraPlaca != "C")
            {
                MetroMessageBox.Show(this, mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
                IngresarVehiculo();
        }

        private void IngresarVehiculo()
        {
            string tipoVehiculo = cmbTipoVehiculo.SelectedItem.ToString().ToUpper();
            string ubicacion = mcbIngresarUbicacion.SelectedItem.ToString();
            string placa = txtIngresarPlaca.Text.ToUpper();

          //  MessageBox.Show(tipoVehiculo + "\n" + ubicacion + "\n" + placa);

            try {
                string consulta = "INSERT INTO INGRES_VEHICULO(ID_TIPO, ID_UBICACION, PLACA, FECHA_INGRESO, OCUPACION)";
                consulta += "VALUES((SELECT ID_TIPO FROM TIPO_VEHICULO WHERE DESCRIPCION = '" + tipoVehiculo +  "'), ";
                consulta += "(SELECT ID_UBICACION FROM UBICACION WHERE NIVEL = '" + ubicacion + "'), ";
                consulta += "'" + placa + "',GETDATE(),'ACTIVO')";
               

                Comando.SqlCommand(consulta);

                MetroMessageBox.Show(this, "Vehiculo ingresado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Ocurrio un error al ingresar el vehiculo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnIngresarVehiculo_Click(object sender, EventArgs e)
        {
            validarPlacaVehiculo();
        }
    }
}
