namespace ProjetoCadastro
{
    partial class CadAluno
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
            label1 = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtEndereco = new TextBox();
            label4 = new Label();
            txtTelefoneAluno = new TextBox();
            label5 = new Label();
            txtNomeResponsavel = new TextBox();
            label6 = new Label();
            txtTelefoneResponsavel = new TextBox();
            label7 = new Label();
            btSalvar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 32);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "id";
            // 
            // txtId
            // 
            txtId.Location = new Point(42, 50);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(42, 101);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(354, 23);
            txtNome.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 83);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(42, 154);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(354, 23);
            txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 136);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 4;
            label3.Text = "E-mail";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(42, 207);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(354, 23);
            txtEndereco.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 189);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 6;
            label4.Text = "Endereço";
            // 
            // txtTelefoneAluno
            // 
            txtTelefoneAluno.Location = new Point(42, 261);
            txtTelefoneAluno.Name = "txtTelefoneAluno";
            txtTelefoneAluno.Size = new Size(187, 23);
            txtTelefoneAluno.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 243);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 8;
            label5.Text = "Telefone";
            // 
            // txtNomeResponsavel
            // 
            txtNomeResponsavel.Location = new Point(39, 315);
            txtNomeResponsavel.Name = "txtNomeResponsavel";
            txtNomeResponsavel.Size = new Size(190, 23);
            txtNomeResponsavel.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 297);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 10;
            label6.Text = "Responsável";
            // 
            // txtTelefoneResponsavel
            // 
            txtTelefoneResponsavel.Location = new Point(235, 315);
            txtTelefoneResponsavel.Name = "txtTelefoneResponsavel";
            txtTelefoneResponsavel.Size = new Size(161, 23);
            txtTelefoneResponsavel.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(235, 297);
            label7.Name = "label7";
            label7.Size = new Size(119, 15);
            label7.TabIndex = 12;
            label7.Text = "Telefone Responsável";
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(149, 361);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(133, 42);
            btSalvar.TabIndex = 14;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            // 
            // CadAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 415);
            Controls.Add(btSalvar);
            Controls.Add(txtTelefoneResponsavel);
            Controls.Add(label7);
            Controls.Add(txtNomeResponsavel);
            Controls.Add(label6);
            Controls.Add(txtTelefoneAluno);
            Controls.Add(label5);
            Controls.Add(txtEndereco);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "CadAluno";
            Text = "CadAluno";
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
        private TextBox txtEndereco;
        private Label label4;
        private TextBox txtTelefoneAluno;
        private Label label5;
        private TextBox txtNomeResponsavel;
        private Label label6;
        private TextBox txtTelefoneResponsavel;
        private Label label7;
        private Button btSalvar;
    }
}