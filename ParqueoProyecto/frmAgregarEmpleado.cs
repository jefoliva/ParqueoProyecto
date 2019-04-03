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
    public partial class frmAgregarEmpleado : MetroFramework.Forms.MetroForm
    {
        AccesoDatos comando = new AccesoDatos();
        public frmAgregarEmpleado()
        {
            InitializeComponent();
        }

        private void frmAgregarEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresarVehiculo_Click(object sender, EventArgs e)
        {
            string empleado = txtNombreEmpleado.Text;
            string consulta = "INSERT INTO EMPLEADO(NOMBRE,ACTIVO) VALUES ('" + empleado + "', 'INACTIVO')";
            
            try
            {
                comando.SqlCommand(consulta);
                MetroMessageBox.Show(this, "Empleado Agregado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, "No se pudo agregar nuevo empleado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
