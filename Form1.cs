using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DanD
{
    public partial class MainForm : Form
    {
        DiceRoller roladorDeDados = new DiceRoller();
        Calculadora calculator = new Calculadora();
        Encontros encontroAux = new Encontros();
        Encontros[] encontros = new Encontros[8];
        int flagEncontro1 = 0; //flag para controlar os encontros/combobox
        int flagEncontro2 = 0;
        int flagEncontro3 = 0;
        int flagEncontro4 = 0;
        int flagEncontro5 = 0;
        int flagEncontro6 = 0;
        int flagEncontro7 = 0;
        int flagEncontro8 = 0;
        int flagBatalha = 0;
        int flagCoresMesa = 0;

        bool contadorLigado = false;
        public MainForm()
        {
            InitializeComponent();
        }

        private void contadorDeTurnosGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            operacaoCalculadoraComboBox.SelectedIndex = 0;
            comboBoxJogadores.SelectedIndex = 0;
            comboBoxMonstros.SelectedIndex = 0;
            for (int i = 0; i < 8; i++)
                encontros[i] = (Encontros)encontroAux.Clone();
            primeiroEncontroBotao.Text = encontros[0].getNomeEncontro() + "\nMonstros: " + encontros[0].getQuantidadeDeMonstros() + "\nDificuldade: " + encontros[0].getDificuldade()
                + "\nXP: " + encontros[0].getExperiencia();
            segundoEncontro.Text = encontros[1].getNomeEncontro() + "\nMonstros: " + encontros[1].getQuantidadeDeMonstros() + "\nDificuldade: " + encontros[1].getDificuldade()
                + "\nXP: " + encontros[1].getExperiencia();
            terceiroEncontro.Text = encontros[2].getNomeEncontro() + "\nMonstros: " + encontros[2].getQuantidadeDeMonstros() + "\nDificuldade: " + encontros[2].getDificuldade()
                + "\nXP: " + encontros[2].getExperiencia();
            quartoEncontro.Text = encontros[3].getNomeEncontro() + "\nMonstros: " + encontros[3].getQuantidadeDeMonstros() + "\nDificuldade: " + encontros[3].getDificuldade()
                + "\nXP: " + encontros[3].getExperiencia();
            quintoEncontro.Text = encontros[4].getNomeEncontro() + "\nMonstros: " + encontros[4].getQuantidadeDeMonstros() + "\nDificuldade: " + encontros[4].getDificuldade()
                + "\nXP: " + encontros[4].getExperiencia();
            sextoEncontro.Text = encontros[5].getNomeEncontro() + "\nMonstros: " + encontros[5].getQuantidadeDeMonstros() + "\nDificuldade: " + encontros[5].getDificuldade()
                + "\nXP: " + encontros[5].getExperiencia();
            setimoEncontro.Text = encontros[6].getNomeEncontro() + "\nMonstros: " + encontros[6].getQuantidadeDeMonstros() + "\nDificuldade: " + encontros[6].getDificuldade()
                + "\nXP: " + encontros[6].getExperiencia();
            oitavoEncontro.Text = encontros[7].getNomeEncontro() + "\nMonstros: " + encontros[7].getQuantidadeDeMonstros() + "\nDificuldade: " + encontros[7].getDificuldade()
                + "\nXP: " + encontros[7].getExperiencia();


        }

        /*/private void botaoD2_Click(object sender, EventArgs e)
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
        }*/

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void chamaVez()
        {

            if ((primeiroLabel.BackColor == Color.Maroon) && (flagCoresMesa == 1))
            {
                primeiroLabel.BackColor = Color.SeaGreen;
            }
            else
            {
                primeiroLabel.BackColor = Color.Maroon;
            }


            if ((segundoLabel.BackColor == Color.Maroon) && (flagCoresMesa == 2))
            {
                segundoLabel.BackColor = Color.SeaGreen;
            }
            else
            {
                segundoLabel.BackColor = Color.Maroon;
            }

            if ((terceiroLabel.BackColor == Color.Maroon) && (flagCoresMesa == 3))
            {
                terceiroLabel.BackColor = Color.SeaGreen;
            }
            else
            {
                terceiroLabel.BackColor = Color.Maroon;
            }

            if ((quartoLabel.BackColor == Color.Maroon) && (flagCoresMesa == 4))
            {
                quartoLabel.BackColor = Color.SeaGreen;
            }
            else
            {
                quartoLabel.BackColor = Color.Maroon;
            }

            if ((quintoLabel.BackColor == Color.Maroon) && (flagCoresMesa == 5))
            {
                quintoLabel.BackColor = Color.SeaGreen;
            }
            else
            {
                quintoLabel.BackColor = Color.Maroon;
            }

            if ((sextoLabel.BackColor == Color.Maroon) && (flagCoresMesa == 6))
            {
                sextoLabel.BackColor = Color.SeaGreen;
            }
            else
            {
                sextoLabel.BackColor = Color.Maroon;
            }

            if ((setimoLabel.BackColor == Color.Maroon) && (flagCoresMesa == 7))
            {
                setimoLabel.BackColor = Color.SeaGreen;
            }
            else
            {
                setimoLabel.BackColor = Color.Maroon;
            }

            if ((oitavoLabel.BackColor == Color.Maroon) && (flagCoresMesa == 8))
            {
                oitavoLabel.BackColor = Color.SeaGreen;
            }
            else
            {
                oitavoLabel.BackColor = Color.Maroon;
            }

            if ((nonoLabel.BackColor == Color.Maroon) && (flagCoresMesa == 9))
            {
                nonoLabel.BackColor = Color.SeaGreen;
            }
            else
            {
                nonoLabel.BackColor = Color.Maroon;
            }

            if ((decimoLabel.BackColor == Color.Maroon) && (flagCoresMesa == 10))
            {
                decimoLabel.BackColor = Color.SeaGreen;
            }
            else
            {
                decimoLabel.BackColor = Color.Maroon;
            }

            if ((decimoPrimeiroLabel.BackColor == Color.Maroon) && (flagCoresMesa == 11))
            {
                decimoPrimeiroLabel.BackColor = Color.SeaGreen;
            }
            else
            {
                decimoPrimeiroLabel.BackColor = Color.Maroon;
            }

            if ((decimoSegundoLabel.BackColor == Color.Maroon) && (flagCoresMesa == 12))
            {
                decimoSegundoLabel.BackColor = Color.SeaGreen;
            }
            else
            {
                decimoSegundoLabel.BackColor = Color.Maroon;
            }

            if ((decimoTerceiroLabel.BackColor == Color.Maroon) && (flagCoresMesa == 13))
            {
                decimoTerceiroLabel.BackColor = Color.SeaGreen;
            }
            else
            {
                decimoTerceiroLabel.BackColor = Color.Maroon;
            }

            if ((decimoQuartoLabel.BackColor == Color.Maroon) && (flagCoresMesa == 14))
            {
                decimoQuartoLabel.BackColor = Color.SeaGreen;
            }
            else
            {
                decimoQuartoLabel.BackColor = Color.Maroon;
            }

            if ((decimoQuintoLabel.BackColor == Color.Maroon) && (flagCoresMesa == 15))
            {
                decimoQuintoLabel.BackColor = Color.SeaGreen;
            }
            else
            {
                decimoQuintoLabel.BackColor = Color.Maroon;
            }

            if ((decimoSextoLabel.BackColor == Color.Maroon) && (flagCoresMesa == 16))
            {
                decimoSextoLabel.BackColor = Color.SeaGreen;
            }
            else
            {
                decimoSextoLabel.BackColor = Color.Maroon;
            }

            if ((decimoSetimoLabel.BackColor == Color.Maroon) && (flagCoresMesa == 17))
            {
                decimoSetimoLabel.BackColor = Color.SeaGreen;
            }
            else
            {
                decimoSetimoLabel.BackColor = Color.Maroon;
            }

            if ((decimoOitavoLabel.BackColor == Color.Maroon) && (flagCoresMesa == 18))
            {
                decimoOitavoLabel.BackColor = Color.SeaGreen;
            }
            else
            {
                decimoOitavoLabel.BackColor = Color.Maroon;
            }

            if ((decimoNonoLabel.BackColor == Color.Maroon) && (flagCoresMesa == 19))
            {
                decimoNonoLabel.BackColor = Color.SeaGreen;
            }
            else
            {
                decimoNonoLabel.BackColor = Color.Maroon;
            }

            if ((vigesimoLabel.BackColor == Color.Maroon) && (flagCoresMesa == 20))
            {
                vigesimoLabel.BackColor = Color.SeaGreen;
            }
            else
            {
                vigesimoLabel.BackColor = Color.Maroon;
            }

        }

        private void limpaVezTurnos()
        {
            primeiroLabel.BackColor = Color.Maroon;
            segundoLabel.BackColor = Color.Maroon;
            terceiroLabel.BackColor = Color.Maroon;
            quartoLabel.BackColor = Color.Maroon;
            quintoLabel.BackColor = Color.Maroon;
            sextoLabel.BackColor = Color.Maroon;
            setimoLabel.BackColor = Color.Maroon;
            oitavoLabel.BackColor = Color.Maroon;
            nonoLabel.BackColor = Color.Maroon;
            decimoLabel.BackColor = Color.Maroon;
            decimoPrimeiroLabel.BackColor = Color.Maroon;
            decimoSegundoLabel.BackColor = Color.Maroon;
            decimoTerceiroLabel.BackColor = Color.Maroon;
            decimoQuartoLabel.BackColor = Color.Maroon;
            decimoQuintoLabel.BackColor = Color.Maroon;
            decimoSextoLabel.BackColor = Color.Maroon;
            decimoSetimoLabel.BackColor = Color.Maroon;
            decimoOitavoLabel.BackColor = Color.Maroon;
            decimoNonoLabel.BackColor = Color.Maroon;
            vigesimoLabel.BackColor = Color.Maroon;
        }

        /*private void botaoLimparTotalDados_Click(object sender, EventArgs e)
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
        }*/

        private void calcularBotao_Click(object sender, EventArgs e)
        {
            resultadoCalculadoraTextBox.Text = (calculator.calcular(Decimal.ToInt32(numero1.Value), Decimal.ToInt32(numero2.Value), operacaoCalculadoraComboBox.Text)).ToString();
        }

        private void botaoPassarTurno_Click(object sender, EventArgs e)
        {
            if(flagBatalha == 0)
            {
                if (MessageBox.Show("Deseja mesmo iniciar o embate?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    flagBatalha = 1;
                }
            }
            if(flagBatalha == 1)
            {
                if (flagCoresMesa < listBoxOrdemJogada.Items.Count)
                {
                    flagCoresMesa = flagCoresMesa + 1;
                }
                else
                    flagCoresMesa = 1;

                numeroDoTurnoTextBox.Text = (int.Parse(numeroDoTurnoTextBox.Text) + 1).ToString();
                emQuemEstaTurno.Text = listBoxOrdemJogada.Items[flagCoresMesa - 1].ToString();
                if (flagCoresMesa < listBoxOrdemJogada.Items.Count)
                    proximoEmQuemEstaraTurno.Text = listBoxOrdemJogada.Items[flagCoresMesa].ToString();
                else
                    proximoEmQuemEstaraTurno.Text = listBoxOrdemJogada.Items[0].ToString();
                chamaVez();
            }
        }

        private void botaoLigaContadorTurnos_Click(object sender, EventArgs e)
        {
            if (contadorLigado == false)
            {
                contadorLigado = true;
                botaoLigaContadorTurnos.Text = "Desligar Contador";
                
            }
                
            else
            {
                contadorLigado = false;
                botaoLigaContadorTurnos.Text = "Ligar Contador";
            }
                
        }

        private void botaoDeclararMorte_Click(object sender, EventArgs e)
        {
            
        }

        private void battleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Battle bt = new Battle(encontros);
            bt.ShowDialog();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void botaoZerarTurnos_Click(object sender, EventArgs e)
        {
            numeroDoTurnoTextBox.Text = "0";
            limpaVezTurnos();
            
        }

        private void insereJogadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroJogadores oc = new CadastroJogadores();
            oc.ShowDialog();
        }

        private void vereficaSeFormDadosAberto()
        {
            if (Application.OpenForms.OfType<Dados>().Count() > 0)
            {
                Application.OpenForms.OfType<Dados>().First().Focus();
            }
            else
            {
                Dados rd = new Dados();
                rd.Show();
            }
        }

        private void RoladordeDadosbutton_Click(object sender, EventArgs e)
        {
            vereficaSeFormDadosAberto();
        }

        private void battleButton_Click(object sender, EventArgs e)
        {

            

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Sair do Aplicativo?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Voce quer Jogar Mais Um Pouco", "Alerta");
            }
        }

        private void primeiroEncontroBotao_Click(object sender, EventArgs e)
        {
            if(flagEncontro1 == 0)
            {
                if(encontros[0].listaDeJogadores.Count != 0)
                {
                    for (int i = 0; i < encontros[0].listaDeJogadores.Count; i++)
                    {
                        comboBoxJogadores.Items.Add(encontros[0].listaDeJogadores.ElementAt(i).getNomeDoPersonagem());
                    }
                }
                if(encontros[0].listaDeMonstros.Count != 0)
                {
                    for (int i = 0; i < encontros[0].listaDeMonstros.Count; i++)
                    {
                        comboBoxJogadores.Items.Add(encontros[0].listaDeMonstros.ElementAt(i).getNome());
                    }
                }
                flagEncontro1 = 1;
                flagEncontro2 = 0;
                flagEncontro3 = 0;
                flagEncontro4 = 0;
                flagEncontro5 = 0;
                flagEncontro6 = 0;
                flagEncontro7 = 0;
                flagEncontro8 = 0;
            }
        }

        private void segundoEncontro_Click(object sender, EventArgs e)
        {
            if (flagEncontro2 == 0)
            {
                if (encontros[1].listaDeJogadores.Count != 0)
                {
                    for (int i = 0; i < encontros[1].listaDeJogadores.Count; i++)
                    {
                        comboBoxJogadores.Items.Add(encontros[1].listaDeJogadores.ElementAt(i).getNomeDoPersonagem());
                    }
                }
                if (encontros[1].listaDeMonstros.Count != 0)
                {
                    for (int i = 0; i < encontros[1].listaDeMonstros.Count; i++)
                    {
                        comboBoxJogadores.Items.Add(encontros[1].listaDeMonstros.ElementAt(i).getNome());
                    }
                }
                flagEncontro1 = 0;
                flagEncontro2 = 1;
                flagEncontro3 = 0;
                flagEncontro4 = 0;
                flagEncontro5 = 0;
                flagEncontro6 = 0;
                flagEncontro7 = 0;
                flagEncontro8 = 0;
            }
        }

        private void terceiroEncontro_Click(object sender, EventArgs e)
        {
            if (flagEncontro3 == 0)
            {
                if (encontros[2].listaDeJogadores.Count != 0)
                {
                    for (int i = 0; i < encontros[2].listaDeJogadores.Count; i++)
                    {
                        comboBoxJogadores.Items.Add(encontros[2].listaDeJogadores.ElementAt(i).getNomeDoPersonagem());
                    }
                }
                if (encontros[2].listaDeMonstros.Count != 0)
                {
                    for (int i = 0; i < encontros[2].listaDeMonstros.Count; i++)
                    {
                        comboBoxJogadores.Items.Add(encontros[2].listaDeMonstros.ElementAt(i).getNome());
                    }
                }
                flagEncontro1 = 0;
                flagEncontro2 = 0;
                flagEncontro3 = 1;
                flagEncontro4 = 0;
                flagEncontro5 = 0;
                flagEncontro6 = 0;
                flagEncontro7 = 0;
                flagEncontro8 = 0;
            }
        }

        private void quartoEncontro_Click(object sender, EventArgs e)
        {
            if (flagEncontro4 == 0)
            {
                if (encontros[3].listaDeJogadores.Count != 0)
                {
                    for (int i = 0; i < encontros[3].listaDeJogadores.Count; i++)
                    {
                        comboBoxJogadores.Items.Add(encontros[3].listaDeJogadores.ElementAt(i).getNomeDoPersonagem());
                    }
                }
                if (encontros[3].listaDeMonstros.Count != 0)
                {
                    for (int i = 0; i < encontros[3].listaDeMonstros.Count; i++)
                    {
                        comboBoxJogadores.Items.Add(encontros[3].listaDeMonstros.ElementAt(i).getNome());
                    }
                }
                flagEncontro1 = 0;
                flagEncontro2 = 0;
                flagEncontro3 = 0;
                flagEncontro4 = 1;
                flagEncontro5 = 0;
                flagEncontro6 = 0;
                flagEncontro7 = 0;
                flagEncontro8 = 0;
            }
        }

        private void quintoEncontro_Click(object sender, EventArgs e)
        {
            if (flagEncontro5 == 0)
            {
                if (encontros[4].listaDeJogadores.Count != 0)
                {
                    for (int i = 0; i < encontros[4].listaDeJogadores.Count; i++)
                    {
                        comboBoxJogadores.Items.Add(encontros[4].listaDeJogadores.ElementAt(i).getNomeDoPersonagem());
                    }
                }
                if (encontros[4].listaDeMonstros.Count != 0)
                {
                    for (int i = 0; i < encontros[4].listaDeMonstros.Count; i++)
                    {
                        comboBoxJogadores.Items.Add(encontros[4].listaDeMonstros.ElementAt(i).getNome());
                    }
                }
                flagEncontro1 = 0;
                flagEncontro2 = 0;
                flagEncontro3 = 0;
                flagEncontro4 = 0;
                flagEncontro5 = 1;
                flagEncontro6 = 0;
                flagEncontro7 = 0;
                flagEncontro8 = 0;
            }
        }

        private void sextoEncontro_Click(object sender, EventArgs e)
        {
            if (flagEncontro6 == 0)
            {
                if (encontros[5].listaDeJogadores.Count != 0)
                {
                    for (int i = 0; i < encontros[5].listaDeJogadores.Count; i++)
                    {
                        comboBoxJogadores.Items.Add(encontros[5].listaDeJogadores.ElementAt(i).getNomeDoPersonagem());
                    }
                }
                if (encontros[5].listaDeMonstros.Count != 0)
                {
                    for (int i = 0; i < encontros[5].listaDeMonstros.Count; i++)
                    {
                        comboBoxJogadores.Items.Add(encontros[5].listaDeMonstros.ElementAt(i).getNome());
                    }
                }
                flagEncontro1 = 0;
                flagEncontro2 = 0;
                flagEncontro3 = 0;
                flagEncontro4 = 0;
                flagEncontro5 = 0;
                flagEncontro6 = 1;
                flagEncontro7 = 0;
                flagEncontro8 = 0;
            }
        }

        private void setimoEncontro_Click(object sender, EventArgs e)
        {
            if (flagEncontro7 == 0)
            {
                if (encontros[6].listaDeJogadores.Count != 0)
                {
                    for (int i = 0; i < encontros[6].listaDeJogadores.Count; i++)
                    {
                        comboBoxJogadores.Items.Add(encontros[6].listaDeJogadores.ElementAt(i).getNomeDoPersonagem());
                    }
                }
                if (encontros[6].listaDeMonstros.Count != 0)
                {
                    for (int i = 0; i < encontros[6].listaDeMonstros.Count; i++)
                    {
                        comboBoxJogadores.Items.Add(encontros[6].listaDeMonstros.ElementAt(i).getNome());
                    }
                }
                flagEncontro1 = 0;
                flagEncontro2 = 0;
                flagEncontro3 = 0;
                flagEncontro4 = 0;
                flagEncontro5 = 0;
                flagEncontro6 = 0;
                flagEncontro7 = 1;
                flagEncontro8 = 0;
            }
        }

        private void oitavoEncontro_Click(object sender, EventArgs e)
        {
            if (flagEncontro8 == 0)
            {
                if (encontros[7].listaDeJogadores.Count != 0)
                {
                    for (int i = 0; i < encontros[7].listaDeJogadores.Count; i++)
                    {
                        comboBoxJogadores.Items.Add(encontros[7].listaDeJogadores.ElementAt(i).getNomeDoPersonagem());
                    }
                }
                if (encontros[7].listaDeMonstros.Count != 0)
                {
                    for (int i = 0; i < encontros[7].listaDeMonstros.Count; i++)
                    {
                        comboBoxJogadores.Items.Add(encontros[7].listaDeMonstros.ElementAt(i).getNome());
                    }
                }
                flagEncontro1 = 0;
                flagEncontro2 = 0;
                flagEncontro3 = 0;
                flagEncontro4 = 0;
                flagEncontro5 = 0;
                flagEncontro6 = 0;
                flagEncontro7 = 0;
                flagEncontro8 = 1;
            }
        }

        private void botaoInserirJogador_Click(object sender, EventArgs e)
        {
            if (!comboBoxJogadores.Text.Equals("Nenhum"))
            {
                if (MessageBox.Show("Deseja mesmo inserir " + comboBoxJogadores.Text + " nesta posição da rodada?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    listBoxOrdemJogada.Items.Add(comboBoxJogadores.Text);
                    comboBoxJogadores.Items.Remove(comboBoxJogadores.Text);
                    comboBoxJogadores.SelectedIndex = 0;
                }
            }
        }

        private void botaoInserirMonstro_Click(object sender, EventArgs e)
        {
            if (!comboBoxMonstros.Text.Equals("Nenhum"))
            {
                if (MessageBox.Show("Deseja mesmo inserir " + comboBoxMonstros.Text + " nesta posição da rodada?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    listBoxOrdemJogada.Items.Add(comboBoxMonstros.Text);
                    comboBoxMonstros.Items.Remove(comboBoxMonstros.Text);
                    comboBoxMonstros.SelectedIndex = 0;
                }
            }       
        }
    }
}
