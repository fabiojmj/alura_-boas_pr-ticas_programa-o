using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class ICMS : IImposto
    {
        public ICMS(IImposto imposto) : base(imposto)
        {
        }

        public ICMS()
        {
            
        }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1 + CalculoDoOutroImposto(orcamento); ;
        }        
    }
}
