using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo1_Luciene
{
    public partial class Jogo2 : Form
    {

        public Jogo2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblVo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicou no VO");
            lblPalavra.Text = lblPalavra.Text + "VO";
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            lblPalavra.Text = "";
        }

    }
}
