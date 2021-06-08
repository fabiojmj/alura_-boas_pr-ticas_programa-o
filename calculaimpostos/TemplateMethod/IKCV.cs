using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.TemplateMethod
{
    public class IKCV : TemplateMethod
    {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && TemItemMaiorQue100ReaisNo(orcamento);
        }

        private bool TemItemMaiorQue100ReaisNo(Orcamento orcamento)
        {
            foreach (var item in orcamento.Items)
            {
                if (item.Valor >100)
                {
                    return true;
                }
            }
            return false;
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.10;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}
