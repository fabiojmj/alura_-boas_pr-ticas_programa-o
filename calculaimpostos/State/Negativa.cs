using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.State
{
    public class Negativa : IEstadoConta
    {
        public void Deposita(Conta conta, double valor)
        {
            conta.Saldo += valor * 0.95;

            if (conta.Saldo > 0)
            {
                conta.EstadoConta = new Positiva();
            }
        }

        public void Saca(Conta conta, double valor)
        {
            throw new Exception("Não é possivel sacar");
        }
    }
}
