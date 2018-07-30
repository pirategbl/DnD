using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanD
{
    public class Monstros : ICloneable
    {
        private String nome; //Planetário
        private String tipo; //Celestial Grande, Leal e Bom
        private String classeDeArmadura; //19 natural
        private int pontosDeVidaAbsolutos; //200
        private String pontosDeVidaDados; //16d10 + 112
        private int controleDePontosDeVida;//Valor mestre colocara como vida do Monstro
        private String deslocamento; //12 m
        private String deslocamentoVoo; //36 m
        private String deslocamentoAquatico; //0 m
        private String deslocamentoEscalada; //0 m
        private int[] atributos; //0 - For     1 - Des    2 - Cons    3 - Int      4 - Sab     5 - Car
        private int[] modificadores; //Os modificadores de atributos la mesmo
        public String testeDeResistencia; //0 - For     1 - Des    2 - Cons    3 - Int      4 - Sab     5 - Car
        public String pericias;//Criar uma classe de pericias e criar objeto para todas as pericias
        public String resistenciaDano; //Dano Radiante, concussão, perfurante.... - Strings
        public String imunidadeAoDano;
        public String fraquezaDano; //Strings 
        public String imunidadeCondicoes; //Enfeitiçado, Exausto - Strings
        public String sentidos; //Visão verdadeira - Strings
        public String idiomas; //Todos - String
        private String nivelDeDesafio; //16
        private String experiencia; //15000
        public String descricoes; //Armas angelicais, Consciência Divina - Strings
        public String acoes; //Ataques Múltiplos, Espada Grande, etc - Strings
        public String acoesLendarias; //Nao possui - Strings

        public void setNome(String n)
        {
            this.nome = n;
        }
        public String getNome()
        {
            return this.nome;
        }

        public void setTipo(String n)
        {
            this.tipo = n;
        }
        public String getTipo()
        {
            return this.tipo;
        }

        public void setClasseDeArmadura(String n)
        {
            this.classeDeArmadura = n;
        }
        public String getClasseDeArmadura()
        {
            return this.classeDeArmadura;
        }

        public void setPontosDeVidaAbsolutos(int n)
        {
            this.pontosDeVidaAbsolutos = n;
        }
        public int getPontosDeVidaAbsolutos()
        {
            return this.pontosDeVidaAbsolutos;
        }

        public void setPontosDeVidaDados(String n)
        {
            this.pontosDeVidaDados = n;
        }
        public String getPontosDeVidaDados()
        {
            return this.pontosDeVidaDados;
        }

        public void setControleDePontosDeVida(int n)
        {
            this.controleDePontosDeVida = n;
        }
        public int getControleDePontosDeVida()
        {
            return this.controleDePontosDeVida;
        }

        public void setDeslocamento(String n)
        {
            this.deslocamento = n;
        }
        public String getDeslocamento()
        {
            return this.deslocamento;
        }

        public void setDeslocamentoVoo(String n)
        {
            this.deslocamentoVoo = n;
        }
        public String getDeslocamentoVoo()
        {
            return this.deslocamentoVoo;
        }

        public void setDeslocamentoAquatico(String n)
        {
            this.deslocamentoAquatico = n;
        }
        public String getDeslocamentoAquatico()
        {
            return this.deslocamentoAquatico;
        }

        public void setDeslocamentoEscalada(String n)
        {
            this.deslocamentoEscalada = n;
        }
        public String getDeslocamentoEscalada()
        {
            return this.deslocamentoEscalada;
        }

        public void setAtributos(int n1, int n2, int n3, int n4, int n5, int n6)
        {
            atributos = new int[6];
            this.atributos[0] = n1;
            this.atributos[1] = n2;
            this.atributos[2] = n3;
            this.atributos[3] = n4;
            this.atributos[4] = n5;
            this.atributos[5] = n6;
        }
        public int getAtributos(int posicao)
        {
            return this.atributos[posicao];
        }

        public void setModificadores(int n1, int n2, int n3, int n4, int n5, int n6)
        {
            modificadores = new int[6];
            this.modificadores[0] = n1;
            this.modificadores[1] = n2;
            this.modificadores[2] = n3;
            this.modificadores[3] = n4;
            this.modificadores[4] = n5;
            this.modificadores[5] = n6;
        }
        public int getModificadores(int posicao)
        {
            return this.modificadores[posicao];
        }

        public void setTesteDeResistencia(String n)
        {
            this.testeDeResistencia = n;
        }
        public String getTesteDeResistencia()
        {
            return this.testeDeResistencia;
        }

        public void setPericias(String n)
        {
            this.pericias = n;
        }
        public String getPericias()
        {
            return this.pericias;
        }

        public void setImunidadeAoDano(String n)
        {
            this.imunidadeAoDano = n;
        }
        public String getImunidadeAoDano()
        {
            return this.imunidadeAoDano;
        }

        public void setResistenciaDano(String n)
        {
            this.resistenciaDano = n;
        }
        public String getResistenciaDano()
        {
            return this.resistenciaDano;
        }

        public void setFraquezaDano(String n)
        {
            this.fraquezaDano = n;
        }
        public String getFraquezaDano()
        {
            return this.fraquezaDano;
        }

        public void setImunidadeCondicoes(String n)
        {
            this.imunidadeCondicoes = n;
        }
        public String getImunidadeCondicoes()
        {
            return this.imunidadeCondicoes;
        }

        public void setSentidos(String n)
        {
            this.sentidos = n;
        }
        public String getSentidos()
        {
            return this.sentidos;
        }

        public void setIdiomas(String n)
        {
            this.idiomas = n;
        }
        public String getIdiomas()
        {
            return this.idiomas;
        }

        public void setNivelDeDesafio(String n)
        {
            this.nivelDeDesafio = n;
        }
        public String getNivelDeDesafio()
        {
            return this.nivelDeDesafio;
        }

        public void setExperiencia(String n)
        {
            this.experiencia = n;
        }
        public String getExperiencia()
        {
            return this.experiencia;
        }

        public void setDescricoes(String n)
        {
            this.descricoes = n;
        }
        public String getDescricoes()
        {
            return this.descricoes;
        }

        public void setAcoes(String n)
        {
            this.acoes = n;
        }
        public String getAcoes()
        {
            return this.acoes;
        }

        public void setAcoesLendarias(String n)
        {
            this.acoesLendarias = n;
        }
        public String getAcoesLendarias()
        {
            return this.acoesLendarias;
        }

        public object Clone()
        {
            Monstros m = new Monstros();
            m.setNome(this.getNome());
            m.setTipo(this.getTipo());
            m.setClasseDeArmadura(this.getClasseDeArmadura());
            m.setPontosDeVidaAbsolutos(this.getPontosDeVidaAbsolutos());
            m.setPontosDeVidaDados(this.getPontosDeVidaDados());
            m.setControleDePontosDeVida(this.getControleDePontosDeVida());
            m.setDeslocamento(this.getDeslocamento());
            m.setDeslocamentoVoo(this.getDeslocamentoVoo());
            m.setDeslocamentoAquatico(this.getDeslocamentoAquatico());
            m.setDeslocamentoEscalada(this.getDeslocamentoEscalada());
            m.setAtributos(this.getAtributos(0), this.getAtributos(1), this.getAtributos(2), this.getAtributos(3),
            this.getAtributos(4), this.getAtributos(5));
            m.setModificadores(this.getModificadores(0), this.getModificadores(1), this.getModificadores(2),
            this.getModificadores(3), this.getModificadores(4), this.getModificadores(5));
            m.setTesteDeResistencia(this.getTesteDeResistencia());
            m.setPericias(this.getPericias());
            m.setResistenciaDano(this.getResistenciaDano());
            m.setImunidadeAoDano(this.getImunidadeAoDano());
            m.setFraquezaDano(this.getFraquezaDano());
            m.setImunidadeCondicoes(this.getImunidadeCondicoes());
            m.setSentidos(this.getSentidos());
            m.setIdiomas(this.getIdiomas());
            m.setNivelDeDesafio(this.getNivelDeDesafio());
            m.setExperiencia(this.getExperiencia());
            m.setDescricoes(this.getDescricoes());
            m.setAcoes(this.getAcoes());
            m.setAcoesLendarias(this.getAcoesLendarias());
            return m;
        }
    }

    
    
}
