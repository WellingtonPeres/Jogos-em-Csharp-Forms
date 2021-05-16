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
            numeroSorteado = rand.Next(0, 1);
            btnGerarValorAleatorio.Enabled = false;
            txtChutarValorAleatorio.Enabled = true;
            ltbNumerosTentados.Items.Clear();
            numeroTentativas = 3;
            lblNumeroTentativas.Text = numeroTentativas.ToString();

            lblTituloInterativo.Text = "Estou pensando em um número de 0 a 10. " +
                                       "Tente adivinhar...";
        }

        private void VerificacaoDeDerrota()
        {
            if (numeroTentativas == 1)
            {
                MessageBox.Show("Que trisque, Você perdeu!!!", "DERROTA");
                txtChutarValorAleatorio.Enabled = false;
                btnGerarValorAleatorio.Enabled = true;
            }
        }

        private void txtChutarValorAleatorio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && txtChutarValorAleatorio.Text != "")
            {
                e.SuppressKeyPress = true;
                if (int.Parse(txtChutarValorAleatorio.Text) == numeroSorteado)
                {
                    MessageBox.Show("VOCÊ ACERTOU!!!", "PARABÉNS");
                    txtChutarValorAleatorio.Enabled = false;
                    btnGerarValorAleatorio.Enabled = true;
                }
                else if (int.Parse(txtChutarValorAleatorio.Text) > numeroSorteado)
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
                ltbNumerosTentados.Items.Add(txtChutarValorAleatorio.Text);
                txtChutarValorAleatorio.Clear();
            }
        }
    }
}
