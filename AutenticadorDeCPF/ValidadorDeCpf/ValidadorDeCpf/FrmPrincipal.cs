using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackEnd;

namespace ValidadorDeCpf
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnValidar_Click(object sender, EventArgs e)
        {
            if (MskCpf.Text.Length == 14)
            {
                Cpf funcoesCpf = new Cpf();
                bool retorno = funcoesCpf.ValidarCpf(MskCpf.Text);

                if (retorno)
                {
                    LblResultado.ForeColor = Color.Green;
                    LblResultado.Text = "CPF Válido";

                }
                else
                {
                    LblResultado.ForeColor = Color.Red;
                    LblResultado.Text = "CPF Inválido";
                }
            }
            else
            {
                MessageBox.Show("Ensira todos os dígitos do CPF.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnValidar_MouseEnter(object sender, EventArgs e)
        {
            BtnValidar.BackColor = SystemColors.MenuHighlight;
        }

        private void BtnValidar_MouseLeave(object sender, EventArgs e)
        {
            BtnValidar.BackColor = SystemColors.ActiveBorder;
        }
    }
}
