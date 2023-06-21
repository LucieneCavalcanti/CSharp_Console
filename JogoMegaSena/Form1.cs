namespace JogoMegaSena
{
    public partial class Form1 : Form
    {
        Random numAleatorio = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btJogar_Click(object sender, EventArgs e)
        {
            int acertos = 0;
            aposta1.BackColor = Color.White;
            aposta2.BackColor = Color.White;
            aposta3.BackColor = Color.White;
            aposta4.BackColor = Color.White;
            aposta5.BackColor = Color.White;
            aposta6.BackColor = Color.White;
            if (aposta1.Text.Equals("") || aposta2.Text.Equals("") || aposta3.Text.Equals("") || aposta4.Text.Equals("") || aposta5.Text.Equals("") || aposta6.Text.Equals(""))
            {
                MessageBox.Show("Preencha todas as apostas!");
            }
            else
            {
                int valorAposta1 = Int32.Parse(aposta1.Text);
                int valorAposta2 = Int32.Parse(aposta2.Text);
                int valorAposta3 = Int32.Parse(aposta3.Text);
                int valorAposta4 = Int32.Parse(aposta4.Text);
                int valorAposta5 = Int32.Parse(aposta5.Text);
                int valorAposta6 = Int32.Parse(aposta6.Text);
                if (valorAposta1 > 60 || valorAposta1 < 1 ||
                    valorAposta2 > 60 || valorAposta2 < 1 ||
                    valorAposta3 > 60 || valorAposta3 < 1 ||
                    valorAposta4 > 60 || valorAposta4 < 1 ||
                    valorAposta5 > 60 || valorAposta5 < 1 ||
                    valorAposta6 > 60 || valorAposta6 < 1)
                {
                    MessageBox.Show("Números de aposta inválidos.");
                }
                else
                {
                    if (valorAposta1 == valorAposta2 ||
                        valorAposta1 == valorAposta3 ||
                        valorAposta1 == valorAposta4 ||
                        valorAposta1 == valorAposta5 ||
                        valorAposta1 == valorAposta6)
                    {
                        MessageBox.Show("O valor da aposta 1 está repetido.");
                    }
                    else if (valorAposta2 == valorAposta1 ||
                        valorAposta2 == valorAposta3 ||
                        valorAposta2 == valorAposta4 ||
                        valorAposta2 == valorAposta5 ||
                        valorAposta2 == valorAposta6)
                    {
                        MessageBox.Show("O valor da aposta 2 está repetido.");
                    }
                    else if (valorAposta3 == valorAposta1 ||
                        valorAposta3 == valorAposta2 ||
                        valorAposta3 == valorAposta4 ||
                        valorAposta3 == valorAposta5 ||
                        valorAposta3 == valorAposta6)
                    {
                        MessageBox.Show("O valor da aposta 3 está repetido.");
                    }
                    else if (valorAposta4 == valorAposta1 ||
                        valorAposta4 == valorAposta2 ||
                        valorAposta4 == valorAposta3 ||
                        valorAposta4 == valorAposta5 ||
                        valorAposta4 == valorAposta6)
                    {
                        MessageBox.Show("O valor da aposta 4 está repetido.");
                    }
                    else if (valorAposta5 == valorAposta1 ||
                        valorAposta5 == valorAposta2 ||
                        valorAposta5 == valorAposta3 ||
                        valorAposta5 == valorAposta4 ||
                        valorAposta5 == valorAposta6)
                    {
                        MessageBox.Show("O valor da aposta 5 está repetido.");
                    }
                    else if (valorAposta6 == valorAposta1 ||
                        valorAposta6 == valorAposta2 ||
                        valorAposta6 == valorAposta3 ||
                        valorAposta6 == valorAposta4 ||
                        valorAposta6 == valorAposta5)
                    {
                        MessageBox.Show("O valor da aposta 6 está repetido.");
                    }


                    else //só acontece de estiver tudo ok!
                    {
                        int valorSorteio1 = 0;
                        int valorSorteio2 = 0;
                        int valorSorteio3 = 0;
                        int valorSorteio4 = 0;
                        int valorSorteio5 = 0;
                        int valorSorteio6 = 0;
                        do //faça enquanto existir algum número repetido
                        {
                            valorSorteio1 = numAleatorio.Next(1, 60);
                            valorSorteio2 = numAleatorio.Next(1, 60);
                            valorSorteio3 = numAleatorio.Next(1, 60);
                            valorSorteio4 = numAleatorio.Next(1, 60);
                            valorSorteio5 = numAleatorio.Next(1, 60);
                            valorSorteio6 = numAleatorio.Next(1, 60);
                        } while (valorSorteio1 == valorSorteio2 || valorSorteio1 == valorSorteio3 || valorSorteio1 == valorSorteio4 || valorSorteio1 == valorSorteio5 || valorSorteio1 == valorSorteio6 ||
                        valorSorteio2 == valorSorteio1 || valorSorteio2 == valorSorteio3 || valorSorteio2 == valorSorteio4 || valorSorteio2 == valorSorteio5 || valorSorteio2 == valorSorteio6 ||
                        valorSorteio3 == valorSorteio1 || valorSorteio3 == valorSorteio2 || valorSorteio3 == valorSorteio4 || valorSorteio3 == valorSorteio5 || valorSorteio3 == valorSorteio6 ||
                        valorSorteio4 == valorSorteio1 || valorSorteio4 == valorSorteio2 || valorSorteio4 == valorSorteio3 || valorSorteio4 == valorSorteio5 || valorSorteio4 == valorSorteio6 ||
                        valorSorteio5 == valorSorteio1 || valorSorteio5 == valorSorteio2 || valorSorteio5 == valorSorteio3 || valorSorteio5 == valorSorteio4 || valorSorteio5 == valorSorteio6 ||
                        valorSorteio6 == valorSorteio1 || valorSorteio6 == valorSorteio2 || valorSorteio6 == valorSorteio3 || valorSorteio6 == valorSorteio4 || valorSorteio6 == valorSorteio5);
                        //mostrar os números sorteados
                        sorteio1.Text = valorSorteio1.ToString();
                        sorteio2.Text = valorSorteio2.ToString();
                        sorteio3.Text = valorSorteio3.ToString();
                        sorteio4.Text = valorSorteio4.ToString();
                        sorteio5.Text = valorSorteio5.ToString();
                        sorteio6.Text = valorSorteio6.ToString();
                        //verificar quantos foram os acertos
                        if (aposta1.Text.Equals(sorteio1.Text) || aposta1.Text.Equals(sorteio2.Text) || aposta1.Text.Equals(sorteio3.Text) ||
                            aposta1.Text.Equals(sorteio4.Text) || aposta1.Text.Equals(sorteio5.Text) || aposta1.Text.Equals(sorteio6.Text))
                        {
                            aposta1.BackColor = Color.BlueViolet;
                            acertos++;
                        }
                        if (aposta2.Text.Equals(sorteio1.Text) || aposta2.Text.Equals(sorteio2.Text) || aposta2.Text.Equals(sorteio3.Text) ||
                            aposta2.Text.Equals(sorteio4.Text) || aposta2.Text.Equals(sorteio5.Text) || aposta2.Text.Equals(sorteio6.Text))
                        {
                            aposta2.BackColor = Color.BlueViolet;
                            acertos++;
                        }
                        if (aposta3.Text.Equals(sorteio1.Text) || aposta3.Text.Equals(sorteio2.Text) || aposta3.Text.Equals(sorteio3.Text) ||
                            aposta3.Text.Equals(sorteio4.Text) || aposta3.Text.Equals(sorteio5.Text) || aposta3.Text.Equals(sorteio6.Text))
                        {
                            aposta3.BackColor = Color.BlueViolet;
                            acertos++;
                        }
                        if (aposta4.Text.Equals(sorteio1.Text) || aposta4.Text.Equals(sorteio2.Text) || aposta4.Text.Equals(sorteio3.Text) ||
                            aposta4.Text.Equals(sorteio4.Text) || aposta4.Text.Equals(sorteio5.Text) || aposta4.Text.Equals(sorteio6.Text))
                        {
                            aposta4.BackColor = Color.BlueViolet;
                            acertos++;
                        }
                        if (aposta5.Text.Equals(sorteio1.Text) || aposta5.Text.Equals(sorteio2.Text) || aposta5.Text.Equals(sorteio3.Text) ||
                            aposta5.Text.Equals(sorteio4.Text) || aposta5.Text.Equals(sorteio5.Text) || aposta5.Text.Equals(sorteio6.Text))
                        {
                            aposta5.BackColor = Color.BlueViolet;
                            acertos++;
                        }
                        if (aposta6.Text.Equals(sorteio1.Text) || aposta6.Text.Equals(sorteio2.Text) || aposta6.Text.Equals(sorteio3.Text) ||
                            aposta6.Text.Equals(sorteio4.Text) || aposta6.Text.Equals(sorteio5.Text) || aposta6.Text.Equals(sorteio6.Text))
                        {
                            aposta6.BackColor = Color.BlueViolet;
                            acertos++;
                        }
                        resultado.Text = "Você acertou " + acertos;
                    }
                }
            }

        }
    }
}