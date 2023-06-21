namespace CalculadoraWindows
{
    public partial class Form1 : Form
    {
        int valorAnterior;
        int valorAtual;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            atualizarVisor("1");
        }
        private void atualizarVisor(string valor)
        {
            if (visor.Text.Equals("Erro!"))
                visor.Text = "";
            visor.Text = visor.Text + valor;
            visor.BackColor = Color.White;
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            atualizarVisor("2");
        }
        private void bt3_Click(object sender, EventArgs e)
        {
            atualizarVisor("3");
        }
        private void bt4_Click(object sender, EventArgs e)
        {
            atualizarVisor("4");
        }
        private void bt5_Click(object sender, EventArgs e)
        {
            atualizarVisor("5");
        }
        private void bt6_Click(object sender, EventArgs e)
        {
            atualizarVisor("6");
        }
        private void bt7_Click(object sender, EventArgs e)
        {
            atualizarVisor("7");
        }
        private void bt8_Click(object sender, EventArgs e)
        {
            atualizarVisor("8");
        }
        private void bt9_Click(object sender, EventArgs e)
        {
            atualizarVisor("9");
        }
        private void bt0_Click(object sender, EventArgs e)
        {
            atualizarVisor("0");
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            visor.Text = "";
            visor.BackColor = Color.White;
        }

        private void btSomar_Click(object sender, EventArgs e)
        {
            if (visor.Text.Equals("") || visor.Text.Equals("Erro!"))
                MessageBox.Show("Digite um número");
            else
            {
                valorAnterior = Int32.Parse(visor.Text);
                visor.Text = "";
                operacao = "SOMA";
            }
        }

        private void btSubtrair_Click(object sender, EventArgs e)
        {
            if (visor.Text.Equals("") || visor.Text.Equals("Erro!"))
                MessageBox.Show("Digite um número");
            else
            {
                valorAnterior = Int32.Parse(visor.Text);
                visor.Text = "";
                operacao = "SUBTRAÇÃO";
            }
        }

        private void btMultiplicar_Click(object sender, EventArgs e)
        {
            if (visor.Text.Equals("") || visor.Text.Equals("Erro!"))
                MessageBox.Show("Digite um número");
            else
            {
                valorAnterior = Int32.Parse(visor.Text);
                visor.Text = "";
                operacao = "MULTIPLICAÇÃO";
            }
        }

        private void btDividir_Click(object sender, EventArgs e)
        {
            if (visor.Text.Equals("") || visor.Text.Equals("Erro!"))
                MessageBox.Show("Digite um número");
            else
            {
                valorAnterior = Int32.Parse(visor.Text);
                visor.Text = "";
                operacao = "DIVISÃO";
            }
        }

        private void btResultado_Click(object sender, EventArgs e)
        {
            if (operacao.Equals(""))
            {
                MessageBox.Show("Selecione uma operação");
                visor.Text = "Erro!";
                visor.BackColor = Color.Yellow;
            }
            else if (visor.Text.Equals(""))
            {
                MessageBox.Show("Digite um número");
                visor.Text = "Erro!";
                visor.BackColor = Color.Yellow;
            }
            else
            {
                if (operacao.Equals("SOMA"))
                    valorAtual = valorAnterior + Int32.Parse(visor.Text);
                if (operacao.Equals("SUBTRAÇÃO"))
                    valorAtual = valorAnterior - Int32.Parse(visor.Text);
                if (operacao.Equals("MULTIPLICAÇÃO"))
                    valorAtual = valorAnterior * Int32.Parse(visor.Text);
                if (operacao.Equals("DIVISÃO"))
                    valorAtual = valorAnterior / Int32.Parse(visor.Text);
                visor.Text = valorAtual.ToString();
                valorAnterior = 0;
                operacao = "";
            }
        }
    }
}