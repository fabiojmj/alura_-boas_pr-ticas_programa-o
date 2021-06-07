using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.CalculaDesconto.requisicao_web
{
    public class FormatoCSV : ITrataFormato
    {
        public ITrataFormato Proximo { get ; set ; }

        public FormatoCSV(ITrataFormato proximo)
        {
            Proximo = proximo;
        }

        public double RetornaSaldo(Requisicao requisicao, Conta conta)
        {
            if (Formato.CSV.Equals(requisicao.Formato))
            {
                return conta.Saldo;
            }
            return Proximo.RetornaSaldo(requisicao,conta);
        }
    }
}
