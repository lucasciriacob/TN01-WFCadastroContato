namespace WFUsandoListagem
{
    partial class FormCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            btnCadastrar = new Button();
            txtCSenha = new TextBox();
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(49, 49);
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Digite o nome de usuario...";
            txtLogin.Size = new Size(169, 23);
            txtLogin.TabIndex = 0;
            txtLogin.KeyDown += txtLogin_KeyDown;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(49, 91);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Digite a senha...";
            txtSenha.Size = new Size(169, 23);
            txtSenha.TabIndex = 1;
            txtSenha.KeyDown += txtSenha_KeyDown;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(90, 172);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 2;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtCSenha
            // 
            txtCSenha.Location = new Point(49, 132);
            txtCSenha.Name = "txtCSenha";
            txtCSenha.PasswordChar = '*';
            txtCSenha.PlaceholderText = "Confirme a senha...";
            txtCSenha.Size = new Size(169, 23);
            txtCSenha.TabIndex = 3;
            txtCSenha.KeyDown += txtCSenha_KeyDown;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 218);
            Controls.Add(txtCSenha);
            Controls.Add(btnCadastrar);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Name = "FormCadastro";
            Text = "Novo Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLogin;
        private TextBox txtSenha;
        private Button btnCadastrar;
        private TextBox txtCSenha;
    }
}