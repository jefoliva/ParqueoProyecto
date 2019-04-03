using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParqueoProyecto
{
    public partial class frmEliminarEspacio : MetroFramework.Forms.MetroForm
    {
        AccesoDatos comando = new AccesoDatos();
        string consulta = "";
        public frmEliminarEspacio()
        {
            InitializeComponent();
        }

        private void frmEliminarEspacio_Load(object sender, EventArgs e)
        {
            consulta = "SELECT NIVEL FROM UBICACION";
            comando.DatosComboBox(cmbEliminarEspacio, consulta);

            cmbEliminarEspacio.SelectedIndex = 0;
        }

        private void btnEliminarEspacio_Click(object sender, EventArgs e)
        {
            try {
                string ubicacion = cmbEliminarEspacio.SelectedItem.ToString();

                string consulta = "DELETE FROM UBICACION WHERE NIVEL= '" + ubicacion + "'";
                comando.SqlCommand(consulta);

                cmbEliminarEspacio.Items.Remove(ubicacion);
                cmbEliminarEspacio.SelectedIndex = 0;
                MetroMessageBox.Show(this, "Ubicacion eliminada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, "No se pudo eliminar la ubicacion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
