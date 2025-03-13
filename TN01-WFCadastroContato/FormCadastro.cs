using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN01_WFCadastroContato
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LimparFormulario()
        {
            txtNome.Text = "";
            txtSobrenome.Text = "";
            mkdTelefone.Text = "";
            txtEmail.Text = "";
            rdbPessoal.Checked = false;
            rdbComercial.Checked = false;
            rdbRecado.Checked = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cadastro p1 = new Cadastro();
            p1.Nome = txtNome.Text;
            p1.Sobrenome = txtSobrenome.Text;
            p1.DddTelefone = mkdTelefone.Text;
            p1.Email = txtEmail.Text;
            if (string.IsNullOrEmpty(p1.Nome) || string.IsNullOrEmpty(p1.Sobrenome) || string.IsNullOrEmpty(p1.DddTelefone) || string.IsNullOrEmpty(p1.Email))
            {
                MessageBox.Show("Faltou preencher algum campo!", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (rdbPessoal.Checked)
            {
                p1.TipoTelefone = "Pessoal";
            }
            else if (rdbComercial.Checked)
            {
                p1.TipoTelefone = "Comercial";
            }
            else if (rdbRecado.Checked)
            {
                p1.TipoTelefone = "Recado";
            }
            else
            {
                MessageBox.Show("Faltou marcar o tipo de telefone!", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cadastro.ListaPessoas.Add(p1);
            MessageBox.Show($"Olá {p1.Nome} {p1.Sobrenome} \n {p1.DddTelefone} \n {p1.TipoTelefone} \n {p1.Email} \n seu cadastrado foi concluido com sucesso!", "Sucesso",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparFormulario();
        }
        
    }
}
