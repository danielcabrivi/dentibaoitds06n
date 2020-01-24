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
    public partial class FrmProfessor : Form
    {
        List<Professor> listProf; //Lista de professor

        public FrmProfessor()
        {
            InitializeComponent();

            listProf = new List<Professor>();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Professor prof = new Professor();

            DialogResult op = MessageBox.Show("Deseja salvar?", "Salvando...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (op == DialogResult.Yes)
            {
                prof.Nome = txtNome.Text;
                //prof.dataNascimento = dtpNascimento.Value;
                //prof.salario = Double.Parse(txtSalario.Text);
                prof.cpf = txtCpf.Text;

                MessageBox.Show(prof.Nome, "Salvou!");

                listProf.Add(prof);

                dgvDados.DataSource = null;
                dgvDados.DataSource = listProf;
                
                
            }

            
        }
    }
}
