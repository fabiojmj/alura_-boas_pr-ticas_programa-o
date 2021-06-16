using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.TemplateMethod
{
    public abstract class RelatorioTemplate
    {
        public abstract void Cabecalho(Cabecalho cabecalho);
        public abstract void Rodape(Rodape rodape);
        public abstract void Corpo(List<Conta> listaConta);

    }
}
