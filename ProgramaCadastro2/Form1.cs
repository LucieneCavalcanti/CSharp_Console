using MySql.Data.MySqlClient;
using Mysqlx.Connection;
using System.CodeDom;

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
            string texto = "";
            if (txtId.Text.Equals(""))
                texto = "Erro: Digite o ID para Salvar.";
            if (txtNome.Text.Equals(""))
                texto += "\nErro: Digite o NOME para Salvar.";
            if (txtEmail.Text.Equals(""))
                texto += "\nErro: Digite o E-MAIL para Salvar.";
            if (txtSenha.Text.Equals(""))
                texto += "\nErro: Digite o SENHA para Salvar.";

            if (texto.Length > 0)
            {
                mensagem.Text = texto;
                mensagem.Visible = true;
            }
            else
                mensagem.Visible = false;


        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var cn = new MySqlConnection(Conn.strConn))
                {
                    cn.Open();
                    MessageBox.Show("Tudo ok");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}