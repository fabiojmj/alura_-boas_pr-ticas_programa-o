using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class ICCC : IImposto
    {
        public ICCC(IImposto imposto) : base(imposto)
        {
        }

        public ICCC()
        {

        }

        public override double Calcula(Orcamento orcamento)
        {
            /*Crie o imposto que se chama ICCC, que retorna 5 % do valor total 
             * caso o orçamento seja menor do que R$ 1000,00 reais, 7 % caso
             * o valor esteja entre R$ 1000 e R$ 3000,00 com os limites inclusos,
             * ou 8 % mais 30 reais, caso o valor esteja acima de R$ 3000,00.*/

            if (orcamento.Valor < 1000)
            {
                return orcamento.Valor * 0.05 + CalculoDoOutroImposto(orcamento);
            }
            else if (orcamento.Valor >= 1000 && orcamento.Valor < 3000)
            {
                return orcamento.Valor * 0.07 + CalculoDoOutroImposto(orcamento);
            }
            else
            {
                return orcamento.Valor * 0.08 + 30 + CalculoDoOutroImposto(orcamento);
            }

        }        
    }
}
