 using System;
using System.Threading;
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
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        static frmLogin _intancia;

        public static frmLogin Instancia
        {
            get
            {
                if (_intancia == null)
                    _intancia = new frmLogin();

                return _intancia;
            }
        }

        public frmLogin()
        {
            Thread t = new Thread(new ThreadStart(Cargando));
            t.Start();
            InitializeComponent();

            for (int i = 0; i < 150; i++)
                Thread.Sleep(10);

            t.Abort();
        }

        void Cargando()
        {
            var frm = new frmPantallaInicio();
            frm.StyleManager = this.StyleManager;
            Application.Run(frm);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            _intancia = this;
            this.Style = MetroFramework.MetroColorStyle.Red;
   
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Usuario Incorrecto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Contraseña incorrecta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (txtUsuario.Text == "admin" && txtContraseña.Text == "admin")
            {
                var frm = new frmMain();

                frmLogin.Instancia.Hide();
                frm.Show();

            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Usuario o contraseña invalidos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
