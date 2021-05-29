using CursoDesignPatterns.CalculaDesconto;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class CalculadorDesconto
    {
        public double Calcula(Orcamento orcamento)
        {

            IDesconto desconto1 = new DescontoPorCincoItens();
            IDesconto desconto2 = new DescontoPorMaisDeQuinhentosReais();
            IDesconto desconto3 = new SemDesconto();

            desconto1.Proximo = desconto2;
            desconto2.Proximo = desconto3;

            return desconto1.Desconta(orcamento); 
        }
    }
}
