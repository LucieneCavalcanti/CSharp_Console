namespace ProjetoCadastro
{
    partial class CadAula
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
            lblid = new Label();
            txtId = new TextBox();
            txtDescricao = new TextBox();
            label2 = new Label();
            cbAluno = new ComboBox();
            label3 = new Label();
            dtAula = new DateTimePicker();
            label4 = new Label();
            txtValor = new MaskedTextBox();
            label5 = new Label();
            cbStatus = new ComboBox();
            label1 = new Label();
            btSalvar = new Button();
            label6 = new Label();
            cbProfessor = new ComboBox();
            SuspendLayout();
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Location = new Point(41, 24);
            lblid.Name = "lblid";
            lblid.Size = new Size(17, 15);
            lblid.TabIndex = 0;
            lblid.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(41, 42);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 1;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(41, 92);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(292, 23);
            txtDescricao.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 74);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 2;
            label2.Text = "Descrição";
            // 
            // cbAluno
            // 
            cbAluno.FormattingEnabled = true;
            cbAluno.Location = new Point(41, 147);
            cbAluno.Name = "cbAluno";
            cbAluno.Size = new Size(292, 23);
            cbAluno.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 129);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 5;
            label3.Text = "Aluno";
            // 
            // dtAula
            // 
            dtAula.Location = new Point(41, 256);
            dtAula.Name = "dtAula";
            dtAula.Size = new Size(292, 23);
            dtAula.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 238);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 7;
            label4.Text = "Data da Aula";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(41, 312);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(125, 23);
            txtValor.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 294);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 9;
            label5.Text = "Valor";
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Agendada", "Realizada", "A pagar", "Pago" });
            cbStatus.Location = new Point(198, 312);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(135, 23);
            cbStatus.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(198, 294);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 11;
            label1.Text = "Status";
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(120, 363);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(125, 40);
            btSalvar.TabIndex = 12;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 184);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 14;
            label6.Text = "Professor";
            // 
            // cbProfessor
            // 
            cbProfessor.FormattingEnabled = true;
            cbProfessor.Location = new Point(41, 202);
            cbProfessor.Name = "cbProfessor";
            cbProfessor.Size = new Size(292, 23);
            cbProfessor.TabIndex = 13;
            // 
            // CadAula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 441);
            Controls.Add(label6);
            Controls.Add(cbProfessor);
            Controls.Add(btSalvar);
            Controls.Add(label1);
            Controls.Add(cbStatus);
            Controls.Add(label5);
            Controls.Add(txtValor);
            Controls.Add(label4);
            Controls.Add(dtAula);
            Controls.Add(label3);
            Controls.Add(cbAluno);
            Controls.Add(txtDescricao);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(lblid);
            Name = "CadAula";
            Text = "CadAula";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblid;
        private TextBox txtId;
        private TextBox txtDescricao;
        private Label label2;
        private ComboBox cbAluno;
        private Label label3;
        private DateTimePicker dtAula;
        private Label label4;
        private MaskedTextBox txtValor;
        private Label label5;
        private ComboBox cbStatus;
        private Label label1;
        private Button btSalvar;
        private Label label6;
        private ComboBox cbProfessor;
    }
}