using CursoDesignPatterns.TemplateMethod;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Decorator
{
    public class ContaMenor100 : Filtro
    {
        public ContaMenor100()
        {
        }

        public ContaMenor100(Filtro filtro)
        {
            ProximoFiltro = filtro;
        }


        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            throw new NotImplementedException();
        }
    }
}
