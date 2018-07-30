using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanD
{
    public class Jogador : ICloneable
    {
        private String nomeDoJogador;
        private String nomeDoPersonagem;
        private String classe;

        public void setNomeDoJogador(String n)
        {
            this.nomeDoJogador = n;
        }

        public String getNomeDoJogador()
        {
            return this.nomeDoJogador;
        }

        public void setNomeDoPersonagem(String np)
        {
            this.nomeDoPersonagem = np;
        }

        public String getNomeDoPersonagem()
        {
            return this.nomeDoPersonagem;
        }

        public void setClasse(String c)
        {
            this.classe = c;
        }

        public String getClasse()
        {
            return this.classe;
        }

        public object Clone()
        {
            Jogador jc = new Jogador();

            jc.nomeDoJogador = this.nomeDoJogador;
            jc.nomeDoPersonagem = this.nomeDoPersonagem;
            jc.classe = this.classe;

            return jc;
        }
    }
}
