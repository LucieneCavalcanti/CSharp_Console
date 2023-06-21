namespace Jogo1_Luciene
{
    partial class Jogo2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jogo2));
            pictureBox1 = new PictureBox();
            lblVo = new Label();
            lblPalavra = new Label();
            btLimpar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(33, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 272);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblVo
            // 
            lblVo.BackColor = Color.Transparent;
            lblVo.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblVo.ForeColor = Color.Black;
            lblVo.Location = new Point(233, 232);
            lblVo.Name = "lblVo";
            lblVo.Size = new Size(72, 42);
            lblVo.TabIndex = 1;
            lblVo.Text = "VO";
            lblVo.Click += lblVo_Click;
            // 
            // lblPalavra
            // 
            lblPalavra.AutoSize = true;
            lblPalavra.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblPalavra.Location = new Point(33, 320);
            lblPalavra.Name = "lblPalavra";
            lblPalavra.Size = new Size(0, 65);
            lblPalavra.TabIndex = 2;
            // 
            // btLimpar
            // 
            btLimpar.BackColor = Color.White;
            btLimpar.Location = new Point(334, 12);
            btLimpar.Name = "btLimpar";
            btLimpar.Size = new Size(75, 23);
            btLimpar.TabIndex = 3;
            btLimpar.Text = "Limpar";
            btLimpar.UseVisualStyleBackColor = false;
            btLimpar.Click += btLimpar_Click;
            // 
            // Jogo2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 450);
            Controls.Add(btLimpar);
            Controls.Add(lblPalavra);
            Controls.Add(lblVo);
            Controls.Add(pictureBox1);
            Name = "Jogo2";
            Text = "Jogo2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblVo;
        private Label lblPalavra;
        private Button btLimpar;
    }
}