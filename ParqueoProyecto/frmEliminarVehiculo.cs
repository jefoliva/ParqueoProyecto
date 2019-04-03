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
    public partial class frmEliminarVehiculo : MetroFramework.Forms.MetroForm
    {
        AccesoDatos Comando = new AccesoDatos();
        public frmEliminarVehiculo()
        {
            InitializeComponent();
        }

        private void frmEliminarVehiculo_Load(object sender, EventArgs e)
        {
            string consulta = "";
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
