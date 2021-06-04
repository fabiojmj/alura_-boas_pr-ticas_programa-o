using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.CalculaDesconto.requisicao_web
{
    public class Servidor
    {
        public double ServidorWeb(Requisicao requisicao,Conta conta)
        {
            ITrataFormato csv = new FormatoCSV();
            ITrataFormato porcento = new FormatoPORCENTO();
            ITrataFormato xml = new FormatoXML();
            ITrataFormato error = new Error();

            csv.Proximo = porcento;
            porcento.Proximo = xml;
            xml.Proximo = error;

            return csv.RetornaSaldo(requisicao,conta);
        }
    }
}
