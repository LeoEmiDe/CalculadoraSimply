using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Formcalculadora : Form
    {
        public Formcalculadora()
       

        {
            InitializeComponent();
        }
        enum operacoes
        {
            //*Enum é uma Lista de coisas*
            soma,
            subtrai,
            multiplica,
            divida,
            nenhuma
        }

        
        static operacoes ultimaoperacao = operacoes.nenhuma;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxDisplay_Textchanged(object sender, EventArgs e)
        {

        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            ultimaoperacao = operacoes.nenhuma;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ultimaoperacao == operacoes.nenhuma)
            {
                ultimaoperacao = operacoes.subtrai;
            }
            else
            {
                FazerCalculo(ultimaoperacao);
            }
            textBoxDisplay.Text += (sender as Button).Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ultimaoperacao == operacoes.nenhuma)
            {
                ultimaoperacao = operacoes.soma;
            }
            else
            {
                FazerCalculo(ultimaoperacao);
            }
            textBoxDisplay.Text += (sender as Button).Text;
        }
        private void FazerCalculo(operacoes ultimaoperacao)
        {
            List<double> listaDeNumeros = new List<double>();

            //switch-case é uma estrutura de decião
            //String é texto.
            switch (ultimaoperacao)
            {
                case operacoes.soma:
                    listaDeNumeros = textBoxDisplay.Text.Split('+').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (listaDeNumeros[0] + listaDeNumeros[1]).ToString();
                    break;
                case operacoes.subtrai:
                    listaDeNumeros = textBoxDisplay.Text.Split('-').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (listaDeNumeros[0] - listaDeNumeros[1]).ToString();
                    break;
                case operacoes.multiplica:
                    listaDeNumeros = textBoxDisplay.Text.Split('*').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (listaDeNumeros[0] * listaDeNumeros[1]).ToString();
                    break;
                case operacoes.divida:
                    try
                    {
                        listaDeNumeros = textBoxDisplay.Text.Split('/').Select(double.Parse).ToList();
                        textBoxDisplay.Text = (listaDeNumeros[0] / listaDeNumeros[1]).ToString();
                    }
                    catch (DivideByZeroException)
                    {
                        textBoxDisplay.Text = "Divisão por zero";
                    }
                    break;
                case operacoes.nenhuma:
                    break;
                default:
                    break;
            }
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            if (ultimaoperacao == operacoes.nenhuma)
            {
                ultimaoperacao = operacoes.divida;
            }
            else
            {
                FazerCalculo(ultimaoperacao);
            }
            textBoxDisplay.Text += (sender as Button).Text;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (ultimaoperacao == operacoes.nenhuma)
            {
                ultimaoperacao = operacoes.multiplica;
            }
            else
            {
                FazerCalculo(ultimaoperacao);
            }
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            if (ultimaoperacao != operacoes.nenhuma)
            {
                FazerCalculo(ultimaoperacao);
            }
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }
        private void buttonNum_click(object sender, EventArgs e)
        {
            //textBoxDisplay.Text += "0";
            textBoxDisplay.Text += (sender as Button).Text;
        }
    }
}
