using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class fm_calculadora : Form
    {
        public fm_calculadora()
        {
            InitializeComponent();
        }

        private void fm_calculadora_Load(object sender, EventArgs e)
        {

        }


        double numero = 0;
        bool operacao = false;
        string operador = "";
        double calculo = 0;
        bool exibir_calculo = false;

        public void botao_numero(double numero_lido)
        {
            if (operacao == false)
                tb_calculadora.Text += numero_lido;
            else
            {
                numero = double.Parse(tb_calculadora.Text);
                tb_calculadora.Text = numero_lido.ToString();                
            }

            operacao = false;
        }            
        
        public void botao_operacao(string operador)
        {
            if (exibir_calculo == true && numero != 0)
                calcular();
            operacao = true;
            this.operador = operador;            
            exibir_calculo = true;
        }
                
        public void calcular()
        {
            if (operador == "+")
                calculo = numero + double.Parse(tb_calculadora.Text);
            else if (operador == "-")
                calculo = numero - double.Parse(tb_calculadora.Text);
            else if (operador == "*")
                calculo = numero * double.Parse(tb_calculadora.Text);
            else if (operador == "/")
                calculo = numero / double.Parse(tb_calculadora.Text);

            tb_calculadora.Text = calculo.ToString();
            numero = 0;    
        }
                

        private void bt_zero_Click(object sender, EventArgs e)
        {
            botao_numero(0);
        }

        private void bt_um_Click(object sender, EventArgs e)
        {
            botao_numero(1);
        }

        private void bt_dois_Click(object sender, EventArgs e)
        {
            botao_numero(2);
        }

        private void bt_tres_Click(object sender, EventArgs e)
        {
            botao_numero(3);
        }

        private void bt_quatro_Click(object sender, EventArgs e)
        {
            botao_numero(4);
        }

        private void bt_cinco_Click(object sender, EventArgs e)
        {
            botao_numero(5);
        }

        private void bt_seis_Click(object sender, EventArgs e)
        {
            botao_numero(6);
        }

        private void bt_sete_Click(object sender, EventArgs e)
        {
            botao_numero(7);
        }

        private void bt_oito_Click(object sender, EventArgs e)
        {
            botao_numero(8);
        }

        private void bt_nove_Click(object sender, EventArgs e)
        {
            botao_numero(9);
        }

        private void bt_soma_Click(object sender, EventArgs e)
        {
            botao_operacao("+");
        }

        private void bt_subtracao_Click(object sender, EventArgs e)
        {
            botao_operacao("-");
        }

        private void bt_multiplicacao_Click(object sender, EventArgs e)
        {
            botao_operacao("*");
        }

        private void bt_divisao_Click(object sender, EventArgs e)
        {
            botao_operacao("/");
        }

        private void bt_resultado_Click(object sender, EventArgs e)
        {
            calcular();
            exibir_calculo = false;
            operacao = true;
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            tb_calculadora.Text = "0";
            numero = 0;
        }

        private void bt_backspace_Click(object sender, EventArgs e)
        {
            int tamanho = tb_calculadora.Text.Length;
            if(operacao==false)
                if (tamanho > 0)
                    tb_calculadora.Text = tb_calculadora.Text.Substring(0, tamanho - 1);
            if (tb_calculadora.Text == "")
                tb_calculadora.Text = "0";
        }

        private void bt_virgula_Click(object sender, EventArgs e)
        {
            tb_calculadora.Text += ",";
        }

    }
}
