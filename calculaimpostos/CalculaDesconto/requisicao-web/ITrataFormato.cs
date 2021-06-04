using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.CalculaDesconto.requisicao_web
{
    public interface ITrataFormato
    {
        double RetornaSaldo(Requisicao requisicao, Conta conta);

        public ITrataFormato Proximo { get; set; }
    }
}
