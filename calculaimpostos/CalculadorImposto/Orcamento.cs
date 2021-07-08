using CursoDesignPatterns;
using CursoDesignPatterns.State;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class Orcamento
    {
        public double Valor { get;  set; }

        public IEstadoOracamento EstadoAtual { get; set; } 

        public IList<Item> Items { get; set; }

        public Orcamento(double valor)
        {
            Valor = valor;
            Items = new List<Item>();
            EstadoAtual = new EmAprovacao();
        }

        public void AdicionaItem(Item item)
        {
            Items.Add(item);
        }
        public void AplicaDescontoExtra()
        {
            EstadoAtual.AplicaDescontoExtra(this);
        }
        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }
        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }
        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }
    }
}
