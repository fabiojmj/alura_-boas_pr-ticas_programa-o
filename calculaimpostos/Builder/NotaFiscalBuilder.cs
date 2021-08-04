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

        public NotaFiscalBuilder()
        {
            DataDeEmissao = DateTime.Now;
        }

        public NotaFiscalBuilder ParaEmpresa(string razao)
        {
            RazaoSocial = razao;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(string cnpj)
        {
            Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComItem(ItemDaNota item)
        {
            Itens.Add(item);
            ValorBruto += item.Valor;
            Impostos += ValorBruto * 0.05;
            return this;
        }

        public NotaFiscalBuilder DataAtual(DateTime dataEmissao)
        {
            DataDeEmissao = dataEmissao;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(string observacoes)
        {
            Observacoes = observacoes;
            return this;
        }

        public NotaFiscal Build()
        {
            return new NotaFiscal(RazaoSocial, Cnpj, DataDeEmissao, ValorBruto, Impostos, Itens, Observacoes);
        }
    }
}
