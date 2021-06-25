using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class ISS : IImposto
    {
        public ISS(IImposto imposto) : base(imposto)
        {
        }

        public ISS()
        {

        }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + CalculoDoOutroImposto(orcamento); ;
        }        
    }
}
