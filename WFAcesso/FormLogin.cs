using System.Windows.Forms;

namespace WFAcesso
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            Usuario us = new Usuario();
            us.Codigo = 1;
            us.Login = "admin";
            us.Senha = "admin";
            us.DataCadastro = Convert.ToDateTime("01/01/2000");
            Usuario.ListaUsuarios.Add(us);

            us = new Usuario();
            us.Codigo = 2;
            us.Login = "user";
            us.Senha = "user";
            us.DataCadastro = Convert.ToDateTime("01/01/2020");
            Usuario.ListaUsuarios.Add(us);

        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            Usuario TelaUsuario = new Usuario();
            TelaUsuario.Login = txtLogin.Text;
            TelaUsuario.Senha = txtSenha.Text;

            foreach (Usuario user in Usuario.ListaUsuarios)
            {
                if (user.Login == TelaUsuario.Login && user.Senha == TelaUsuario.Senha)
                {
                    MessageBox.Show("Usuário logado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
            MessageBox.Show("Usuário ou senha inválidos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        private void txtLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtSenha.Focus();

        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogar_Click(sender, e);
        }
    }
}
