using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.TemplateMethod
{
    public class RelatorioSimples : RelatorioTemplate
    {
        public override void Cabecalho(Cabecalho cabecalho)
        {
            Console.WriteLine($"Nome do Banco: {cabecalho.NomeBanco} - Telefone: {cabecalho.Telefone}");
        }

        public override void Corpo(List<Conta> listaConta)
        {
            foreach (var item in listaConta)
            {
                Console.WriteLine($"Titular: {item.Titular} - Saldo: {item.Saldo}");
            }
        }

        public override void Rodape(Rodape rodape)
        {
            Console.WriteLine($"Nome do Banco: {rodape.NomeBanco} - Telefone: {rodape.Telefone}");
        }
    }
}
