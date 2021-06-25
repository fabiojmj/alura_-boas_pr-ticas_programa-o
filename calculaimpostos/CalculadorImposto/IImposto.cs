using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public abstract class IImposto
    {
        public IImposto OutroImposto { get; set; }
        public IImposto(IImposto imposto)
        {
            OutroImposto = imposto;
        }

        public IImposto()
        {
            OutroImposto = null;
        }

        public abstract double Calcula(Orcamento orcamento);

        protected double CalculoDoOutroImposto(Orcamento orcamento)
        {
            if (OutroImposto is null)
            {
                return 0;
            }
            return OutroImposto.Calcula(orcamento);
        }
    }
}
