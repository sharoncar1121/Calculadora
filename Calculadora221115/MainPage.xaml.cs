using System.Linq;
using System;
using Xamarin.Forms;

namespace Calculadora221115
{
    public partial class MainPage : ContentPage
    {
        private double Numero1;
        private double Numero2;
        private string Operador;

        public MainPage()
        {
            InitializeComponent();
        }

        private void clicNumero(object sender, EventArgs e)
        {
            Button tmp = (Button)sender;
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = tmp.Text;
            }
            else
            {
                txtResultado.Text += tmp.Text;
            }

        }

        private void clicSuma(object sender, EventArgs e)
        {
            Operador = "+";
            Numero1 = Double.Parse(txtResultado.Text);
            txtResultado.Text = "0";
        }

        private void clicResta(object sender, EventArgs e)
        {
            Operador = "-";
            Numero1 = Double.Parse(txtResultado.Text);
            txtResultado.Text = "0";
        }

        private void clicMultiplicacion(object sender, EventArgs e)
        {
            Operador = "*";
            Numero1 = Double.Parse(txtResultado.Text);
            txtResultado.Text = "0";
        }

        private void clicdivision(object sender, EventArgs e)
        {
            Operador = "/";
            Numero1 = Double.Parse(txtResultado.Text);
            txtResultado.Text = "0";
        }

        private void clicporcentaje(object sender, EventArgs e)
        {
            Operador = "%";
            Numero1 = Double.Parse(txtResultado.Text);
            txtResultado.Text = "0";
        }

        private void clicclear(object sender, EventArgs e)
        {
            Operador = "CE";
            txtResultado.Text = "0";
        }

        private void clicers(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length > 0)
            {
                txtResultado.Text = txtResultado.Text.Substring
                                (0, txtResultado.Text.Count() - 1);
            }

            else
            {
                txtResultado.Text = "0";
            }

        }
        private void clicIgual(object sender, EventArgs e)
        {
            if (txtResultado.Text == "")
            {
                txtResultado.Text = "0";
            }
            else
            {
            }

            Numero2 = Double.Parse(txtResultado.Text);

            double operacionFinal = 0;

            if (Operador == "+")
            {
                operacionFinal = Numero1 + Numero2;

            }

            else if (Operador == "-")
            {
                operacionFinal = Numero1 - Numero2;
            }

            else if (Operador == "*")
            {
                operacionFinal = Numero1 * Numero2;
            }

            else if (Operador == "/")
            {
                operacionFinal = Numero1 / Numero2;
            }

            else if (Operador == "%")
            {
                operacionFinal = (Numero1 * Numero2) / 100;
            }




            txtResultado.Text = operacionFinal.ToString();

        }
    }
}
