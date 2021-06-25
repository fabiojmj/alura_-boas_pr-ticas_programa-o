using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.TemplateMethod
{
    public abstract class TemplateMethod : IImposto
    {
        public override double Calcula(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
            {
                return MaximaTaxacao(orcamento);
            }
            else
            {
                return MinimaTaxacao(orcamento);
            }
        }

        public abstract double MaximaTaxacao(Orcamento orcamento);
        public abstract double MinimaTaxacao(Orcamento orcamento);
        public abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
    }
}
