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
    public partial class frmVerTicket : MetroFramework.Forms.MetroForm
    {
        public frmVerTicket()
        {
            InitializeComponent();
        }

        private void frmVerTicket_Load(object sender, EventArgs e)
        {

        }

        private void btnVerTicket_Click(object sender, EventArgs e)
        {
            if( string.IsNullOrEmpty( txtIngresarTicket.Text ) )
               MetroFramework.MetroMessageBox.Show(this, "Por favor, ingrese un número de ticket valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, 250);
            else
            {
                var _frmTicket = new frmTicket();
                _frmTicket.StyleManager = this.StyleManager;
                _frmTicket.ShowDialog();
                _frmTicket.Dispose();
            }

        }
    }
}
