using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Investimento
{
    public interface IInvestimento
    {
        double Investimento(ContaBancaria conta);
    }
}
