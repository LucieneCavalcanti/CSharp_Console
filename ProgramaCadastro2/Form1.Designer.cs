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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 57);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "id";
            // 
            // txtId
            // 
            txtId.Location = new Point(113, 75);
            txtId.Name = "txtId";
            txtId.Size = new Size(66, 23);
            txtId.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(113, 135);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(325, 23);
            txtNome.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 117);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(113, 190);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(325, 23);
            txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(114, 172);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 4;
            label3.Text = "E-mail";
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(12, 63);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(63, 44);
            btSalvar.TabIndex = 6;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(113, 239);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(325, 23);
            txtSenha.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(114, 221);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 8;
            label4.Text = "Senha";
            // 
            // mensagem
            // 
            mensagem.ForeColor = Color.Red;
            mensagem.Location = new Point(495, 57);
            mensagem.Name = "mensagem";
            mensagem.Size = new Size(282, 205);
            mensagem.TabIndex = 9;
            mensagem.Text = "label5";
            mensagem.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(114, 288);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(324, 150);
            dataGridView1.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(384, 20);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private Button button1;
    }
}