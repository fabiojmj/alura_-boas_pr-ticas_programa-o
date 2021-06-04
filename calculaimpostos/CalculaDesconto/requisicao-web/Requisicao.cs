using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.CalculaDesconto.requisicao_web
{
    public class Requisicao
    {
        public Formato Formato { get; private set; }

        public Requisicao(Formato formato)
        {
            this.Formato = formato;
        }
    }
}
