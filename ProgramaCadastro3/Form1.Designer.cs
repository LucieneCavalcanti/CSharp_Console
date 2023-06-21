namespace ProgramaCadastro2
{
    partial class Form1
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
            label1 = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            btSalvar = new Button();
            txtSenha = new TextBox();
            label4 = new Label();
            mensagem = new Label();
            validaNome = new Label();
            validaEmail = new Label();
            validaSenha = new Label();
            validaId = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 26);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "id";
            // 
            // txtId
            // 
            txtId.Location = new Point(39, 44);
            txtId.Name = "txtId";
            txtId.Size = new Size(66, 23);
            txtId.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(39, 104);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(325, 23);
            txtNome.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 86);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(39, 159);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(325, 23);
            txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 141);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 4;
            label3.Text = "E-mail";
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(39, 252);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(98, 44);
            btSalvar.TabIndex = 6;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(39, 208);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(325, 23);
            txtSenha.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 190);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 8;
            label4.Text = "Senha";
            // 
            // mensagem
            // 
            mensagem.ForeColor = Color.Red;
            mensagem.Location = new Point(412, 44);
            mensagem.Name = "mensagem";
            mensagem.Size = new Size(241, 205);
            mensagem.TabIndex = 9;
            mensagem.Text = "label5";
            mensagem.Visible = false;
            // 
            // validaNome
            // 
            validaNome.AutoSize = true;
            validaNome.Location = new Point(370, 107);
            validaNome.Name = "validaNome";
            validaNome.Size = new Size(12, 15);
            validaNome.TabIndex = 10;
            validaNome.Text = "*";
            // 
            // validaEmail
            // 
            validaEmail.AutoSize = true;
            validaEmail.Location = new Point(370, 162);
            validaEmail.Name = "validaEmail";
            validaEmail.Size = new Size(12, 15);
            validaEmail.TabIndex = 11;
            validaEmail.Text = "*";
            // 
            // validaSenha
            // 
            validaSenha.AutoSize = true;
            validaSenha.Location = new Point(370, 211);
            validaSenha.Name = "validaSenha";
            validaSenha.Size = new Size(12, 15);
            validaSenha.TabIndex = 12;
            validaSenha.Text = "*";
            // 
            // validaId
            // 
            validaId.AutoSize = true;
            validaId.Location = new Point(111, 47);
            validaId.Name = "validaId";
            validaId.Size = new Size(12, 15);
            validaId.TabIndex = 13;
            validaId.Text = "*";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 316);
            Controls.Add(validaId);
            Controls.Add(validaSenha);
            Controls.Add(validaEmail);
            Controls.Add(validaNome);
            Controls.Add(mensagem);
            Controls.Add(label4);
            Controls.Add(txtSenha);
            Controls.Add(btSalvar);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private Button btSalvar;
        private TextBox txtSenha;
        private Label label4;
        private Label mensagem;
        private Label validaNome;
        private Label validaEmail;
        private Label validaSenha;
        private Label validaId;
    }
}