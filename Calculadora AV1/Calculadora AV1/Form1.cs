using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_AV1
{
    public partial class Form1 : Form
    {

        public decimal Resultado { get; set; }

        public decimal Valor { get; set; }

        private Operacao OperacaoSelecionada { get; set; }

        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }

        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(label1.Text);
            label1.Text = "";
            label3.Text = "+";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(label1.Text);
            label1.Text = "";
            label3.Text = "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(label1.Text);
            label1.Text = "";
            label3.Text = "*";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(label1.Text);
            label1.Text = "";
            label3.Text = "/";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(label1.Text);
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(label1.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(label1.Text);
                    break;
                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(label1.Text);
                    break;
            }
            label1.Text = "";
            label2.Text = Convert.ToString(Resultado);
            label3.Text = "=";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (!label1.Text.Contains(","))
                label1.Text += ",";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
        }
    }
}
