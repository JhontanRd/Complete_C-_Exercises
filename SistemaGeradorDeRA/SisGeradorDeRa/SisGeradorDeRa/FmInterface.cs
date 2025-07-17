using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SisGeradorDeRa.BE;

namespace SisGeradorDeRa
{
    public partial class FmGerador : Form
    {
        public FmGerador()
        {
            InitializeComponent();
        }

        private void BtnGerarRa_MouseEnter(object sender, EventArgs e)
        {
            BtnGerarRa.BackColor = Color.DarkSeaGreen;
        }

        private void BtnGerarRa_MouseLeave(object sender, EventArgs e)
        {
            BtnGerarRa.BackColor = Color.DarkOliveGreen;
        }

        private void RdbNao_CheckedChanged(object sender, EventArgs e)
        {
            if(!RdbNao.Checked)
            {
                NumQuantLetras.Enabled = true;
            }
            else
            {
                NumQuantLetras.Enabled = false;
                NumQuantLetras.Value = 0;
            }
        }

        private void BtnGerarRa_Click(object sender, EventArgs e)
        {
            if (NumQuantNumeros.Text != "0")
            {
                if (NumQuantLetras.Enabled)
                {
                    Aleatorio geradorComLetras = new Aleatorio(Convert.ToInt16(NumQuantLetras.Text), Convert.ToInt16(NumQuantNumeros.Text));
                    TxtRaGerado.Text = geradorComLetras.GerarRAComLetras();
                }
                else
                {
                    Aleatorio geradorSemLetras = new Aleatorio(Convert.ToInt16(NumQuantNumeros.Text));
                    TxtRaGerado.Text = geradorSemLetras.GerarRASemLetras();
                }
            }
            else
            {
                TxtRaGerado.Clear();
            }
        }
    }
}
