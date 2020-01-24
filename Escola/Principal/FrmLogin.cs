using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            String usuario, senha;

            usuario = txtUsuario.Text;
            senha = txtSenha.Text;

            if (usuario.Equals("admin") && senha.Equals("123"))
            {
                FrmProfessor fpro = new FrmProfessor();
                fpro.Show();
                this.Visible = false;
            }else{
                lblUsuario.ForeColor = Color.Red;
                lblSenha.ForeColor = Color.Red;
            }
        }
    }
}
