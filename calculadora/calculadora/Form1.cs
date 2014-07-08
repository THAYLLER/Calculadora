using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class FmrCalculadora : Form
    {
        public FmrCalculadora()
        {
            InitializeComponent();
        }
        bool detecta = true;
        double valor1, valor2, resultado;
        string operacao;
        private void BtoZero_Click(object sender, EventArgs e)
        {
            if (detecta)
            {
                TbTela.Text = "";
                valor1 = Convert.ToDouble(TbTela.Text += 0);
                detecta = false;
            }
            else
            {
                valor1 = Convert.ToDouble(TbTela.Text += 0);
            }
        }

        private void BtoUm_Click(object sender, EventArgs e)
        {
            if (detecta)
            {
                TbTela.Text = "";
                valor1 = Convert.ToDouble(TbTela.Text += 1);
                detecta = false;
            }
            else
            {
                valor1 = Convert.ToDouble(TbTela.Text += 1);
            }
        }

        private void BtoDois_Click(object sender, EventArgs e)
        {
            if (detecta)
            {
                TbTela.Text = "";
                valor1 = Convert.ToDouble(TbTela.Text += 2);
                detecta = false;
            }
            else
            {
                valor1 = Convert.ToDouble(TbTela.Text += 2);
            }
        }

        private void BtoTres_Click(object sender, EventArgs e)
        {
            if (detecta)
            {
                TbTela.Text = "";
                valor1 = Convert.ToDouble(TbTela.Text += 3);
                detecta = false;
            }
            else
            {
                valor1 = Convert.ToDouble(TbTela.Text += 3);
            }
        }

        private void BtoQuatro_Click(object sender, EventArgs e)
        {
            if (detecta)
            {
                TbTela.Text = "";
                valor1 = Convert.ToDouble(TbTela.Text += 4);
                detecta = false;
            }
            else
            {
                valor1 = Convert.ToDouble(TbTela.Text += 4);
            }
        }

        private void BtoCinco_Click(object sender, EventArgs e)
        {
            if (detecta)
            {
                TbTela.Text = "";
                valor1 = Convert.ToDouble(TbTela.Text += 5);
                detecta = false;
            }
            else
            {
                valor1 = Convert.ToDouble(TbTela.Text += 5);
            }
        }

        private void BtoSeis_Click(object sender, EventArgs e)
        {
            if (detecta)
            {
                TbTela.Text = "";
                valor1 = Convert.ToDouble(TbTela.Text += 6);
                detecta = false;
            }
            else
            {
                valor1 = Convert.ToDouble(TbTela.Text += 6);
            }
        }

        private void BtoSete_Click(object sender, EventArgs e)
        {
            if (detecta)
            {
                TbTela.Text = "";
                valor1 = Convert.ToDouble(TbTela.Text += 7);
                detecta = false;
            }
            else
            {
                valor1 = Convert.ToDouble(TbTela.Text += 7);
            }
        }

        private void BtoOito_Click(object sender, EventArgs e)
        {
            if (detecta)
            {
                TbTela.Text = "";
                valor1 = Convert.ToDouble(TbTela.Text += 8);
                detecta = false;
            }
            else
            {
                valor1 = Convert.ToDouble(TbTela.Text += 8);
            }
        }

        private void BtoNove_Click(object sender, EventArgs e)
        {
            if (detecta)
            {
                TbTela.Text = "";
                valor1 = Convert.ToDouble(TbTela.Text += 9);
                detecta = false;
            }
            else
            {
                valor1 = Convert.ToDouble(TbTela.Text += 9);
            }
        }

        private void BtoVirgula_Click(object sender, EventArgs e)
        {
            TbTela.Text += ",";
            detecta = false;
        }

        private void BtoPonto_Click(object sender, EventArgs e)
        {
            TbTela.Text += ".";
            detecta = false;
        }

        private void BtoLimpar_Click(object sender, EventArgs e)
        {
            TbTela.Text = "";
            detecta = true;
        }

        private void BtoSoma_Click(object sender, EventArgs e)
        {
            operacao = "+";
            detecta = true;
            valor2 = Convert.ToDouble(TbTela.Text);
        }

        private void BtoSubtrair_Click(object sender, EventArgs e)
        {
            operacao = "-";
            detecta = true;
            valor2 = Convert.ToDouble(TbTela.Text);
        }

        private void BtoMultiplicar_Click(object sender, EventArgs e)
        {
            operacao = "*";
            detecta = true;
            valor2 = Convert.ToDouble(TbTela.Text);
        }

        private void BtoDividir_Click(object sender, EventArgs e)
        {
            operacao = "/";
            detecta = true;
            valor2 = Convert.ToDouble(TbTela.Text);
        }

        private void BtoIgual_Click(object sender, EventArgs e)
        {
            switch (operacao)
            {
                case "+":
                    {
                        resultado = valor1 + valor2;
                        TbTela.Text = resultado.ToString();
                        break;
                    }

                case "-":
                    {
                        resultado = valor1 - valor2;
                        TbTela.Text = resultado.ToString();
                        break;
                    }
                case "/":
                    {
                        resultado = valor1 / valor2;
                        TbTela.Text = resultado.ToString();
                        break;
                    }
                case "*":
                    {
                        resultado = valor1 * valor2;
                        TbTela.Text = resultado.ToString();
                        break;
                    }
            }
        }
    }
}
