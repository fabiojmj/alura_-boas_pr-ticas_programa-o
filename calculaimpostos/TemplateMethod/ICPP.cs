using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.TemplateMethod
{
    public class ICPP : TemplateMethod
    {
        public ICPP() : base()
        {
            OutroImposto = null;
        }

        public ICPP(IImposto outroImposto) : base(outroImposto)
        {
            OutroImposto = outroImposto;
        }



        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor >= 500;
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07 + CalculoDoOutroImposto(orcamento);
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05 + CalculoDoOutroImposto(orcamento);
        }
    }
}
