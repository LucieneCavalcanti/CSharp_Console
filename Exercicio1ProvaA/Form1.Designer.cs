namespace Exercicio1ProvaA
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
            txtNome = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            txtSenha = new TextBox();
            label3 = new Label();
            txtRG = new TextBox();
            label4 = new Label();
            btSalvar = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 51);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(126, 43);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(298, 23);
            txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(126, 88);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(298, 23);
            txtEmail.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 96);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 2;
            label2.Text = "E-mail";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(126, 136);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(298, 23);
            txtSenha.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 144);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 4;
            label3.Text = "Senha";
            // 
            // txtRG
            // 
            txtRG.Location = new Point(126, 179);
            txtRG.Name = "txtRG";
            txtRG.Size = new Size(164, 23);
            txtRG.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 187);
            label4.Name = "label4";
            label4.Size = new Size(22, 15);
            label4.TabIndex = 6;
            label4.Text = "RG";
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(140, 276);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(178, 49);
            btSalvar.TabIndex = 8;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 234);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 9;
            label5.Text = "label5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 367);
            Controls.Add(label5);
            Controls.Add(btSalvar);
            Controls.Add(txtRG);
            Controls.Add(label4);
            Controls.Add(txtSenha);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtSenha;
        private Label label3;
        private TextBox txtRG;
        private Label label4;
        private Button btSalvar;
        private Label label5;
    }
}