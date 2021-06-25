using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.CalculadorImposto
{
    public class ImpostoMuitoAlto : IImposto
    {
        public ImpostoMuitoAlto()
        {
        }

        public ImpostoMuitoAlto(IImposto imposto) : base(imposto)
        {
        }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.2 + CalculoDoOutroImposto(orcamento);
        }
    }
}
