using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Builder
{
    public class ItemDaNota
    {
        public ItemDaNota(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public string Nome { get; set; }

        public double Valor { get; set; }

    }
}
