using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Investimento
{
    public class Arrojado : IInvestimento
    {
        private Random random;
        public double Investimento(ContaBancaria conta)
        {
            int chute = random.Next(10);
            if (chute >= 0 && chute <= 1)
            {
                return conta.Saldo * 0.5;
            }
            else if (chute >= 2 && chute <= 4)
            {
                return conta.Saldo * 0.3;
            }
            else
            {
                return conta.Saldo * 0.006;
            }
        }
    }
}
