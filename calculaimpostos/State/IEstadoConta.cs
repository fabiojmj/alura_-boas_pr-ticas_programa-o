using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.State
{
    public interface IEstadoConta
    {
        void Saca(Conta conta,double valor);
        void Deposita(Conta conta, double valor);
    }
}
