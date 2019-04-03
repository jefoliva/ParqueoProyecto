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
    public partial class frmSeleccionarEmpleado : MetroFramework.Forms.MetroForm
    {
        AccesoDatos comando = new AccesoDatos();

        public frmSeleccionarEmpleado()
        {
            InitializeComponent();
        }

        private void frmSeleccionarEmpleado_Load(object sender, EventArgs e)
        {
            string consulta = "";
        }
    }
}
