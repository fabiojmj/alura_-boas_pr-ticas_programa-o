using CursoDesignPatterns.CalculaDesconto.requisicao_web;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Decorator
{
    public class ContaMaior500 : Filtro
    {
        public IList<Conta> ContasFiltradas { get; set; }

        public ContaMaior500() : base()
        {
        }

        public ContaMaior500(Filtro filtro) : base(filtro)
        {            
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

            foreach (var conta in Filtra(ContasFiltradas))
            {
                ContasFiltradas.Add(conta);
            }

            return ContasFiltradas;
        }

        public override bool AplicaCondicaoFiltro(Conta conta)
        {
            return conta.Saldo > 500;
        }
    }
}
