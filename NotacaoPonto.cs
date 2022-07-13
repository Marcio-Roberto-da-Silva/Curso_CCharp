using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
     public static void Executar()
        {
            var saudacao = "ola ".ToUpper().Insert(3, "Word ").Replace("Word", " Mundo!");
            Console.WriteLine(saudacao);

            Console.WriteLine("Teste" .Length);

            String valorImportante = null;
            Console.WriteLine(valorImportante?.Length);
        }
    }
}
