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
    public partial class CadastroJogadores : Form
    {

        private MySqlConnection conexao;

        private MySqlCommand comando;

        public CadastroJogadores()
        {
            InitializeComponent();
        }

        public void inserirJogador()
        {
            try
            {
                conexao = new MySqlConnection("server=127.0.0.1; user id=root; pwd= ; database=dungeonsbd");
                conexao.Open();

                try
                {
                    comando = new MySqlCommand("insert into tb_jogador (Jogador, Personagem, Classe_Personagem) values ('" + nomeDoJogadorTextBox.Text + "', '" + nomeDoPersonagemTextBox.Text + "', '" + classesComboBox.Text + "')", conexao);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastrado com Sucesso");
                    nomeDoJogadorTextBox.Text = "";
                    nomeDoPersonagemTextBox.Text = "";
                    classesComboBox.SelectedIndex = 0;
                    nomeDoJogadorTextBox.Focus();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Erro no SQL");
                }

                conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao acessar o banco!");
            }

        }

        private void CadastroJogadores_Load(object sender, EventArgs e)
        {
            classesComboBox.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inserirJogador();
        }
    }
}
