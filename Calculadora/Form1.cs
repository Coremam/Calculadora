namespace Calculadora
{
    public partial class Form1 : Form
    {
        //Sempre que tivermos a variável seguida de ? quer dizer que ela aceita null
        decimal numero1, numero2;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }


        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            txtResultados.Text = "0";
            operacao = "";
            numero1 = 0;
            numero2 = 0;
            lblHistorico.Text = "";
        }

        public void GerarStringResultado(string textoAcrescentar)
        {
            if (txtResultados.Text == "0" && textoAcrescentar != ",")
            {
                txtResultados.Text = textoAcrescentar;
            }
            else
            {
                txtResultados.Text += textoAcrescentar;
            }
            lblHistorico.Text += textoAcrescentar;
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            GerarStringResultado("1");
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            GerarStringResultado("2");
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            GerarStringResultado("3");
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            GerarStringResultado("4");
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            GerarStringResultado("5");
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            GerarStringResultado("6");
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            GerarStringResultado("7");
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            GerarStringResultado("8");
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            GerarStringResultado("9");
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            GerarStringResultado("0");
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            //contains vai verificar se existe esse(s) caracteres dentro da string
            //Vou verificar se NÃO existe um ponto
            if (!txtResultados.Text.Contains(","))
            {
                GerarStringResultado(",");
            }
        }

        public void CalcularOperacao()
        {
            decimal resultado = 0;

            switch (operacao)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;

                case "-":
                    resultado = numero1 - numero2;
                    break;

                case "*":
                    resultado = numero1 * numero2;
                    break;

                case "/":
                    if (numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                    }
                    break;
            }

            txtResultados.Text = resultado.ToString();

            lblHistorico.Text += " = " + resultado;

            operacao = "";

        }

        public void CriarOperacao(string operacaoParametro)
        {
            if (operacao != "")
            {
                numero2 = Convert.ToDecimal(txtResultados.Text);
                CalcularOperacao();
            }
            operacao = operacaoParametro;
            numero1 = Convert.ToDecimal(txtResultados.Text);
            txtResultados.Text = "0";

            lblHistorico.Text += " " + operacao + " ";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            CriarOperacao("+");
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            CriarOperacao("-");
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            CriarOperacao("*");
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            CriarOperacao("/");
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            numero2 = Convert.ToDecimal(txtResultados.Text);
            CalcularOperacao();
        }

        private void btnAlterarSinal_Click(object sender, EventArgs e)
        {
            if (txtResultados.Text.Contains("-"))
            {
                //Remove é o metodo capaz de remover um ou mais caracteres de uma string
                //Informe o indice que ele inica a remoção e a quantidade de caracteres
                txtResultados.Text = txtResultados.Text.Remove(0, 1);
                lblHistorico.Text = "(" + lblHistorico.Text + ") * -1";
            }
            else
            {
                if (Convert.ToDecimal(txtResultados.Text) != 0)
                {
                    txtResultados.Text = "-" + txtResultados.Text;
                    lblHistorico.Text = "(" + lblHistorico.Text + ") * -1";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
