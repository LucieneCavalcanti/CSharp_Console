namespace Exercicio1ProvaA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Length < 20)
            {
                MessageBox.Show("O nome deve possuir pelo menos 20 caracteres");
            }
            else if (txtEmail.Text.Length < 20 || !txtEmail.Text.Contains("@")
                || !txtEmail.Text.Contains("."))
            {
                MessageBox.Show("O e-mail deve possuir pelo menos 20 caracteres, contendo @ e . ");
            }
            else if (txtSenha.Text.Length < 2 || txtSenha.Text.Length > 20)
            {
                MessageBox.Show("A senha deve possuir entre 2 e 20 caracteres");
            }
            else if (txtRG.Text.Length < 10 || txtRG.Text.Length > 15)
            {
                MessageBox.Show("O RG deve possuir entre 10 e 15 caracteres");
            }
            else MessageBox.Show("Salvo com sucesso!");
        }
    }
}