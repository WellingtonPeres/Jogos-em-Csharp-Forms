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
    public partial class Form1 : Form
    {
        int numeroSorteado;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerarValorAleatorio_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            numeroSorteado = rand.Next(0, 10);
            lblValorAleatorio.Text = numeroSorteado.ToString();
            btnGerarValorAleatorio.Enabled = false;
            btnTestarChute.Enabled = true;
            txtChutarValorAleatorio.Enabled = true;
        }

        private void btnTestarChute_Click(object sender, EventArgs e)
        {
            int numeroChute = int.Parse(txtChutarValorAleatorio.Text);
            if (numeroChute == numeroSorteado)
            {
                MessageBox.Show("Parabéns... Você acertou!!!");
            }
            else if (numeroChute > numeroSorteado)
            {
                MessageBox.Show("Que pena... Você errou!!!\n" +
                    "O número que eu pensei é menor.", "Mensagem");
            }
            else
            {
                MessageBox.Show("Que pena... Você errou!!!\n" +
                    "O número que eu pensei é maior.", "Mensagem");
            }
            ltbNumerosTentados.Items.Add(numeroChute);
        }
    }
}
