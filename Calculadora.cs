using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanD
{
    public class Calculadora
    {
        public int calcular(int numero1, int numero2, String operacao)
        {
            int resultado;
            if (operacao.Equals("+"))
                resultado = numero1 + numero2;
            else
                resultado = numero1 - numero2;
            return resultado;
        }
    }
}
