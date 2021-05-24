using CursoDesignPatterns;
using System;

namespace calculaimpostos
{
    class Program
    {
        static void Main(string[] args)
        {
            IImposto iss = new ISS();
            IImposto icms = new ICMS();
            IImposto iccc = new ICCC();

            Orcamento orcamento = new Orcamento(500.0);
            CalculadorImpostos calculadorImpostos = new CalculadorImpostos();

            calculadorImpostos.RealizaCalculo(orcamento, iss);
            calculadorImpostos.RealizaCalculo(orcamento, icms);
            calculadorImpostos.RealizaCalculo(orcamento,iccc);
            Console.ReadKey();
        }
    }
}
