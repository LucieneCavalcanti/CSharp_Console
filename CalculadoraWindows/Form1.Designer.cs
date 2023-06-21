namespace CalculadoraWindows
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
            bt1 = new Button();
            bt2 = new Button();
            bt3 = new Button();
            bt4 = new Button();
            bt5 = new Button();
            bt6 = new Button();
            bt7 = new Button();
            bt8 = new Button();
            bt9 = new Button();
            bt0 = new Button();
            visor = new Label();
            btSomar = new Button();
            btLimpar = new Button();
            btSubtrair = new Button();
            btMultiplicar = new Button();
            btDividir = new Button();
            btResultado = new Button();
            groupBox1 = new GroupBox();
            btSurpresa = new Button();
            btExp = new Button();
            btMod = new Button();
            btRaiz = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // bt1
            // 
            bt1.Location = new Point(44, 99);
            bt1.Name = "bt1";
            bt1.Size = new Size(75, 36);
            bt1.TabIndex = 0;
            bt1.Text = "1";
            bt1.UseVisualStyleBackColor = true;
            bt1.Click += bt1_Click;
            // 
            // bt2
            // 
            bt2.Location = new Point(125, 99);
            bt2.Name = "bt2";
            bt2.Size = new Size(75, 36);
            bt2.TabIndex = 1;
            bt2.Text = "2";
            bt2.UseVisualStyleBackColor = true;
            bt2.Click += bt2_Click;
            // 
            // bt3
            // 
            bt3.Location = new Point(206, 99);
            bt3.Name = "bt3";
            bt3.Size = new Size(75, 36);
            bt3.TabIndex = 2;
            bt3.Text = "3";
            bt3.UseVisualStyleBackColor = true;
            bt3.Click += bt3_Click;
            // 
            // bt4
            // 
            bt4.Location = new Point(44, 141);
            bt4.Name = "bt4";
            bt4.Size = new Size(75, 36);
            bt4.TabIndex = 3;
            bt4.Text = "4";
            bt4.UseVisualStyleBackColor = true;
            bt4.Click += bt4_Click;
            // 
            // bt5
            // 
            bt5.Location = new Point(125, 141);
            bt5.Name = "bt5";
            bt5.Size = new Size(75, 36);
            bt5.TabIndex = 4;
            bt5.Text = "5";
            bt5.UseVisualStyleBackColor = true;
            bt5.Click += bt5_Click;
            // 
            // bt6
            // 
            bt6.Location = new Point(206, 141);
            bt6.Name = "bt6";
            bt6.Size = new Size(75, 36);
            bt6.TabIndex = 5;
            bt6.Text = "6";
            bt6.UseVisualStyleBackColor = true;
            bt6.Click += bt6_Click;
            // 
            // bt7
            // 
            bt7.Location = new Point(44, 183);
            bt7.Name = "bt7";
            bt7.Size = new Size(75, 36);
            bt7.TabIndex = 6;
            bt7.Text = "7";
            bt7.UseVisualStyleBackColor = true;
            bt7.Click += bt7_Click;
            // 
            // bt8
            // 
            bt8.Location = new Point(125, 183);
            bt8.Name = "bt8";
            bt8.Size = new Size(75, 36);
            bt8.TabIndex = 7;
            bt8.Text = "8";
            bt8.UseVisualStyleBackColor = true;
            bt8.Click += bt8_Click;
            // 
            // bt9
            // 
            bt9.Location = new Point(206, 183);
            bt9.Name = "bt9";
            bt9.Size = new Size(75, 36);
            bt9.TabIndex = 8;
            bt9.Text = "9";
            bt9.UseVisualStyleBackColor = true;
            bt9.Click += bt9_Click;
            // 
            // bt0
            // 
            bt0.Location = new Point(125, 225);
            bt0.Name = "bt0";
            bt0.Size = new Size(75, 36);
            bt0.TabIndex = 9;
            bt0.Text = "0";
            bt0.UseVisualStyleBackColor = true;
            bt0.Click += bt0_Click;
            // 
            // visor
            // 
            visor.BackColor = SystemColors.ControlLight;
            visor.BorderStyle = BorderStyle.FixedSingle;
            visor.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            visor.ForeColor = Color.Red;
            visor.Location = new Point(44, 32);
            visor.Name = "visor";
            visor.Size = new Size(237, 53);
            visor.TabIndex = 10;
            visor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btSomar
            // 
            btSomar.BackColor = Color.FromArgb(192, 255, 192);
            btSomar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btSomar.Location = new Point(287, 99);
            btSomar.Name = "btSomar";
            btSomar.Size = new Size(75, 36);
            btSomar.TabIndex = 11;
            btSomar.Text = "+";
            btSomar.UseVisualStyleBackColor = false;
            btSomar.Click += btSomar_Click;
            // 
            // btLimpar
            // 
            btLimpar.BackColor = Color.FromArgb(192, 255, 255);
            btLimpar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btLimpar.Location = new Point(287, 32);
            btLimpar.Name = "btLimpar";
            btLimpar.Size = new Size(75, 53);
            btLimpar.TabIndex = 12;
            btLimpar.Text = "Limpar";
            btLimpar.UseVisualStyleBackColor = false;
            btLimpar.Click += btLimpar_Click;
            // 
            // btSubtrair
            // 
            btSubtrair.BackColor = Color.FromArgb(255, 255, 192);
            btSubtrair.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btSubtrair.Location = new Point(287, 141);
            btSubtrair.Name = "btSubtrair";
            btSubtrair.Size = new Size(75, 36);
            btSubtrair.TabIndex = 13;
            btSubtrair.Text = "-";
            btSubtrair.UseVisualStyleBackColor = false;
            btSubtrair.Click += btSubtrair_Click;
            // 
            // btMultiplicar
            // 
            btMultiplicar.BackColor = Color.FromArgb(255, 224, 192);
            btMultiplicar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btMultiplicar.Location = new Point(287, 183);
            btMultiplicar.Name = "btMultiplicar";
            btMultiplicar.Size = new Size(75, 36);
            btMultiplicar.TabIndex = 14;
            btMultiplicar.Text = "X";
            btMultiplicar.UseVisualStyleBackColor = false;
            btMultiplicar.Click += btMultiplicar_Click;
            // 
            // btDividir
            // 
            btDividir.BackColor = Color.FromArgb(255, 192, 192);
            btDividir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btDividir.Location = new Point(287, 225);
            btDividir.Name = "btDividir";
            btDividir.Size = new Size(75, 36);
            btDividir.TabIndex = 15;
            btDividir.Text = "/";
            btDividir.UseVisualStyleBackColor = false;
            btDividir.Click += btDividir_Click;
            // 
            // btResultado
            // 
            btResultado.BackColor = Color.FromArgb(255, 128, 0);
            btResultado.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btResultado.Location = new Point(44, 267);
            btResultado.Name = "btResultado";
            btResultado.Size = new Size(471, 40);
            btResultado.TabIndex = 16;
            btResultado.Text = "Resultado";
            btResultado.UseVisualStyleBackColor = false;
            btResultado.Click += btResultado_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btSurpresa);
            groupBox1.Controls.Add(btExp);
            groupBox1.Controls.Add(btMod);
            groupBox1.Controls.Add(btRaiz);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(381, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(134, 228);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Avançado";
            // 
            // btSurpresa
            // 
            btSurpresa.BackColor = Color.FromArgb(255, 128, 128);
            btSurpresa.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btSurpresa.Location = new Point(29, 179);
            btSurpresa.Name = "btSurpresa";
            btSurpresa.Size = new Size(75, 36);
            btSurpresa.TabIndex = 19;
            btSurpresa.Text = "???";
            btSurpresa.UseVisualStyleBackColor = false;
            // 
            // btExp
            // 
            btExp.BackColor = Color.FromArgb(255, 192, 128);
            btExp.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btExp.Location = new Point(29, 137);
            btExp.Name = "btExp";
            btExp.Size = new Size(75, 36);
            btExp.TabIndex = 18;
            btExp.Text = "EXP";
            btExp.UseVisualStyleBackColor = false;
            // 
            // btMod
            // 
            btMod.BackColor = Color.FromArgb(255, 255, 128);
            btMod.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btMod.Location = new Point(29, 95);
            btMod.Name = "btMod";
            btMod.Size = new Size(75, 36);
            btMod.TabIndex = 17;
            btMod.Text = "MOD";
            btMod.UseVisualStyleBackColor = false;
            // 
            // btRaiz
            // 
            btRaiz.BackColor = Color.FromArgb(128, 255, 128);
            btRaiz.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btRaiz.Location = new Point(29, 53);
            btRaiz.Name = "btRaiz";
            btRaiz.Size = new Size(75, 36);
            btRaiz.TabIndex = 16;
            btRaiz.Text = "Raiz";
            btRaiz.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 334);
            Controls.Add(groupBox1);
            Controls.Add(btResultado);
            Controls.Add(btDividir);
            Controls.Add(btMultiplicar);
            Controls.Add(btSubtrair);
            Controls.Add(btLimpar);
            Controls.Add(btSomar);
            Controls.Add(visor);
            Controls.Add(bt0);
            Controls.Add(bt9);
            Controls.Add(bt8);
            Controls.Add(bt7);
            Controls.Add(bt6);
            Controls.Add(bt5);
            Controls.Add(bt4);
            Controls.Add(bt3);
            Controls.Add(bt2);
            Controls.Add(bt1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button bt1;
        private Button bt2;
        private Button bt3;
        private Button bt4;
        private Button bt5;
        private Button bt6;
        private Button bt7;
        private Button bt8;
        private Button bt9;
        private Button bt0;
        private Label visor;
        private Button btSomar;
        private Button btLimpar;
        private Button btSubtrair;
        private Button btMultiplicar;
        private Button btDividir;
        private Button btResultado;
        private GroupBox groupBox1;
        private Button btSurpresa;
        private Button btExp;
        private Button btMod;
        private Button btRaiz;
    }
}