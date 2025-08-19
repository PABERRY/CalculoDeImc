using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoDeImc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(txbPeso.Text);
            double n2 = double.Parse(txbAltura.Text);

            if (n2 == 0)
            {
                MessageBox.Show("Impossível fazer o calculo por 0 !",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txbPeso.Text.Length <= 0)
            {
                MessageBox.Show("o campo PESO não pode estar vazio!",
                   "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txbAltura.Text.Length <= 0)
            {
                MessageBox.Show("o campo ALTURA não pode estar vazio!",
                   "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            double resultado = n1 / (n2 * n2);
            txbResultado.Text = resultado.ToString();



           
            if (resultado < 18.5)
            {
                lblSaude.Text = ("Você está abaixo do peso");

                lblSaude.ForeColor = Color.Red;
            }
            else if (resultado < 24.9)
            {
                lblSaude.Text = ("Você está no peso ideal, parabéns!");

                lblSaude.ForeColor = Color.Green;
            }
            else if (resultado < 29.9)
            {
                lblSaude.Text = ("Levemente acima do peso");

                lblSaude.ForeColor = Color.Yellow;

            }
            else if (resultado < 34.9)
            {
                lblSaude.Text = ("Obesidade grau |");

                lblSaude.ForeColor = Color.Orange;
            }
            else if (resultado < 39.9)
            {
                lblSaude.Text = ("Obesidade grau ||, severa");

                lblSaude.ForeColor = Color.Red;
            }
            else if (resultado >= 40)
            {
                lblSaude.Text = ("Obesidade grau |||, Obesidade mórbida");

                lblSaude.ForeColor = Color.DarkRed;
            }

        }

        private void txbAltura_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCalcular.PerformClick();

            }
        }
    }
}
