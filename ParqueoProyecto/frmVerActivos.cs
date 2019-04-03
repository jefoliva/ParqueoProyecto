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
    public partial class frmVerActivos : MetroFramework.Forms.MetroForm
    {
        public frmVerActivos()
        {
            InitializeComponent();
        }

        private void frmVerActivos_Load(object sender, EventArgs e)
        {
            gridVerActivos.StyleManager = this.StyleManager;

            AccesoDatos comando = new AccesoDatos();
            string consulta = "SELECT T0.PLACA, T1.NIVEL, T2.DESCRIPCION, CONVERT (DATE,T0.FECHA_INGRESO)";
            consulta += " AS FECHA FROM INGRES_VEHICULO T0 INNER JOIN UBICACION T1 ON T0.ID_UBICACION=T1.ID_UBICACION ";
            consulta += " INNER JOIN TIPO_VEHICULO T2 ON T0.ID_TIPO=T2.ID_TIPO WHERE T0.OCUPACION='ACTIVO'";


            gridVerActivos.DataSource = comando.Datos(consulta);
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
