using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.State
{
    public class Finalizado : IEstadoOracamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Nao se aplica");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new NotImplementedException();
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new NotImplementedException();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new NotImplementedException();
        }
    }
}
