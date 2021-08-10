using CursoDesignPatterns.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Observer
{
    public class Multiplicador : IExecutaAcoes
    {
        public double Fator { get; private set; }

        public Multiplicador(double fator)
        {
            this.Fator = fator;
        }
        public void Acao(NotaFiscal notaFiscal)
        {
            notaFiscal.ValorBruto *= this.Fator;
            Console.WriteLine(notaFiscal.ValorBruto);
        }
    }
}
