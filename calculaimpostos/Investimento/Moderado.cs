using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Investimento
{
    public class Moderado : IInvestimento
    {
         private Random random;

        public double Investimento(ContaBancaria conta)
        {
            random = new Random();

            if (random.Next(2) == 0)
            {
                return conta.Saldo * 0.025;
            }
            else
            {
                return conta.Saldo * 0.007;
            }           
        }
    }
}
