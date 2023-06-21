namespace ProgramaCadastro2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            mensagem.Visible = false;
            if (txtId.Text.Equals(""))
            {
                validaId.ForeColor = Color.Red;
                txtId.Focus();
            }
            else validaId.ForeColor = Color.Black;
            if (txtNome.Text.Equals(""))
                validaNome.ForeColor = Color.Red;
            else validaNome.ForeColor = Color.Black;
            if (txtEmail.Text.Equals(""))
                validaEmail.ForeColor = Color.Red;
            else validaEmail.ForeColor = Color.Black;
            if (txtSenha.Text.Equals(""))
                validaSenha.ForeColor = Color.Red;
            else validaSenha.ForeColor = Color.Black;
            //verificar se o nome tem no mínimo 5 e no máximo 100 caracteres

            //verificar se o email contem o @, o . e pelo menos 10 caracteres

            //verificar se a senha possui no mínimo 5 e no máximo 20 caracteres

            //mostrar as mensagens específicas para cada erro


            if (txtId.Text.Equals("") || txtNome.Text.Equals("")
                || txtEmail.Text.Equals("") || txtSenha.Text.Equals(""))
            {
                mensagem.Text = "Preencha todos os campos";
                mensagem.Visible = true;
                //ou
                MessageBox.Show("Preencha todos os campos");
            }
        }
    }
}