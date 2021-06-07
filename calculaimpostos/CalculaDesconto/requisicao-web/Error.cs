using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.CalculaDesconto.requisicao_web
{
    public class Error : ITrataFormato
    {
        public ITrataFormato Proximo { get; set; }

        public Error(ITrataFormato proximo)
        {
            Proximo = proximo;
        }

        public double RetornaSaldo(Requisicao requisicao, Conta conta)
        {
            return -1;
        }
    }
}
