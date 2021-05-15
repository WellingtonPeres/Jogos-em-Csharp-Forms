using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adivinhe_se_Puder
{
    public partial class btnJogarNovamente : Form
    {
        int numeroSorteado;
        int numeroTentativas = 3;

    public btnJogarNovamente()
        {
            InitializeComponent();
            lblNumeroTentativas.Text = numeroTentativas.ToString();
        }

        private void btnGerarValorAleatorio_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            numeroSorteado = rand.Next(0, 10);
            btnGerarValorAleatorio.Enabled = false;
            btnTestarChute.Enabled = true;
            txtChutarValorAleatorio.Enabled = true;

            lblTituloInterativo.Text = "Estou pensando em um número de 0 a 10. " +
                                       "Tente adivinhar...";

            btnJogarDeNovo.Enabled = true;
        }

        private void btnTestarChute_Click(object sender, EventArgs e)
        {
            int numeroChute = int.Parse(txtChutarValorAleatorio.Text);
            if (numeroChute == numeroSorteado)
            {
                MessageBox.Show("VOCÊ ACERTOU!!!", "PARABÉNS");
            }
            else if (numeroChute > numeroSorteado)
            {
                VerificacaoDeDerrota();
                lblTituloInterativo.Text = "Que pena... Você errou!!!" +
                                           "O número que eu pensei é menor.";
                numeroTentativas--;
                lblNumeroTentativas.Text = numeroTentativas.ToString();
            }
            else
            {
                VerificacaoDeDerrota();
                lblTituloInterativo.Text = "Que pena... Você errou!!!" +
                                           "O número que eu pensei é maior.";
                numeroTentativas--;
                lblNumeroTentativas.Text = numeroTentativas.ToString();
            }
            ltbNumerosTentados.Items.Add(numeroChute);
            txtChutarValorAleatorio.Clear();
        }

        private void VerificacaoDeDerrota()
        {
            if (numeroTentativas == 1)
            {
                MessageBox.Show("Que trisque, Você perdeu!!!", "DERROTA");
                txtChutarValorAleatorio.Enabled = false;
                btnTestarChute.Enabled = false;
            }
        }

        private void btnJogarDeNovo_Click(object sender, EventArgs e)
        {
            btnGerarValorAleatorio.Enabled = true;

            txtChutarValorAleatorio.Enabled = false;
            txtChutarValorAleatorio.Clear();

            btnTestarChute.Enabled = false;

            ltbNumerosTentados.Items.Clear();

            lblTituloInterativo.Text = "Adivinhe se Puder!";
            btnJogarDeNovo.Enabled = false;
            numeroTentativas = 3;
            lblNumeroTentativas.Text = numeroTentativas.ToString();
        }
    }
}
