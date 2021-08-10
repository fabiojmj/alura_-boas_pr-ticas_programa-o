using CursoDesignPatterns.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Observer
{
    public class EnviaEmail : IExecutaAcoes
    {
        public void Acao(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Envia Email");
        }
    }
}
