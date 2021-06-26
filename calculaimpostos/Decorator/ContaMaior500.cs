using CursoDesignPatterns.TemplateMethod;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Decorator
{
    public class ContaMaior500 : Filtro
    {
        public ContaMaior500()
        {
        }

        public ContaMaior500(Filtro filtro)
        {
            ProximoFiltro = filtro;
        }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            throw new NotImplementedException();
        }
    }
}
