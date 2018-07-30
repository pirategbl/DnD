using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanD
{
    public class Encontros : ICloneable
    {
        private String nome;
        private int quantidadeDeMonstros;
        public List<Monstros> listaDeMonstros;
        public List<Jogador> listaDeJogadores;
        private float dificuldade;
        private int experiencia;

        public Encontros()
        {
            this.nome = "";
            this.quantidadeDeMonstros = 0;
            this.dificuldade = 0;
            this.experiencia = 0;
            listaDeJogadores = new List<Jogador>();
            listaDeMonstros = new List<Monstros>();
        }

        public void setNomeEncontro(String n)
        {
            this.nome = n;
        }

        public String getNomeEncontro()
        {
            return this.nome;
        }

        public void setQuantidadeDeMonstros()
        {
            this.quantidadeDeMonstros = listaDeMonstros.Count;
        }
        
        public int getQuantidadeDeMonstros()
        {
            return this.quantidadeDeMonstros;
        }

        public void setMonstroNaLista(Monstros m)
        {
            this.listaDeMonstros.Add(m);
        }

        public Monstros getMonstroNaLista(int indice)
        {
            return this.listaDeMonstros.ElementAt(indice);
        }

        public void setJogadorNaLista(Jogador j)
        {
            this.listaDeJogadores.Add(j);
        }

        public Jogador getJogadorNaLista(int indice)
        {
            return this.listaDeJogadores.ElementAt(indice);
        }

        public void setDificuldade()
        {
            float valor = 0;

            for(int i = 0; i < listaDeMonstros.Count; i++)
            {
                if (listaDeMonstros.ElementAt(i).getNivelDeDesafio().Equals("1/8"))
                    valor = valor + (float)0.125;
                else
                    if (listaDeMonstros.ElementAt(i).getNivelDeDesafio().Equals("1/4"))
                    valor = valor + (float)0.25;
                else
                    if (listaDeMonstros.ElementAt(i).getNivelDeDesafio().Equals("1/2"))
                    valor = valor + (float)0.5;
                else
                    valor = valor + Int32.Parse(listaDeMonstros.ElementAt(i).getNivelDeDesafio());
            }
            this.dificuldade = valor;
        }

        public float getDificuldade()
        {
            return this.dificuldade;
        }

        public void setExperiencia()
        {
            int valor = 0;
            
            for(int i = 0; i < listaDeMonstros.Count; i++)
            {
                valor = valor + Int32.Parse(listaDeMonstros.ElementAt(i).getExperiencia());
            }
            this.experiencia = valor;
        }

        public int getExperiencia()
        {
            return this.experiencia;
        }

        public object Clone()
        {
            Encontros c = new Encontros();
            c.nome = this.nome;
            c.quantidadeDeMonstros = this.quantidadeDeMonstros;
            c.listaDeJogadores = this.listaDeJogadores;
            c.listaDeMonstros = this.listaDeMonstros;
            c.dificuldade = this.dificuldade;
            c.experiencia = this.experiencia;
            return c;
        }
    }
}
