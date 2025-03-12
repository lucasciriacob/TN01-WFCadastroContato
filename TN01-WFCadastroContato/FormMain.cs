namespace TN01_WFCadastroContato
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void mnsCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastro formCadastro = new FormCadastro();
            formCadastro.ShowDialog();
        }

        private void mnsSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
