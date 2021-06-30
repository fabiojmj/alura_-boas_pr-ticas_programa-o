using CursoDesignPatterns.CalculaDesconto.requisicao_web;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Decorator
{
    public class DataCorrenteMesAtual : Filtro
    {
        public IList<Conta> ContasFiltradas { get; set; } 
        public DataCorrenteMesAtual() : base()
        {            
        }

        public DataCorrenteMesAtual(Filtro filtro):base(filtro)
        {
        }

        public override bool AplicaCondicaoFiltro(Conta conta)
        {
            return conta.DataAbertura == DateTime.Now;
        }

        public override IList<Conta> AplicaFiltro(IList<Conta> contas)
        {
            ContasFiltradas = new List<Conta>();

            foreach (var item in contas)
            {
                if (AplicaCondicaoFiltro(item))
                {
                    ContasFiltradas.Add(item);
                }
            }

            foreach(var conta in Filtra(ContasFiltradas))
            {
                ContasFiltradas.Add(conta);
            }

            return ContasFiltradas;
        }
    }
}
