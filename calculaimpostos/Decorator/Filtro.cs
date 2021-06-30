using CursoDesignPatterns.CalculaDesconto.requisicao_web;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Decorator
{
    public abstract class Filtro
    {
        public Filtro(Filtro filtro)
        {
            ProximoFiltro = filtro;
        }

        public Filtro()
        {           
        }
        public Filtro ProximoFiltro { get; private set; }

        public abstract bool AplicaCondicaoFiltro(Conta conta);

        public abstract IList<Conta> AplicaFiltro(IList<Conta> contas);

        protected IList<Conta> Filtra(IList<Conta> contas)
        {
            if (ProximoFiltro is null)
            {
                return new List<Conta>();
            }
            else
            {
                return ProximoFiltro.Filtra(contas);
            }
        }
    }
}
