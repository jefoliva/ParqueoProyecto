using MetroFramework;
using System;
using System.Windows.Forms;

namespace ParqueoProyecto
{
    public partial class frmTarifas : MetroFramework.Forms.MetroForm
    {
        AccesoDatos comando = new AccesoDatos();
        string consulta = "";
        public frmTarifas()
        {
            InitializeComponent();
        }

        private void frmTarifas_Load(object sender, EventArgs e)
        {
            btnGuardarTarifa.Enabled = false;
            txtTarifaDia.Enabled = false;
            txtTarifaHora.Enabled = false;
            txtTarifaSemana.Enabled = false;
            txtTarifaMes.Enabled = false;

            cargarTarifas();
        }

        private void cargarTarifas()
        {
          
            consulta = "SELECT MONTO FROM TIPO_TARIFA WHERE DESCRIPCION = 'HORA'";
            txtTarifaHora.Text = comando.DatosNumericos(consulta);

            consulta = "SELECT MONTO FROM TIPO_TARIFA WHERE DESCRIPCION = 'DIA'";
            txtTarifaDia.Text = comando.DatosNumericos(consulta);

            consulta = "SELECT MONTO FROM TIPO_TARIFA WHERE DESCRIPCION = 'SEMANA'";
            txtTarifaSemana.Text = comando.DatosNumericos(consulta);

            consulta = "SELECT MONTO FROM TIPO_TARIFA WHERE DESCRIPCION = 'MES'";
            txtTarifaMes.Text = comando.DatosNumericos(consulta);


        }

        private void btnModificarTarifa_Click(object sender, EventArgs e)
        {

            MetroFramework.MetroMessageBox.Show(this, "Seguro que quiere modificar tarifas", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            btnGuardarTarifa.Enabled = true;

            txtTarifaDia.Enabled = true;
            txtTarifaHora.Enabled = true;
            txtTarifaSemana.Enabled = true;
            txtTarifaMes.Enabled = true;
        }

        private void btnGuardarTarifa_Click(object sender, EventArgs e)
        {
            try
            {
                int tarifaHora = Convert.ToInt32(txtTarifaHora.Text);
                int tarifaDia = Convert.ToInt32(txtTarifaDia.Text);
                int tarifaSemana = Convert.ToInt32(txtTarifaSemana.Text);
                int tarifaMes = Convert.ToInt32(txtTarifaMes.Text);

                consulta = "UPDATE TIPO_TARIFA SET MONTO= '" + tarifaHora + "' WHERE DESCRIPCION='HORA'";
                comando.SqlCommand(consulta);

                consulta = "UPDATE TIPO_TARIFA SET MONTO= '" + tarifaDia + "' WHERE DESCRIPCION='DIA'";
                comando.SqlCommand(consulta);

                consulta = "UPDATE TIPO_TARIFA SET MONTO= '" + tarifaSemana + "' WHERE DESCRIPCION='SEMANA'";
                comando.SqlCommand(consulta);

                consulta = "UPDATE TIPO_TARIFA SET MONTO= '" + tarifaMes + "' WHERE DESCRIPCION='MES'";
                comando.SqlCommand(consulta);

                MetroMessageBox.Show(this, "Las nuevas tarifas se han guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "Ocurrió un error al guardar las tarifas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
