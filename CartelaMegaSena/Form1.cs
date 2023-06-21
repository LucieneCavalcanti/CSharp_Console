namespace CartelaMegaSena
{
    public partial class Form1 : Form
    {
        int contadorDeNumeros = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btJogar_Click(object sender, EventArgs e)
        {

        }
        private void contarNumeros(CheckBox bt)
        {
            if (contadorDeNumeros < 6) contadorDeNumeros++;
            else if(bt.Checked == false) // faz nada
                if (contadorDeNumeros == 6)
                {
                    MessageBox.Show("Escolha no máximo 6 números.");
                    bt.Checked = false;
                }else
                {
                    contadorDeNumeros--;
                }
            
            //MessageBox.Show(contadorDeNumeros.ToString());
        }
        private void tratarBotoes(bool contadorDeNumeros)
        {
            
        }

        private void bt47_CheckedChanged(object sender, EventArgs e)
        {
            contarNumeros(bt47);
        }

        private void bt1_CheckedChanged(object sender, EventArgs e)
        {
            contarNumeros(bt1);
        }

        private void bt2_CheckedChanged(object sender, EventArgs e)
        {
            contarNumeros(bt2);
        }

        private void bt3_CheckedChanged(object sender, EventArgs e)
        {
            contarNumeros(bt3);
        }

        private void bt4_CheckedChanged(object sender, EventArgs e)
        {
            contarNumeros(bt4);
        }

        private void bt5_CheckedChanged(object sender, EventArgs e)
        {
            contarNumeros(bt5);
        }

        private void bt6_CheckedChanged(object sender, EventArgs e)
        {
            contarNumeros(bt6);
        }

        private void bt7_CheckedChanged(object sender, EventArgs e)
        {
            contarNumeros(bt7);
        }

        private void bt8_CheckedChanged(object sender, EventArgs e)
        {
            contarNumeros(bt8);
        }

        private void bt9_CheckedChanged(object sender, EventArgs e)
        {
            contarNumeros(bt9);
        }

        private void bt10_CheckedChanged(object sender, EventArgs e)
        {
            contarNumeros(bt10);
        }

        private void bt11_CheckedChanged(object sender, EventArgs e)
        {
            contarNumeros(bt11);
        }

        private void bt12_CheckedChanged(object sender, EventArgs e)
        {
            contarNumeros(bt12);
        }

        private void bt13_CheckedChanged(object sender, EventArgs e)
        {
            contarNumeros(bt13);
        }

        private void bt14_CheckedChanged(object sender, EventArgs e)
        {
            contarNumeros(bt14);
        }

        private void bt15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt17_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt18_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt19_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt21_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt22_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt23_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt24_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt25_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt26_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt27_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt28_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt29_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt30_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt31_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt32_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt33_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt34_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt35_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt36_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox37_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt38_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt39_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt40_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt41_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt42_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt43_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt44_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt45_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt46_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt48_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt49_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt50_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt51_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt52_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt53_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt54_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt55_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt56_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt57_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt58_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt59_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt60_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}