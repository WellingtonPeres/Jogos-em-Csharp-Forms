using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_Memória
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();

            List<string> icons = new List<string>()
            {
                "!", "!", "N", "N", ",", ",", "K", "K",
                "b", "b", "v", "v", "w", "w", "z", "z"
            };

        }
    }
}
