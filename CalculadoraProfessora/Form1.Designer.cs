namespace CalculadoraProfessora
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
            numero1 = new TextBox();
            numero2 = new TextBox();
            label2 = new Label();
            somar = new Button();
            subtrair = new Button();
            multiplicar = new Button();
            dividir = new Button();
            resultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 49);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Número 1";
            // 
            // numero1
            // 
            numero1.Location = new Point(162, 41);
            numero1.Name = "numero1";
            numero1.Size = new Size(157, 23);
            numero1.TabIndex = 1;
            // 
            // numero2
            // 
            numero2.Location = new Point(162, 80);
            numero2.Name = "numero2";
            numero2.Size = new Size(157, 23);
            numero2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 88);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Número 2";
            // 
            // somar
            // 
            somar.Location = new Point(339, 40);
            somar.Name = "somar";
            somar.Size = new Size(107, 23);
            somar.TabIndex = 4;
            somar.Text = "Soma";
            somar.UseVisualStyleBackColor = true;
            somar.Click += somar_Click;
            // 
            // subtrair
            // 
            subtrair.Location = new Point(339, 80);
            subtrair.Name = "subtrair";
            subtrair.Size = new Size(107, 23);
            subtrair.TabIndex = 5;
            subtrair.Text = "Subtração";
            subtrair.UseVisualStyleBackColor = true;
            subtrair.Click += subtrair_Click;
            // 
            // multiplicar
            // 
            multiplicar.Location = new Point(339, 122);
            multiplicar.Name = "multiplicar";
            multiplicar.Size = new Size(107, 23);
            multiplicar.TabIndex = 6;
            multiplicar.Text = "Multiplicação";
            multiplicar.UseVisualStyleBackColor = true;
            multiplicar.Click += multiplicar_Click;
            // 
            // dividir
            // 
            dividir.Location = new Point(339, 165);
            dividir.Name = "dividir";
            dividir.Size = new Size(107, 23);
            dividir.TabIndex = 7;
            dividir.Text = "Divisão";
            dividir.UseVisualStyleBackColor = true;
            dividir.Click += dividir_Click;
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Font = new Font("Swis721 Ex BT", 24F, FontStyle.Regular, GraphicsUnit.Point);
            resultado.Location = new Point(186, 149);
            resultado.Name = "resultado";
            resultado.Size = new Size(38, 39);
            resultado.TabIndex = 8;
            resultado.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 222);
            Controls.Add(resultado);
            Controls.Add(dividir);
            Controls.Add(multiplicar);
            Controls.Add(subtrair);
            Controls.Add(somar);
            Controls.Add(numero2);
            Controls.Add(label2);
            Controls.Add(numero1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox numero1;
        private TextBox numero2;
        private Label label2;
        private Button somar;
        private Button subtrair;
        private Button multiplicar;
        private Button dividir;
        private Label resultado;
    }
}