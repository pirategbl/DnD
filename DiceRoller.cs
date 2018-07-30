using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanD
{
    public class DiceRoller
    {
        Random gerador = new Random();
        
        public int rolarD2(System.Windows.Forms.NumericUpDown qntdD2)
        {
            int resultado = 0;
            
            for(int i = 0; i < Decimal.ToInt32(qntdD2.Value); i++)
            {
                resultado = resultado + gerador.Next(1, 3);
            }
            return resultado;
        }

        public int rolarD4(System.Windows.Forms.NumericUpDown qntdD4)
        {
            int resultado = 0;

            for (int i = 0; i < Decimal.ToInt32(qntdD4.Value); i++)
            {
                resultado = resultado + gerador.Next(1, 5);
            }
            return resultado;
        }

        public int rolarD6(System.Windows.Forms.NumericUpDown qntdD6)
        {
            int resultado = 0;

            for (int i = 0; i < Decimal.ToInt32(qntdD6.Value); i++)
            {
                resultado = resultado + gerador.Next(1, 7);
            }
            return resultado;
        }

        public int rolarD8(System.Windows.Forms.NumericUpDown qntdD8)
        {
            int resultado = 0;

            for (int i = 0; i < Decimal.ToInt32(qntdD8.Value); i++)
            {
                resultado = resultado + gerador.Next(1, 9);
            }
            return resultado;
        }

        public int rolarD10(System.Windows.Forms.NumericUpDown qntdD10)
        {
            int resultado = 0;

            for (int i = 0; i < Decimal.ToInt32(qntdD10.Value); i++)
            {
                resultado = resultado + gerador.Next(1, 11);
            }
            return resultado;
        }

        public int rolarD12(System.Windows.Forms.NumericUpDown qntdD12)
        {
            int resultado = 0;

            for (int i = 0; i < Decimal.ToInt32(qntdD12.Value); i++)
            {
                resultado = resultado + gerador.Next(1, 13);
            }
            return resultado;
        }

        public int rolarD20(System.Windows.Forms.NumericUpDown qntdD20)
        {
            int resultado = 0;

            for (int i = 0; i < Decimal.ToInt32(qntdD20.Value); i++)
            {
                resultado = resultado + gerador.Next(1, 21);
            }
            return resultado;
        }
    }
}
