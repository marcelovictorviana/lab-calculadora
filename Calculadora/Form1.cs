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


        public void botao_numero(int numero)
        {
            if (operacao == false)
                tb_calculadora.Text += numero;
            else
                tb_calculadora.Text = numero.ToString();

            operacao = false;
        }


        bool operacao = false;

        public void botao_operacao(string operador)
        {
            operacao = true;
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

    }
}
