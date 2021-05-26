using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Investimento
{
    public class Conservador : IInvestimento
    {
        public double Investimento(ContaBancaria conta)
        {
            return conta.Saldo * 0.08;
        }
    }
}
