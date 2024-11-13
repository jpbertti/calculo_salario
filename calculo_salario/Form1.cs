using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculo_salario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show ("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string Nome;                                                          //inicialização com 0 quando é menor de 1440
            double valor_hora, horas_trabalhadas, salario_bruto, vale_transporte, imposto_de_renda = 0, salario_liquido;
            
            Nome = txtNome.Text;
            valor_hora = double.Parse(txtValorHora.Text);
            horas_trabalhadas = double.Parse(txtHorasTrabalhadas.Text);

            salario_bruto = valor_hora * horas_trabalhadas;

            vale_transporte = salario_bruto * 0.06;

            if (salario_bruto > 1440)
            {
                imposto_de_renda = salario_bruto * 0.11;
            }
            // else
            //{
               // imposto_de_renda = 0;
           // }

            salario_liquido = salario_bruto - vale_transporte - imposto_de_renda;

            MessageBox.Show("O Salario bruto do(a) " + Nome + " é de: " + salario_bruto.ToString("C"));

            MessageBox.Show("O valor do Vale Transporte é de: " + vale_transporte.ToString("C"));

            MessageBox.Show("O desconto do imposto de renda é de: " + imposto_de_renda.ToString("C"));

            MessageBox.Show("O Valor do Salário líquido é: " + salario_liquido.ToString("C"));

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtHorasTrabalhadas.Clear();
            txtNome.Clear();
            txtValorHora.Clear();
            txtNome.Focus();
        }
    }
}
