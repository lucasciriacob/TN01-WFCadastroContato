using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAcesso;

namespace WFUsandoListagem
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            u.Login = txtLogin.Text;
            u.Senha = txtSenha.Text;
            string csenha = txtCSenha.Text;
            u.Codigo = Usuario.ListaUsuarios.Count + 1000;
            u.DataCadastro = DateTime.Now;


            if (u.Senha!= csenha)
            {
                MessageBox.Show("As senhas não conferem.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Usuario.ListaUsuarios.Add(u);

            MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private void txtLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCSenha.Focus();
            }
        }

        private void txtCSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCadastrar.PerformClick();
            }
        }
    }

}
