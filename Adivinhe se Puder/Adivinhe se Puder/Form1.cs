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
        }

        private void btnTestarChute_Click(object sender, EventArgs e)
        {
            int numeroChute = int.Parse(txtChutarValorAleatorio.Text);
            if (numeroChute == numeroSorteado)
            {
                MessageBox.Show("Parabéns... Você acertou!!!");
            }
            else
            {
                MessageBox.Show("Que pena... Você errou!!!");
            }
            ltbNumerosTentados.Items.Add(numeroChute);
        }
    }
}
