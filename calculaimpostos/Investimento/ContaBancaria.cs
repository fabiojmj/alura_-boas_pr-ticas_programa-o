using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Investimento
{
    public class ContaBancaria
    {
        public double Saldo { get; set; }

        public ContaBancaria(double saldo)
        {
            Saldo = saldo;
        }

        public void RealizaDeposito(double valorDeposito)
        {
            Saldo += valorDeposito;
        }
    }
}
