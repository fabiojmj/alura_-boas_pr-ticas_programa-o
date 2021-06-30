using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.CalculaDesconto.requisicao_web
{
    public class Conta
    {
        public string NomeTitular { get; set; }

        public double Saldo { get; set; }

        public DateTime DataAbertura { get; set; }

        public Conta(string nomeTitular, double saldo)
        {
            NomeTitular = nomeTitular;
            Saldo = saldo;
            DataAbertura = DateTime.Now;
        }
    }
}
