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
    public partial class Battle : Form
    {

        private MySqlConnection conexao;

        private MySqlCommand comando;

        private MySqlDataReader armazena;

        List<Monstros> listaDeMonstros = new List<Monstros>();
        List<Jogador> listaDeJogadores = new List<Jogador>();
        Monstros m;
        Jogador j;
        private Encontros[] encontros;

        public Battle(Encontros[] encontros)
        {
            this.encontros = encontros;
            InitializeComponent();
        }

        public void limparTextBox()
        {
            nomeLabel.Text = "";
            tipoLabel.Text = "";
            labelCA.Text = "";
            labelPV.Text = "";
            labelDadosPV.Text = "";
            labelDeslocamento.Text = "";
            labelDesEscalada.Text = "";
            labelDesAquatico.Text = "";
            labelDesVoo.Text = "";
            labelFOR.Text = "";
            labelDES.Text = "";
            labelCON.Text = "";
            labelINT.Text = "";
            labelSAB.Text = "";
            labelCAR.Text = "";
            labelModFOR.Text = "";
            labelModDES.Text = "";
            labelModCON.Text = "";
            labelModINT.Text = "";
            labelModSAB.Text = "";
            labelModCAR.Text = "";
            testeDeResistenciaTexto.Text = "";
            periciasTexto.Text = "";
            resistenciaDanoTexto.Text = "";
            vulnerabilidadeDanoTexto.Text = "";
            imunidadeDanoTexto.Text = "";
            imunidadeCondicaoTexto.Text = "";
            sentidosTexto.Text = "";
            idiomasTexto.Text = "";
            nivelDeDesafioTexto.Text = "";
            labelExperiencia.Text = "";
            acoesrichTextBox.Text = "";
            acoesLendariasrichTextBox.Text = "";
        }

        /*private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                nomeLabel.Text = listaDeMonstros[monstrosListBox.SelectedIndex].getNome();
                tipoLabel.Text = listaDeMonstros[monstrosListBox.SelectedIndex].getTipo();
                labelCA.Text = listaDeMonstros[monstrosListBox.SelectedIndex].getClasseDeArmadura().ToString();
                labelPV.Text = listaDeMonstros[monstrosListBox.SelectedIndex].getPontosDeVidaAbsolutos().ToString() + " " + listaDeMonstros[monstrosListBox.SelectedIndex].getPontosDeVidaDados().ToString();
                labelDeslocamento.Text = listaDeMonstros[monstrosListBox.SelectedIndex].getDeslocamento().ToString() + "m terrestre, " + listaDeMonstros[monstrosListBox.SelectedIndex].getDeslocamentoVoo().ToString() + "m de voo, " + 
                listaDeMonstros[monstrosListBox.SelectedIndex].getDeslocamentoAquatico().ToString() + "m aquatico";
                labelFOR.Text = listaDeMonstros[monstrosListBox.SelectedIndex].getAtributos(0).ToString();
                labelDES.Text = listaDeMonstros[monstrosListBox.SelectedIndex].getAtributos(1).ToString();
                labelCON.Text = listaDeMonstros[monstrosListBox.SelectedIndex].getAtributos(2).ToString();
                labelINT.Text = listaDeMonstros[monstrosListBox.SelectedIndex].getAtributos(3).ToString();
                labelSAB.Text = listaDeMonstros[monstrosListBox.SelectedIndex].getAtributos(4).ToString();
                labelCAR.Text = listaDeMonstros[monstrosListBox.SelectedIndex].getAtributos(5).ToString();
           
                if(listaDeMonstros[monstrosListBox.SelectedIndex].getModificadores(0) >= 0)
                    labelModFOR.Text = "(+" + listaDeMonstros[monstrosListBox.SelectedIndex].getModificadores(0).ToString() + ")";
                else
                    labelModFOR.Text = "(" + listaDeMonstros[monstrosListBox.SelectedIndex].getModificadores(0).ToString() + ")";
                if(listaDeMonstros[monstrosListBox.SelectedIndex].getModificadores(1) >= 0)
                    labelModDES.Text = "(+" + listaDeMonstros[monstrosListBox.SelectedIndex].getModificadores(1).ToString() + ")";
                else
                    labelModDES.Text = "(" + listaDeMonstros[monstrosListBox.SelectedIndex].getModificadores(1).ToString() + ")";
                if(listaDeMonstros[monstrosListBox.SelectedIndex].getModificadores(2) >= 0)
                    labelModCON.Text = "(+" + listaDeMonstros[monstrosListBox.SelectedIndex].getModificadores(2).ToString() + ")";
                else
                    labelModCON.Text = "(" + listaDeMonstros[monstrosListBox.SelectedIndex].getModificadores(2).ToString() + ")";
                if (listaDeMonstros[0].getModificadores(3) >= 0)
                    labelModINT.Text = "(+" + listaDeMonstros[monstrosListBox.SelectedIndex].getModificadores(3).ToString() + ")";
                else
                    labelModINT.Text = "(" + listaDeMonstros[monstrosListBox.SelectedIndex].getModificadores(3).ToString() + ")";
                if (listaDeMonstros[monstrosListBox.SelectedIndex].getModificadores(4) >= 0)
                    labelModSAB.Text = "(+" + listaDeMonstros[monstrosListBox.SelectedIndex].getModificadores(4).ToString() + ")";
                else
                    labelModSAB.Text = "(" + listaDeMonstros[monstrosListBox.SelectedIndex].getModificadores(4).ToString() + ")";
                if (listaDeMonstros[monstrosListBox.SelectedIndex].getModificadores(5) >= 0)
                    labelModCAR.Text = "(+" + listaDeMonstros[monstrosListBox.SelectedIndex].getModificadores(5).ToString() + ")";
                else
                    labelModCAR.Text = "(" + listaDeMonstros[monstrosListBox.SelectedIndex].getModificadores(5).ToString() + ")";
                for (int z = 0; z < listaDeMonstros[monstrosListBox.SelectedIndex].testeDeResistencia.Count; z++)
                {
                    testeDeResistenciaTexto.Text = testeDeResistenciaTexto.Text + listaDeMonstros[monstrosListBox.SelectedIndex].testeDeResistencia[z];
                }
                for (int z = 0; z < listaDeMonstros[monstrosListBox.SelectedIndex].pericias.Count; z++)
                {
                    periciasTexto.Text = periciasTexto.Text + listaDeMonstros[monstrosListBox.SelectedIndex].pericias[z];
                }
                for (int z = 0; z < listaDeMonstros[monstrosListBox.SelectedIndex].resistenciaDano.Count; z++)
                {
                    resistenciaDanoTexto.Text = resistenciaDanoTexto.Text + listaDeMonstros[monstrosListBox.SelectedIndex].resistenciaDano[z];
                }
                for (int z = 0; z < listaDeMonstros[monstrosListBox.SelectedIndex].fraquezaDano.Count; z++)
                {
                    vulnerabilidadeDanoTexto.Text = vulnerabilidadeDanoTexto.Text + listaDeMonstros[monstrosListBox.SelectedIndex].fraquezaDano[z];
                }
                for (int z = 0; z < listaDeMonstros[monstrosListBox.SelectedIndex].imunidadeAoDano.Count; z++)
                {
                    imunidadeDanoTexto.Text = imunidadeDanoTexto.Text + listaDeMonstros[monstrosListBox.SelectedIndex].imunidadeAoDano[z];
                }
                for (int z = 0; z < listaDeMonstros[monstrosListBox.SelectedIndex].imunidadeCondicoes.Count; z++)
                {
                    imunidadeCondicaoTexto.Text = imunidadeCondicaoTexto.Text + listaDeMonstros[monstrosListBox.SelectedIndex].imunidadeCondicoes[z];
                }
                for (int z = 0; z < listaDeMonstros[monstrosListBox.SelectedIndex].sentidos.Count; z++)
                {
                    sentidosTexto.Text = sentidosTexto.Text + listaDeMonstros[monstrosListBox.SelectedIndex].sentidos[z];
                }
                for (int z = 0; z < listaDeMonstros[monstrosListBox.SelectedIndex].idiomas.Count; z++)
                {
                    idiomasTexto.Text = idiomasTexto.Text + listaDeMonstros[monstrosListBox.SelectedIndex].idiomas[z];
                }
            for (int z = 0; z < listaDeMonstros[monstrosListBox.SelectedIndex].acoes.Count; z++)
            {
                acoesLabel.Text = acoesLabel.Text + listaDeMonstros[monstrosListBox.SelectedIndex].acoes[z] + Environment.NewLine;
            }
            nivelDeDesafioTexto.Text = listaDeMonstros[monstrosListBox.SelectedIndex].getNivelDeDesafio() + " (" + listaDeMonstros[monstrosListBox.SelectedIndex].getExperiencia().ToString() + "XP )";
                
        }*/

        private void mostrarImagem()
        {
            switch (monstrosListBox.Text)
            {

                case "BANSHEE":
                    Image banshee = Properties.Resources.banshee;
                    fotoMonstroPictureBox.Image = banshee;
                    fotoMonstroPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case "CICLOPE":

                    Image ciclope = Properties.Resources.ciclope;
                    fotoMonstroPictureBox.Image = ciclope;
                    fotoMonstroPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case "COCATRIZ":
                    Image cocatriz = Properties.Resources.cocatriz;
                    fotoMonstroPictureBox.Image = cocatriz;
                    fotoMonstroPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                
                case "DEVORADOR DE MENTES":
                    Image devoradorDeMentes = Properties.Resources.devoradorDeMentes;
                    fotoMonstroPictureBox.Image = devoradorDeMentes;
                    fotoMonstroPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case "DIABO DE CHIFRES":

                    Image diaboDeChifres = Properties.Resources.diaboDeChifres;
                    fotoMonstroPictureBox.Image = diaboDeChifres;
                    fotoMonstroPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case "DJINNI":
                    Image djinni = Properties.Resources.djinni;
                    fotoMonstroPictureBox.Image = djinni;
                    fotoMonstroPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case "DRAGÃO VERMELHO ANCIÃO":

                    Image dragao = Properties.Resources.dragaoVermelhoAnciao;
                    fotoMonstroPictureBox.Image = dragao;
                    fotoMonstroPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case "DROW":
                    Image drow = Properties.Resources.drow;
                    fotoMonstroPictureBox.Image = drow;
                    fotoMonstroPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case "ELEMENTAL DA ÁGUA":
                    Image elementalDaAgua = Properties.Resources.elementalDaAgua;
                    fotoMonstroPictureBox.Image = elementalDaAgua;
                    fotoMonstroPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case "ENTE":

                    Image ente = Properties.Resources.ente;
                    fotoMonstroPictureBox.Image = ente;
                    fotoMonstroPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case "ESQUELETO":
                    Image esqueleto = Properties.Resources.esqueleto;
                    fotoMonstroPictureBox.Image = esqueleto;
                    fotoMonstroPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case "FANTASMA":
                    Image fantasma = Properties.Resources.fantasma;
                    fotoMonstroPictureBox.Image = fantasma;
                    fotoMonstroPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case "GNOLL":
                    Image gnoll = Properties.Resources.gnoll;
                    fotoMonstroPictureBox.Image = gnoll;
                    fotoMonstroPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case "GOBLIN":
                    Image goblin = Properties.Resources.goblin;
                    fotoMonstroPictureBox.Image = goblin;
                    fotoMonstroPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case "GOLEM DE FERRO":
                    Image golemDeFerro = Properties.Resources.golemDeFerro;
                    fotoMonstroPictureBox.Image = golemDeFerro;
                    fotoMonstroPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case "HIDRA":

                    Image hidra = Properties.Resources.hidra;
                    fotoMonstroPictureBox.Image = hidra;
                    fotoMonstroPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case "HIPOGRIFO":
                    Image hipogrifo = Properties.Resources.hipogrifo;
                    fotoMonstroPictureBox.Image = hipogrifo;
                    fotoMonstroPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case "KOBOLD":
                    Image kobold = Properties.Resources.kobold;
                    fotoMonstroPictureBox.Image = kobold;
                    fotoMonstroPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case "KRAKEN":
                    Image kraken = Properties.Resources.kraken;
                    fotoMonstroPictureBox.Image = kraken;
                    fotoMonstroPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case "LICH":
                    Image lich = Properties.Resources.lich;
                    fotoMonstroPictureBox.Image = lich;
                    fotoMonstroPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case "LOBISOMEM":
                    Image lobisomem = Properties.Resources.lobisomem;
                    fotoMonstroPictureBox.Image = lobisomem;
                    fotoMonstroPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case "LOBO ATROZ":
                    Image loboAtroz = Properties.Resources.loboAtroz;
                    fotoMonstroPictureBox.Image = loboAtroz;
                    fotoMonstroPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case "MEDUSA":
                    Image medusa = Properties.Resources.medusa;
                    fotoMonstroPictureBox.Image = medusa;
                    fotoMonstroPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case "MINOTAURO":
                    Image minotauro = Properties.Resources.minotauro;
                    fotoMonstroPictureBox.Image = minotauro;
                    fotoMonstroPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case "MONSTRO DA FERRUGEM":
                    Image monstroDeFerrugem = Properties.Resources.monstroDeFerrugem;
                    fotoMonstroPictureBox.Image = monstroDeFerrugem;
                    fotoMonstroPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case "MÚMIA":
                    Image mumia = Properties.Resources.mumia;
                    fotoMonstroPictureBox.Image = mumia;
                    fotoMonstroPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case "OBSERVADOR":
                    Image observador = Properties.Resources.observador;
                    fotoMonstroPictureBox.Image = observador;
                    fotoMonstroPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case "OGRO":
                    Image ogro = Properties.Resources.ogro;
                    fotoMonstroPictureBox.Image = ogro;
                    fotoMonstroPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case "ORC":
                    Image orc = Properties.Resources.orc;
                    fotoMonstroPictureBox.Image = orc;
                    fotoMonstroPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case "PÉGASO":
                    Image pegaso = Properties.Resources.pegaso;
                    fotoMonstroPictureBox.Image = pegaso;
                    fotoMonstroPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case "PLANETÁRIO":
                    Image planetario = Properties.Resources.planetario;
                    fotoMonstroPictureBox.Image = planetario;
                    fotoMonstroPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case "QUIMERA":
                    Image quimera = Properties.Resources.quimera;
                    fotoMonstroPictureBox.Image = quimera;
                    fotoMonstroPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case "SÁTIRO":
                    Image satiro = Properties.Resources.satiro;
                    fotoMonstroPictureBox.Image = satiro;
                    fotoMonstroPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case "TARRASQUE":
                    Image tarrasque = Properties.Resources.tarrasque;
                    fotoMonstroPictureBox.Image = tarrasque;
                    fotoMonstroPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case "TROLL":
                    Image troll = Properties.Resources.troll;
                    fotoMonstroPictureBox.Image = troll;
                    fotoMonstroPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case "VAMPIRO":
                    Image vampiro = Properties.Resources.vampiro;
                    fotoMonstroPictureBox.Image = vampiro;
                    fotoMonstroPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case "VERME PÚRPURA":
                    Image vermePurpura = Properties.Resources.vermePurpura;
                    fotoMonstroPictureBox.Image = vermePurpura;
                    fotoMonstroPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (textBoxNome.Text.Equals(""))
                MessageBox.Show("Digite um nome para o encontro");
            else
            {
                encontros[Decimal.ToInt32(numericoNumeroEncontros.Value) - 1].setNomeEncontro(textBoxNome.Text);
                for(int k = 0; k < listaDeMonstros.Count; k++)
                {
                    if(listaDeMonstros.ElementAt(k).Equals(nomeMonstrocomboBox.Text))
                        encontros[Decimal.ToInt32(numericoNumeroEncontros.Value) - 1].setMonstroNaLista((Monstros)listaDeMonstros.ElementAt(k).Clone());
                }

                for(int n = 0; n < listaDeJogadores.Count; n++)
                {
                    for (int a = 0; a < encontros[Decimal.ToInt32(numericoNumeroEncontros.Value) - 1].listaDeJogadores.Count; a++)
                    {
                        if (encontros[Decimal.ToInt32(numericoNumeroEncontros.Value) - 1].listaDeJogadores.ElementAt(a).getNomeDoJogador().Equals(nomeJogadorcomboBox.Text))
                            MessageBox.Show("Não é possível adicionar um jogador de mesmo nome no encontro");
                        else
                        {
                            for (int b = 0; b < listaDeJogadores.Count; b++)
                                if (listaDeJogadores.ElementAt(b).getNomeDoJogador().Equals(nomeJogadorcomboBox.Text))
                                    encontros[Decimal.ToInt32(numericoNumeroEncontros.Value) - 1].listaDeJogadores.Add((Jogador)listaDeJogadores.ElementAt(b));
                        }
                    }
                }
                encontros[Decimal.ToInt32(numericoNumeroEncontros.Value) - 1].setQuantidadeDeMonstros();
                encontros[Decimal.ToInt32(numericoNumeroEncontros.Value) - 1].setDificuldade();
                encontros[Decimal.ToInt32(numericoNumeroEncontros.Value) - 1].setExperiencia();
            }
        }

        public void criarMonstros()
        {
            try
            {
                conexao = new MySqlConnection("server=127.0.0.1; user id=root; pwd= ; database=dungeonsbd");
                conexao.Open();

                try
                {
                    comando = new MySqlCommand("select * from tb_monstros WHERE Status=1", conexao);
                    armazena = comando.ExecuteReader();
                    m = new Monstros();
                    monstrosListBox.Items.Clear();
                    nomeMonstrocomboBox.Items.Clear();

                    while (armazena.Read())
                    {
                        monstrosListBox.Items.Add(armazena["Monstro"].ToString());
                        nomeMonstrocomboBox.Items.Add(armazena["Monstro"].ToString());
                        m.setNome(armazena["Monstro"].ToString());
                        m.setTipo(armazena["Tipo_Alinhamento"].ToString());
                        m.setClasseDeArmadura(armazena["CA"].ToString());
                        m.setPontosDeVidaAbsolutos(Int32.Parse(armazena["PV_Absoluto"].ToString()));
                        m.setPontosDeVidaDados(armazena["Dados_PV"].ToString());
                        m.setDeslocamento(armazena["Deslocamento"].ToString());
                        m.setDeslocamentoVoo(armazena["Deslocamento_Voo"].ToString());
                        m.setDeslocamentoAquatico(armazena["Deslocamento_Aqua"].ToString());
                        m.setDeslocamentoEscalada(armazena["Desloc_Escalada"].ToString());
                        m.setAtributos(Int32.Parse(armazena["Atrib_Forca"].ToString()), Int32.Parse(armazena["Atrib_Destreza"].ToString()),
                            Int32.Parse(armazena["Atrib_Constituicao"].ToString()), Int32.Parse(armazena["Atrib_Inteligencia"].ToString()),
                        Int32.Parse(armazena["Atrib_Sabedoria"].ToString()), Int32.Parse(armazena["Atrib_Carisma"].ToString()));
                        m.setModificadores(Int32.Parse(armazena["Mod_Forca"].ToString()), Int32.Parse(armazena["Mod_Destreza"].ToString()),
                            Int32.Parse(armazena["Mod_Constituicao"].ToString()), Int32.Parse(armazena["Mod_Inteligencia"].ToString()),
                        Int32.Parse(armazena["Mod_Sabedoria"].ToString()), Int32.Parse(armazena["Mod_Carisma"].ToString()));
                        m.setTesteDeResistencia(armazena["Teste_Resistencia"].ToString());
                        m.setPericias(armazena["Pericias"].ToString());
                        m.setResistenciaDano(armazena["Resistencia_Dano"].ToString());
                        m.setImunidadeAoDano(armazena["Imunidade_Dano"].ToString());
                        m.setFraquezaDano(armazena["Fraqueza_Dano"].ToString());
                        m.setImunidadeCondicoes(armazena["Imunidade_Condicoes"].ToString());
                        m.setSentidos(armazena["Sentidos"].ToString());
                        m.setIdiomas(armazena["Idiomas"].ToString());
                        m.setNivelDeDesafio(armazena["Nivel_Desafio"].ToString());
                        m.setExperiencia(armazena["Experiencia"].ToString());
                        m.setDescricoes(armazena["Descricao"].ToString());
                        m.setAcoes(armazena["Acoes"].ToString());
                        m.setAcoesLendarias(armazena["Acoes_Lendarias"].ToString());
                        listaDeMonstros.Add((Monstros)m.Clone());
                    }

                    monstrosListBox.SelectedIndex = 0;
                    nomeMonstrocomboBox.SelectedIndex = 0;

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
        public void ExibeMonstros()
        {
            try
            {
                conexao = new MySqlConnection("server=127.0.0.1; user id=root; pwd= ; database=dungeonsbd");
                conexao.Open();

                try
                {
                    comando = new MySqlCommand("Select * from tb_monstros WHERE Monstro = '"+ monstrosListBox.Text +"'", conexao);
                    armazena = comando.ExecuteReader();
                    armazena.Read();
                    nomeLabel.Text = listaDeMonstros.ElementAt(monstrosListBox.SelectedIndex).getNome();
                    tipoLabel.Text = listaDeMonstros.ElementAt(monstrosListBox.SelectedIndex).getTipo();
                    labelCA.Text = listaDeMonstros.ElementAt(monstrosListBox.SelectedIndex).getClasseDeArmadura();
                    labelPV.Text = listaDeMonstros.ElementAt(monstrosListBox.SelectedIndex).getPontosDeVidaAbsolutos().ToString();
                    labelDadosPV.Text = listaDeMonstros.ElementAt(monstrosListBox.SelectedIndex).getPontosDeVidaDados();
                    labelDeslocamento.Text = listaDeMonstros.ElementAt(monstrosListBox.SelectedIndex).getDeslocamento();
                    labelDesEscalada.Text = listaDeMonstros.ElementAt(monstrosListBox.SelectedIndex).getDeslocamentoEscalada();
                    labelDesAquatico.Text = listaDeMonstros.ElementAt(monstrosListBox.SelectedIndex).getDeslocamentoAquatico();
                    labelDesVoo.Text = listaDeMonstros.ElementAt(monstrosListBox.SelectedIndex).getDeslocamentoVoo();
                    labelFOR.Text = listaDeMonstros.ElementAt(monstrosListBox.SelectedIndex).getAtributos(0).ToString();
                    labelDES.Text = listaDeMonstros.ElementAt(monstrosListBox.SelectedIndex).getAtributos(1).ToString();
                    labelCON.Text = listaDeMonstros.ElementAt(monstrosListBox.SelectedIndex).getAtributos(2).ToString();
                    labelINT.Text = listaDeMonstros.ElementAt(monstrosListBox.SelectedIndex).getAtributos(3).ToString();
                    labelSAB.Text = listaDeMonstros.ElementAt(monstrosListBox.SelectedIndex).getAtributos(4).ToString();
                    labelCAR.Text = listaDeMonstros.ElementAt(monstrosListBox.SelectedIndex).getAtributos(5).ToString();
                    labelModFOR.Text = listaDeMonstros.ElementAt(monstrosListBox.SelectedIndex).getModificadores(0).ToString();
                    labelModDES.Text = listaDeMonstros.ElementAt(monstrosListBox.SelectedIndex).getModificadores(1).ToString();
                    labelModCON.Text = listaDeMonstros.ElementAt(monstrosListBox.SelectedIndex).getModificadores(2).ToString();
                    labelModINT.Text = listaDeMonstros.ElementAt(monstrosListBox.SelectedIndex).getModificadores(3).ToString();
                    labelModSAB.Text = listaDeMonstros.ElementAt(monstrosListBox.SelectedIndex).getModificadores(4).ToString();
                    labelModCAR.Text = listaDeMonstros.ElementAt(monstrosListBox.SelectedIndex).getModificadores(5).ToString();
                    testeDeResistenciaTexto.Text = listaDeMonstros.ElementAt(monstrosListBox.SelectedIndex).getTesteDeResistencia();
                    periciasTexto.Text = listaDeMonstros.ElementAt(monstrosListBox.SelectedIndex).getPericias();
                    resistenciaDanoTexto.Text = listaDeMonstros.ElementAt(monstrosListBox.SelectedIndex).getResistenciaDano();
                    vulnerabilidadeDanoTexto.Text = listaDeMonstros.ElementAt(monstrosListBox.SelectedIndex).getFraquezaDano();
                    imunidadeDanoTexto.Text = listaDeMonstros.ElementAt(monstrosListBox.SelectedIndex).getImunidadeAoDano();
                    imunidadeCondicaoTexto.Text = listaDeMonstros.ElementAt(monstrosListBox.SelectedIndex).getImunidadeCondicoes();
                    sentidosTexto.Text = listaDeMonstros.ElementAt(monstrosListBox.SelectedIndex).getSentidos();
                    idiomasTexto.Text = listaDeMonstros.ElementAt(monstrosListBox.SelectedIndex).getIdiomas();
                    nivelDeDesafioTexto.Text = listaDeMonstros.ElementAt(monstrosListBox.SelectedIndex).getNivelDeDesafio();
                    labelExperiencia.Text = listaDeMonstros.ElementAt(monstrosListBox.SelectedIndex).getExperiencia();
                    acoesrichTextBox.Text = listaDeMonstros.ElementAt(monstrosListBox.SelectedIndex).getAcoes();
                    acoesLendariasrichTextBox.Text = listaDeMonstros.ElementAt(monstrosListBox.SelectedIndex).getAcoesLendarias();

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
        public void exibeJogadores ()
        {
            j = new Jogador();
            try
            {
                conexao = new MySqlConnection("server=127.0.0.1; user id=root; pwd= ; database=dungeonsbd");
                conexao.Open();

                try
                {
                    comando = new MySqlCommand("select Jogador from tb_jogador", conexao);
                    armazena = comando.ExecuteReader();
                    nomeJogadorcomboBox.Items.Clear();

                    while (armazena.Read())
                    {
                        nomeJogadorcomboBox.Items.Add(armazena["Jogador"].ToString());
                        j.setNomeDoJogador(armazena["Jogador"].ToString());
                        j.setNomeDoPersonagem(armazena["Personagem"].ToString());
                        j.setClasse(armazena["Classe_Personagem"].ToString());
                        listaDeJogadores.Add((Jogador)j.Clone());
                    }

                    nomeJogadorcomboBox.SelectedIndex = 0;

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

        private void Battle_Load(object sender, EventArgs e)
        {
            criarMonstros();
            ExibeMonstros();
            exibeJogadores();
        }

        private void monstrosListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            limparTextBox();
            //criarMonstros();
            ExibeMonstros();
            mostrarImagem();
        }

        //private void NomeMonstrolistBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //  ExibeNomeMonstros();
        //}

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
        private void RoladorDadosbutton_Click(object sender, EventArgs e)
        {
            vereficaSeFormDadosAberto();
            
        }

        private void checkBoxVidaPadrão_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxVidaPadrao.Checked)
            {
                numericoVidaManual.Enabled = false;
            }
            else
                numericoVidaManual.Enabled = true;
        }
    }
}
