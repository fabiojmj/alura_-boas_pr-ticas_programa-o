using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.TemplateMethod
{
    public class RelatorioComplexo : RelatorioTemplate
    {
        public override void Cabecalho(Cabecalho cabecalho)
        {
            Console.WriteLine($"Nome do Banco: {cabecalho.NomeBanco} - Endereco: {cabecalho.Endereco} - " +
                $"Telefone: {cabecalho.Telefone}");
        }

        public override void Corpo(List<Conta> listaConta)
        {
            foreach (var item in listaConta)
            {
                Console.WriteLine($"Titular: {item.Titular} -" +
                    $"Agencia: {item.Agencia} - Numero da Conta: {item.NumeroConta} "+
                    $" Saldo: {item.Saldo}");
            }
        }

        public override void Rodape(Rodape rodape)
        {
            Console.WriteLine($"E-mail: {rodape.Email} - Data: {rodape.DataAtual}");
        }
    }
}
