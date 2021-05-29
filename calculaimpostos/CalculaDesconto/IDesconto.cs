using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.CalculaDesconto
{
    public interface IDesconto
    {
        double Desconta(Orcamento orcamento);

        public IDesconto Proximo { get; set; }
    }
}
