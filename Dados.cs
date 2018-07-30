using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanD
{
    
    public partial class Dados : Form
    {
        DiceRoller roladorDeDados = new DiceRoller();
        Calculadora calculator = new Calculadora();

        public Dados()
        {
            InitializeComponent();
        }

        private void botaoD2_Click(object sender, EventArgs e)
        {
            resultadoD2.Text = roladorDeDados.rolarD2(quantidadeD2).ToString();
            resultadoRoladorDadosTextBox.Text = (int.Parse(resultadoRoladorDadosTextBox.Text) + int.Parse(resultadoD2.Text)).ToString();
        }

        private void botaoD4_Click(object sender, EventArgs e)
        {
            resultadoD4.Text = roladorDeDados.rolarD4(quantidadeD4).ToString();
            resultadoRoladorDadosTextBox.Text = (int.Parse(resultadoRoladorDadosTextBox.Text) + int.Parse(resultadoD4.Text)).ToString();
        }

        private void botaoD6_Click(object sender, EventArgs e)
        {
            resultadoD6.Text = roladorDeDados.rolarD6(quantidadeD6).ToString();
            resultadoRoladorDadosTextBox.Text = (int.Parse(resultadoRoladorDadosTextBox.Text) + int.Parse(resultadoD6.Text)).ToString();
        }

        private void botaoD8_Click(object sender, EventArgs e)
        {
            resultadoD8.Text = roladorDeDados.rolarD8(quantidadeD8).ToString();
            resultadoRoladorDadosTextBox.Text = (int.Parse(resultadoRoladorDadosTextBox.Text) + int.Parse(resultadoD8.Text)).ToString();
        }

        private void botaoD10_Click(object sender, EventArgs e)
        {
            resultadoD10.Text = roladorDeDados.rolarD10(quantidadeD10).ToString();
            resultadoRoladorDadosTextBox.Text = (int.Parse(resultadoRoladorDadosTextBox.Text) + int.Parse(resultadoD10.Text)).ToString();
        }

        private void botaoD12_Click(object sender, EventArgs e)
        {
            resultadoD12.Text = roladorDeDados.rolarD12(quantidadeD12).ToString();
            resultadoRoladorDadosTextBox.Text = (int.Parse(resultadoRoladorDadosTextBox.Text) + int.Parse(resultadoD12.Text)).ToString();
        }

        private void botaoD20_Click(object sender, EventArgs e)
        {
            resultadoD20.Text = roladorDeDados.rolarD20(quantidadeD20).ToString();
            resultadoRoladorDadosTextBox.Text = (int.Parse(resultadoRoladorDadosTextBox.Text) + int.Parse(resultadoD20.Text)).ToString();
        }

        private void botaoLimparTotalDados_Click(object sender, EventArgs e)
        {
            quantidadeD2.Value = 0;
            quantidadeD4.Value = 0;
            quantidadeD6.Value = 0;
            quantidadeD8.Value = 0;
            quantidadeD10.Value = 0;
            quantidadeD12.Value = 0;
            quantidadeD20.Value = 0;
            resultadoD2.Text = "0";
            resultadoD4.Text = "0";
            resultadoD6.Text = "0";
            resultadoD8.Text = "0";
            resultadoD10.Text = "0";
            resultadoD12.Text = "0";
            resultadoD20.Text = "0";
            resultadoRoladorDadosTextBox.Text = "0";
        }

        

        private void Dados_Load(object sender, EventArgs e)
        {
            
        }
    }
}
