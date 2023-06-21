using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCadastro
{
    public partial class JanelaPrincipal : Form
    {
        public JanelaPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void btAula_Click(object sender, EventArgs e)
        {
            new CadAula().Show();
        }

        private void btAluno_Click(object sender, EventArgs e)
        {
            new CadAluno().Show();
        }
    }
}
