using CursoDesignPatterns;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class Orcamento
    {
        public double Valor { get; private set; }

        public IList<Item> Items { get; set; }

        public Orcamento(double valor)
        {
            Valor = valor;
            Items = new List<Item>();
        }
        public void AdicionaItem(Item item)
        {
            Items.Add(item);
        }
    }
}
