using CursoDesignPatterns.TemplateMethod;
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
            ProximoFiltro = null;
        }
        public Filtro ProximoFiltro { get; set; }



        public abstract IList<Conta> Filtra(IList<Conta> contas);
    }
}
