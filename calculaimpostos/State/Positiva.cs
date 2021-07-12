using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.State
{
    public class Positiva : IEstadoConta
    {
        public void Deposita(Conta conta, double valor)
        {
            conta.Saldo += valor * 0.98;
        }

        public void Saca(Conta conta, double valor)
        {
            conta.Saldo -= valor;
            if (conta.Saldo < 0)
            {
                conta.EstadoConta = new Negativa();
            }   
        }
    }
}
