namespace WFAcesso
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogar = new Button();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            SuspendLayout();
            // 
            // btnLogar
            // 
            btnLogar.Location = new Point(63, 170);
            btnLogar.Name = "btnLogar";
            btnLogar.Size = new Size(75, 23);
            btnLogar.TabIndex = 0;
            btnLogar.Text = "Logar";
            btnLogar.UseVisualStyleBackColor = true;
            btnLogar.Click += btnLogar_Click;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(33, 58);
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Informe o login...";
            txtLogin.Size = new Size(135, 23);
            txtLogin.TabIndex = 3;
            txtLogin.KeyDown += txtLogin_KeyDown;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(33, 117);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Informe a senha...";
            txtSenha.Size = new Size(135, 23);
            txtSenha.TabIndex = 4;
            txtSenha.KeyDown += txtSenha_KeyDown;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(215, 218);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Controls.Add(btnLogar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Autenticação";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogar;
        private TextBox txtLogin;
        private TextBox txtSenha;
    }
}
