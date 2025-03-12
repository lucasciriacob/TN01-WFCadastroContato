namespace TN01_WFCadastroContato
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
            lblNome = new Label();
            lblSobrenome = new Label();
            txtNome = new TextBox();
            txtSobrenome = new TextBox();
            mkdTelefone = new MaskedTextBox();
            lblLinha = new Label();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            rdbRecado = new RadioButton();
            rdbComercial = new RadioButton();
            rdbPessoal = new RadioButton();
            lblEmail = new Label();
            btnVoltar = new Button();
            btnSalvar = new Button();
            txtEmail = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(27, 26);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // lblSobrenome
            // 
            lblSobrenome.AutoSize = true;
            lblSobrenome.Location = new Point(208, 26);
            lblSobrenome.Name = "lblSobrenome";
            lblSobrenome.Size = new Size(71, 15);
            lblSobrenome.TabIndex = 1;
            lblSobrenome.Text = "Sobrenome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(76, 23);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 2;
            // 
            // txtSobrenome
            // 
            txtSobrenome.Location = new Point(285, 23);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(100, 23);
            txtSobrenome.TabIndex = 3;
            // 
            // mkdTelefone
            // 
            mkdTelefone.Location = new Point(41, 118);
            mkdTelefone.Mask = "(99) 00000-0000";
            mkdTelefone.Name = "mkdTelefone";
            mkdTelefone.Size = new Size(114, 23);
            mkdTelefone.TabIndex = 4;
            mkdTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblLinha
            // 
            lblLinha.BorderStyle = BorderStyle.Fixed3D;
            lblLinha.Location = new Point(27, 74);
            lblLinha.Name = "lblLinha";
            lblLinha.Size = new Size(420, 1);
            lblLinha.TabIndex = 5;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(27, 171);
            label1.Name = "label1";
            label1.Size = new Size(420, 1);
            label1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 89);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 7;
            label2.Text = "DDD/Telefone:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbRecado);
            groupBox1.Controls.Add(rdbComercial);
            groupBox1.Controls.Add(rdbPessoal);
            groupBox1.Location = new Point(199, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(417, 70);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = " Tipo Telefone";
            // 
            // rdbRecado
            // 
            rdbRecado.AutoSize = true;
            rdbRecado.Location = new Point(300, 33);
            rdbRecado.Name = "rdbRecado";
            rdbRecado.Size = new Size(64, 19);
            rdbRecado.TabIndex = 2;
            rdbRecado.TabStop = true;
            rdbRecado.Text = "Recado";
            rdbRecado.UseVisualStyleBackColor = true;
            // 
            // rdbComercial
            // 
            rdbComercial.AutoSize = true;
            rdbComercial.Location = new Point(160, 33);
            rdbComercial.Name = "rdbComercial";
            rdbComercial.Size = new Size(79, 19);
            rdbComercial.TabIndex = 1;
            rdbComercial.TabStop = true;
            rdbComercial.Text = "Comercial";
            rdbComercial.UseVisualStyleBackColor = true;
            // 
            // rdbPessoal
            // 
            rdbPessoal.AutoSize = true;
            rdbPessoal.Location = new Point(9, 33);
            rdbPessoal.Name = "rdbPessoal";
            rdbPessoal.Size = new Size(64, 19);
            rdbPessoal.TabIndex = 0;
            rdbPessoal.TabStop = true;
            rdbPessoal.Text = "Pessoal";
            rdbPessoal.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(30, 193);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email:";
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(465, 262);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(98, 51);
            btnVoltar.TabIndex = 11;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(598, 262);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(95, 51);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(94, 190);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(321, 23);
            txtEmail.TabIndex = 10;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 337);
            Controls.Add(btnSalvar);
            Controls.Add(btnVoltar);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblLinha);
            Controls.Add(mkdTelefone);
            Controls.Add(txtSobrenome);
            Controls.Add(txtNome);
            Controls.Add(lblSobrenome);
            Controls.Add(lblNome);
            Name = "FormCadastro";
            Text = "FormCadastro";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblSobrenome;
        private TextBox txtNome;
        private TextBox txtSobrenome;
        private MaskedTextBox mkdTelefone;
        private Label lblLinha;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton rdbPessoal;
        private RadioButton rdbRecado;
        private RadioButton rdbComercial;
        private Label lblEmail;
        private Button btnVoltar;
        private Button btnSalvar;
        private TextBox txtEmail;
    }
}