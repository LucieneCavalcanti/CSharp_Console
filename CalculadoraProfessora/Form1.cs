namespace CalculadoraProfessora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void somar_Click(object sender, EventArgs e)
        {
            if (numero1.Text.Equals("")==false && numero2.Text.Equals("")==false) {
                MessageBox.Show("O resultado é " + (Int32.Parse(numero1.Text) +
                    Int32.Parse(numero2.Text)), "Soma",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                resultado.Text = Convert.ToString(Int32.Parse(numero1.Text) +
                    Int32.Parse(numero2.Text));
            } else
            {
                MessageBox.Show("Usuário inteligumento, digite os números","Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void subtrair_Click(object sender, EventArgs e)
        {
            if (numero1.Text.Equals("") == false && numero2.Text.Equals("") == false)
            {
                MessageBox.Show("O resultado é " + (Int32.Parse(numero1.Text) -
                Int32.Parse(numero2.Text)), "Subtração",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            resultado.Text = Convert.ToString(Int32.Parse(numero1.Text) -
                Int32.Parse(numero2.Text));
            }
            else
            {
                MessageBox.Show("Usuário inteligumento, digite os números", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            if (numero1.Text.Equals("") == false && numero2.Text.Equals("") == false)
            {
                int valor1 = Int32.Parse(numero1.Text);
                int valor2 = Int32.Parse(numero2.Text);
                int multiplicacao = valor1 * valor2;
                MessageBox.Show("A multiplicação é: " + multiplicacao, "Multiplicação",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resultado.Text = Convert.ToString(multiplicacao);
            }
            else
            {
                MessageBox.Show("Usuário inteligumento, digite os números", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            if (numero1.Text.Equals("") == false && numero2.Text.Equals("") == false)
            {
                MessageBox.Show("O resultado é " + (Int32.Parse(numero1.Text) /
                Int32.Parse(numero2.Text)), "Divisão",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            resultado.Text = Convert.ToString(Int32.Parse(numero1.Text) /
                Int32.Parse(numero2.Text));
            }
            else
            {
                MessageBox.Show("Usuário inteligumento, digite os números", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}