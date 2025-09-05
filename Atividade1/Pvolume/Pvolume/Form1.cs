namespace Pvolume
{
    public partial class Form1 : Form
    {
        double raio, altura, volume;

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtRaio.Text = "";
            txtAltura.Text = string.Empty;
            txtVolume.Clear();  
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtRaio.Text, out raio) || (raio <= 0))
            {
                MessageBox.Show("raio invalido");
            }
            /*else if (raio <= 0)
             {
                 MessageBox.Show("raio deve ser maior que zero");
             }*/
        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtRaio.Text, out raio) || (raio <= 0))
            {
                MessageBox.Show("raio invalido");
            }
            else if (!Double.TryParse(txtAltura.Text, out altura) || (altura <= 0))
            {
                MessageBox.Show("alura invalida");
            }
            else
            {
                volume = Math.PI * Math.Pow(raio, 2) * altura;//math função para contas matematica 
                txtVolume.Text = volume.ToString("N2");
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}

