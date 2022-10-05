using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CalculadoraV2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public void AnyNumberBtn_Click(object sender, EventArgs e) 
        {
            if (sender.GetType().Equals(btnNumeroZero.GetType()))
                txtExpressao.Text += ((Button)sender).Text;
        }

        public void AnyOperatorBtn_Click(object sender, EventArgs e)
        {
            if(sender.GetType().Equals(btnMultiplicar.GetType()))
                txtExpressao.Text += " " + ((Button)sender).Text + " ";
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text != "")
            {
                string[] resultado = lblResultado.Text.Split(' ');
                txtExpressao.Clear();
                txtExpressao.Text += resultado[0];
            }
        }

        private void BtnResetaCalculadora_Click(object sender, EventArgs e)
        {
            txtExpressao.Clear();
            lblResultado.Text = "";
        }

        private void TxtExpressao_TextChanged(object sender, EventArgs e)
        {
            List<string> expressao = ((TextBox)sender).Text.Split(' ').ToList<string>();

            int lastIndex = expressao.Count - 1;
            if (expressao[lastIndex].Equals("") && lastIndex > 1)
            {
                expressao.RemoveAt(lastIndex);
                if (expressao[expressao.Count-1].Equals("^2"))
                    btnIgual.PerformClick();
            }
            
            if (expressao.Count % 2 != 0 && expressao.Count > 1)
                btnIgual.PerformClick();
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            string[] operadores = { "^2", "√", "^", "*", "/", "+", "-" };
            double res = 0;
            List<string> expressaoDividida = txtExpressao.Text.Split(' ').ToList<string>();
            Dictionary<List<string>, double> resultado;

            int i = 0;
            while(expressaoDividida.Count > 1)
            {
                resultado = Calcular(expressaoDividida, res, operadores[i], operadores[i+1]);
                foreach (var item in resultado)
                {
                    expressaoDividida = item.Key;
                    res = item.Value;
                }
                i++;
            }

            lblResultado.Text = res.ToString();
        }

        private Dictionary<List<string>, double> Calcular(List<string> expressao, double resposta, string operadorUm, string operadorDois) 
        {
            int i = 1;
            while (expressao.Count != i)
            {
                if (expressao[i].Equals(operadorUm) || expressao[i].Equals(operadorDois))
                {
                    switch (expressao[i])
                    {
                        case "^2":
                            resposta = Math.Pow(double.Parse(expressao[i - 1]), 2);
                            break;
                        case "√":
                            resposta = Math.Sqrt(double.Parse(expressao[i + 1]));
                            break;
                        case "^":
                            resposta = Math.Pow(double.Parse(expressao[i - 1]), double.Parse(expressao[i + 1]));
                            break;
                        case "*":
                            resposta = double.Parse(expressao[i - 1]) * double.Parse(expressao[i + 1]);
                            break;
                        case "/":
                            resposta = double.Parse(expressao[i - 1]) / double.Parse(expressao[i + 1]);
                            break;
                        case "+":
                            resposta = double.Parse(expressao[i - 1]) + double.Parse(expressao[i + 1]);
                            break;
                        default:
                            resposta = double.Parse(expressao[i - 1]) - double.Parse(expressao[i + 1]);
                            break;
                    }
                    
                    expressao.RemoveAt(i + 1);
                    expressao.RemoveAt(i);
                    expressao[i - 1] = resposta.ToString();
                }
                else
                    i += 2;
            }
            return new Dictionary<List<string>, double>() { {expressao, resposta }};
        }
    }


}
