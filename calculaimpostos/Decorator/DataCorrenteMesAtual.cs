using CursoDesignPatterns.TemplateMethod;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Decorator
{
    public class DataCorrenteMesAtual : Filtro
    {
        public DataCorrenteMesAtual()
        {
        }

        public DataCorrenteMesAtual(Filtro filtro)
        {
            ProximoFiltro = filtro;
        }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            throw new NotImplementedException();
        }
    }
}
