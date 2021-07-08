using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.State
{
    public class Aprovado : IEstadoOracamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor -= orcamento.Valor * 0.02;
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new NotImplementedException();
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new NotImplementedException();
        }
    }
}
