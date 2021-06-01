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


            CalculadorDesconto calculadorDesconto = new CalculadorDesconto();
            Orcamento orcamento2 = new Orcamento(500.0);
            orcamento2.AdicionaItem(new Item("CANETA",250));
            orcamento2.AdicionaItem(new Item("LAPIS", 250));

            double desconto = calculadorDesconto.Calcula(orcamento2);
            Console.WriteLine(desconto);

            Console.ReadKey();



        }
    }
}
