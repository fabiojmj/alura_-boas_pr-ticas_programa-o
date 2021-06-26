using CursoDesignPatterns;
using CursoDesignPatterns.CalculaDesconto.requisicao_web;
using CursoDesignPatterns.CalculadorImposto;
using System;

namespace calculaimpostos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Padrao Strategy
            IImposto iss = new ISS();
            IImposto icms = new ICMS();
            IImposto iccc = new ICCC();

            Orcamento orcamento = new Orcamento(500.0);
            CalculadorImpostos calculadorImpostos = new CalculadorImpostos();

            calculadorImpostos.RealizaCalculo(orcamento, iss);
            calculadorImpostos.RealizaCalculo(orcamento, icms);
            calculadorImpostos.RealizaCalculo(orcamento, iccc);
            #endregion

            #region Padrao Chain of responsibility            
            CalculadorDesconto calculadorDesconto = new CalculadorDesconto();
            Orcamento orcamento2 = new Orcamento(500.0);
            orcamento2.AdicionaItem(new Item("CANETA", 250));
            orcamento2.AdicionaItem(new Item("LAPIS", 250));

            double desconto = calculadorDesconto.Calcula(orcamento2);
            Console.WriteLine(desconto);
            #endregion

            #region Padrao Template Method
            Conta conta = new Conta("Nome Titular", 500);
            Requisicao requisicao = new Requisicao(Formato.CSV);
            double saldo = new Servidor().ServidorWeb(requisicao, conta);
            Console.WriteLine(saldo);
            #endregion

            #region Padrao Decorator
            IImposto impostoComplexo = new ISS(new ICMS());
            Orcamento orcamento3 = new Orcamento(500.0);

            double valor = impostoComplexo.Calcula(orcamento3);
            Console.WriteLine(valor);

            IImposto impostoMuitoAlto = new ImpostoMuitoAlto(new ISS());
            Orcamento orcamento4 = new Orcamento(100.0);

            double valorAlto = impostoMuitoAlto.Calcula(orcamento4);
            Console.WriteLine(valorAlto);
            #endregion
            Console.ReadKey();
        }
    }
}
