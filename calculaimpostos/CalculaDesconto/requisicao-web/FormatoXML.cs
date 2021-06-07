using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.CalculaDesconto.requisicao_web
{
    public class FormatoXML : ITrataFormato
    {
        public ITrataFormato Proximo { get ; set ; }

        public FormatoXML(ITrataFormato proximo = null)
        {
            if (proximo is null)
            {
                throw new Exception("Formato invalido");
            }            
        }

        public double RetornaSaldo(Requisicao requisicao, Conta conta)
        {
            if (Formato.XML.Equals(requisicao.Formato))
            {
                return conta.Saldo;
            }
            return Proximo.RetornaSaldo(requisicao,conta);            
        }
    }
}
