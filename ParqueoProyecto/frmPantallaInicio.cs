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
    public partial class frmPantallaInicio : MetroFramework.Forms.MetroForm
    {
        public frmPantallaInicio()
        {
            InitializeComponent();
        }

        private void frmPantallaInicio_Load(object sender, EventArgs e)
        {
            this.Style = MetroFramework.MetroColorStyle.Red;
            mprogressBar.Style = MetroFramework.MetroColorStyle.Red;
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
