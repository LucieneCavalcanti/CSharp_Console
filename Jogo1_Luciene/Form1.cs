namespace Jogo1_Luciene
{
    public partial class Form1 : Form
    {
        string[] palavras = new string[10] {
            "C A S __",
            "B __ L A",
            "B __ T __ T __",
            "C A B __ L O",
            "C A B __ D E",
            "D A D __",
            "G __ T O",
            "C __ R R O",
            "C H O C O L A T __",
            "C __ M __"};
        string[] palavrasCorretas = new string[10] {
            "C A S A",
            "B O L A",
            "B A T A T A",
            "C A B E L O",
            "C A B I D E",
            "D A D O",
            "G A T O",
            "C A R R O",
            "C H O C O L A T E",
            "C A M A"};

        string[] letrasFaltantes = new string[10] {
            "A", "O", "A", "E", "I",
            "O","A","A","E","A"};
        int contadorJogadas = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btLetra1_Click(object sender, EventArgs e)
        {
            corrigir(btLetra1.Text);
        }

        private void btLetra3_Click(object sender, EventArgs e)
        {
            corrigir(btLetra3.Text);
        }

        private void btLetra4_Click(object sender, EventArgs e)
        {
            corrigir(btLetra4.Text);
        }

        private void btLetra2_Click(object sender, EventArgs e)
        {
            corrigir(btLetra2.Text);
        }

        private void btProxima_Click(object sender, EventArgs e)
        {
            if (contadorJogadas < palavras.Length)
            {
                lblPalavra.ForeColor = Color.Black;
                lblPalavra.Text = palavras[contadorJogadas];
                btProxima.Visible = false;
                btLetra1.Enabled = true;
                btLetra2.Enabled = true;
                btLetra3.Enabled = true;
                btLetra4.Enabled = true;
                btLetra5.Enabled = true;
                btLetra5.Enabled = true;
                button5.Enabled = true;
                button4.Enabled = true;
                button3.Enabled = true;
                button2.Enabled = true;
                button1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Você terminou!!");
                Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblPalavra.Text = palavras[contadorJogadas];
            btLetra1.Text = "A";
            btLetra2.Text = "E";
            btLetra3.Text = "I";
            btLetra4.Text = "O";
            btLetra5.Text = "U";
            btLetra1.Enabled = true;
            btLetra2.Enabled = true;
            btLetra3.Enabled = true;
            btLetra4.Enabled = true;
            btLetra5.Enabled = true;
            button5.Enabled = true;
            button4.Enabled = true;
            button3.Enabled = true;
            button2.Enabled = true;
            button1.Enabled = true;
        }
        private void corrigir(string letraClicada)
        {
            if (letraClicada == letrasFaltantes[contadorJogadas])
            {
                lblPalavra.Text = palavrasCorretas[contadorJogadas];
                lblPalavra.ForeColor = Color.Red;
                MessageBox.Show("Parabéns, você acertou!");
                contadorJogadas++;
                btProxima.Visible = true;
                btLetra1.Enabled = false;
                btLetra2.Enabled = false;
                btLetra3.Enabled = false;
                btLetra4.Enabled = false;
                btLetra5.Enabled = false;
                button5.Enabled = false;
                button4.Enabled = false;
                button3.Enabled = false;
                button2.Enabled = false;
                button1.Enabled = false;
            }
            else
            {
                MessageBox.Show("Tente outra vez.");
                btProxima.Visible = false;
            }
        }

        private void btLetra5_Click(object sender, EventArgs e)
        {
            corrigir(btLetra5.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            corrigir(button1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            corrigir(button5.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            corrigir(button4.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            corrigir(button3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            corrigir(button2.Text);
        }
    }
}