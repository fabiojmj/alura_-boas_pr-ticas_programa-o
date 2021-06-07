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
            ITrataFormato porcento = new FormatoPORCENTO(csv);
            ITrataFormato xml = new FormatoXML(porcento);
            //ITrataFormato error = new Error(xml);

            //csv.Proximo = porcento;
            //porcento.Proximo = xml;
            //xml.Proximo = error;          

            return csv.RetornaSaldo(requisicao,conta);
        }
    }
}
