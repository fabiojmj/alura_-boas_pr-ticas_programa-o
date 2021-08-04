using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Builder
{
    public class ItemNotaBuilder
    {
        public string Nome { get; set; }

        public double Valor { get; set; }

        public ItemNotaBuilder ComName(string nome)
        {
            Nome = nome;
            return this;
        }

        public ItemNotaBuilder ComValor(double valor)
        {
            Valor = valor;
            return this;
        }

        public ItemDaNota Build()
        {
            return new ItemDaNota(Nome,Valor);
        }

    }
}
