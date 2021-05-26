using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Investimento
{
    public class RealizadorDeInvestimentos
    {
        public void RealizadorInvestimentos(IInvestimento investimento, ContaBancaria conta)
        {
            double valorSaldo = investimento.Investimento(conta) * 0.75;
            conta.RealizaDeposito(valorSaldo);
        }
    }
}
