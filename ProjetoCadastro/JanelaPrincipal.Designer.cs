namespace ProjetoCadastro
{
    partial class JanelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaPrincipal));
            button1 = new Button();
            btAluno = new Button();
            btAula = new Button();
            btRelatorios = new Button();
            btPagamento = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(12, 21);
            button1.Name = "button1";
            button1.Size = new Size(94, 83);
            button1.TabIndex = 0;
            button1.Text = "Professor";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btAluno
            // 
            btAluno.Image = (Image)resources.GetObject("btAluno.Image");
            btAluno.ImageAlign = ContentAlignment.TopCenter;
            btAluno.Location = new Point(12, 110);
            btAluno.Name = "btAluno";
            btAluno.Size = new Size(94, 83);
            btAluno.TabIndex = 1;
            btAluno.Text = "Aluno";
            btAluno.TextAlign = ContentAlignment.BottomCenter;
            btAluno.UseVisualStyleBackColor = true;
            btAluno.Click += btAluno_Click;
            // 
            // btAula
            // 
            btAula.Image = (Image)resources.GetObject("btAula.Image");
            btAula.ImageAlign = ContentAlignment.TopCenter;
            btAula.Location = new Point(12, 199);
            btAula.Name = "btAula";
            btAula.Size = new Size(94, 83);
            btAula.TabIndex = 2;
            btAula.Text = "Aula";
            btAula.TextAlign = ContentAlignment.BottomCenter;
            btAula.UseVisualStyleBackColor = true;
            btAula.Click += btAula_Click;
            // 
            // btRelatorios
            // 
            btRelatorios.Image = (Image)resources.GetObject("btRelatorios.Image");
            btRelatorios.ImageAlign = ContentAlignment.TopCenter;
            btRelatorios.Location = new Point(12, 288);
            btRelatorios.Name = "btRelatorios";
            btRelatorios.Size = new Size(94, 83);
            btRelatorios.TabIndex = 3;
            btRelatorios.Text = "Relatórios";
            btRelatorios.TextAlign = ContentAlignment.BottomCenter;
            btRelatorios.UseVisualStyleBackColor = true;
            // 
            // btPagamento
            // 
            btPagamento.Image = (Image)resources.GetObject("btPagamento.Image");
            btPagamento.ImageAlign = ContentAlignment.TopCenter;
            btPagamento.Location = new Point(12, 377);
            btPagamento.Name = "btPagamento";
            btPagamento.Size = new Size(94, 83);
            btPagamento.TabIndex = 4;
            btPagamento.Text = "Pagamento";
            btPagamento.TextAlign = ContentAlignment.BottomCenter;
            btPagamento.UseVisualStyleBackColor = true;
            // 
            // JanelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 471);
            Controls.Add(btPagamento);
            Controls.Add(btRelatorios);
            Controls.Add(btAula);
            Controls.Add(btAluno);
            Controls.Add(button1);
            IsMdiContainer = true;
            Name = "JanelaPrincipal";
            Text = "JanelaPrincipal";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btAluno;
        private Button btAula;
        private Button btRelatorios;
        private Button btPagamento;
    }
}