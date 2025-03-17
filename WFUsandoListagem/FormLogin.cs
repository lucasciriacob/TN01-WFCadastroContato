using System.Windows.Forms;
using WFUsandoListagem;

namespace WFAcesso
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            txtLogin.Focus();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            
            Usuario us = new Usuario();
            us.Codigo = 1000;
            us.Login = "user";
            us.Senha = "123456";
            us.DataCadastro = Convert.ToDateTime("10/01/2025 18:30");
            Usuario.ListaUsuarios.Add(us);
            

        }
        public void LimparForm()
        {
            txtLogin.Text = "";
            txtSenha.Text = "";
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
                   
                    FormMain formMain = new FormMain();
                    formMain.Show();
                    LimparForm();
                    return;

                }

            }
            MessageBox.Show("Usuário ou senha inválidos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            LimparForm();
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
