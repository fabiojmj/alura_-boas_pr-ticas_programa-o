using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class CalculadorImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, IImposto imposto)
        {
            double iss = imposto.Calcula(orcamento);
            Console.WriteLine(iss);
        }
    }
}
