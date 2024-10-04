using votacao_carros.Properties;

namespace votacao_carros
{
    public partial class frmCarros : Form
    {
        int carro = 0, votos = 0;

        public frmCarros()
        {
            InitializeComponent();
        }

        private void btn_carro1_Click(object sender, EventArgs e)
        {
            pic_carros.Image = Properties.Resources.civic;
            carro = 1;
        }

        private void btn_carro2_Click(object sender, EventArgs e)
        {
            pic_carros.Image = Properties.Resources.corolla;
            carro = 2;
        }

        private void btn_votar_Click(object sender, EventArgs e)
        {
            if (carro == 1)
            {
                votos = Convert.ToInt32(lbl_civic.Text) + 1;
                lbl_civic.Text = votos.ToString();
            }

            if (carro == 2)
            {
                votos = Convert.ToInt32(lbl_corolla.Text) + 1;
                lbl_corolla.Text = votos.ToString();
            }

            pic_carros.Image = Properties.Resources.carros1;
            carro = votos = 0;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            lbl_civic.Text = "0";
            lbl_corolla.Text = "0";
            carro = votos = 0;
            pic_carros.Image = Properties.Resources.carros1;
        }
    }
}
