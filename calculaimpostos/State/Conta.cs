using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.State
{
    public class Conta
    {
        public double Saldo { get; set; }

        public IEstadoConta EstadoConta { get; set; }

        public void Saca(double valor)
        {
            EstadoConta.Saca(this,valor);
        }
        
        public void Deposita(double valor)
        {
            EstadoConta.Deposita(this,valor);
        }
    }
}
