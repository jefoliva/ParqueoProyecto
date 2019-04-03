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
    public partial class frmEliminarEmpleado : MetroFramework.Forms.MetroForm
    {
        AccesoDatos comando = new AccesoDatos();
        public frmEliminarEmpleado()
        {
            InitializeComponent();
        }

        private void frmEliminarEmpleado_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT NOMBRE FROM EMPLEADO";
            comando.DatosComboBox(cmbEmpleado, consulta);
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            string nombreEmpleado = cmbEmpleado.SelectedItem.ToString();
            string consulta = "DELETE FROM EMPLEADO WHERE NOMBRE='" + nombreEmpleado + "'";
            
            try
            {
                comando.SqlCommand(consulta);
                cmbEmpleado.Items.Remove(nombreEmpleado);
                cmbEmpleado.SelectedIndex = 0;
                MetroMessageBox.Show(this, "Empleado Eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception)
            {
                MetroMessageBox.Show(this, "Hubo un error al eliminar el empleado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
