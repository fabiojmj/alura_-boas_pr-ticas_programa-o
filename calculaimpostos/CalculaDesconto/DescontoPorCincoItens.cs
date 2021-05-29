using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.CalculaDesconto
{
    public class DescontoPorCincoItens : IDesconto
    {
        public IDesconto Proximo { get ; set ; }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Items.Count > 5)
            {
                return orcamento.Valor * 0.1;
            }
            return Proximo.Desconta(orcamento);
        }
    }
}
