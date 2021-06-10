using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.TemplateMethod
{
    public class IHIT : TemplateMethod
    {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return ItemRepetidos(orcamento);
        }

        private bool ItemRepetidos(Orcamento orcamento)
        {
            foreach (var item in orcamento.Items)
            {
                foreach (var itemProcura in orcamento.Items)
                {
                    if(itemProcura.Nome == item.Nome)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Items.Count * 0.01;
        }
    }
}
