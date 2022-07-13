using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar()
        {
            double nota = 6.0;
            double notaDecorte = 7.0;

            Console.WriteLine("Nota inválida? {0}", nota >10.00);
            Console.WriteLine("Nota inválida? {0}", nota < 00.00);
            Console.WriteLine("Perfeirto? {0} ", nota == 10.00);
            Console.WriteLine("Tem com Melhorar? {0}", nota != 10.00);
            Console.WriteLine("Passou Por Média? {0}", nota >=notaDecorte);
            Console.WriteLine("recuperação? {0}", nota < notaDecorte);
            Console.WriteLine("Reprovado? {0} ", nota <= 3.0);
        }
    }
}
