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
    public partial class MonstroSelecionado : Form
    {
        Monstros monstro;

        public MonstroSelecionado(Monstros m)
        {
            monstro = m;
            InitializeComponent();
        }
        
        private void MonstroSelecionado_Load(object sender, EventArgs e)
        {

            nomeLabel.Text = monstro.getNome();
            tipoLabel.Text = monstro.getTipo();
            labelCA.Text = monstro.getClasseDeArmadura();
            labelPV.Text = monstro.getControleDePontosDeVida().ToString();
            labelDeslocamento.Text = monstro.getDeslocamento();
            labelDesEscalada.Text = monstro.getDeslocamentoEscalada();
            labelDesAquatico.Text = monstro.getDeslocamentoAquatico();
            labelDesVoo.Text = monstro.getDeslocamentoVoo();
            labelFOR.Text = monstro.getAtributos(0).ToString();
            labelDES.Text = monstro.getAtributos(1).ToString();
            labelCON.Text = monstro.getAtributos(2).ToString();
            labelINT.Text = monstro.getAtributos(3).ToString();
            labelSAB.Text = monstro.getAtributos(4).ToString();
            labelCAR.Text = monstro.getAtributos(5).ToString();
            labelModFOR.Text = monstro.getModificadores(0).ToString();
            labelModDES.Text = monstro.getModificadores(1).ToString();
            labelModCON.Text = monstro.getModificadores(2).ToString();
            labelModINT.Text = monstro.getModificadores(3).ToString();
            labelModSAB.Text = monstro.getModificadores(4).ToString();
            labelModCAR.Text = monstro.getModificadores(5).ToString();
            testeDeResistenciaTexto.Text = monstro.getTesteDeResistencia();
            periciasTexto.Text = monstro.getPericias();
            resistenciaDanoTexto.Text = monstro.getResistenciaDano();
            vulnerabilidadeDanoTexto.Text = monstro.getFraquezaDano();
            imunidadeDanoTexto.Text = monstro.getImunidadeAoDano();
            imunidadeCondicaoTexto.Text = monstro.getImunidadeCondicoes();
            sentidosTexto.Text = monstro.getSentidos();
            idiomasTexto.Text = monstro.getIdiomas();
            nivelDeDesafioTexto.Text = monstro.getNivelDeDesafio();
            labelExperiencia.Text = monstro.getExperiencia();
            acoesrichTextBox.Text = monstro.getAcoes();
            acoesLendariasrichTextBox.Text = monstro.getAcoesLendarias();
        }
    }
}
