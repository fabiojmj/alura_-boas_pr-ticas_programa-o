using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Builder
{
    public class NotaFiscalBuilder
    {
        public String RazaoSocial { get; private set; }
        public String Cnpj { get; private set; }
        public DateTime DataDeEmissao { get; private set; }
        public double ValorBruto { get; private set; }
        public double Impostos { get; private set; }

        public string Observacoes { get; private set; }

        public IList<ItemDaNota> Itens = new List<ItemDaNota>();

        public void ParaEmpresa(string razao)
        {
            RazaoSocial = razao;
        }

        public void ComCnpj(string cnpj)
        {
            Cnpj = cnpj;
        }

        public void ComItem(ItemDaNota item)
        {
            Itens.Add(item);
            ValorBruto += item.Valor;
            Impostos += ValorBruto * 0.05;
        }

        public void DataAtual()
        {
            DataDeEmissao = DateTime.Now;
        }

        public void ComObservacoes(string observacoes)
        {
            Observacoes = observacoes;
        }

        public NotaFiscal Build()
        {
            return new NotaFiscal(RazaoSocial, Cnpj, DataDeEmissao, ValorBruto, Impostos, Itens, Observacoes);
        }
    }
}
