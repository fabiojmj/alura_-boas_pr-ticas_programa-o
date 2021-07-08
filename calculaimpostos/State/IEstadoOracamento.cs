using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.State
{
    public interface IEstadoOracamento
    {
        void AplicaDescontoExtra(Orcamento orcamento);
        void Aprova(Orcamento orcamento);
        void Reprova(Orcamento orcamento);
        void Finaliza(Orcamento orcamento);
    }
}
